
namespace GUI
{
    partial class FormHoaDon
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSHOPDataSet = new GUI.QLSHOPDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIABAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENKHACHHANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTHANHTIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENSANPHAM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYTAO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENNHANVIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dataTable1TableAdapter = new GUI.QLSHOPDataSetTableAdapters.DataTable1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSHOPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.dataTable1BindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1067, 554);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.qLSHOPDataSet;
            // 
            // qLSHOPDataSet
            // 
            this.qLSHOPDataSet.DataSetName = "QLSHOPDataSet";
            this.qLSHOPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSOLUONG,
            this.colDONGIABAN,
            this.colTENKHACHHANG,
            this.colTHANHTIEN,
            this.colTENSANPHAM,
            this.colNGAYTAO,
            this.colTENNHANVIEN,
            this.colSDT});
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(642, 299, 341, 281);
            this.gridView1.DetailHeight = 431;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTENKHACHHANG, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colSOLUONG
            // 
            this.colSOLUONG.FieldName = "SOLUONG";
            this.colSOLUONG.MinWidth = 27;
            this.colSOLUONG.Name = "colSOLUONG";
            this.colSOLUONG.Visible = true;
            this.colSOLUONG.VisibleIndex = 2;
            this.colSOLUONG.Width = 100;
            // 
            // colDONGIABAN
            // 
            this.colDONGIABAN.FieldName = "DONGIABAN";
            this.colDONGIABAN.MinWidth = 27;
            this.colDONGIABAN.Name = "colDONGIABAN";
            this.colDONGIABAN.Visible = true;
            this.colDONGIABAN.VisibleIndex = 1;
            this.colDONGIABAN.Width = 100;
            // 
            // colTENKHACHHANG
            // 
            this.colTENKHACHHANG.FieldName = "TENKHACHHANG";
            this.colTENKHACHHANG.MinWidth = 27;
            this.colTENKHACHHANG.Name = "colTENKHACHHANG";
            this.colTENKHACHHANG.Visible = true;
            this.colTENKHACHHANG.VisibleIndex = 2;
            this.colTENKHACHHANG.Width = 100;
            // 
            // colTHANHTIEN
            // 
            this.colTHANHTIEN.FieldName = "THANHTIEN";
            this.colTHANHTIEN.MinWidth = 27;
            this.colTHANHTIEN.Name = "colTHANHTIEN";
            this.colTHANHTIEN.Visible = true;
            this.colTHANHTIEN.VisibleIndex = 3;
            this.colTHANHTIEN.Width = 100;
            // 
            // colTENSANPHAM
            // 
            this.colTENSANPHAM.FieldName = "TENSANPHAM";
            this.colTENSANPHAM.MinWidth = 27;
            this.colTENSANPHAM.Name = "colTENSANPHAM";
            this.colTENSANPHAM.Visible = true;
            this.colTENSANPHAM.VisibleIndex = 0;
            this.colTENSANPHAM.Width = 100;
            // 
            // colNGAYTAO
            // 
            this.colNGAYTAO.FieldName = "NGAYTAO";
            this.colNGAYTAO.MinWidth = 27;
            this.colNGAYTAO.Name = "colNGAYTAO";
            this.colNGAYTAO.Visible = true;
            this.colNGAYTAO.VisibleIndex = 4;
            this.colNGAYTAO.Width = 100;
            // 
            // colTENNHANVIEN
            // 
            this.colTENNHANVIEN.FieldName = "TENNHANVIEN";
            this.colTENNHANVIEN.MinWidth = 27;
            this.colTENNHANVIEN.Name = "colTENNHANVIEN";
            this.colTENNHANVIEN.Visible = true;
            this.colTENNHANVIEN.VisibleIndex = 5;
            this.colTENNHANVIEN.Width = 100;
            // 
            // colSDT
            // 
            this.colSDT.FieldName = "SDT";
            this.colSDT.MinWidth = 27;
            this.colSDT.Name = "colSDT";
            this.colSDT.Visible = true;
            this.colSDT.VisibleIndex = 6;
            this.colSDT.Width = 100;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.gridControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormHoaDon";
            this.Text = "FormHoaDon";
            this.Load += new System.EventHandler(this.FormHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSHOPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private QLSHOPDataSet qLSHOPDataSet;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private QLSHOPDataSetTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIABAN;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKHACHHANG;
        private DevExpress.XtraGrid.Columns.GridColumn colTHANHTIEN;
        private DevExpress.XtraGrid.Columns.GridColumn colTENSANPHAM;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYTAO;
        private DevExpress.XtraGrid.Columns.GridColumn colTENNHANVIEN;
        private DevExpress.XtraGrid.Columns.GridColumn colSDT;
    }
}