Imports DataModel.Shared.BusinessObjects
Imports DataModel.Shared.DataModel.Shared.BusinessObjects
Imports DevExpress.Data.Linq
Imports DevExpress.ExpressApp.Security
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports Microsoft.EntityFrameworkCore

Namespace WinForms.Client

    Partial Public Class MainForm
        Inherits Ribbon.RibbonForm

        Private serverModeSource As EntityServerModeSource = New EntityServerModeSource()

        Private dbContext As DXApplication1EFCoreDbContext = Nothing

        Public Sub New()
            InitializeComponent()
            SetUpBinding()
            Dim item1 As GridColumnSummaryItem = New GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Count", "Count={0}")
            colFirstName.Summary.Add(item1)
            AddHandler gridView.PopupMenuShowing, AddressOf GridView_PopupMenuShowing
            AddHandler gridView.EditFormShowing, AddressOf GridView_EditFormShowing
            gridView.OptionsSelection.EnableAppearanceFocusedCell = False
            gridView.FocusRectStyle = Views.Grid.DrawFocusRectStyle.RowFocus
            bbiNew.Enabled = RemoteContextUtils.IsGranded(GetType(Employee), SecurityOperations.Create)
            bbiDelete.Enabled = RemoteContextUtils.IsGranded(GetType(Employee), SecurityOperations.Delete)
            bbiEdit.Enabled = RemoteContextUtils.IsGranded(GetType(Employee), SecurityOperations.Write)
        End Sub

        Private Sub SetUpBinding()
            dbContext?.Dispose()
            dbContext = RemoteContextUtils.GetDBContext()
            serverModeSource = New EntityServerModeSource() With {.ElementType = GetType(Employee), .KeyExpression = "ID"}
            serverModeSource.QueryableSource = dbContext.Employees
            gridControl.DataSource = serverModeSource
        End Sub

        Private Sub RefreshData()
            serverModeSource.Reload()
        End Sub

        Private Sub bbiPrintPreview_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            gridControl.ShowRibbonPrintPreview()
        End Sub

        Private Sub GridView_PopupMenuShowing(ByVal sender As Object, ByVal e As Views.Grid.PopupMenuShowingEventArgs)
            e.Menu?.Remove(Localization.GridStringId.MenuColumnFilterEditor)
        End Sub

        Private Sub GridView_EditFormShowing(ByVal sender As Object, ByVal e As Views.Grid.EditFormShowingEventArgs)
            e.Allow = False
            Dim employee As Employee = Nothing
            If CSharpImpl.__Assign(employee, TryCast(gridView.GetRow(e.RowHandle), Employee)) IsNot Nothing Then
                Using editForm = New EditForm(employee)
                    If (editForm.ShowDialog() = DialogResult.OK) AndAlso RemoteContextUtils.IsGranded(GetType(Employee), SecurityOperations.Write) Then
                        Try
                            Dim newObj = editForm.GetEmployee()
                            Dim contextObj = dbContext.Employees.First(Function(n) n.ID = newObj.ID)
                            newObj.CopyToContextObject(contextObj, dbContext)
                            dbContext.SaveChanges()
                            RefreshData()
                        Catch __unusedSecurityException1__ As System.Security.SecurityException
                            XtraMessageBox.Show("Modifying this data row is restricted for security reasons.")
                        End Try
                    End If
                End Using
            End If
        End Sub

        Private Sub bbiNew_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim employee As New Employee()
            Using editForm = New EditForm(employee)
                Try
                    If editForm.ShowDialog() = DialogResult.OK Then
                        Dim newObj = editForm.GetEmployee()
                        Dim contextObj = dbContext.CreateProxy(Of Employee)()
                        dbContext.Employees.Add(contextObj)
                        newObj.CopyToContextObject(contextObj, dbContext)
                        dbContext.SaveChanges()
                        RefreshData()
                    End If
                Catch e1 As System.Security.SecurityException
                    XtraMessageBox.Show("Adding a new item is restricted for security reasons.")
                End Try
            End Using
        End Sub

        Private Sub bbiRefresh_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            RefreshData()
        End Sub

        Private Sub bbiEdit_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            gridView.ShowEditForm()
        End Sub

        Private Sub bbiDelete_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim selectedRowHandles As Integer() = gridView.GetSelectedRows()
            Dim employee As Employee = Nothing
            If selectedRowHandles.Length = 1 AndAlso (CSharpImpl.__Assign(employee, TryCast(gridView.GetRow(selectedRowHandles(0)), Employee)) IsNot Nothing) Then
                Try
                    dbContext.Employees.Remove(employee)
                    dbContext.SaveChanges()
                    RefreshData()
                Catch __unusedSecurityException1__ As System.Security.SecurityException
                    XtraMessageBox.Show("Removing this data row is restricted for security reasons.")
                End Try
            End If
        End Sub

        Private Sub bbiLogOut_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Call RemoteContextUtils.Logoff()
            Me.Close()
        End Sub

        Private Class CSharpImpl

            <System.Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
            Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
                target = value
                Return value
            End Function
        End Class
    End Class
End Namespace
