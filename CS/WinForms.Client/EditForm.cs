using System;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Forms;
using DataModel.Shared.BusinessObjects;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.ApplicationBuilder;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Security;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;

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

        private void CheckPermissions() {
            dataLayoutControl1.BeginUpdate();
            try {
                foreach(BaseLayoutItem layoutItem in dataLayoutControl1.Items) {
                    if((layoutItem is LayoutControlItem layoutControlItem) && (layoutControlItem.Control != null)
                            && (layoutControlItem.Control.DataBindings.Count > 0)) {
                        var memberName = layoutControlItem.Control.DataBindings[0].BindingMemberInfo.BindingMember;
                        if(middleTierClient.Security.CanRead(securedObjectSpace, curEmployee, memberName)) {
                            layoutControlItem.Control.Enabled = 
                                middleTierClient.Security.CanWrite(securedObjectSpace, curEmployee, memberName);
                        }
                        else {
                            var prevControl = layoutControlItem.Control;
                            layoutControlItem.Control = new ProtectedContentEdit();
                            prevControl.Dispose();
                        }
                    }
                }
            } finally {
                dataLayoutControl1.EndUpdate();
            }
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
            CheckPermissions();
        }

        void SetEmployee(Employee employee) {
            this.curEmployee = new Employee();
            this.curEmployee.Birthday = employee.Birthday;
            this.curEmployee.ID = employee.ID;
            this.curEmployee.FirstName = employee.FirstName;
            this.curEmployee.LastName = employee.LastName;
            this.curEmployee.Email = employee.Email;
            if(employee.Department != null) {
                curEmployee.Department = departments.First(n => n.ID == employee.Department.ID);
            }
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
