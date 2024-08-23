namespace WinForms.Client {
    partial class AuthForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            buttonLogin = new DevExpress.XtraEditors.SimpleButton();
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            buttonCancel = new DevExpress.XtraEditors.SimpleButton();
            passwordEdit = new DevExpress.XtraEditors.TextEdit();
            userNameEdit = new DevExpress.XtraEditors.TextEdit();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlGroupButtons = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItemLogin = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItemCancel = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            emptySpaceItem7 = new DevExpress.XtraLayout.EmptySpaceItem();
            emptySpaceItem8 = new DevExpress.XtraLayout.EmptySpaceItem();
            layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            simpleLabelItem2 = new DevExpress.XtraLayout.SimpleLabelItem();
            layoutControlItemUserName = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            layoutControlItemPassword = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
            emptySpaceItem9 = new DevExpress.XtraLayout.EmptySpaceItem();
            emptySpaceItem10 = new DevExpress.XtraLayout.EmptySpaceItem();
            emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)passwordEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userNameEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroupButtons).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItemLogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItemCancel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)simpleLabelItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItemUserName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItemPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dxErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // buttonLogin
            // 
            buttonLogin.DialogResult = System.Windows.Forms.DialogResult.OK;
            buttonLogin.Location = new System.Drawing.Point(316, 211);
            buttonLogin.Margin = new System.Windows.Forms.Padding(2);
            buttonLogin.MaximumSize = new System.Drawing.Size(70, 26);
            buttonLogin.MinimumSize = new System.Drawing.Size(70, 26);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new System.Drawing.Size(70, 26);
            buttonLogin.StyleController = layoutControl1;
            buttonLogin.TabIndex = 0;
            buttonLogin.Text = "Log In";
            // 
            // layoutControl1
            // 
            layoutControl1.AllowCustomization = false;
            layoutControl1.Controls.Add(buttonCancel);
            layoutControl1.Controls.Add(buttonLogin);
            layoutControl1.Controls.Add(passwordEdit);
            layoutControl1.Controls.Add(userNameEdit);
            layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            layoutControl1.Location = new System.Drawing.Point(0, 0);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(624, 143, 742, 800);
            layoutControl1.OptionsFocus.EnableAutoTabOrder = false;
            layoutControl1.Root = Root;
            layoutControl1.Size = new System.Drawing.Size(478, 255);
            layoutControl1.TabIndex = 5;
            layoutControl1.Text = "layoutControl1";
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            buttonCancel.Location = new System.Drawing.Point(390, 211);
            buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            buttonCancel.MaximumSize = new System.Drawing.Size(70, 26);
            buttonCancel.MinimumSize = new System.Drawing.Size(70, 26);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new System.Drawing.Size(70, 26);
            buttonCancel.StyleController = layoutControl1;
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Cancel";
            // 
            // passwordEdit
            // 
            passwordEdit.EditValue = "";
            passwordEdit.Location = new System.Drawing.Point(83, 113);
            passwordEdit.Name = "passwordEdit";
            passwordEdit.Properties.NullValuePrompt = "Password";
            passwordEdit.Properties.PasswordChar = '*';
            passwordEdit.Size = new System.Drawing.Size(310, 20);
            passwordEdit.StyleController = layoutControl1;
            passwordEdit.TabIndex = 3;
            // 
            // userNameEdit
            // 
            userNameEdit.EditValue = "User";
            dxErrorProvider.SetIconAlignment(userNameEdit, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            userNameEdit.Location = new System.Drawing.Point(83, 89);
            userNameEdit.Name = "userNameEdit";
            userNameEdit.Size = new System.Drawing.Size(310, 20);
            userNameEdit.StyleController = layoutControl1;
            userNameEdit.TabIndex = 2;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlGroupButtons, layoutControlGroup1, emptySpaceItem4 });
            Root.Name = "Root";
            Root.OptionsItemText.TextToControlDistance = 4;
            Root.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            Root.Size = new System.Drawing.Size(478, 255);
            Root.TextVisible = false;
            // 
            // layoutControlGroupButtons
            // 
            layoutControlGroupButtons.GroupBordersVisible = false;
            layoutControlGroupButtons.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItemLogin, layoutControlItemCancel, emptySpaceItem1, emptySpaceItem7, emptySpaceItem8 });
            layoutControlGroupButtons.Location = new System.Drawing.Point(0, 205);
            layoutControlGroupButtons.Name = "layoutControlGroupButtons";
            layoutControlGroupButtons.OptionsItemText.TextToControlDistance = 0;
            layoutControlGroupButtons.Size = new System.Drawing.Size(470, 42);
            layoutControlGroupButtons.TextVisible = false;
            // 
            // layoutControlItemLogin
            // 
            layoutControlItemLogin.Control = buttonLogin;
            layoutControlItemLogin.Location = new System.Drawing.Point(310, 0);
            layoutControlItemLogin.Name = "layoutControlItemLogin";
            layoutControlItemLogin.Size = new System.Drawing.Size(74, 30);
            layoutControlItemLogin.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItemLogin.TextVisible = false;
            // 
            // layoutControlItemCancel
            // 
            layoutControlItemCancel.Control = buttonCancel;
            layoutControlItemCancel.Location = new System.Drawing.Point(384, 0);
            layoutControlItemCancel.Name = "layoutControlItemCancel";
            layoutControlItemCancel.Size = new System.Drawing.Size(74, 30);
            layoutControlItemCancel.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItemCancel.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.AllowHotTrack = false;
            emptySpaceItem1.Location = new System.Drawing.Point(0, 0);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new System.Drawing.Size(310, 30);
            emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem7
            // 
            emptySpaceItem7.AllowHotTrack = false;
            emptySpaceItem7.Location = new System.Drawing.Point(458, 0);
            emptySpaceItem7.Name = "emptySpaceItem7";
            emptySpaceItem7.Size = new System.Drawing.Size(12, 30);
            emptySpaceItem7.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem8
            // 
            emptySpaceItem8.AllowHotTrack = false;
            emptySpaceItem8.Location = new System.Drawing.Point(0, 30);
            emptySpaceItem8.Name = "emptySpaceItem8";
            emptySpaceItem8.Size = new System.Drawing.Size(470, 12);
            emptySpaceItem8.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup1
            // 
            layoutControlGroup1.GroupBordersVisible = false;
            layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { simpleLabelItem2, layoutControlItemUserName, emptySpaceItem2, layoutControlItemPassword, emptySpaceItem5, emptySpaceItem6, emptySpaceItem9, emptySpaceItem10 });
            layoutControlGroup1.Location = new System.Drawing.Point(0, 44);
            layoutControlGroup1.Name = "layoutControlGroup1";
            layoutControlGroup1.Size = new System.Drawing.Size(470, 161);
            layoutControlGroup1.TextVisible = false;
            // 
            // simpleLabelItem2
            // 
            simpleLabelItem2.AllowHotTrack = false;
            simpleLabelItem2.AllowHtmlStringInCaption = true;
            simpleLabelItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            simpleLabelItem2.AppearanceItemCaption.Options.UseFont = true;
            simpleLabelItem2.Location = new System.Drawing.Point(77, 0);
            simpleLabelItem2.Name = "simpleLabelItem2";
            simpleLabelItem2.Size = new System.Drawing.Size(314, 17);
            simpleLabelItem2.Text = "Enter your user name (<b>Admin</b> or <b>User</b>) to proceed.";
            simpleLabelItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            simpleLabelItem2.TextSize = new System.Drawing.Size(252, 13);
            // 
            // layoutControlItemUserName
            // 
            layoutControlItemUserName.Control = userNameEdit;
            layoutControlItemUserName.CustomizationFormText = "User Name";
            layoutControlItemUserName.Location = new System.Drawing.Point(77, 39);
            layoutControlItemUserName.Name = "layoutControlItemUserName";
            layoutControlItemUserName.Size = new System.Drawing.Size(314, 24);
            layoutControlItemUserName.Text = "User Name:";
            layoutControlItemUserName.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItemUserName.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            emptySpaceItem2.AllowHotTrack = false;
            emptySpaceItem2.Location = new System.Drawing.Point(77, 99);
            emptySpaceItem2.Name = "emptySpaceItem2";
            emptySpaceItem2.Size = new System.Drawing.Size(314, 62);
            emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItemPassword
            // 
            layoutControlItemPassword.Control = passwordEdit;
            layoutControlItemPassword.Location = new System.Drawing.Point(77, 63);
            layoutControlItemPassword.Name = "layoutControlItemPassword";
            layoutControlItemPassword.Size = new System.Drawing.Size(314, 24);
            layoutControlItemPassword.Text = "Password:";
            layoutControlItemPassword.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItemPassword.TextVisible = false;
            // 
            // emptySpaceItem5
            // 
            emptySpaceItem5.AllowHotTrack = false;
            emptySpaceItem5.Location = new System.Drawing.Point(391, 0);
            emptySpaceItem5.Name = "emptySpaceItem5";
            emptySpaceItem5.Size = new System.Drawing.Size(79, 161);
            emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem6
            // 
            emptySpaceItem6.AllowHotTrack = false;
            emptySpaceItem6.Location = new System.Drawing.Point(0, 0);
            emptySpaceItem6.Name = "emptySpaceItem6";
            emptySpaceItem6.Size = new System.Drawing.Size(77, 161);
            emptySpaceItem6.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem9
            // 
            emptySpaceItem9.AllowHotTrack = false;
            emptySpaceItem9.Location = new System.Drawing.Point(77, 17);
            emptySpaceItem9.Name = "emptySpaceItem9";
            emptySpaceItem9.Size = new System.Drawing.Size(314, 22);
            emptySpaceItem9.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem10
            // 
            emptySpaceItem10.AllowHotTrack = false;
            emptySpaceItem10.Location = new System.Drawing.Point(77, 87);
            emptySpaceItem10.Name = "emptySpaceItem10";
            emptySpaceItem10.Size = new System.Drawing.Size(314, 12);
            emptySpaceItem10.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem4
            // 
            emptySpaceItem4.AllowHotTrack = false;
            emptySpaceItem4.Location = new System.Drawing.Point(0, 0);
            emptySpaceItem4.Name = "emptySpaceItem4";
            emptySpaceItem4.Size = new System.Drawing.Size(470, 44);
            emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // dxErrorProvider
            // 
            dxErrorProvider.ContainerControl = this;
            // 
            // AuthForm
            // 
            AcceptButton = buttonLogin;
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(478, 255);
            Controls.Add(layoutControl1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AuthForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Welcome to the XAF's Security in Non-XAF Apps Demo!";
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)passwordEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)userNameEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroupButtons).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItemLogin).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItemCancel).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem7).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem8).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).EndInit();
            ((System.ComponentModel.ISupportInitialize)simpleLabelItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItemUserName).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItemPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem5).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem6).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem9).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem10).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dxErrorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton buttonLogin;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit passwordEdit;
        private DevExpress.XtraEditors.TextEdit userNameEdit;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemUserName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemPassword;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemLogin;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.SimpleButton buttonCancel;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemCancel;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroupButtons;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem8;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem9;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem10;

    }
}