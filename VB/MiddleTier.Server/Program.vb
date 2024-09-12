Imports System.Reflection
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.AspNetCore.DesignTime
Imports DevExpress.ExpressApp.Design
Imports DevExpress.ExpressApp.Utils
Imports Microsoft.AspNetCore.Hosting
Imports Microsoft.Extensions.DependencyInjection
Imports Microsoft.Extensions.Hosting

Namespace MiddleTier.Server

    Public Class Program
        Implements IDesignTimeApplicationFactory

        Private Shared Function ContainsArgument(ByVal args As String(), ByVal argument As String) As Boolean
            Return args.Any(Function(arg) arg.TrimStart("/"c).TrimStart("-"c).ToLower() Is argument.ToLower())
        End Function

        Public Shared Function Main(ByVal args() As String) As Integer
            If ContainsArgument(args, "help") OrElse ContainsArgument(args, "h") Then
                Console.WriteLine("Updates the database when its version does not match the application's version.")
                Console.WriteLine()
                Console.WriteLine($"    {System.Reflection.Assembly.GetExecutingAssembly().GetName().Name}.exe --updateDatabase [--forceUpdate --silent]")
                Console.WriteLine()
                Console.WriteLine("--forceUpdate - Marks that the database must be updated whether its version matches the application's version or not.")
                Console.WriteLine("--silent - Marks that database update proceeds automatically and does not require any interaction with the user.")
                Console.WriteLine()
                Console.WriteLine($"Exit codes: 0 - {DBUpdaterStatus.UpdateCompleted}")
                Console.WriteLine($"            1 - {DBUpdaterStatus.UpdateError}")
                Console.WriteLine($"            2 - {DBUpdaterStatus.UpdateNotNeeded}")
            Else
                DevExpress.ExpressApp.FrameworkSettings.DefaultSettingsCompatibilityMode = DevExpress.ExpressApp.FrameworkSettingsCompatibilityMode.Latest
                DevExpress.ExpressApp.Security.SecurityStrategy.AutoAssociationReferencePropertyMode = DevExpress.ExpressApp.Security.ReferenceWithoutAssociationPermissionsMode.AllMembers
                Dim host As IHost = CreateHostBuilder(args).Build()
                If ContainsArgument(args, "updateDatabase") Then
                    Using serviceScope = host.Services.CreateScope()
                        Return serviceScope.ServiceProvider.GetRequiredService(Of DevExpress.ExpressApp.Utils.IDBUpdater)().Update(ContainsArgument(args, "forceUpdate"), ContainsArgument(args, "silent"))
                    End Using
                Else
                    host.Run()
                End If
            End If
            Return 0
        End Function
        Private Function Create() As XafApplication Implements IDesignTimeApplicationFactory.Create
            Dim hostBuilder As IHostBuilder = CreateHostBuilder(Array.Empty(Of String)())
            Return DesignTimeApplicationFactoryHelper.Create(hostBuilder)
        End Function

        Public Shared Function CreateHostBuilder(ByVal args As String()) As IHostBuilder
            Return Host.CreateDefaultBuilder(args) _
        .ConfigureWebHostDefaults(Sub(webBuilder)
                                      webBuilder.UseStartup(Of Startup)()
                                  End Sub)
        End Function
    End Class
End Namespace
