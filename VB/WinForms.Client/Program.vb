Imports System
Imports DataModel.Shared.BusinessObjects
Imports DevExpress.ExpressApp.Security.ClientServer.Internal
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraEditors
Imports Microsoft.EntityFrameworkCore

Namespace WinForms.Client

    Friend Module Program

        ''' <summary>
        '''  The main entry point for the application.
        ''' </summary>
        <STAThread>
        Sub Main()
            Call WindowsFormsSettings.SetPerMonitorDpiAware()
            WindowsFormsSettings.DefaultLookAndFeel.SetSkinStyle(SkinStyle.WXI)
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            ApplicationConfiguration.Initialize()
            Application.EnableVisualStyles()
            While Not RemoteContextUtils.IsLogin
                Using authForm As AuthForm = New AuthForm()
                    If authForm.ShowDialog() Is DialogResult.OK Then
                        MiddleTierStartupHelper.WaitMiddleTierServerReady(MiddleTierStartupHelper.EFCoreWebApiMiddleTierInstanceKey, TimeSpan.MaxValue)
                        ' Perform authorization.
                        Dim securedClient = RemoteContextUtils.CreateSecuredClient(Configuration.ConfigurationManager.AppSettings("endpointUrl"), authForm.Login, authForm.Password)
                        RemoteContextUtils.SecuredDataServerClient = securedClient
                        Dim options As DbContextOptions(Of DataModel.[Shared].BusinessObjects.DXApplication1EFCoreDbContext) = RemoteContextUtils.CreateDbContextOptions(securedClient)
                        RemoteContextUtils.Options = options
                        Application.Run(New MainForm())
                    Else
                        Exit While
                    End If
                End Using
            End While
        End Sub
    End Module
End Namespace
