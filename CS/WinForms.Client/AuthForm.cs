using System;
using DevExpress.XtraEditors;

namespace WinForms.Client {
    public partial class AuthForm : XtraForm {
        public AuthForm() {
            InitializeComponent();
        }

        public string Login {
            get { return userNameEdit.Text; }
        }

        public string Password {
            get { return passwordEdit.Text; }
        }
    }
}
