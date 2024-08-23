Namespace WinForms.Client

    Partial Class EditForm

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim columnDefinition1 As DevExpress.XtraLayout.ColumnDefinition = New DevExpress.XtraLayout.ColumnDefinition()
            Dim columnDefinition2 As DevExpress.XtraLayout.ColumnDefinition = New DevExpress.XtraLayout.ColumnDefinition()
            Dim rowDefinition1 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
            Me.OK_button = New DevExpress.XtraEditors.SimpleButton()
            Me.dataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
            Me.Cancel_button = New DevExpress.XtraEditors.SimpleButton()
            Me.FirstNameTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.employeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.LastNameTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.BirthdayDateEdit = New DevExpress.XtraEditors.DateEdit()
            Me.EmailTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.FullNameTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.DepartmentTitleLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
            Me.departmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.ItemForFirstName = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForLastName = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForBirthday = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForEmail = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.ItemForDepartmentTitle = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForFullName = New DevExpress.XtraLayout.LayoutControlItem()
            CType(Me.dataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dataLayoutControl1.SuspendLayout()
            CType(Me.FirstNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.employeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LastNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.BirthdayDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.BirthdayDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.EmailTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.FullNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DepartmentTitleLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.departmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForFirstName, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForLastName, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForBirthday, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForEmail, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForDepartmentTitle, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForFullName, System.ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' OK_button
            ' 
            Me.OK_button.AutoWidthInLayoutControl = True
            Me.OK_button.Location = New System.Drawing.Point(298, 333)
            Me.OK_button.MinimumSize = New System.Drawing.Size(100, 0)
            Me.OK_button.Name = "OK_button"
            Me.OK_button.Size = New System.Drawing.Size(100, 22)
            Me.OK_button.StyleController = Me.dataLayoutControl1
            Me.OK_button.TabIndex = 8
            Me.OK_button.Text = "OK"
            Me.OK_button.Click += AddressOf OK_button_Click
            ' 
            ' dataLayoutControl1
            ' 
            Me.dataLayoutControl1.AllowCustomization = False
            Me.dataLayoutControl1.AllowGeneratingCollectionProperties = DevExpress.Utils.DefaultBoolean.[True]
            Me.dataLayoutControl1.AllowGeneratingNestedGroups = DevExpress.Utils.DefaultBoolean.[True]
            Me.dataLayoutControl1.Controls.Add(Me.Cancel_button)
            Me.dataLayoutControl1.Controls.Add(Me.OK_button)
            Me.dataLayoutControl1.Controls.Add(Me.FirstNameTextEdit)
            Me.dataLayoutControl1.Controls.Add(Me.LastNameTextEdit)
            Me.dataLayoutControl1.Controls.Add(Me.BirthdayDateEdit)
            Me.dataLayoutControl1.Controls.Add(Me.EmailTextEdit)
            Me.dataLayoutControl1.Controls.Add(Me.FullNameTextEdit)
            Me.dataLayoutControl1.Controls.Add(Me.DepartmentTitleLookUpEdit)
            Me.dataLayoutControl1.DataSource = Me.employeesBindingSource
            Me.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dataLayoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.dataLayoutControl1.Name = "dataLayoutControl1"
            Me.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(539, 216, 650, 400)
            Me.dataLayoutControl1.Root = Me.Root
            Me.dataLayoutControl1.Size = New System.Drawing.Size(410, 367)
            Me.dataLayoutControl1.TabIndex = 3
            Me.dataLayoutControl1.Text = "dataLayoutControl1"
            ' 
            ' Cancel_button
            ' 
            Me.Cancel_button.AutoWidthInLayoutControl = True
            Me.Cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.Cancel_button.Location = New System.Drawing.Point(194, 333)
            Me.Cancel_button.MinimumSize = New System.Drawing.Size(100, 0)
            Me.Cancel_button.Name = "Cancel_button"
            Me.Cancel_button.Size = New System.Drawing.Size(100, 22)
            Me.Cancel_button.StyleController = Me.dataLayoutControl1
            Me.Cancel_button.TabIndex = 7
            Me.Cancel_button.Text = "Cancel"
            ' 
            ' FirstNameTextEdit
            ' 
            Me.FirstNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.employeesBindingSource, "FirstName", True))
            Me.FirstNameTextEdit.Location = New System.Drawing.Point(75, 12)
            Me.FirstNameTextEdit.Name = "FirstNameTextEdit"
            Me.FirstNameTextEdit.Size = New System.Drawing.Size(323, 20)
            Me.FirstNameTextEdit.StyleController = Me.dataLayoutControl1
            Me.FirstNameTextEdit.TabIndex = 0
            ' 
            ' employeesBindingSource
            ' 
            Me.employeesBindingSource.DataSource = GetType(DataModel.[Shared].BusinessObjects.Employee)
            ' 
            ' LastNameTextEdit
            ' 
            Me.LastNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.employeesBindingSource, "LastName", True))
            Me.LastNameTextEdit.Location = New System.Drawing.Point(75, 36)
            Me.LastNameTextEdit.Name = "LastNameTextEdit"
            Me.LastNameTextEdit.Size = New System.Drawing.Size(323, 20)
            Me.LastNameTextEdit.StyleController = Me.dataLayoutControl1
            Me.LastNameTextEdit.TabIndex = 2
            ' 
            ' BirthdayDateEdit
            ' 
            Me.BirthdayDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.employeesBindingSource, "Birthday", True))
            Me.BirthdayDateEdit.EditValue = Nothing
            Me.BirthdayDateEdit.Location = New System.Drawing.Point(75, 84)
            Me.BirthdayDateEdit.Name = "BirthdayDateEdit"
            Me.BirthdayDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
            Me.BirthdayDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.BirthdayDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.BirthdayDateEdit.Size = New System.Drawing.Size(323, 20)
            Me.BirthdayDateEdit.StyleController = Me.dataLayoutControl1
            Me.BirthdayDateEdit.TabIndex = 3
            ' 
            ' EmailTextEdit
            ' 
            Me.EmailTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.employeesBindingSource, "Email", True))
            Me.EmailTextEdit.Location = New System.Drawing.Point(75, 108)
            Me.EmailTextEdit.Name = "EmailTextEdit"
            Me.EmailTextEdit.Size = New System.Drawing.Size(323, 20)
            Me.EmailTextEdit.StyleController = Me.dataLayoutControl1
            Me.EmailTextEdit.TabIndex = 4
            ' 
            ' FullNameTextEdit
            ' 
            Me.FullNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.employeesBindingSource, "FullName", True))
            Me.FullNameTextEdit.Location = New System.Drawing.Point(75, 60)
            Me.FullNameTextEdit.Name = "FullNameTextEdit"
            Me.FullNameTextEdit.Properties.[ReadOnly] = True
            Me.FullNameTextEdit.Size = New System.Drawing.Size(323, 20)
            Me.FullNameTextEdit.StyleController = Me.dataLayoutControl1
            Me.FullNameTextEdit.TabIndex = 6
            ' 
            ' DepartmentTitleLookUpEdit
            ' 
            Me.DepartmentTitleLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.employeesBindingSource, "Department", True))
            Me.DepartmentTitleLookUpEdit.Location = New System.Drawing.Point(87, 165)
            Me.DepartmentTitleLookUpEdit.Name = "DepartmentTitleLookUpEdit"
            Me.DepartmentTitleLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.DepartmentTitleLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Title", "Title")})
            Me.DepartmentTitleLookUpEdit.Properties.DataSource = Me.departmentsBindingSource
            Me.DepartmentTitleLookUpEdit.Properties.DisplayMember = "Title"
            Me.DepartmentTitleLookUpEdit.Properties.NullText = ""
            Me.DepartmentTitleLookUpEdit.Size = New System.Drawing.Size(299, 20)
            Me.DepartmentTitleLookUpEdit.StyleController = Me.dataLayoutControl1
            Me.DepartmentTitleLookUpEdit.TabIndex = 5
            ' 
            ' departmentsBindingSource
            ' 
            Me.departmentsBindingSource.DataSource = GetType(DataModel.[Shared].BusinessObjects.Department)
            ' 
            ' Root
            ' 
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup1})
            Me.Root.Name = "Root"
            Me.Root.Size = New System.Drawing.Size(410, 367)
            Me.Root.TextVisible = False
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.AllowDrawBackground = False
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForFirstName, Me.ItemForLastName, Me.ItemForBirthday, Me.ItemForEmail, Me.layoutControlGroup2, Me.emptySpaceItem1, Me.emptySpaceItem2, Me.layoutControlGroup3, Me.ItemForFullName})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "autoGeneratedGroup0"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(390, 347)
            ' 
            ' ItemForFirstName
            ' 
            Me.ItemForFirstName.Control = Me.FirstNameTextEdit
            Me.ItemForFirstName.Location = New System.Drawing.Point(0, 0)
            Me.ItemForFirstName.Name = "ItemForFirstName"
            Me.ItemForFirstName.Size = New System.Drawing.Size(390, 24)
            Me.ItemForFirstName.Text = "First Name"
            Me.ItemForFirstName.TextSize = New System.Drawing.Size(51, 13)
            ' 
            ' ItemForLastName
            ' 
            Me.ItemForLastName.Control = Me.LastNameTextEdit
            Me.ItemForLastName.Location = New System.Drawing.Point(0, 24)
            Me.ItemForLastName.Name = "ItemForLastName"
            Me.ItemForLastName.Size = New System.Drawing.Size(390, 24)
            Me.ItemForLastName.Text = "Last Name"
            Me.ItemForLastName.TextSize = New System.Drawing.Size(51, 13)
            ' 
            ' ItemForBirthday
            ' 
            Me.ItemForBirthday.Control = Me.BirthdayDateEdit
            Me.ItemForBirthday.Location = New System.Drawing.Point(0, 72)
            Me.ItemForBirthday.Name = "ItemForBirthday"
            Me.ItemForBirthday.Size = New System.Drawing.Size(390, 24)
            Me.ItemForBirthday.Text = "Birthday"
            Me.ItemForBirthday.TextSize = New System.Drawing.Size(51, 13)
            ' 
            ' ItemForEmail
            ' 
            Me.ItemForEmail.Control = Me.EmailTextEdit
            Me.ItemForEmail.Location = New System.Drawing.Point(0, 96)
            Me.ItemForEmail.Name = "ItemForEmail"
            Me.ItemForEmail.Size = New System.Drawing.Size(390, 24)
            Me.ItemForEmail.Text = "Email"
            Me.ItemForEmail.TextSize = New System.Drawing.Size(51, 13)
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForDepartmentTitle})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 120)
            Me.layoutControlGroup2.Name = "innerAutoGeneratedGroup1"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(390, 69)
            Me.layoutControlGroup2.Text = "Department"
            ' 
            ' ItemForDepartmentTitle
            ' 
            Me.ItemForDepartmentTitle.Control = Me.DepartmentTitleLookUpEdit
            Me.ItemForDepartmentTitle.Location = New System.Drawing.Point(0, 0)
            Me.ItemForDepartmentTitle.Name = "ItemForDepartmentTitle"
            Me.ItemForDepartmentTitle.Size = New System.Drawing.Size(366, 24)
            Me.ItemForDepartmentTitle.Text = "Title"
            Me.ItemForDepartmentTitle.TextSize = New System.Drawing.Size(51, 13)
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 189)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(390, 132)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.AllowHotTrack = False
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 321)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(182, 26)
            Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.GroupBordersVisible = False
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2, Me.layoutControlItem1})
            Me.layoutControlGroup3.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table
            Me.layoutControlGroup3.Location = New System.Drawing.Point(182, 321)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.AutoSize
            columnDefinition1.Width = 104R
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.AutoSize
            columnDefinition2.Width = 104R
            Me.layoutControlGroup3.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(New DevExpress.XtraLayout.ColumnDefinition() {columnDefinition1, columnDefinition2})
            rowDefinition1.Height = 26R
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.AutoSize
            Me.layoutControlGroup3.OptionsTableLayoutGroup.RowDefinitions.AddRange(New DevExpress.XtraLayout.RowDefinition() {rowDefinition1})
            Me.layoutControlGroup3.Size = New System.Drawing.Size(208, 26)
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.Cancel_button
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(104, 26)
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.OK_button
            Me.layoutControlItem1.Location = New System.Drawing.Point(104, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.OptionsTableLayoutItem.ColumnIndex = 1
            Me.layoutControlItem1.Size = New System.Drawing.Size(104, 26)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' ItemForFullName
            ' 
            Me.ItemForFullName.Control = Me.FullNameTextEdit
            Me.ItemForFullName.Location = New System.Drawing.Point(0, 48)
            Me.ItemForFullName.Name = "ItemForFullName"
            Me.ItemForFullName.Size = New System.Drawing.Size(390, 24)
            Me.ItemForFullName.Text = "Full Name"
            Me.ItemForFullName.TextSize = New System.Drawing.Size(51, 13)
            ' 
            ' EditForm
            ' 
            AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            ClientSize = New System.Drawing.Size(410, 367)
            Controls.Add(Me.dataLayoutControl1)
            Name = "EditForm"
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Detail Form"
            CType(Me.dataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.dataLayoutControl1.ResumeLayout(False)
            CType(Me.FirstNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.employeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LastNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.BirthdayDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.BirthdayDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.EmailTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.FullNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DepartmentTitleLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.departmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForFirstName, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForLastName, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForBirthday, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForEmail, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForDepartmentTitle, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForFullName, System.ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
        End Sub

#End Region
        Private OK_button As DevExpress.XtraEditors.SimpleButton

        Private Cancel_button As DevExpress.XtraEditors.SimpleButton

        Private dataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private employeesBindingSource As System.Windows.Forms.BindingSource

        Private FirstNameTextEdit As DevExpress.XtraEditors.TextEdit

        Private LastNameTextEdit As DevExpress.XtraEditors.TextEdit

        Private BirthdayDateEdit As DevExpress.XtraEditors.DateEdit

        Private EmailTextEdit As DevExpress.XtraEditors.TextEdit

        Private FullNameTextEdit As DevExpress.XtraEditors.TextEdit

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private ItemForFirstName As DevExpress.XtraLayout.LayoutControlItem

        Private ItemForLastName As DevExpress.XtraLayout.LayoutControlItem

        Private ItemForBirthday As DevExpress.XtraLayout.LayoutControlItem

        Private ItemForEmail As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private ItemForDepartmentTitle As DevExpress.XtraLayout.LayoutControlItem

        Private ItemForFullName As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private DepartmentTitleLookUpEdit As DevExpress.XtraEditors.LookUpEdit

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup

        Private departmentsBindingSource As System.Windows.Forms.BindingSource
    End Class
End Namespace
