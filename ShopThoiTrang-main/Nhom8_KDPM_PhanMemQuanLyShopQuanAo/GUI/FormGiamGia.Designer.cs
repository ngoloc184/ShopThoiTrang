
namespace GUI
{
    partial class FormGiamGia
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
            this.gcGiamGia = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MAGIAMGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENGIAMGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MOTA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GIATRITOIDA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DONHANGTU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYBD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYKT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColuMUCGIAMGIAmn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaGG = new System.Windows.Forms.TextBox();
            this.txtTenGG = new System.Windows.Forms.TextBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtGiaTri = new System.Windows.Forms.TextBox();
            this.txtYeuCau = new System.Windows.Forms.TextBox();
            this.txtMucGG = new System.Windows.Forms.TextBox();
            this.dtpNgayBD = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayKT = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gcGiamGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcGiamGia
            // 
            this.gcGiamGia.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcGiamGia.Location = new System.Drawing.Point(13, 38);
            this.gcGiamGia.MainView = this.gridView1;
            this.gcGiamGia.Margin = new System.Windows.Forms.Padding(4);
            this.gcGiamGia.Name = "gcGiamGia";
            this.gcGiamGia.Size = new System.Drawing.Size(1182, 399);
            this.gcGiamGia.TabIndex = 0;
            this.gcGiamGia.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcGiamGia.Click += new System.EventHandler(this.gcGiamGia_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MAGIAMGIA,
            this.TENGIAMGIA,
            this.MOTA,
            this.GIATRITOIDA,
            this.DONHANGTU,
            this.NGAYBD,
            this.NGAYKT,
            this.gridColuMUCGIAMGIAmn8});
            this.gridView1.DetailHeight = 437;
            this.gridView1.GridControl = this.gcGiamGia;
            this.gridView1.Name = "gridView1";
            // 
            // MAGIAMGIA
            // 
            this.MAGIAMGIA.Caption = "Mã giảm giá";
            this.MAGIAMGIA.FieldName = "MAGIAMGIA";
            this.MAGIAMGIA.MinWidth = 25;
            this.MAGIAMGIA.Name = "MAGIAMGIA";
            this.MAGIAMGIA.OptionsColumn.AllowEdit = false;
            this.MAGIAMGIA.OptionsColumn.AllowFocus = false;
            this.MAGIAMGIA.OptionsColumn.ReadOnly = true;
            this.MAGIAMGIA.Visible = true;
            this.MAGIAMGIA.VisibleIndex = 0;
            this.MAGIAMGIA.Width = 94;
            // 
            // TENGIAMGIA
            // 
            this.TENGIAMGIA.Caption = "Tên giảm giá";
            this.TENGIAMGIA.FieldName = "TENGIAMGIA";
            this.TENGIAMGIA.MinWidth = 25;
            this.TENGIAMGIA.Name = "TENGIAMGIA";
            this.TENGIAMGIA.OptionsColumn.AllowEdit = false;
            this.TENGIAMGIA.OptionsColumn.AllowFocus = false;
            this.TENGIAMGIA.OptionsColumn.ReadOnly = true;
            this.TENGIAMGIA.Visible = true;
            this.TENGIAMGIA.VisibleIndex = 1;
            this.TENGIAMGIA.Width = 94;
            // 
            // MOTA
            // 
            this.MOTA.Caption = "Mô tả";
            this.MOTA.FieldName = "MOTA";
            this.MOTA.MinWidth = 25;
            this.MOTA.Name = "MOTA";
            this.MOTA.OptionsColumn.AllowEdit = false;
            this.MOTA.OptionsColumn.AllowFocus = false;
            this.MOTA.OptionsColumn.ReadOnly = true;
            this.MOTA.Visible = true;
            this.MOTA.VisibleIndex = 2;
            this.MOTA.Width = 94;
            // 
            // GIATRITOIDA
            // 
            this.GIATRITOIDA.Caption = "Giá trị tối đa";
            this.GIATRITOIDA.FieldName = "GIATRITOIDA";
            this.GIATRITOIDA.MinWidth = 25;
            this.GIATRITOIDA.Name = "GIATRITOIDA";
            this.GIATRITOIDA.OptionsColumn.AllowEdit = false;
            this.GIATRITOIDA.OptionsColumn.AllowFocus = false;
            this.GIATRITOIDA.OptionsColumn.ReadOnly = true;
            this.GIATRITOIDA.Visible = true;
            this.GIATRITOIDA.VisibleIndex = 3;
            this.GIATRITOIDA.Width = 94;
            // 
            // DONHANGTU
            // 
            this.DONHANGTU.Caption = "Yêu cầu đơn hàng";
            this.DONHANGTU.FieldName = "DONHANGTU";
            this.DONHANGTU.MinWidth = 25;
            this.DONHANGTU.Name = "DONHANGTU";
            this.DONHANGTU.OptionsColumn.AllowEdit = false;
            this.DONHANGTU.OptionsColumn.AllowFocus = false;
            this.DONHANGTU.OptionsColumn.ReadOnly = true;
            this.DONHANGTU.Visible = true;
            this.DONHANGTU.VisibleIndex = 4;
            this.DONHANGTU.Width = 94;
            // 
            // NGAYBD
            // 
            this.NGAYBD.Caption = "Ngày bắt đầu";
            this.NGAYBD.FieldName = "NGAYBD";
            this.NGAYBD.MinWidth = 25;
            this.NGAYBD.Name = "NGAYBD";
            this.NGAYBD.OptionsColumn.AllowEdit = false;
            this.NGAYBD.OptionsColumn.AllowFocus = false;
            this.NGAYBD.OptionsColumn.ReadOnly = true;
            this.NGAYBD.Visible = true;
            this.NGAYBD.VisibleIndex = 5;
            this.NGAYBD.Width = 94;
            // 
            // NGAYKT
            // 
            this.NGAYKT.Caption = "Ngày kết thúc";
            this.NGAYKT.FieldName = "NGAYKT";
            this.NGAYKT.MinWidth = 25;
            this.NGAYKT.Name = "NGAYKT";
            this.NGAYKT.OptionsColumn.AllowEdit = false;
            this.NGAYKT.OptionsColumn.AllowFocus = false;
            this.NGAYKT.OptionsColumn.ReadOnly = true;
            this.NGAYKT.Visible = true;
            this.NGAYKT.VisibleIndex = 6;
            this.NGAYKT.Width = 94;
            // 
            // gridColuMUCGIAMGIAmn8
            // 
            this.gridColuMUCGIAMGIAmn8.Caption = "Mức giảm giá";
            this.gridColuMUCGIAMGIAmn8.FieldName = "MUCGIAMGIA";
            this.gridColuMUCGIAMGIAmn8.MinWidth = 25;
            this.gridColuMUCGIAMGIAmn8.Name = "gridColuMUCGIAMGIAmn8";
            this.gridColuMUCGIAMGIAmn8.OptionsColumn.AllowEdit = false;
            this.gridColuMUCGIAMGIAmn8.OptionsColumn.AllowFocus = false;
            this.gridColuMUCGIAMGIAmn8.OptionsColumn.ReadOnly = true;
            this.gridColuMUCGIAMGIAmn8.Visible = true;
            this.gridColuMUCGIAMGIAmn8.VisibleIndex = 7;
            this.gridColuMUCGIAMGIAmn8.Width = 94;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 464);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã giảm giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 508);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên giảm giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 552);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mô tả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 596);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giá trị tối đa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(492, 464);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Yêu cầu đơn hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(492, 508);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mức giảm giá";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(493, 552);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Ngày bắt đầu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(493, 597);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 24);
            this.label8.TabIndex = 8;
            this.label8.Text = "Ngày kết thúc";
            // 
            // txtMaGG
            // 
            this.txtMaGG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaGG.Location = new System.Drawing.Point(136, 461);
            this.txtMaGG.Name = "txtMaGG";
            this.txtMaGG.Size = new System.Drawing.Size(324, 28);
            this.txtMaGG.TabIndex = 9;
            // 
            // txtTenGG
            // 
            this.txtTenGG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenGG.Location = new System.Drawing.Point(136, 505);
            this.txtTenGG.Name = "txtTenGG";
            this.txtTenGG.Size = new System.Drawing.Size(324, 28);
            this.txtTenGG.TabIndex = 10;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoTa.Location = new System.Drawing.Point(136, 549);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(324, 28);
            this.txtMoTa.TabIndex = 11;
            // 
            // txtGiaTri
            // 
            this.txtGiaTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaTri.Location = new System.Drawing.Point(136, 593);
            this.txtGiaTri.Name = "txtGiaTri";
            this.txtGiaTri.Size = new System.Drawing.Size(324, 28);
            this.txtGiaTri.TabIndex = 12;
            // 
            // txtYeuCau
            // 
            this.txtYeuCau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYeuCau.Location = new System.Drawing.Point(665, 461);
            this.txtYeuCau.Name = "txtYeuCau";
            this.txtYeuCau.Size = new System.Drawing.Size(313, 28);
            this.txtYeuCau.TabIndex = 13;
            // 
            // txtMucGG
            // 
            this.txtMucGG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMucGG.Location = new System.Drawing.Point(665, 505);
            this.txtMucGG.Name = "txtMucGG";
            this.txtMucGG.Size = new System.Drawing.Size(313, 28);
            this.txtMucGG.TabIndex = 14;
            // 
            // dtpNgayBD
            // 
            this.dtpNgayBD.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBD.Location = new System.Drawing.Point(665, 547);
            this.dtpNgayBD.Name = "dtpNgayBD";
            this.dtpNgayBD.Size = new System.Drawing.Size(313, 28);
            this.dtpNgayBD.TabIndex = 15;
            this.dtpNgayBD.Value = new System.DateTime(2021, 5, 24, 0, 0, 0, 0);
            // 
            // dtpNgayKT
            // 
            this.dtpNgayKT.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKT.Location = new System.Drawing.Point(665, 592);
            this.dtpNgayKT.Name = "dtpNgayKT";
            this.dtpNgayKT.Size = new System.Drawing.Size(313, 28);
            this.dtpNgayKT.TabIndex = 16;
            this.dtpNgayKT.Value = new System.DateTime(2021, 5, 24, 0, 0, 0, 0);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1008, 444);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 43);
            this.button2.TabIndex = 18;
            this.button2.Text = "Tạo mới";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(1008, 493);
            this.btnThem.Name = "btnThem";
            this.btnThem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnThem.Size = new System.Drawing.Size(187, 43);
            this.btnThem.TabIndex = 19;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(1009, 542);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(187, 43);
            this.btnSua.TabIndex = 20;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLai.Location = new System.Drawing.Point(1008, 591);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(187, 43);
            this.btnQuayLai.TabIndex = 21;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            // 
            // FormGiamGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 692);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dtpNgayKT);
            this.Controls.Add(this.dtpNgayBD);
            this.Controls.Add(this.txtMucGG);
            this.Controls.Add(this.txtYeuCau);
            this.Controls.Add(this.txtGiaTri);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.txtTenGG);
            this.Controls.Add(this.txtMaGG);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gcGiamGia);
            this.Name = "FormGiamGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGiamGia";
            this.Load += new System.EventHandler(this.FormGiamGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcGiamGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcGiamGia;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MAGIAMGIA;
        private DevExpress.XtraGrid.Columns.GridColumn TENGIAMGIA;
        private DevExpress.XtraGrid.Columns.GridColumn MOTA;
        private DevExpress.XtraGrid.Columns.GridColumn GIATRITOIDA;
        private DevExpress.XtraGrid.Columns.GridColumn DONHANGTU;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYBD;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYKT;
        private DevExpress.XtraGrid.Columns.GridColumn gridColuMUCGIAMGIAmn8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaGG;
        private System.Windows.Forms.TextBox txtTenGG;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtGiaTri;
        private System.Windows.Forms.TextBox txtYeuCau;
        private System.Windows.Forms.TextBox txtMucGG;
        private System.Windows.Forms.DateTimePicker dtpNgayBD;
        private System.Windows.Forms.DateTimePicker dtpNgayKT;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnQuayLai;
    }
}