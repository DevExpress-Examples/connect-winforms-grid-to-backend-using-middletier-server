using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using DataModel.Shared.BusinessObjects;
using DevExpress.EntityFrameworkCore.Security.MiddleTier.ClientServer;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Security;
using DevExpress.ExpressApp.Security.ClientServer;
using Microsoft.EntityFrameworkCore;

namespace WinForms.Client {
    public class RemoteContextUtils {
        public static DbContextOptions<DXApplication1EFCoreDbContext> Options { get; set; }

        public static WebApiSecuredDataServerClient SecuredDataServerClient { get; set; }

        public static void Logoff() {
            Options = null;
            SecuredDataServerClient = null;
        }

        public static bool IsLogin {
            get {
                return Options != null;
            }
        }

        public static bool IsGranded(Type type, string operation) {
            var request = new SerializablePermissionRequest(type, null, null, operation);
            return ((IMiddleTierServerSecurity)SecuredDataServerClient).IsGranted(request);
        }

        public static DXApplication1EFCoreDbContext GetDBContext() {
            return new DXApplication1EFCoreDbContext(Options);
        }

        public static DbContextOptions<DXApplication1EFCoreDbContext> CreateDbContextOptions(WebApiSecuredDataServerClient securedClient) {
            var builder = new DbContextOptionsBuilder<DXApplication1EFCoreDbContext>();
            return builder
                .UseLazyLoadingProxies()
                .UseChangeTrackingProxies()
                .UseMiddleTier(securedClient)
                .Options as DbContextOptions<DXApplication1EFCoreDbContext>;
        }

        public static WebApiSecuredDataServerClient CreateSecuredClient(string url, string login, string password) {
            // Connect to an EF Core Middle Tier Security Application from Non-XAF Applications
            // https://docs.devexpress.com/eXpressAppFramework/404398/data-security-and-safety/security-system/non-xaf/connect-to-the-efcore-middle-tier-service-from-non-xaf-applications

            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(url);
            httpClient.DefaultRequestHeaders.Add("Accept", "application/json");

            var securedClient = new WebSocketSecuredDataServerClient(httpClient, XafTypesInfo.Instance);
            securedClient.CustomAuthenticate += (sender, arguments) => {
                arguments.Handled = true;
                HttpResponseMessage msg = arguments.HttpClient.PostAsJsonAsync("api/Authentication/Authenticate", (AuthenticationStandardLogonParameters)arguments.LogonParameters).GetAwaiter().GetResult();
                string token = (string)msg.Content.ReadFromJsonAsync(typeof(string)).GetAwaiter().GetResult();
                if(msg.StatusCode == HttpStatusCode.Unauthorized) {
                    throw new UserFriendlyException(token);
                }
                msg.EnsureSuccessStatusCode();
                arguments.HttpClient.DefaultRequestHeaders.Authorization
                    = new AuthenticationHeaderValue("bearer", token);
            };

            securedClient.Authenticate(new AuthenticationStandardLogonParameters(login, password));
            ((IMiddleTierServerSecurity)securedClient).Logon();

            return securedClient;
        }
    }
}
