
namespace GUI
{
    partial class UserControl_NhapHang
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaSPP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryMaSP = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoaiSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenSPP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSIZE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COLSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTHanhTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryMaSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            gridLevelNode2.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this.gridControl1.Location = new System.Drawing.Point(0, 49);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryMaSP});
            this.gridControl1.Size = new System.Drawing.Size(848, 470);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaSPP,
            this.colTenSPP,
            this.colSIZE,
            this.colMAU,
            this.colDONGIA,
            this.COLSOLUONG,
            this.colTHanhTien});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click);
            // 
            // colMaSPP
            // 
            this.colMaSPP.AppearanceCell.Options.UseTextOptions = true;
            this.colMaSPP.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaSPP.Caption = "Mã Sản Phẩm";
            this.colMaSPP.ColumnEdit = this.repositoryMaSP;
            this.colMaSPP.FieldName = "MASANPHAM";
            this.colMaSPP.Name = "colMaSPP";
            this.colMaSPP.Visible = true;
            this.colMaSPP.VisibleIndex = 0;
            // 
            // repositoryMaSP
            // 
            this.repositoryMaSP.AutoHeight = false;
            this.repositoryMaSP.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryMaSP.Name = "repositoryMaSP";
            this.repositoryMaSP.PopupView = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaSP,
            this.colTenSP,
            this.colLoaiSP});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colMaSP
            // 
            this.colMaSP.Caption = "Mã Sản Phẩm";
            this.colMaSP.FieldName = "MASANPHAM";
            this.colMaSP.Name = "colMaSP";
            this.colMaSP.Visible = true;
            this.colMaSP.VisibleIndex = 0;
            // 
            // colTenSP
            // 
            this.colTenSP.Caption = "Tên Sản Phẩm";
            this.colTenSP.FieldName = "TENSANPHAM";
            this.colTenSP.Name = "colTenSP";
            this.colTenSP.Visible = true;
            this.colTenSP.VisibleIndex = 1;
            // 
            // colLoaiSP
            // 
            this.colLoaiSP.Caption = "Loại Sản Phẩm";
            this.colLoaiSP.FieldName = "TENLOAISANPHAM";
            this.colLoaiSP.Name = "colLoaiSP";
            this.colLoaiSP.Visible = true;
            this.colLoaiSP.VisibleIndex = 2;
            // 
            // colTenSPP
            // 
            this.colTenSPP.AppearanceCell.Options.UseTextOptions = true;
            this.colTenSPP.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenSPP.Caption = "Tên Sản Phẩm";
            this.colTenSPP.FieldName = "TENSANPHAM";
            this.colTenSPP.Name = "colTenSPP";
            this.colTenSPP.OptionsColumn.AllowEdit = false;
            this.colTenSPP.OptionsColumn.AllowFocus = false;
            this.colTenSPP.Visible = true;
            this.colTenSPP.VisibleIndex = 1;
            // 
            // colSIZE
            // 
            this.colSIZE.AppearanceCell.Options.UseTextOptions = true;
            this.colSIZE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSIZE.Caption = "Size";
            this.colSIZE.FieldName = "SIZE";
            this.colSIZE.Name = "colSIZE";
            this.colSIZE.Visible = true;
            this.colSIZE.VisibleIndex = 2;
            // 
            // colMAU
            // 
            this.colMAU.AppearanceCell.Options.UseTextOptions = true;
            this.colMAU.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMAU.Caption = "Màu";
            this.colMAU.FieldName = "MAU";
            this.colMAU.Name = "colMAU";
            this.colMAU.Visible = true;
            this.colMAU.VisibleIndex = 3;
            // 
            // colDONGIA
            // 
            this.colDONGIA.AppearanceCell.Options.UseTextOptions = true;
            this.colDONGIA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDONGIA.Caption = "Đơn Giá";
            this.colDONGIA.FieldName = "DONGIA";
            this.colDONGIA.Name = "colDONGIA";
            this.colDONGIA.OptionsColumn.AllowEdit = false;
            this.colDONGIA.OptionsColumn.AllowFocus = false;
            this.colDONGIA.Visible = true;
            this.colDONGIA.VisibleIndex = 4;
            // 
            // COLSOLUONG
            // 
            this.COLSOLUONG.AppearanceCell.Options.UseTextOptions = true;
            this.COLSOLUONG.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.COLSOLUONG.Caption = "Số Lượng";
            this.COLSOLUONG.FieldName = "SOLUONG";
            this.COLSOLUONG.Name = "COLSOLUONG";
            this.COLSOLUONG.Visible = true;
            this.COLSOLUONG.VisibleIndex = 5;
            // 
            // colTHanhTien
            // 
            this.colTHanhTien.AppearanceCell.Options.UseTextOptions = true;
            this.colTHanhTien.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTHanhTien.Caption = "Thành Tiền";
            this.colTHanhTien.FieldName = "THANHTIEN";
            this.colTHanhTien.Name = "colTHanhTien";
            this.colTHanhTien.Visible = true;
            this.colTHanhTien.VisibleIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 1;
            // 
            // UserControl_NhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gridControl1);
            this.Name = "UserControl_NhapHang";
            this.Size = new System.Drawing.Size(848, 519);
            this.Load += new System.EventHandler(this.UserControl_NhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryMaSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaSPP;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryMaSP;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colMaSP;
        private DevExpress.XtraGrid.Columns.GridColumn colTenSP;
        private DevExpress.XtraGrid.Columns.GridColumn colLoaiSP;
        private DevExpress.XtraGrid.Columns.GridColumn colTenSPP;
        private DevExpress.XtraGrid.Columns.GridColumn colSIZE;
        private DevExpress.XtraGrid.Columns.GridColumn colMAU;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private DevExpress.XtraGrid.Columns.GridColumn COLSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colTHanhTien;
        private System.Windows.Forms.TextBox textBox1;
    }
}
