
namespace GUI
{
    partial class FormBillsSold
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.viewHoaDonBindingSource1 = new System.Windows.Forms.BindingSource();
            this.qLSHOPDataSet = new GUI.QLSHOPDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAHOADON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYTAO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTHANHTIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENKHACHHANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENNHANVIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.viewHoaDonBindingSource = new System.Windows.Forms.BindingSource();
            this.view_HoaDonTableAdapter = new GUI.QLSHOPDataSetTableAdapters.View_HoaDonTableAdapter();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewHoaDonBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSHOPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewHoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.simpleButton2);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(924, 297, 975, 600);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(664, 582);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.viewHoaDonBindingSource1;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.gridControl1.Location = new System.Drawing.Point(14, 14);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.gridControl1.Size = new System.Drawing.Size(636, 523);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // viewHoaDonBindingSource1
            // 
            this.viewHoaDonBindingSource1.DataMember = "View_HoaDon";
            this.viewHoaDonBindingSource1.DataSource = this.qLSHOPDataSet;
            // 
            // qLSHOPDataSet
            // 
            this.qLSHOPDataSet.DataSetName = "QLSHOPDataSet";
            this.qLSHOPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAHOADON,
            this.colNGAYTAO,
            this.colTHANHTIEN,
            this.colTENKHACHHANG,
            this.colTENNHANVIEN});
            this.gridView1.DetailHeight = 294;
            this.gridView1.FixedLineWidth = 1;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colMAHOADON
            // 
            this.colMAHOADON.FieldName = "MAHOADON";
            this.colMAHOADON.MinWidth = 23;
            this.colMAHOADON.Name = "colMAHOADON";
            this.colMAHOADON.OptionsColumn.AllowEdit = false;
            this.colMAHOADON.OptionsColumn.ReadOnly = true;
            this.colMAHOADON.Visible = true;
            this.colMAHOADON.VisibleIndex = 0;
            this.colMAHOADON.Width = 87;
            // 
            // colNGAYTAO
            // 
            this.colNGAYTAO.FieldName = "NGAYTAO";
            this.colNGAYTAO.MinWidth = 23;
            this.colNGAYTAO.Name = "colNGAYTAO";
            this.colNGAYTAO.OptionsColumn.AllowEdit = false;
            this.colNGAYTAO.OptionsColumn.ReadOnly = true;
            this.colNGAYTAO.Visible = true;
            this.colNGAYTAO.VisibleIndex = 1;
            this.colNGAYTAO.Width = 87;
            // 
            // colTHANHTIEN
            // 
            this.colTHANHTIEN.FieldName = "THANHTIEN";
            this.colTHANHTIEN.MinWidth = 23;
            this.colTHANHTIEN.Name = "colTHANHTIEN";
            this.colTHANHTIEN.OptionsColumn.AllowEdit = false;
            this.colTHANHTIEN.OptionsColumn.ReadOnly = true;
            this.colTHANHTIEN.Visible = true;
            this.colTHANHTIEN.VisibleIndex = 2;
            this.colTHANHTIEN.Width = 87;
            // 
            // colTENKHACHHANG
            // 
            this.colTENKHACHHANG.FieldName = "TENKHACHHANG";
            this.colTENKHACHHANG.MinWidth = 23;
            this.colTENKHACHHANG.Name = "colTENKHACHHANG";
            this.colTENKHACHHANG.OptionsColumn.AllowEdit = false;
            this.colTENKHACHHANG.OptionsColumn.ReadOnly = true;
            this.colTENKHACHHANG.Visible = true;
            this.colTENKHACHHANG.VisibleIndex = 3;
            this.colTENKHACHHANG.Width = 87;
            // 
            // colTENNHANVIEN
            // 
            this.colTENNHANVIEN.FieldName = "TENNHANVIEN";
            this.colTENNHANVIEN.MinWidth = 23;
            this.colTENNHANVIEN.Name = "colTENNHANVIEN";
            this.colTENNHANVIEN.OptionsColumn.AllowEdit = false;
            this.colTENNHANVIEN.OptionsColumn.ReadOnly = true;
            this.colTENNHANVIEN.Visible = true;
            this.colTENNHANVIEN.VisibleIndex = 4;
            this.colTENNHANVIEN.Width = 87;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(9, 545);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(645, 27);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "simpleButton1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(664, 582);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(640, 527);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // gridColumn4
            // 
            this.gridColumn4.MinWidth = 30;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Width = 112;
            // 
            // viewHoaDonBindingSource
            // 
            this.viewHoaDonBindingSource.DataMember = "View_HoaDon";
            this.viewHoaDonBindingSource.DataSource = this.qLSHOPDataSet;
            // 
            // view_HoaDonTableAdapter
            // 
            this.view_HoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Width = 50;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(14, 541);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(636, 27);
            this.simpleButton2.StyleController = this.layoutControl1;
            this.simpleButton2.TabIndex = 7;
            this.simpleButton2.Text = "Xuất Report";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.simpleButton2;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 527);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(640, 31);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // FormBillsSold
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormBillsSold";
            this.Size = new System.Drawing.Size(664, 582);
            this.Load += new System.EventHandler(this.FormBillsSold_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewHoaDonBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSHOPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewHoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAHOADON;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYTAO;
        private DevExpress.XtraGrid.Columns.GridColumn colTHANHTIEN;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKHACHHANG;
        private DevExpress.XtraGrid.Columns.GridColumn colTENNHANVIEN;
        private System.Windows.Forms.BindingSource viewHoaDonBindingSource;
        private QLSHOPDataSet qLSHOPDataSet;
        private QLSHOPDataSetTableAdapters.View_HoaDonTableAdapter view_HoaDonTableAdapter;
        private System.Windows.Forms.BindingSource viewHoaDonBindingSource1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}
