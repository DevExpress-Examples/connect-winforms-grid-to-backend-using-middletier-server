Imports System.Linq
Imports DataModel.Shared.BusinessObjects
Imports DataModel.Shared.DataModel.Shared.BusinessObjects
Imports DevExpress.ExpressApp.Security
Imports DevExpress.XtraEditors

Namespace WinForms.Client

    Partial Public Class EditForm
        Inherits XtraForm

        Private curEmployee As Employee

        Private departments As Department() = Nothing

        Private Sub New()
            InitializeComponent()
            If Not RemoteContextUtils.IsGranded(GetType(Employee), SecurityOperations.Write) Then
                Me.dataLayoutControl1.OptionsView.IsReadOnly = DevExpress.Utils.DefaultBoolean.[True]
                Me.Text += " (Read-Only)"
            End If
        End Sub

        Public Sub New(ByVal employee As Employee)
            Me.New()
            Using dbContext As DXApplication1EFCoreDbContext = RemoteContextUtils.GetDBContext()
                departments = dbContext.Departments.ToArray()
            End Using

            departmentsBindingSource.DataSource = departments
            Me.SetEmployee(employee)
            employeesBindingSource.Add(curEmployee)
        End Sub

        Private Sub SetEmployee(ByVal employee As Employee)
            curEmployee = New Employee()
            curEmployee.Birthday = employee.Birthday
            curEmployee.ID = employee.ID
            curEmployee.FirstName = employee.FirstName
            curEmployee.LastName = employee.LastName
            curEmployee.Email = employee.Email
            If employee.Department IsNot Nothing Then curEmployee.Department = departments.First(Function(n) n.ID = employee.Department.ID)
        End Sub

        Public Function GetEmployee() As Employee
            Return curEmployee
        End Function

        Private Sub OK_button_Click(ByVal sender As Object, ByVal e As System.EventArgs)
            If Me.ValidateChildren() Then Me.DialogResult = System.Windows.Forms.DialogResult.OK
        End Sub
    End Class
End Namespace
