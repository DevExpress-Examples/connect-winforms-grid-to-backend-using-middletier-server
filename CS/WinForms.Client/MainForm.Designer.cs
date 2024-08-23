namespace WinForms.Client {
    partial class MainForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            gridControl = new DevExpress.XtraGrid.GridControl();
            gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            colEMail = new DevExpress.XtraGrid.Columns.GridColumn();
            colDepartment = new DevExpress.XtraGrid.Columns.GridColumn();
            colBirthday = new DevExpress.XtraGrid.Columns.GridColumn();
            ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            bbiPrintPreview = new DevExpress.XtraBars.BarButtonItem();
            bbiNew = new DevExpress.XtraBars.BarButtonItem();
            bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            bbiLogOut = new DevExpress.XtraBars.BarButtonItem();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)gridControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ribbonControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            SuspendLayout();
            // 
            // gridControl
            // 
            gridControl.Location = new System.Drawing.Point(24, 24);
            gridControl.MainView = gridView;
            gridControl.MenuManager = ribbonControl;
            gridControl.Name = "gridControl";
            gridControl.Size = new System.Drawing.Size(742, 369);
            gridControl.TabIndex = 2;
            gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView });
            // 
            // gridView
            // 
            gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colFirstName, colLastName, colEMail, colDepartment, colBirthday });
            gridView.GridControl = gridControl;
            gridView.Name = "gridView";
            gridView.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            gridView.OptionsMenu.ShowDateTimeGroupIntervalItems = false;
            gridView.OptionsView.ShowFooter = true;
            // 
            // colFirstName
            // 
            colFirstName.Caption = "First Name";
            colFirstName.FieldName = "FirstName";
            colFirstName.Name = "colFirstName";
            colFirstName.Visible = true;
            colFirstName.VisibleIndex = 0;
            // 
            // colLastName
            // 
            colLastName.Caption = "Last Name";
            colLastName.FieldName = "LastName";
            colLastName.Name = "colLastName";
            colLastName.Visible = true;
            colLastName.VisibleIndex = 1;
            // 
            // colEMail
            // 
            colEMail.Caption = "E-mail";
            colEMail.FieldName = "Email";
            colEMail.Name = "colEMail";
            colEMail.Visible = true;
            colEMail.VisibleIndex = 2;
            // 
            // colDepartment
            // 
            colDepartment.Caption = "Department";
            colDepartment.FieldName = "Department.Title";
            colDepartment.Name = "colDepartment";
            colDepartment.Visible = true;
            colDepartment.VisibleIndex = 3;
            // 
            // colBirthday
            // 
            colBirthday.Caption = "Birthday";
            colBirthday.FieldName = "Birthday";
            colBirthday.Name = "colBirthday";
            colBirthday.Visible = true;
            colBirthday.VisibleIndex = 4;
            // 
            // ribbonControl
            // 
            ribbonControl.ExpandCollapseItem.Id = 0;
            ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbonControl.ExpandCollapseItem, bbiPrintPreview, bbiNew, bbiEdit, bbiDelete, bbiRefresh, bbiLogOut });
            ribbonControl.Location = new System.Drawing.Point(0, 0);
            ribbonControl.MaxItemId = 21;
            ribbonControl.Name = "ribbonControl";
            ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1 });
            ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            ribbonControl.Size = new System.Drawing.Size(790, 158);
            ribbonControl.StatusBar = ribbonStatusBar;
            ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiPrintPreview
            // 
            bbiPrintPreview.Caption = "Print Preview";
            bbiPrintPreview.Id = 14;
            bbiPrintPreview.ImageOptions.ImageUri.Uri = "Preview";
            bbiPrintPreview.Name = "bbiPrintPreview";
            bbiPrintPreview.ItemClick += bbiPrintPreview_ItemClick;
            // 
            // bbiNew
            // 
            bbiNew.Caption = "New";
            bbiNew.Id = 16;
            bbiNew.ImageOptions.ImageUri.Uri = "New";
            bbiNew.Name = "bbiNew";
            bbiNew.ItemClick += bbiNew_ItemClick;
            // 
            // bbiEdit
            // 
            bbiEdit.Caption = "Edit";
            bbiEdit.Id = 17;
            bbiEdit.ImageOptions.ImageUri.Uri = "Edit";
            bbiEdit.Name = "bbiEdit";
            bbiEdit.ItemClick += bbiEdit_ItemClick;
            // 
            // bbiDelete
            // 
            bbiDelete.Caption = "Delete";
            bbiDelete.Id = 18;
            bbiDelete.ImageOptions.ImageUri.Uri = "Delete";
            bbiDelete.Name = "bbiDelete";
            bbiDelete.ItemClick += bbiDelete_ItemClick;
            // 
            // bbiRefresh
            // 
            bbiRefresh.Caption = "Refresh";
            bbiRefresh.Id = 19;
            bbiRefresh.ImageOptions.ImageUri.Uri = "Refresh";
            bbiRefresh.Name = "bbiRefresh";
            bbiRefresh.ItemClick += bbiRefresh_ItemClick;
            // 
            // bbiLogOut
            // 
            bbiLogOut.Caption = "Log Out";
            bbiLogOut.Id = 20;
            bbiLogOut.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("bbiLogOut.ImageOptions.SvgImage");
            bbiLogOut.Name = "bbiLogOut";
            bbiLogOut.ItemClick += bbiLogOut_ItemClick;
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1, ribbonPageGroup2 });
            ribbonPage1.MergeOrder = 0;
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.AllowTextClipping = false;
            ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            ribbonPageGroup1.ItemLinks.Add(bbiNew);
            ribbonPageGroup1.ItemLinks.Add(bbiEdit);
            ribbonPageGroup1.ItemLinks.Add(bbiDelete);
            ribbonPageGroup1.ItemLinks.Add(bbiRefresh);
            ribbonPageGroup1.ItemLinks.Add(bbiLogOut);
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            ribbonPageGroup1.Text = "Tasks";
            // 
            // ribbonPageGroup2
            // 
            ribbonPageGroup2.AllowTextClipping = false;
            ribbonPageGroup2.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            ribbonPageGroup2.ItemLinks.Add(bbiPrintPreview);
            ribbonPageGroup2.Name = "ribbonPageGroup2";
            ribbonPageGroup2.Text = "Print and Export";
            // 
            // ribbonStatusBar
            // 
            ribbonStatusBar.Location = new System.Drawing.Point(0, 575);
            ribbonStatusBar.Name = "ribbonStatusBar";
            ribbonStatusBar.Ribbon = ribbonControl;
            ribbonStatusBar.Size = new System.Drawing.Size(790, 24);
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(gridControl);
            layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            layoutControl1.Location = new System.Drawing.Point(0, 158);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.Root = Root;
            layoutControl1.Size = new System.Drawing.Size(790, 417);
            layoutControl1.TabIndex = 4;
            layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlGroup1 });
            Root.Name = "Root";
            Root.Size = new System.Drawing.Size(790, 417);
            Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1 });
            layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            layoutControlGroup1.Name = "layoutControlGroup1";
            layoutControlGroup1.Size = new System.Drawing.Size(770, 397);
            layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = gridControl;
            layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new System.Drawing.Size(746, 373);
            layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem1.TextVisible = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(790, 599);
            Controls.Add(layoutControl1);
            Controls.Add(ribbonStatusBar);
            Controls.Add(ribbonControl);
            Name = "MainForm";
            Ribbon = ribbonControl;
            StatusBar = ribbonStatusBar;
            Text = "WinForms UI Client | DevExpress";
            ((System.ComponentModel.ISupportInitialize)gridControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)ribbonControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bbiPrintPreview;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem bbiNew;
        private DevExpress.XtraBars.BarButtonItem bbiEdit;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colEMail;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartment;
        private DevExpress.XtraGrid.Columns.GridColumn colBirthday;
        private DevExpress.XtraBars.BarButtonItem bbiLogOut;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}