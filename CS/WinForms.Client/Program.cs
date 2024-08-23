using System;
using System.Linq;
using System.Windows.Forms;
using DataModel.Shared.BusinessObjects;
using DevExpress.ExpressApp.Security.ClientServer.Internal;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using Microsoft.EntityFrameworkCore;

namespace WinForms.Client {
    internal static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            WindowsFormsSettings.SetPerMonitorDpiAware();
            WindowsFormsSettings.DefaultLookAndFeel.SetSkinStyle(SkinStyle.WXI);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();


            while(!RemoteContextUtils.IsLogin)
                using(AuthForm authForm = new AuthForm()) {
                    if(authForm.ShowDialog() == DialogResult.OK) {
                        MiddleTierStartupHelper.WaitMiddleTierServerReady(MiddleTierStartupHelper.EFCoreWebApiMiddleTierInstanceKey, TimeSpan.MaxValue);
                        // Perform authorization.
                        var securedClient = RemoteContextUtils.CreateSecuredClient(System.Configuration.ConfigurationManager.AppSettings["endpointUrl"], authForm.Login, authForm.Password);
                        RemoteContextUtils.SecuredDataServerClient = securedClient;
                        DbContextOptions<DXApplication1EFCoreDbContext> options = RemoteContextUtils.CreateDbContextOptions(securedClient);
                        RemoteContextUtils.Options = options;

                        Application.Run(new MainForm());
                    }
                    else
                        break;
                }

        }
    }
}