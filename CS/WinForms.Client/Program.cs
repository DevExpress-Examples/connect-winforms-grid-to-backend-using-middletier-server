using System;
using System.Windows.Forms;
using DataModel.Shared.BusinessObjects;
using DevExpress.ExpressApp.ApplicationBuilder;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.Templates;

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

            while (true) {

                // Perform authorization and create client for Middle-Tier Server
                IMiddleTierClient<DXApplication1EFCoreDbContext> middleTierClient = LogIn();
                if (middleTierClient == null) {
                    return;
                }

                try {
                    using (MainForm form = new MainForm(middleTierClient)) {
                        Application.Run(form);
                        if (!form.IsLogoffExecuted)
                            break;
                    }
                }
                finally {
                    middleTierClient.Dispose();
                }
            }
        }

        static IMiddleTierClient<DXApplication1EFCoreDbContext> LogIn() {
            using (AuthForm authForm = new AuthForm()) {
                while (true) {
                    if (authForm.ShowDialog() == DialogResult.OK) {
                        try {
                            return CreateMiddleTierClient(authForm.Login, authForm.Password);
                        }
                        catch (Exception ex) {
                            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                        return null;
                }
            }
        }

        static IMiddleTierClient<DXApplication1EFCoreDbContext> CreateMiddleTierClient(string login, string password) {
            string endpointUrl = System.Configuration.ConfigurationManager.AppSettings["endpointUrl"];
            return new MiddleTierClientBuilder<DXApplication1EFCoreDbContext>()
                .UseServer(endpointUrl)
                .UsePasswordAuthentication(login, password)
                .Build();
        }
    }
}