Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Security
Imports DevExpress.ExpressApp.Security.Authentication
Imports DevExpress.ExpressApp.Security.Authentication.ClientServer
Imports Microsoft.AspNetCore.Mvc

Namespace MiddleTier.Server.JWT

    <ApiController>
    <Route("api/[controller]")>
    Public Class AuthenticationController
        Inherits ControllerBase

        Private ReadOnly tokenProvider As IAuthenticationTokenProvider

        Public Sub New(ByVal tokenProvider As IAuthenticationTokenProvider)
            Me.tokenProvider = tokenProvider
        End Sub

        <HttpPost("Authenticate")>
        Public Function Authenticate(<FromBody> ByVal logonParameters As AuthenticationStandardLogonParameters) As IActionResult
            Try
                Return Ok(tokenProvider.Authenticate(logonParameters))
            Catch ex As AuthenticationException
                Return Unauthorized(ex.GetJson())
            End Try
        End Function
    End Class
End Namespace
