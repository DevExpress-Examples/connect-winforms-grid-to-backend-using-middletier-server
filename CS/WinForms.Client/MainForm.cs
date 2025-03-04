using System;
using System.Linq;
using System.Windows.Forms;
using DataModel.Shared.BusinessObjects;
using DevExpress.Data.Linq;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.ApplicationBuilder;
using DevExpress.ExpressApp.Security;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using Microsoft.EntityFrameworkCore;

namespace WinForms.Client {
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm {
        readonly IMiddleTierClient<DXApplication1EFCoreDbContext> middleTierClient;
        EntityServerModeSource serverModeSource = new EntityServerModeSource();
        DXApplication1EFCoreDbContext dbContext = null;
        IObjectSpace securedObjectSpace;
        RepositoryItemProtectedContentTextEdit protectedContentTextEdit;
        public MainForm(IMiddleTierClient<DXApplication1EFCoreDbContext> middleTierClient) {
            this.middleTierClient = middleTierClient;
            InitializeComponent();
            SetUpBinding();

            GridColumnSummaryItem item1 = new GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Count", "Count={0}");
            this.colFirstName.Summary.Add(item1);

            gridView.PopupMenuShowing += GridView_PopupMenuShowing;
            gridView.EditFormShowing += GridView_EditFormShowing;
            gridView.CustomRowCellEdit += GridView_CustomRowCellEdit;
            gridView.FocusedRowObjectChanged += GridView_FocusedRowObjectChanged;

            gridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;

            this.securedObjectSpace = middleTierClient.CreateObjectSpace();
            this.bbiNew.Enabled = middleTierClient.Security.CanCreate<Employee>(securedObjectSpace);
            this.bbiEdit.Enabled = middleTierClient.Security.CanWrite<Employee>(securedObjectSpace);
            UpdateDeleteButton();

            this.Disposed += MainForm_Disposed;

            protectedContentTextEdit = new RepositoryItemProtectedContentTextEdit();
        }

        private void UpdateDeleteButton() {
            object targetObject = gridView.GetRow(gridView.FocusedRowHandle);
            bbiDelete.Enabled = middleTierClient.Security.CanDelete(securedObjectSpace, targetObject);
        }
        private void MainForm_Disposed(object sender, EventArgs e) {
            securedObjectSpace.Dispose();
        }

        void SetUpBinding() {
            dbContext?.Dispose();
            dbContext = middleTierClient.CreateDbContext();

            serverModeSource?.Dispose();
            serverModeSource = new EntityServerModeSource() { ElementType = typeof(Employee), KeyExpression = "ID" };
            serverModeSource.QueryableSource = dbContext.Employees;
            gridControl.DataSource = serverModeSource;
        }

        void RefreshData() {
            SetUpBinding();
        }

        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e) {
            gridControl.ShowRibbonPrintPreview();
        }

        private void GridView_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e) {
            e.Menu?.Remove(DevExpress.XtraGrid.Localization.GridStringId.MenuColumnFilterEditor);
        }

        void GridView_EditFormShowing(object sender, DevExpress.XtraGrid.Views.Grid.EditFormShowingEventArgs e) {
            e.Allow = false;

            if(gridView.GetRow(e.RowHandle) is Employee employee) {
                using(var editForm = new EditForm(employee, middleTierClient)) {
                    if((editForm.ShowDialog() == DialogResult.OK) && (middleTierClient.Security.CanWrite<Employee>(securedObjectSpace)))
                        try {
                            var newObj = editForm.GetEmployee();
                            var contextObj = dbContext.Employees.First(n => n.ID == newObj.ID);
                            newObj.CopyToContextObject(contextObj, dbContext);
                            dbContext.SaveChanges();
                            RefreshData();
                        }
                        catch(System.Security.SecurityException) {
                            XtraMessageBox.Show("Modifying this data row is restricted for security reasons.");
                        }
                }
            }
        }

        private void GridView_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e) {
            string fieldName = e.Column.FieldName;
            object targetObject = gridView.GetRow(e.RowHandle);
            // The targetObject is null for some rows (column header row, auto filter row and others).
            if((targetObject != null) && !middleTierClient.Security.CanRead(securedObjectSpace, targetObject, fieldName)) {
                e.RepositoryItem = protectedContentTextEdit;
            }
        }
        private void GridView_FocusedRowObjectChanged(object sender, FocusedRowObjectChangedEventArgs e) {
            UpdateDeleteButton();
        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e) {
            Employee employee = new Employee();
            using(var editForm = new EditForm(employee, middleTierClient)) {
                try {
                    if(editForm.ShowDialog() == DialogResult.OK) {
                        var newObj = editForm.GetEmployee();
                        var contextObj = dbContext.CreateProxy<Employee>();
                        dbContext.Employees.Add(contextObj);
                        newObj.CopyToContextObject(contextObj, dbContext);
                        dbContext.SaveChanges();
                        RefreshData();
                    }
                }
                catch(System.Security.SecurityException) {
                    XtraMessageBox.Show("Adding a new item is restricted for security reasons.");
                }
            }
        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e) {
            RefreshData();
        }

        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e) {
            gridView.ShowEditForm();
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e) {
            int[] selectedRowHandles = gridView.GetSelectedRows();
            if((selectedRowHandles.Length == 1) && (gridView.GetRow(selectedRowHandles[0]) is Employee employee)) {
                try {
                    dbContext.Employees.Remove(employee);
                    dbContext.SaveChanges();
                    RefreshData();
                }
                catch(System.Security.SecurityException) {
                    XtraMessageBox.Show("Removing this data row is restricted for security reasons.");
                }
            }
        }

        private void bbiLogOut_ItemClick(object sender, ItemClickEventArgs e) {
            IsLogoffExecuted = true;
            this.Close();
        }

        public bool IsLogoffExecuted { get; private set; }
    }
}