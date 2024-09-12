Imports Aqua.EnumerableExtensions
Imports System.Data
Imports System.IO
Imports DataModel.Shared.BusinessObjects
Imports DataModel.Shared.DataModel.Shared.BusinessObjects
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Security
Imports DevExpress.ExpressApp.Updating
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl.EF.PermissionPolicy
Imports Microsoft.Extensions.DependencyInjection

Namespace DataModel.Shared.DatabaseUpdate

    ' For more typical usage scenarios, be sure to check out https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Updating.ModuleUpdater
    Public Class Updater
        Inherits ModuleUpdater

        Private Const AdministratorUserName As String = "Admin"

        Private Const AdministratorRoleName As String = "Administrators"

        Private Const DefaultUserName As String = "User"

        Private Const DefaultUserRoleName As String = "Users"

        Public Sub New(ByVal objectSpace As IObjectSpace, ByVal currentDBVersion As Version)
            MyBase.New(objectSpace, currentDBVersion)
        End Sub

        Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
            MyBase.UpdateDatabaseAfterUpdateSchema()
            CreateUser()
            CreateAdmin()
            CreateEmployees()
        End Sub

        Private Sub CreateUser()
            Dim userManager As UserManager = ObjectSpace.ServiceProvider.GetRequiredService(Of UserManager)()
            ' If a user named 'User' doesn't exist in the database, create this user
            If userManager.FindUserByName(Of ApplicationUser)(ObjectSpace, DefaultUserName) Is Nothing Then
                ' Set a password if the standard authentication type is used
                Dim EmptyPassword As String = ""
                Dim result = userManager.CreateUser(Of ApplicationUser)(ObjectSpace, DefaultUserName, EmptyPassword, Sub(user)
                                                                                                                         user.Roles.Add(GetUserRole())
                                                                                                                     End Sub)
                ObjectSpace.CommitChanges()
            End If
        End Sub

        Private Sub CreateAdmin()
            Dim userManager As UserManager = Me.ObjectSpace.ServiceProvider.GetRequiredService(Of UserManager)()
            ' If a user named 'Admin' doesn't exist in the database, create this user
            If userManager.FindUserByName(Of ApplicationUser)(Me.ObjectSpace, AdministratorUserName) Is Nothing Then
                ' Set a password if the standard authentication type is used
                Dim EmptyPassword As String = ""
                Dim result = userManager.CreateUser(Of ApplicationUser)(Me.ObjectSpace, AdministratorUserName, EmptyPassword, Function(user)
                                                                                                                                  ' Add the Administrators role to the user
                                                                                                                                  user.Roles.Add(GetAdminRole())
                                                                                                                              End Function)
                Me.ObjectSpace.CommitChanges()
            End If
        End Sub
        Private Function GetAdminRole() As PermissionPolicyRole
            Dim adminRole As PermissionPolicyRole = Me.ObjectSpace.FirstOrDefault(Of PermissionPolicyRole)(Function(u) Equals(u.Name, AdministratorRoleName))
            If adminRole Is Nothing Then
                adminRole = Me.ObjectSpace.CreateObject(Of PermissionPolicyRole)()
                adminRole.Name = AdministratorRoleName
                adminRole.IsAdministrative = True
            End If

            Return adminRole
        End Function

        Private Function GetUserRole() As PermissionPolicyRole
            Dim userRole As PermissionPolicyRole = Me.ObjectSpace.FirstOrDefault(Of PermissionPolicyRole)(Function(u) Equals(u.Name, DefaultUserRoleName))
            If userRole Is Nothing Then
                userRole = Me.ObjectSpace.CreateObject(Of PermissionPolicyRole)()
                userRole.Name = DefaultUserRoleName
                userRole.AddTypePermission(Of Employee)(SecurityOperations.Read, SecurityPermissionState.Allow)
                ' Users have only read-only access to Employee records.
                userRole.AddTypePermission(Of Employee)(SecurityOperations.Write, SecurityPermissionState.Deny)
                ' For more information on criteria language syntax (both string and strongly-typed formats), see https://docs.devexpress.com/CoreLibraries/4928/.
            End If

            Return userRole
        End Function

        Private Sub CreateEmployees()
            ' Create dataset
            If Not Me.ObjectSpace.GetObjectsQuery(Of Employee)().Any() Then
                Dim shortName As String = "Employees.xml"
                Dim embeddedResourceName As String = Array.Find(Of String)([GetType]().Assembly.GetManifestResourceNames(), Function(s) s.Contains(shortName))
                Dim stream As Stream = [GetType]().Assembly.GetManifestResourceStream(embeddedResourceName)
                If stream Is Nothing Then
                    Throw New Exception(String.Format("Cannot read employees data from the {0} file!", shortName))
                End If

                Dim ds As DataSet = New DataSet()
                ds.ReadXml(stream)
                For Each employeeRow As DataRow In ds.Tables("Employee").Rows
                    Dim employee As Employee = Me.ObjectSpace.CreateObject(Of Employee)()
                    employee.Email = Convert.ToString(employeeRow("EmailAddress"))
                    employee.FirstName = Convert.ToString(employeeRow("FirstName"))
                    employee.LastName = Convert.ToString(employeeRow("LastName"))
                    employee.Birthday = Convert.ToDateTime(employeeRow("BirthDate"))
                    Dim departmentTitle As String = Convert.ToString(employeeRow("GroupName"))
                    Dim department As Department = Me.ObjectSpace.FirstOrDefault(Of Department)(Function(d) Equals(d.Title, departmentTitle), True)
                    If department Is Nothing Then
                        department = Me.ObjectSpace.CreateObject(Of Department)()
                        department.Title = departmentTitle
                        Dim rnd As Random = New Random()
                        department.Office = $"{rnd.[Next](1, 7)}0{rnd.[Next](9)}"
                    End If

                    employee.Department = department
                Next

                Me.ObjectSpace.CommitChanges()
            End If
        End Sub
    End Class
End Namespace
