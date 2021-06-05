
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGiamGia));
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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnTaoMoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnQuayLai = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.gcGiamGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcGiamGia
            // 
            this.gcGiamGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcGiamGia.Location = new System.Drawing.Point(0, 0);
            this.gcGiamGia.MainView = this.gridView1;
            this.gcGiamGia.Name = "gcGiamGia";
            this.gcGiamGia.ShowOnlyPredefinedDetails = true;
            this.gcGiamGia.Size = new System.Drawing.Size(838, 227);
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
            this.gridView1.DetailHeight = 355;
            this.gridView1.GridControl = this.gcGiamGia;
            this.gridView1.Name = "gridView1";
            // 
            // MAGIAMGIA
            // 
            this.MAGIAMGIA.Caption = "Mã giảm giá";
            this.MAGIAMGIA.FieldName = "MAGIAMGIA";
            this.MAGIAMGIA.MinWidth = 19;
            this.MAGIAMGIA.Name = "MAGIAMGIA";
            this.MAGIAMGIA.OptionsColumn.AllowEdit = false;
            this.MAGIAMGIA.OptionsColumn.AllowFocus = false;
            this.MAGIAMGIA.OptionsColumn.ReadOnly = true;
            this.MAGIAMGIA.Visible = true;
            this.MAGIAMGIA.VisibleIndex = 0;
            this.MAGIAMGIA.Width = 70;
            // 
            // TENGIAMGIA
            // 
            this.TENGIAMGIA.Caption = "Tên giảm giá";
            this.TENGIAMGIA.FieldName = "TENGIAMGIA";
            this.TENGIAMGIA.MinWidth = 19;
            this.TENGIAMGIA.Name = "TENGIAMGIA";
            this.TENGIAMGIA.OptionsColumn.AllowEdit = false;
            this.TENGIAMGIA.OptionsColumn.AllowFocus = false;
            this.TENGIAMGIA.OptionsColumn.ReadOnly = true;
            this.TENGIAMGIA.Visible = true;
            this.TENGIAMGIA.VisibleIndex = 1;
            this.TENGIAMGIA.Width = 70;
            // 
            // MOTA
            // 
            this.MOTA.Caption = "Mô tả";
            this.MOTA.FieldName = "MOTA";
            this.MOTA.MinWidth = 19;
            this.MOTA.Name = "MOTA";
            this.MOTA.OptionsColumn.AllowEdit = false;
            this.MOTA.OptionsColumn.AllowFocus = false;
            this.MOTA.OptionsColumn.ReadOnly = true;
            this.MOTA.Visible = true;
            this.MOTA.VisibleIndex = 2;
            this.MOTA.Width = 70;
            // 
            // GIATRITOIDA
            // 
            this.GIATRITOIDA.Caption = "Giá trị tối đa";
            this.GIATRITOIDA.FieldName = "GIATRITOIDA";
            this.GIATRITOIDA.MinWidth = 19;
            this.GIATRITOIDA.Name = "GIATRITOIDA";
            this.GIATRITOIDA.OptionsColumn.AllowEdit = false;
            this.GIATRITOIDA.OptionsColumn.AllowFocus = false;
            this.GIATRITOIDA.OptionsColumn.ReadOnly = true;
            this.GIATRITOIDA.Visible = true;
            this.GIATRITOIDA.VisibleIndex = 3;
            this.GIATRITOIDA.Width = 70;
            // 
            // DONHANGTU
            // 
            this.DONHANGTU.Caption = "Yêu cầu đơn hàng";
            this.DONHANGTU.FieldName = "DONHANGTU";
            this.DONHANGTU.MinWidth = 19;
            this.DONHANGTU.Name = "DONHANGTU";
            this.DONHANGTU.OptionsColumn.AllowEdit = false;
            this.DONHANGTU.OptionsColumn.AllowFocus = false;
            this.DONHANGTU.OptionsColumn.ReadOnly = true;
            this.DONHANGTU.Visible = true;
            this.DONHANGTU.VisibleIndex = 4;
            this.DONHANGTU.Width = 70;
            // 
            // NGAYBD
            // 
            this.NGAYBD.Caption = "Ngày bắt đầu";
            this.NGAYBD.FieldName = "NGAYBD";
            this.NGAYBD.MinWidth = 19;
            this.NGAYBD.Name = "NGAYBD";
            this.NGAYBD.OptionsColumn.AllowEdit = false;
            this.NGAYBD.OptionsColumn.AllowFocus = false;
            this.NGAYBD.OptionsColumn.ReadOnly = true;
            this.NGAYBD.Visible = true;
            this.NGAYBD.VisibleIndex = 5;
            this.NGAYBD.Width = 70;
            // 
            // NGAYKT
            // 
            this.NGAYKT.Caption = "Ngày kết thúc";
            this.NGAYKT.FieldName = "NGAYKT";
            this.NGAYKT.MinWidth = 19;
            this.NGAYKT.Name = "NGAYKT";
            this.NGAYKT.OptionsColumn.AllowEdit = false;
            this.NGAYKT.OptionsColumn.AllowFocus = false;
            this.NGAYKT.OptionsColumn.ReadOnly = true;
            this.NGAYKT.Visible = true;
            this.NGAYKT.VisibleIndex = 6;
            this.NGAYKT.Width = 70;
            // 
            // gridColuMUCGIAMGIAmn8
            // 
            this.gridColuMUCGIAMGIAmn8.Caption = "Mức giảm giá";
            this.gridColuMUCGIAMGIAmn8.FieldName = "MUCGIAMGIA";
            this.gridColuMUCGIAMGIAmn8.MinWidth = 19;
            this.gridColuMUCGIAMGIAmn8.Name = "gridColuMUCGIAMGIAmn8";
            this.gridColuMUCGIAMGIAmn8.OptionsColumn.AllowEdit = false;
            this.gridColuMUCGIAMGIAmn8.OptionsColumn.AllowFocus = false;
            this.gridColuMUCGIAMGIAmn8.OptionsColumn.ReadOnly = true;
            this.gridColuMUCGIAMGIAmn8.Visible = true;
            this.gridColuMUCGIAMGIAmn8.VisibleIndex = 7;
            this.gridColuMUCGIAMGIAmn8.Width = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã giảm giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên giảm giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mô tả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giá trị tối đa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(420, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "Yêu cầu đơn hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(420, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 28);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mức giảm giá";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(420, 56);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 28);
            this.label7.TabIndex = 7;
            this.label7.Text = "Ngày bắt đầu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(420, 84);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 28);
            this.label8.TabIndex = 8;
            this.label8.Text = "Ngày kết thúc";
            // 
            // txtMaGG
            // 
            this.txtMaGG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaGG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaGG.Location = new System.Drawing.Point(127, 2);
            this.txtMaGG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaGG.Name = "txtMaGG";
            this.txtMaGG.Size = new System.Drawing.Size(289, 24);
            this.txtMaGG.TabIndex = 9;
            // 
            // txtTenGG
            // 
            this.txtTenGG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenGG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenGG.Location = new System.Drawing.Point(127, 30);
            this.txtTenGG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenGG.Name = "txtTenGG";
            this.txtTenGG.Size = new System.Drawing.Size(289, 24);
            this.txtTenGG.TabIndex = 10;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoTa.Location = new System.Drawing.Point(127, 58);
            this.txtMoTa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(289, 24);
            this.txtMoTa.TabIndex = 11;
            // 
            // txtGiaTri
            // 
            this.txtGiaTri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGiaTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaTri.Location = new System.Drawing.Point(127, 86);
            this.txtGiaTri.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGiaTri.Name = "txtGiaTri";
            this.txtGiaTri.Size = new System.Drawing.Size(289, 24);
            this.txtGiaTri.TabIndex = 12;
            this.txtGiaTri.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaTri_KeyPress);
            // 
            // txtYeuCau
            // 
            this.txtYeuCau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtYeuCau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYeuCau.Location = new System.Drawing.Point(545, 2);
            this.txtYeuCau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtYeuCau.Name = "txtYeuCau";
            this.txtYeuCau.Size = new System.Drawing.Size(291, 24);
            this.txtYeuCau.TabIndex = 13;
            this.txtYeuCau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYeuCau_KeyPress);
            // 
            // txtMucGG
            // 
            this.txtMucGG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMucGG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMucGG.Location = new System.Drawing.Point(545, 30);
            this.txtMucGG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMucGG.Name = "txtMucGG";
            this.txtMucGG.Size = new System.Drawing.Size(291, 24);
            this.txtMucGG.TabIndex = 14;
            this.txtMucGG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMucGG_KeyPress);
            // 
            // dtpNgayBD
            // 
            this.dtpNgayBD.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpNgayBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBD.Location = new System.Drawing.Point(545, 58);
            this.dtpNgayBD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpNgayBD.Name = "dtpNgayBD";
            this.dtpNgayBD.Size = new System.Drawing.Size(291, 24);
            this.dtpNgayBD.TabIndex = 15;
            this.dtpNgayBD.Value = new System.DateTime(2021, 5, 24, 0, 0, 0, 0);
            // 
            // dtpNgayKT
            // 
            this.dtpNgayKT.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpNgayKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKT.Location = new System.Drawing.Point(545, 86);
            this.dtpNgayKT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpNgayKT.Name = "dtpNgayKT";
            this.dtpNgayKT.Size = new System.Drawing.Size(291, 24);
            this.dtpNgayKT.TabIndex = 16;
            this.dtpNgayKT.Value = new System.DateTime(2021, 5, 24, 0, 0, 0, 0);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnTaoMoi,
            this.btnThem,
            this.btnSua,
            this.btnQuayLai});
            this.barManager1.MaxItemId = 4;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnTaoMoi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSua),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnQuayLai)});
            this.bar1.Text = "Tools";
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.Caption = "Tạo mới";
            this.btnTaoMoi.Id = 0;
            this.btnTaoMoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoMoi.ImageOptions.Image")));
            this.btnTaoMoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTaoMoi.ImageOptions.LargeImage")));
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnTaoMoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaoMoi_ItemClick);
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Hint = "Thêm";
            this.btnThem.Id = 1;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 2;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.LargeImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Caption = "Quay lại";
            this.btnQuayLai.Id = 3;
            this.btnQuayLai.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQuayLai.ImageOptions.Image")));
            this.btnQuayLai.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnQuayLai.ImageOptions.LargeImage")));
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnQuayLai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQuayLai_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(838, 27);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 540);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(838, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 27);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 513);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(838, 27);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 513);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gcGiamGia);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 227);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 254);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(838, 286);
            this.panel2.TabIndex = 22;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Controls.Add(this.dtpNgayKT, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtYeuCau, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpNgayBD, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtMucGG, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtGiaTri, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtMaGG, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTenGG, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtMoTa, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(838, 286);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // FormGiamGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 540);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormGiamGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGiamGia";
            this.Load += new System.EventHandler(this.FormGiamGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcGiamGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnTaoMoi;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnQuayLai;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}