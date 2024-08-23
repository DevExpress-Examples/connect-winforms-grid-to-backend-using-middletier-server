Imports System.Text
Imports DataModel.Shared
Imports DataModel.Shared.BusinessObjects
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.ApplicationBuilder
Imports DevExpress.ExpressApp.Security
Imports DevExpress.ExpressApp.Security.Authentication.ClientServer
Imports DevExpress.Persistent.BaseImpl.EF.PermissionPolicy
Imports Microsoft.AspNetCore.Authentication.JwtBearer
Imports Microsoft.AspNetCore.Authorization
Imports Microsoft.EntityFrameworkCore
Imports Microsoft.IdentityModel.Tokens

Namespace MiddleTier.Server

    Public Class Startup

        Public Sub New(ByVal configuration As IConfiguration)
            Me.Configuration = configuration
        End Sub

        Public ReadOnly Property Configuration As IConfiguration

        ' This method gets called by the runtime. Use this method to add services to the container.
        ' For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        Public Sub ConfigureServices(ByVal services As IServiceCollection)
            services.AddScoped(Of IAuthenticationTokenProvider, JWT.JwtTokenProviderService)()
            services.AddXafMiddleTier(Configuration, Function(builder)
                builder.Modules.Add(Of DataModel.[Shared].DXApplication1Module)()
                builder.ObjectSpaceProviders.AddSecuredEFCore().WithDbContext(Of DataModel.[Shared].BusinessObjects.DXApplication1EFCoreDbContext)(Function(serviceProvider, options)
                    ' Uncomment this code to use an in-memory database. This database is recreated each time the server starts. With the in-memory database, you don't need to make a migration when the data model is changed.
                    ' Do not use this code in production environment to avoid data loss.
                    ' We recommend that you refer to the following help topic before you use an in-memory database: https://docs.microsoft.com/en-us/ef/core/testing/in-memory
                    'options.UseInMemoryDatabase("InMemory");
                    Dim connectionString As String = Nothing
                    If Configuration.GetConnectionString("ConnectionString") IsNot Nothing Then
                        connectionString = Configuration.GetConnectionString("ConnectionString")
                    End If

                    ArgumentNullException.ThrowIfNull(connectionString)
                    options.UseSqlServer(connectionString)
                    options.UseChangeTrackingProxies()
                    options.UseObjectSpaceLinkProxies()
                    options.UseXafServiceProviderContainer(serviceProvider)
                    options.UseLazyLoadingProxies()
                End Function).AddNonPersistent()
                builder.Security.UseIntegratedMode(Function(options)
                    options.Lockout.Enabled = True
                    options.RoleType = GetType(PermissionPolicyRole)
                    ' ApplicationUser descends from PermissionPolicyUser and supports the OAuth authentication. For more information, refer to the following topic: https://docs.devexpress.com/eXpressAppFramework/402197
                    ' If your application uses PermissionPolicyUser or a custom user type, set the UserType property as follows:
                    options.UserType = GetType(DataModel.[Shared].BusinessObjects.ApplicationUser)
                    ' ApplicationUserLoginInfo is only necessary for applications that use the ApplicationUser user type.
                    ' If you use PermissionPolicyUser or a custom user type, comment out the following line:
                    options.UserLoginInfoType = GetType(DataModel.[Shared].BusinessObjects.ApplicationUserLoginInfo)
                    options.Events.OnSecurityStrategyCreated += Function(securityStrategy)
                        CType(securityStrategy, SecurityStrategy).PermissionsReloadMode = PermissionsReloadMode.CacheOnFirstAccess
                    End Function
                End Function).AddPasswordAuthentication(Function(options)
                    options.IsSupportChangePassword = True
                End Function)
                builder.AddBuildStep(Function(application)
                    application.ApplicationName = "SetupApplication.DXApplication1"
                    application.CheckCompatibilityType = DevExpress.ExpressApp.CheckCompatibilityType.DatabaseSchema
#If Not RELEASE
                    If application.CheckCompatibilityType Is CheckCompatibilityType.DatabaseSchema Then
                        application.DatabaseUpdateMode = DatabaseUpdateMode.UpdateDatabaseAlways
                        application.DatabaseVersionMismatch += Function(s, e)
                            e.Updater.Update()
                            e.Handled = True
                        End Function
                    End If
#End If
                End Function)
            End Function)
            services.AddAuthentication().AddJwtBearer(Function(options)
                options.TokenValidationParameters = New TokenValidationParameters() With {.ValidateIssuerSigningKey = True, .ValidateIssuer = False, .ValidateAudience = False, .IssuerSigningKey = New SymmetricSecurityKey(Encoding.UTF8.GetBytes(Me.Configuration("Authentication:Jwt:IssuerSigningKey")))}
            End Function)
            services.AddAuthorization(Function(options)
                options.DefaultPolicy = New AuthorizationPolicyBuilder(JwtBearerDefaults.AuthenticationScheme).RequireAuthenticatedUser().RequireXafAuthentication().Build()
            End Function)
        End Sub

        ' This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        Public Sub Configure(ByVal app As IApplicationBuilder, ByVal env As IWebHostEnvironment, ByVal hostApplicationLifetime As IHostApplicationLifetime)
            If env.IsDevelopment() Then
                app.UseDeveloperExceptionPage()
            Else
                app.UseExceptionHandler("/Error")
                ' The default HSTS value is 30 days. To change this for production scenarios, see: https://aka.ms/aspnetcore-hsts.
                app.UseHsts()
            End If

            app.UseHttpsRedirection()
            app.UseRequestLocalization()
            app.UseStaticFiles()
            app.UseRouting()
            app.UseAuthentication()
            app.UseAuthorization()
            app.UseXafMiddleTier()
            app.UseEndpoints(Function(endpoints)
                endpoints.MapControllers()
            End Function)
        End Sub
    End Class
End Namespace
