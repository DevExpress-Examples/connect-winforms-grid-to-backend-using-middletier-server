Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Security
Imports DevExpress.Persistent.BaseImpl.EF.PermissionPolicy

Namespace DataModel.Shared.BusinessObjects

    <DefaultProperty(NameOf(PermissionPolicyUser.UserName))>
    Public Class ApplicationUser
        Inherits PermissionPolicyUser
        Implements ISecurityUserWithLoginInfo
        Implements ISecurityUserLockout

        <Browsable(False)>
        Public Overridable Property AccessFailedCount As Integer Implements ISecurityUserLockout.AccessFailedCount

        <Browsable(False)>
        Private Property LockoutEnd() As DateTime Implements ISecurityUserLockout.LockoutEnd

        <Browsable(False)>
        <DevExpress.ExpressApp.DC.Aggregated>
        Public Overridable Property UserLogins As IList(Of ApplicationUserLoginInfo) = New ObservableCollection(Of ApplicationUserLoginInfo)()

        Public ReadOnly Property IOAuthSecurityUser_UserLogins As IEnumerable(Of ISecurityUserLoginInfo) _
    Implements IOAuthSecurityUser.UserLogins
            Get
                Return UserLogins.OfType(Of ISecurityUserLoginInfo)()
            End Get
        End Property

        Public Function ISecurityUserWithLoginInfo_CreateUserLoginInfo(loginProviderName As String, providerUserKey As String) As ISecurityUserLoginInfo _
        Implements ISecurityUserWithLoginInfo.CreateUserLoginInfo
            Dim result As ApplicationUserLoginInfo = DirectCast(CType(Me, IObjectSpaceLink).ObjectSpace.CreateObject(Of ApplicationUserLoginInfo)(), ApplicationUserLoginInfo)
            result.LoginProviderName = loginProviderName
            result.ProviderUserKey = providerUserKey
            result.UserProp = Me
            Return result
        End Function
    End Class
End Namespace
