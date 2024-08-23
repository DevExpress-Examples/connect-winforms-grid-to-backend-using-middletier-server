Imports System.IdentityModel.Tokens.Jwt
Imports System.Runtime.ExceptionServices
Imports System.Security.Claims
Imports System.Text
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Security
Imports DevExpress.ExpressApp.Security.Authentication.ClientServer
Imports Microsoft.IdentityModel.Tokens

Namespace MiddleTier.Server.JWT

    Public Class JwtTokenProviderService
        Inherits IAuthenticationTokenProvider

        Private ReadOnly signInManager As SignInManager

        Private ReadOnly configuration As IConfiguration

        Public Sub New(ByVal signInManager As SignInManager, ByVal configuration As IConfiguration)
            Me.signInManager = signInManager
            Me.configuration = configuration
        End Sub

        Public Function Authenticate(ByVal logonParameters As Object) As String
            Dim result = signInManager.AuthenticateByLogonParameters(logonParameters)
            If result.Succeeded Then
                Dim issuerSigningKey = New SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration("Authentication:Jwt:IssuerSigningKey")))
                'issuer: configuration["Authentication:Jwt:Issuer"],
                'audience: configuration["Authentication:Jwt:Audience"],
                Dim token = New JwtSecurityToken(claims:=result.Principal.Claims, expires:=DateTime.Now.AddDays(2), signingCredentials:=New SigningCredentials(issuerSigningKey, SecurityAlgorithms.HmacSha256))
                Return New JwtSecurityTokenHandler().WriteToken(token)
            End If

            If TypeOf result.[Error] Is IUserFriendlyException Then
                ExceptionDispatchInfo.[Throw](result.[Error])
            End If

            Throw New AuthenticationException("Internal server error")
        End Function
    End Class
End Namespace
