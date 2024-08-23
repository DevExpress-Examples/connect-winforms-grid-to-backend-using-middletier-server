using System.Linq;
using System.Windows.Forms;
using DataModel.Shared.BusinessObjects;
using DevExpress.Data.Linq;
using DevExpress.ExpressApp.Security;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using Microsoft.EntityFrameworkCore;

namespace WinForms.Client {
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm {
        EntityServerModeSource serverModeSource = new EntityServerModeSource();
        DXApplication1EFCoreDbContext dbContext = null;
        public MainForm() {
            InitializeComponent();
            SetUpBinding();

            GridColumnSummaryItem item1 = new GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Count", "Count={0}");
            this.colFirstName.Summary.Add(item1);

            gridView.PopupMenuShowing += GridView_PopupMenuShowing;
            gridView.EditFormShowing += GridView_EditFormShowing;

            gridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;

            this.bbiNew.Enabled = RemoteContextUtils.IsGranded(typeof(Employee), SecurityOperations.Create);
            this.bbiDelete.Enabled = RemoteContextUtils.IsGranded(typeof(Employee), SecurityOperations.Delete);
            this.bbiEdit.Enabled = RemoteContextUtils.IsGranded(typeof(Employee), SecurityOperations.Write);
        }

        void SetUpBinding() {
            dbContext?.Dispose();

            dbContext = RemoteContextUtils.GetDBContext();

            serverModeSource = new EntityServerModeSource() { ElementType = typeof(Employee), KeyExpression = "ID" };
            serverModeSource.QueryableSource = dbContext.Employees;
            gridControl.DataSource = serverModeSource;
        }

        void RefreshData() {
            serverModeSource.Reload();
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
                using(var editForm = new EditForm(employee)) {
                    if((editForm.ShowDialog() == DialogResult.OK) && (RemoteContextUtils.IsGranded(typeof(Employee), SecurityOperations.Write)))
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

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e) {
            Employee employee = new Employee();
            using(var editForm = new EditForm(employee)) {
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
            RemoteContextUtils.Logoff();
            this.Close();
        }
    }
}