Imports System.ComponentModel.DataAnnotations
Imports DevExpress.Persistent.BaseImpl.EF

Namespace DataModel.Shared.BusinessObjects

    Public Class Employee
        Inherits BaseObject

        <Required()>
        Public Overridable Property FirstName As [String]

        <Required()>
        Public Overridable Property LastName As [String]

        Public Overridable Property Birthday As DateTime?

        <MaxLength(255)>
        Public Overridable Property Email As [String]

        Public Overridable Property Department As Department

        Public ReadOnly Property FullName As String
            Get
                Return $"{FirstName} {LastName}"
            End Get
        End Property

        Public Sub CopyToContextObject(ByVal contextObj As Employee, ByVal dbContext As DXApplication1EFCoreDbContext)
            contextObj.FirstName = FirstName
            contextObj.LastName = LastName
            contextObj.Birthday = Birthday
            contextObj.Email = Email
            If Department IsNot Nothing Then
                contextObj.Department = dbContext.Departments.First(Function(n) n.ID = Department.ID)
            Else
                contextObj.Department = Nothing
            End If
        End Sub
    End Class
End Namespace
