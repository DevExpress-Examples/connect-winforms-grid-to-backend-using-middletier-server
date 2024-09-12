Imports System.Text
Imports DataModel.Shared
Imports DataModel.Shared.BusinessObjects
Imports DataModel.Shared.DataModel.Shared
Imports DataModel.Shared.DataModel.Shared.BusinessObjects
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.ApplicationBuilder
Imports DevExpress.ExpressApp.Security
Imports DevExpress.ExpressApp.Security.Authentication.ClientServer
Imports DevExpress.Persistent.BaseImpl.EF.PermissionPolicy
Imports Microsoft.AspNetCore.Authentication.JwtBearer
Imports Microsoft.AspNetCore.Authorization
Imports Microsoft.AspNetCore.Builder
Imports Microsoft.AspNetCore.Hosting
Imports Microsoft.EntityFrameworkCore
Imports Microsoft.Extensions.Configuration
Imports Microsoft.Extensions.DependencyInjection
Imports Microsoft.Extensions.Hosting
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

            services.AddXafMiddleTier(Configuration, Sub(builder)
                                                         builder.Modules _
            .Add(Of DXApplication1Module)()

                                                         builder.ObjectSpaceProviders _
            .AddSecuredEFCore() _
                .WithDbContext(Of DXApplication1EFCoreDbContext)(Sub(serviceProvider, options)
                                                                     ' Uncomment this code to use an in-memory database. This database is recreated each time the server starts. With the in-memory database, you don't need to make a migration when the data model is changed.
                                                                     ' Do not use this code in production environment to avoid data loss.
                                                                     ' We recommend that you refer to the following help topic before you use an in-memory database: https://docs.microsoft.com/en-us/ef/core/testing/in-memory
                                                                     'options.UseInMemoryDatabase("InMemory")
                                                                     Dim connectionString As String = Nothing
                                                                     If Configuration.GetConnectionString("ConnectionString") IsNot Nothing Then
                                                                         connectionString = Configuration.GetConnectionString("ConnectionString")
                                                                     End If

                                                                     ArgumentNullException.ThrowIfNull(connectionString)
                                                                     options.UseSqlServer(connectionString)
                                                                     options.UseChangeTrackingProxies()
                                                                     options.UseObjectSpaceLinkProxies()
                                                                     options.UseLazyLoadingProxies()
                                                                 End Sub) _
            .AddNonPersistent()

                                                         builder.Security _
            .UseIntegratedMode(Sub(options)
                                   options.Lockout.Enabled = True

                                   options.RoleType = GetType(PermissionPolicyRole)
                                   ' ApplicationUser descends from PermissionPolicyUser and supports the OAuth authentication. For more information, refer to the following topic: https://docs.devexpress.com/eXpressAppFramework/402197
                                   ' If your application uses PermissionPolicyUser or a custom user type, set the UserType property as follows:
                                   options.UserType = GetType(ApplicationUser)
                                   ' ApplicationUserLoginInfo is only necessary for applications that use the ApplicationUser user type.
                                   ' If you use PermissionPolicyUser or a custom user type, comment out the following line:
                                   options.UserLoginInfoType = GetType(ApplicationUserLoginInfo)
                                   options.Events.OnSecurityStrategyCreated =
Sub(securityStrategy)
    Dim securityStrategyImpl As SecurityStrategy = CType(securityStrategy, SecurityStrategy)
    securityStrategyImpl.PermissionsReloadMode = PermissionsReloadMode.CacheOnFirstAccess
End Sub

                               End Sub) _
            .AddPasswordAuthentication(Sub(options)
                                           options.IsSupportChangePassword = True
                                       End Sub)

                                                         builder.AddBuildStep(Sub(application)
                                                                                  application.ApplicationName = "SetupApplication.DXApplication1"
                                                                                  application.CheckCompatibilityType = DevExpress.ExpressApp.CheckCompatibilityType.DatabaseSchema
#If Not RELEASE Then
                                                                                  If application.CheckCompatibilityType = CheckCompatibilityType.DatabaseSchema Then
                                                                                      application.DatabaseUpdateMode = DatabaseUpdateMode.UpdateDatabaseAlways
                                                                                      AddHandler application.DatabaseVersionMismatch, Sub(s, e)
                                                                                                                                          e.Updater.Update()
                                                                                                                                          e.Handled = True
                                                                                                                                      End Sub
                                                                                  End If
#End If
                                                                              End Sub)
                                                     End Sub)

            services.AddAuthentication() _
        .AddJwtBearer(Sub(options)
                          options.TokenValidationParameters = New TokenValidationParameters() With {
                .ValidateIssuerSigningKey = True,
                .ValidateIssuer = False,
                .ValidateAudience = False,
                .IssuerSigningKey = New SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration("Authentication:Jwt:IssuerSigningKey")))
            }
                      End Sub)

            services.AddAuthorization(Sub(options)
                                          options.DefaultPolicy = New AuthorizationPolicyBuilder(
            JwtBearerDefaults.AuthenticationScheme) _
            .RequireAuthenticatedUser() _
            .RequireXafAuthentication() _
            .Build()
                                      End Sub)
        End Sub

        Private Sub OnSecurityStrategyCreatedHandler(ByVal securityStrategy As ISecurityStrategyBase)
            Dim securityStrategyImpl As SecurityStrategy = CType(securityStrategy, SecurityStrategy)
            securityStrategyImpl.PermissionsReloadMode = PermissionsReloadMode.CacheOnFirstAccess
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
