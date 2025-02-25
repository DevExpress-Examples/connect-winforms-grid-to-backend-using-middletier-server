using System;
using System.Linq;
using DataModel.Shared.BusinessObjects;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.ApplicationBuilder;
using DevExpress.ExpressApp.Security;
using DevExpress.XtraEditors;

namespace WinForms.Client {
    public partial class EditForm : XtraForm {
        Employee curEmployee;
        Department[] departments = null;
        readonly IMiddleTierClient<DXApplication1EFCoreDbContext> middleTierClient;
        readonly IObjectSpace securedObjectSpace;

        EditForm(IMiddleTierClient<DXApplication1EFCoreDbContext>middleTierClient) {
            InitializeComponent();
            this.middleTierClient = middleTierClient;
            this.securedObjectSpace = middleTierClient.CreateObjectSpace();

            if(!middleTierClient.Security.CanWrite<Employee>(securedObjectSpace)) {
                this.dataLayoutControl1.OptionsView.IsReadOnly = DevExpress.Utils.DefaultBoolean.True;
                this.Text += " (Read-Only)";
            }
            this.Disposed += EditForm_Disposed;
        }

        private void EditForm_Disposed(object sender, EventArgs e) {
            securedObjectSpace.Dispose();
        }

        public EditForm(Employee employee, IMiddleTierClient<DXApplication1EFCoreDbContext> middleTierClient) : this(middleTierClient) {
            using(DXApplication1EFCoreDbContext dbContext = middleTierClient.CreateDbContext()) {
                departments = dbContext.Departments.ToArray();
            }
            departmentsBindingSource.DataSource = departments;
            SetEmployee(employee);
            employeesBindingSource.Add(curEmployee);
        }

        void SetEmployee(Employee employee) {
            this.curEmployee = new Employee();
            this.curEmployee.Birthday = employee.Birthday;
            this.curEmployee.ID = employee.ID;
            this.curEmployee.FirstName = employee.FirstName;
            this.curEmployee.LastName = employee.LastName;
            this.curEmployee.Email = employee.Email;
            if(employee.Department != null)
                curEmployee.Department = departments.First(n => n.ID == employee.Department.ID);
        }
        public Employee GetEmployee() {
            return this.curEmployee;
        }

        private void OK_button_Click(object sender, System.EventArgs e) {
            if(this.ValidateChildren())
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
