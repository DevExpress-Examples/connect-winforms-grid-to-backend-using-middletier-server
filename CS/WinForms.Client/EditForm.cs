using System.Linq;
using DataModel.Shared.BusinessObjects;
using DevExpress.ExpressApp.Security;
using DevExpress.XtraEditors;

namespace WinForms.Client {
    public partial class EditForm : XtraForm {
        Employee curEmployee;
        Department[] departments = null;

        EditForm() {
            InitializeComponent();

            if(!RemoteContextUtils.IsGranded(typeof(Employee), SecurityOperations.Write)) {
                this.dataLayoutControl1.OptionsView.IsReadOnly = DevExpress.Utils.DefaultBoolean.True;
                this.Text += " (Read-Only)";
            }
        }

        public EditForm(Employee employee) : this() {
            using(DXApplication1EFCoreDbContext dbContext = RemoteContextUtils.GetDBContext()) {
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
