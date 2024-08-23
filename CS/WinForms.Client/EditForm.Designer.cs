namespace WinForms.Client {
    partial class EditForm {
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
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            OK_button = new DevExpress.XtraEditors.SimpleButton();
            dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            Cancel_button = new DevExpress.XtraEditors.SimpleButton();
            FirstNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            employeesBindingSource = new System.Windows.Forms.BindingSource(components);
            LastNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            BirthdayDateEdit = new DevExpress.XtraEditors.DateEdit();
            EmailTextEdit = new DevExpress.XtraEditors.TextEdit();
            FullNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            DepartmentTitleLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            departmentsBindingSource = new System.Windows.Forms.BindingSource(components);
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            ItemForFirstName = new DevExpress.XtraLayout.LayoutControlItem();
            ItemForLastName = new DevExpress.XtraLayout.LayoutControlItem();
            ItemForBirthday = new DevExpress.XtraLayout.LayoutControlItem();
            ItemForEmail = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            ItemForDepartmentTitle = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ItemForFullName = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)dataLayoutControl1).BeginInit();
            dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FirstNameTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LastNameTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BirthdayDateEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BirthdayDateEdit.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EmailTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FullNameTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DepartmentTitleLookUpEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)departmentsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemForFirstName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemForLastName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemForBirthday).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemForEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemForDepartmentTitle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemForFullName).BeginInit();
            SuspendLayout();
            // 
            // OK_button
            // 
            OK_button.AutoWidthInLayoutControl = true;
            OK_button.Location = new System.Drawing.Point(298, 333);
            OK_button.MinimumSize = new System.Drawing.Size(100, 0);
            OK_button.Name = "OK_button";
            OK_button.Size = new System.Drawing.Size(100, 22);
            OK_button.StyleController = dataLayoutControl1;
            OK_button.TabIndex = 8;
            OK_button.Text = "OK";
            OK_button.Click += OK_button_Click;
            // 
            // dataLayoutControl1
            // 
            dataLayoutControl1.AllowCustomization = false;
            dataLayoutControl1.AllowGeneratingCollectionProperties = DevExpress.Utils.DefaultBoolean.True;
            dataLayoutControl1.AllowGeneratingNestedGroups = DevExpress.Utils.DefaultBoolean.True;
            dataLayoutControl1.Controls.Add(Cancel_button);
            dataLayoutControl1.Controls.Add(OK_button);
            dataLayoutControl1.Controls.Add(FirstNameTextEdit);
            dataLayoutControl1.Controls.Add(LastNameTextEdit);
            dataLayoutControl1.Controls.Add(BirthdayDateEdit);
            dataLayoutControl1.Controls.Add(EmailTextEdit);
            dataLayoutControl1.Controls.Add(FullNameTextEdit);
            dataLayoutControl1.Controls.Add(DepartmentTitleLookUpEdit);
            dataLayoutControl1.DataSource = employeesBindingSource;
            dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            dataLayoutControl1.Name = "dataLayoutControl1";
            dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(539, 216, 650, 400);
            dataLayoutControl1.Root = Root;
            dataLayoutControl1.Size = new System.Drawing.Size(410, 367);
            dataLayoutControl1.TabIndex = 3;
            dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // Cancel_button
            // 
            Cancel_button.AutoWidthInLayoutControl = true;
            Cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Cancel_button.Location = new System.Drawing.Point(194, 333);
            Cancel_button.MinimumSize = new System.Drawing.Size(100, 0);
            Cancel_button.Name = "Cancel_button";
            Cancel_button.Size = new System.Drawing.Size(100, 22);
            Cancel_button.StyleController = dataLayoutControl1;
            Cancel_button.TabIndex = 7;
            Cancel_button.Text = "Cancel";
            // 
            // FirstNameTextEdit
            // 
            FirstNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", employeesBindingSource, "FirstName", true));
            FirstNameTextEdit.Location = new System.Drawing.Point(75, 12);
            FirstNameTextEdit.Name = "FirstNameTextEdit";
            FirstNameTextEdit.Size = new System.Drawing.Size(323, 20);
            FirstNameTextEdit.StyleController = dataLayoutControl1;
            FirstNameTextEdit.TabIndex = 0;
            // 
            // employeesBindingSource
            // 
            employeesBindingSource.DataSource = typeof(DataModel.Shared.BusinessObjects.Employee);
            // 
            // LastNameTextEdit
            // 
            LastNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", employeesBindingSource, "LastName", true));
            LastNameTextEdit.Location = new System.Drawing.Point(75, 36);
            LastNameTextEdit.Name = "LastNameTextEdit";
            LastNameTextEdit.Size = new System.Drawing.Size(323, 20);
            LastNameTextEdit.StyleController = dataLayoutControl1;
            LastNameTextEdit.TabIndex = 2;
            // 
            // BirthdayDateEdit
            // 
            BirthdayDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", employeesBindingSource, "Birthday", true));
            BirthdayDateEdit.EditValue = null;
            BirthdayDateEdit.Location = new System.Drawing.Point(75, 84);
            BirthdayDateEdit.Name = "BirthdayDateEdit";
            BirthdayDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            BirthdayDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            BirthdayDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            BirthdayDateEdit.Size = new System.Drawing.Size(323, 20);
            BirthdayDateEdit.StyleController = dataLayoutControl1;
            BirthdayDateEdit.TabIndex = 3;
            // 
            // EmailTextEdit
            // 
            EmailTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", employeesBindingSource, "Email", true));
            EmailTextEdit.Location = new System.Drawing.Point(75, 108);
            EmailTextEdit.Name = "EmailTextEdit";
            EmailTextEdit.Size = new System.Drawing.Size(323, 20);
            EmailTextEdit.StyleController = dataLayoutControl1;
            EmailTextEdit.TabIndex = 4;
            // 
            // FullNameTextEdit
            // 
            FullNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", employeesBindingSource, "FullName", true));
            FullNameTextEdit.Location = new System.Drawing.Point(75, 60);
            FullNameTextEdit.Name = "FullNameTextEdit";
            FullNameTextEdit.Properties.ReadOnly = true;
            FullNameTextEdit.Size = new System.Drawing.Size(323, 20);
            FullNameTextEdit.StyleController = dataLayoutControl1;
            FullNameTextEdit.TabIndex = 6;
            // 
            // DepartmentTitleLookUpEdit
            // 
            DepartmentTitleLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", employeesBindingSource, "Department", true));
            DepartmentTitleLookUpEdit.Location = new System.Drawing.Point(87, 165);
            DepartmentTitleLookUpEdit.Name = "DepartmentTitleLookUpEdit";
            DepartmentTitleLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            DepartmentTitleLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] { new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Title", "Title") });
            DepartmentTitleLookUpEdit.Properties.DataSource = departmentsBindingSource;
            DepartmentTitleLookUpEdit.Properties.DisplayMember = "Title";
            DepartmentTitleLookUpEdit.Properties.NullText = "";
            DepartmentTitleLookUpEdit.Size = new System.Drawing.Size(299, 20);
            DepartmentTitleLookUpEdit.StyleController = dataLayoutControl1;
            DepartmentTitleLookUpEdit.TabIndex = 5;
            // 
            // departmentsBindingSource
            // 
            departmentsBindingSource.DataSource = typeof(DataModel.Shared.BusinessObjects.Department);
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlGroup1 });
            Root.Name = "Root";
            Root.Size = new System.Drawing.Size(410, 367);
            Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            layoutControlGroup1.AllowDrawBackground = false;
            layoutControlGroup1.GroupBordersVisible = false;
            layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { ItemForFirstName, ItemForLastName, ItemForBirthday, ItemForEmail, layoutControlGroup2, emptySpaceItem1, emptySpaceItem2, layoutControlGroup3, ItemForFullName });
            layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            layoutControlGroup1.Name = "autoGeneratedGroup0";
            layoutControlGroup1.Size = new System.Drawing.Size(390, 347);
            // 
            // ItemForFirstName
            // 
            ItemForFirstName.Control = FirstNameTextEdit;
            ItemForFirstName.Location = new System.Drawing.Point(0, 0);
            ItemForFirstName.Name = "ItemForFirstName";
            ItemForFirstName.Size = new System.Drawing.Size(390, 24);
            ItemForFirstName.Text = "First Name";
            ItemForFirstName.TextSize = new System.Drawing.Size(51, 13);
            // 
            // ItemForLastName
            // 
            ItemForLastName.Control = LastNameTextEdit;
            ItemForLastName.Location = new System.Drawing.Point(0, 24);
            ItemForLastName.Name = "ItemForLastName";
            ItemForLastName.Size = new System.Drawing.Size(390, 24);
            ItemForLastName.Text = "Last Name";
            ItemForLastName.TextSize = new System.Drawing.Size(51, 13);
            // 
            // ItemForBirthday
            // 
            ItemForBirthday.Control = BirthdayDateEdit;
            ItemForBirthday.Location = new System.Drawing.Point(0, 72);
            ItemForBirthday.Name = "ItemForBirthday";
            ItemForBirthday.Size = new System.Drawing.Size(390, 24);
            ItemForBirthday.Text = "Birthday";
            ItemForBirthday.TextSize = new System.Drawing.Size(51, 13);
            // 
            // ItemForEmail
            // 
            ItemForEmail.Control = EmailTextEdit;
            ItemForEmail.Location = new System.Drawing.Point(0, 96);
            ItemForEmail.Name = "ItemForEmail";
            ItemForEmail.Size = new System.Drawing.Size(390, 24);
            ItemForEmail.Text = "Email";
            ItemForEmail.TextSize = new System.Drawing.Size(51, 13);
            // 
            // layoutControlGroup2
            // 
            layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { ItemForDepartmentTitle });
            layoutControlGroup2.Location = new System.Drawing.Point(0, 120);
            layoutControlGroup2.Name = "innerAutoGeneratedGroup1";
            layoutControlGroup2.Size = new System.Drawing.Size(390, 69);
            layoutControlGroup2.Text = "Department";
            // 
            // ItemForDepartmentTitle
            // 
            ItemForDepartmentTitle.Control = DepartmentTitleLookUpEdit;
            ItemForDepartmentTitle.Location = new System.Drawing.Point(0, 0);
            ItemForDepartmentTitle.Name = "ItemForDepartmentTitle";
            ItemForDepartmentTitle.Size = new System.Drawing.Size(366, 24);
            ItemForDepartmentTitle.Text = "Title";
            ItemForDepartmentTitle.TextSize = new System.Drawing.Size(51, 13);
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.AllowHotTrack = false;
            emptySpaceItem1.Location = new System.Drawing.Point(0, 189);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new System.Drawing.Size(390, 132);
            emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            emptySpaceItem2.AllowHotTrack = false;
            emptySpaceItem2.Location = new System.Drawing.Point(0, 321);
            emptySpaceItem2.Name = "emptySpaceItem2";
            emptySpaceItem2.Size = new System.Drawing.Size(182, 26);
            emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup3
            // 
            layoutControlGroup3.GroupBordersVisible = false;
            layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem2, layoutControlItem1 });
            layoutControlGroup3.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            layoutControlGroup3.Location = new System.Drawing.Point(182, 321);
            layoutControlGroup3.Name = "layoutControlGroup3";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.AutoSize;
            columnDefinition1.Width = 104D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.AutoSize;
            columnDefinition2.Width = 104D;
            layoutControlGroup3.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] { columnDefinition1, columnDefinition2 });
            rowDefinition1.Height = 26D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.AutoSize;
            layoutControlGroup3.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] { rowDefinition1 });
            layoutControlGroup3.Size = new System.Drawing.Size(208, 26);
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = Cancel_button;
            layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new System.Drawing.Size(104, 26);
            layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = OK_button;
            layoutControlItem1.Location = new System.Drawing.Point(104, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.OptionsTableLayoutItem.ColumnIndex = 1;
            layoutControlItem1.Size = new System.Drawing.Size(104, 26);
            layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem1.TextVisible = false;
            // 
            // ItemForFullName
            // 
            ItemForFullName.Control = FullNameTextEdit;
            ItemForFullName.Location = new System.Drawing.Point(0, 48);
            ItemForFullName.Name = "ItemForFullName";
            ItemForFullName.Size = new System.Drawing.Size(390, 24);
            ItemForFullName.Text = "Full Name";
            ItemForFullName.TextSize = new System.Drawing.Size(51, 13);
            // 
            // EditForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(410, 367);
            Controls.Add(dataLayoutControl1);
            Name = "EditForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Detail Form";
            ((System.ComponentModel.ISupportInitialize)dataLayoutControl1).EndInit();
            dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)FirstNameTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)LastNameTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)BirthdayDateEdit.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)BirthdayDateEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)EmailTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)FullNameTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)DepartmentTitleLookUpEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)departmentsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemForFirstName).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemForLastName).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemForBirthday).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemForEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup2).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemForDepartmentTitle).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemForFullName).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton OK_button;
        private DevExpress.XtraEditors.SimpleButton Cancel_button;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private DevExpress.XtraEditors.TextEdit FirstNameTextEdit;
        private DevExpress.XtraEditors.TextEdit LastNameTextEdit;
        private DevExpress.XtraEditors.DateEdit BirthdayDateEdit;
        private DevExpress.XtraEditors.TextEdit EmailTextEdit;
        private DevExpress.XtraEditors.TextEdit FullNameTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForFirstName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForLastName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBirthday;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmail;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDepartmentTitle;
        private DevExpress.XtraLayout.LayoutControlItem ItemForFullName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.LookUpEdit DepartmentTitleLookUpEdit;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private System.Windows.Forms.BindingSource departmentsBindingSource;
    }
}