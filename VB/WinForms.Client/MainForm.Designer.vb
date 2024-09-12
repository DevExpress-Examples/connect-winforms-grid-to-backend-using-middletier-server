Namespace WinForms.Client

    Partial Class MainForm

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WinForms.Client.MainForm))
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colFirstName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLastName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colEMail = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDepartment = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBirthday = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.bbiPrintPreview = New DevExpress.XtraBars.BarButtonItem()
            Me.bbiNew = New DevExpress.XtraBars.BarButtonItem()
            Me.bbiEdit = New DevExpress.XtraBars.BarButtonItem()
            Me.bbiDelete = New DevExpress.XtraBars.BarButtonItem()
            Me.bbiRefresh = New DevExpress.XtraBars.BarButtonItem()
            Me.bbiLogOut = New DevExpress.XtraBars.BarButtonItem()
            Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' gridControl
            ' 
            Me.gridControl.Location = New System.Drawing.Point(24, 24)
            Me.gridControl.MainView = Me.gridView
            Me.gridControl.MenuManager = Me.ribbonControl
            Me.gridControl.Name = "gridControl"
            Me.gridControl.Size = New System.Drawing.Size(742, 369)
            Me.gridControl.TabIndex = 2
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
            ' 
            ' gridView
            ' 
            Me.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFirstName, Me.colLastName, Me.colEMail, Me.colDepartment, Me.colBirthday})
            Me.gridView.GridControl = Me.gridControl
            Me.gridView.Name = "gridView"
            Me.gridView.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm
            Me.gridView.OptionsMenu.ShowDateTimeGroupIntervalItems = False
            Me.gridView.OptionsView.ShowFooter = True
            ' 
            ' colFirstName
            ' 
            Me.colFirstName.Caption = "First Name"
            Me.colFirstName.FieldName = "FirstName"
            Me.colFirstName.Name = "colFirstName"
            Me.colFirstName.Visible = True
            Me.colFirstName.VisibleIndex = 0
            ' 
            ' colLastName
            ' 
            Me.colLastName.Caption = "Last Name"
            Me.colLastName.FieldName = "LastName"
            Me.colLastName.Name = "colLastName"
            Me.colLastName.Visible = True
            Me.colLastName.VisibleIndex = 1
            ' 
            ' colEMail
            ' 
            Me.colEMail.Caption = "E-mail"
            Me.colEMail.FieldName = "Email"
            Me.colEMail.Name = "colEMail"
            Me.colEMail.Visible = True
            Me.colEMail.VisibleIndex = 2
            ' 
            ' colDepartment
            ' 
            Me.colDepartment.Caption = "Department"
            Me.colDepartment.FieldName = "Department.Title"
            Me.colDepartment.Name = "colDepartment"
            Me.colDepartment.Visible = True
            Me.colDepartment.VisibleIndex = 3
            ' 
            ' colBirthday
            ' 
            Me.colBirthday.Caption = "Birthday"
            Me.colBirthday.FieldName = "Birthday"
            Me.colBirthday.Name = "colBirthday"
            Me.colBirthday.Visible = True
            Me.colBirthday.VisibleIndex = 4
            ' 
            ' ribbonControl
            ' 
            Me.ribbonControl.ExpandCollapseItem.Id = 0
            Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl.ExpandCollapseItem, Me.bbiPrintPreview, Me.bbiNew, Me.bbiEdit, Me.bbiDelete, Me.bbiRefresh, Me.bbiLogOut})
            Me.ribbonControl.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl.MaxItemId = 21
            Me.ribbonControl.Name = "ribbonControl"
            Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1})
            Me.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
            Me.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
            Me.ribbonControl.Size = New System.Drawing.Size(790, 158)
            Me.ribbonControl.StatusBar = Me.ribbonStatusBar
            Me.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
            ' 
            ' bbiPrintPreview
            ' 
            Me.bbiPrintPreview.Caption = "Print Preview"
            Me.bbiPrintPreview.Id = 14
            Me.bbiPrintPreview.ImageOptions.ImageUri.Uri = "Preview"
            Me.bbiPrintPreview.Name = "bbiPrintPreview"
            AddHandler Me.bbiPrintPreview.ItemClick, AddressOf bbiPrintPreview_ItemClick
            ' 
            ' bbiNew
            ' 
            Me.bbiNew.Caption = "New"
            Me.bbiNew.Id = 16
            Me.bbiNew.ImageOptions.ImageUri.Uri = "New"
            Me.bbiNew.Name = "bbiNew"
            AddHandler Me.bbiNew.ItemClick, AddressOf bbiNew_ItemClick
            ' 
            ' bbiEdit
            ' 
            Me.bbiEdit.Caption = "Edit"
            Me.bbiEdit.Id = 17
            Me.bbiEdit.ImageOptions.ImageUri.Uri = "Edit"
            Me.bbiEdit.Name = "bbiEdit"
            AddHandler Me.bbiEdit.ItemClick, AddressOf bbiEdit_ItemClick
            ' 
            ' bbiDelete
            ' 
            Me.bbiDelete.Caption = "Delete"
            Me.bbiDelete.Id = 18
            Me.bbiDelete.ImageOptions.ImageUri.Uri = "Delete"
            Me.bbiDelete.Name = "bbiDelete"
            AddHandler Me.bbiDelete.ItemClick, AddressOf bbiDelete_ItemClick
            ' 
            ' bbiRefresh
            ' 
            Me.bbiRefresh.Caption = "Refresh"
            Me.bbiRefresh.Id = 19
            Me.bbiRefresh.ImageOptions.ImageUri.Uri = "Refresh"
            Me.bbiRefresh.Name = "bbiRefresh"
            AddHandler Me.bbiRefresh.ItemClick, AddressOf bbiRefresh_ItemClick
            ' 
            ' bbiLogOut
            ' 
            Me.bbiLogOut.Caption = "Log Out"
            Me.bbiLogOut.Id = 20
            Me.bbiLogOut.ImageOptions.SvgImage = CType(resources.GetObject("bbiLogOut.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
            Me.bbiLogOut.Name = "bbiLogOut"
            AddHandler Me.bbiLogOut.ItemClick, AddressOf bbiLogOut_ItemClick
            ' 
            ' ribbonPage1
            ' 
            Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1, Me.ribbonPageGroup2})
            Me.ribbonPage1.MergeOrder = 0
            Me.ribbonPage1.Name = "ribbonPage1"
            Me.ribbonPage1.Text = "Home"
            ' 
            ' ribbonPageGroup1
            ' 
            Me.ribbonPageGroup1.AllowTextClipping = False
            Me.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.ribbonPageGroup1.ItemLinks.Add(Me.bbiNew)
            Me.ribbonPageGroup1.ItemLinks.Add(Me.bbiEdit)
            Me.ribbonPageGroup1.ItemLinks.Add(Me.bbiDelete)
            Me.ribbonPageGroup1.ItemLinks.Add(Me.bbiRefresh)
            Me.ribbonPageGroup1.ItemLinks.Add(Me.bbiLogOut)
            Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
            Me.ribbonPageGroup1.Text = "Tasks"
            ' 
            ' ribbonPageGroup2
            ' 
            Me.ribbonPageGroup2.AllowTextClipping = False
            Me.ribbonPageGroup2.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.ribbonPageGroup2.ItemLinks.Add(Me.bbiPrintPreview)
            Me.ribbonPageGroup2.Name = "ribbonPageGroup2"
            Me.ribbonPageGroup2.Text = "Print and Export"
            ' 
            ' ribbonStatusBar
            ' 
            Me.ribbonStatusBar.Location = New System.Drawing.Point(0, 575)
            Me.ribbonStatusBar.Name = "ribbonStatusBar"
            Me.ribbonStatusBar.Ribbon = Me.ribbonControl
            Me.ribbonStatusBar.Size = New System.Drawing.Size(790, 24)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.gridControl)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 158)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.Root
            Me.layoutControl1.Size = New System.Drawing.Size(790, 417)
            Me.layoutControl1.TabIndex = 4
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' Root
            ' 
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup1})
            Me.Root.Name = "Root"
            Me.Root.Size = New System.Drawing.Size(790, 417)
            Me.Root.TextVisible = False
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(770, 397)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.gridControl
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(746, 373)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' MainForm
            ' 
            AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            ClientSize = New System.Drawing.Size(790, 599)
            Controls.Add(Me.layoutControl1)
            Controls.Add(Me.ribbonStatusBar)
            Controls.Add(Me.ribbonControl)
            Name = "MainForm"
            Ribbon = Me.ribbonControl
            StatusBar = Me.ribbonStatusBar
            Me.Text = "WinForms UI Client | DevExpress"
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()
        End Sub

#End Region
        Private gridControl As DevExpress.XtraGrid.GridControl

        Private gridView As DevExpress.XtraGrid.Views.Grid.GridView

        Private ribbonControl As DevExpress.XtraBars.Ribbon.RibbonControl

        Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage

        Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private bbiPrintPreview As DevExpress.XtraBars.BarButtonItem

        Private ribbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private ribbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar

        Private bbiNew As DevExpress.XtraBars.BarButtonItem

        Private bbiEdit As DevExpress.XtraBars.BarButtonItem

        Private bbiDelete As DevExpress.XtraBars.BarButtonItem

        Private bbiRefresh As DevExpress.XtraBars.BarButtonItem

        Private colFirstName As DevExpress.XtraGrid.Columns.GridColumn

        Private colLastName As DevExpress.XtraGrid.Columns.GridColumn

        Private colEMail As DevExpress.XtraGrid.Columns.GridColumn

        Private colDepartment As DevExpress.XtraGrid.Columns.GridColumn

        Private colBirthday As DevExpress.XtraGrid.Columns.GridColumn

        Private bbiLogOut As DevExpress.XtraBars.BarButtonItem

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
