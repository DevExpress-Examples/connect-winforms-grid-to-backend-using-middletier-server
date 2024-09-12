Imports System.Collections.ObjectModel
Imports DevExpress.Persistent.BaseImpl.EF

Namespace DataModel.Shared.BusinessObjects

    Public Class Department
        Inherits BaseObject

        Public Overridable Property Title As String

        Public Overridable Property Office As String

        Public Overridable Property Employees() As IList(Of Employee) = New ObservableCollection(Of Employee)()

        Public Overrides Function ToString() As String
            Return Title
        End Function
    End Class
End Namespace
