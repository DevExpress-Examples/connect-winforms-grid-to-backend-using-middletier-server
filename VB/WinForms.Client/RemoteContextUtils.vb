Imports System
Imports System.Net
Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.Net.Http.Json
Imports DataModel.Shared.BusinessObjects
Imports DataModel.Shared.DataModel.Shared.BusinessObjects
Imports DevExpress.EntityFrameworkCore.Security.MiddleTier.ClientServer
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Security
Imports DevExpress.ExpressApp.Security.ClientServer
Imports Microsoft.EntityFrameworkCore

Namespace WinForms.Client

    Public Class RemoteContextUtils

        Public Shared Property Options As DbContextOptions(Of DXApplication1EFCoreDbContext)

        Public Shared Property SecuredDataServerClient As WebApiSecuredDataServerClient

        Public Shared Sub Logoff()
            Options = Nothing
            SecuredDataServerClient = Nothing
        End Sub

        Public Shared ReadOnly Property IsLogin As Boolean
            Get
                Return Options IsNot Nothing
            End Get
        End Property

        Public Shared Function IsGranded(ByVal type As Type, ByVal operation As String) As Boolean
            Dim request = New SerializablePermissionRequest(type, Nothing, Nothing, operation)
            Return CType(SecuredDataServerClient, IMiddleTierServerSecurity).IsGranted(request)
        End Function

        Public Shared Function GetDBContext() As DXApplication1EFCoreDbContext
            Return New DXApplication1EFCoreDbContext(Options)
        End Function

        Public Shared Function CreateDbContextOptions(ByVal securedClient As WebApiSecuredDataServerClient) As DbContextOptions(Of DXApplication1EFCoreDbContext)
            Dim builder = New DbContextOptionsBuilder(Of DXApplication1EFCoreDbContext)()
            Return TryCast(builder.UseLazyLoadingProxies().UseChangeTrackingProxies().UseMiddleTier(securedClient).Options, DbContextOptions(Of DXApplication1EFCoreDbContext))
        End Function

        Public Shared Function CreateSecuredClient(ByVal url As String, ByVal login As String, ByVal password As String) As WebApiSecuredDataServerClient
            ' Connect to an EF Core Middle Tier Security Application from Non-XAF Applications
            ' https://docs.devexpress.com/eXpressAppFramework/404398/data-security-and-safety/security-system/non-xaf/connect-to-the-efcore-middle-tier-service-from-non-xaf-applications
            Dim httpClient = New HttpClient()
            httpClient.BaseAddress = New Uri(url)
            httpClient.DefaultRequestHeaders.Add("Accept", "application/json")
            Dim securedClient = New WebSocketSecuredDataServerClient(httpClient, XafTypesInfo.Instance)
            AddHandler securedClient.CustomAuthenticate, Sub(sender, arguments)
                                                             arguments.Handled = True
                                                             Dim msg As HttpResponseMessage = arguments.HttpClient.PostAsJsonAsync("api/Authentication/Authenticate", CType(arguments.LogonParameters, AuthenticationStandardLogonParameters)).GetAwaiter().GetResult()
                                                             Dim token As String = CStr(msg.Content.ReadFromJsonAsync(GetType(String)).GetAwaiter().GetResult())
                                                             If msg.StatusCode = HttpStatusCode.Unauthorized Then
                                                                 Throw New UserFriendlyException(token)
                                                             End If

                                                             msg.EnsureSuccessStatusCode()
                                                             arguments.HttpClient.DefaultRequestHeaders.Authorization = New AuthenticationHeaderValue("bearer", token)
                                                         End Sub
            securedClient.Authenticate(New AuthenticationStandardLogonParameters(login, password))
            CType(securedClient, IMiddleTierServerSecurity).Logon()
            Return securedClient
        End Function
    End Class
End Namespace
