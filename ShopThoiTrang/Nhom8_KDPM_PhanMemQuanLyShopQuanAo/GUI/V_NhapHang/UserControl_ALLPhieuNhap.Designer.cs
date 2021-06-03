
namespace GUI.V_NhapHang
{
    partial class UserControl_ALLPhieuNhap
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_ALLPhieuNhap));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridView_deTailsPhieuNhap = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPHIEUNHAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTONGTIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRANGTHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhapHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnXuatBáoCáo = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnHuy = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_deTailsPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXuatBáoCáo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHuy)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView_deTailsPhieuNhap
            // 
            this.gridView_deTailsPhieuNhap.GridControl = this.gridControl1;
            this.gridView_deTailsPhieuNhap.Name = "gridView_deTailsPhieuNhap";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.gridView_deTailsPhieuNhap;
            gridLevelNode1.RelationName = "FK_CTPN_PN";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnXuatBáoCáo,
            this.btnHuy});
            this.gridControl1.Size = new System.Drawing.Size(781, 426);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView_deTailsPhieuNhap});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPHIEUNHAP,
            this.colTONGTIEN,
            this.colTRANGTHAI,
            this.gridColumn1,
            this.colNhapHang});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colMAPHIEUNHAP
            // 
            this.colMAPHIEUNHAP.AppearanceCell.Options.UseTextOptions = true;
            this.colMAPHIEUNHAP.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMAPHIEUNHAP.AppearanceHeader.Options.UseTextOptions = true;
            this.colMAPHIEUNHAP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMAPHIEUNHAP.FieldName = "MAPHIEUNHAP";
            this.colMAPHIEUNHAP.Name = "colMAPHIEUNHAP";
            this.colMAPHIEUNHAP.OptionsColumn.AllowEdit = false;
            this.colMAPHIEUNHAP.OptionsColumn.AllowFocus = false;
            this.colMAPHIEUNHAP.Visible = true;
            this.colMAPHIEUNHAP.VisibleIndex = 0;
            this.colMAPHIEUNHAP.Width = 50;
            // 
            // colTONGTIEN
            // 
            this.colTONGTIEN.AppearanceCell.Options.UseTextOptions = true;
            this.colTONGTIEN.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTONGTIEN.AppearanceHeader.Options.UseTextOptions = true;
            this.colTONGTIEN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTONGTIEN.FieldName = "TONGTIEN";
            this.colTONGTIEN.Name = "colTONGTIEN";
            this.colTONGTIEN.OptionsColumn.AllowEdit = false;
            this.colTONGTIEN.OptionsColumn.AllowFocus = false;
            this.colTONGTIEN.Visible = true;
            this.colTONGTIEN.VisibleIndex = 1;
            this.colTONGTIEN.Width = 227;
            // 
            // colTRANGTHAI
            // 
            this.colTRANGTHAI.AppearanceCell.Options.UseTextOptions = true;
            this.colTRANGTHAI.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTRANGTHAI.AppearanceHeader.Options.UseTextOptions = true;
            this.colTRANGTHAI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTRANGTHAI.FieldName = "TRANGTHAI";
            this.colTRANGTHAI.Name = "colTRANGTHAI";
            this.colTRANGTHAI.OptionsColumn.AllowEdit = false;
            this.colTRANGTHAI.OptionsColumn.AllowFocus = false;
            this.colTRANGTHAI.Visible = true;
            this.colTRANGTHAI.VisibleIndex = 2;
            this.colTRANGTHAI.Width = 227;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Ngày Lập";
            this.gridColumn1.DisplayFormat.FormatString = "d";
            this.gridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn1.FieldName = "NGAYLAP";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            // 
            // colNhapHang
            // 
            this.colNhapHang.AppearanceCell.Options.UseTextOptions = true;
            this.colNhapHang.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNhapHang.AppearanceHeader.Options.UseTextOptions = true;
            this.colNhapHang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNhapHang.Caption = "Xuât Báo cáo";
            this.colNhapHang.ColumnEdit = this.btnXuatBáoCáo;
            this.colNhapHang.Name = "colNhapHang";
            this.colNhapHang.Visible = true;
            this.colNhapHang.VisibleIndex = 4;
            this.colNhapHang.Width = 150;
            // 
            // btnXuatBáoCáo
            // 
            this.btnXuatBáoCáo.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnXuatBáoCáo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnXuatBáoCáo.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatBáoCáo.ContextImageOptions.Image")));
            this.btnXuatBáoCáo.Name = "btnXuatBáoCáo";
            this.btnXuatBáoCáo.ReadOnly = true;
            this.btnXuatBáoCáo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnXuatBáoCáo.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnXuatBáoCáo_ButtonClick);
            // 
            // btnHuy
            // 
            this.btnHuy.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.btnHuy.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // UserControl_ALLPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "UserControl_ALLPhieuNhap";
            this.Size = new System.Drawing.Size(781, 426);
            this.Load += new System.EventHandler(this.UserControl_ALLPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView_deTailsPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXuatBáoCáo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHuy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_deTailsPhieuNhap;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPHIEUNHAP;
        private DevExpress.XtraGrid.Columns.GridColumn colTONGTIEN;
        private DevExpress.XtraGrid.Columns.GridColumn colTRANGTHAI;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colNhapHang;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnXuatBáoCáo;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnHuy;
    }
}
