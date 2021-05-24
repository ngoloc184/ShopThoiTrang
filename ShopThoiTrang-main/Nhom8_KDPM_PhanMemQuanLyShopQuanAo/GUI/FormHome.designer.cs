namespace GUI
{
    partial class FormHome
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
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            this.tileBar = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroupTables = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.AboutUsTileBarItem = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.OurProductTileBarItem = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.AboutUsNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.btnDetails = new DevExpress.XtraEditors.SimpleButton();
            this.imageSlider2 = new DevExpress.XtraEditors.Controls.ImageSlider();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNoti = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnFB = new System.Windows.Forms.Button();
            this.btnIG = new System.Windows.Forms.Button();
            this.btnGG = new System.Windows.Forms.Button();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.employeesLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.customersNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.formContact1 = new GUI.formOurProduct();
            this.customersLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).BeginInit();
            this.navigationFrame.SuspendLayout();
            this.AboutUsNavigationPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.customersNavigationPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // tileBar
            // 
            this.tileBar.AllowGlyphSkinning = true;
            this.tileBar.AllowSelectedItem = true;
            this.tileBar.AppearanceGroupText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.tileBar.AppearanceGroupText.Options.UseForeColor = true;
            this.tileBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tileBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tileBar.DropDownButtonWidth = 30;
            this.tileBar.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar.Groups.Add(this.tileBarGroupTables);
            this.tileBar.IndentBetweenGroups = 10;
            this.tileBar.IndentBetweenItems = 10;
            this.tileBar.ItemPadding = new System.Windows.Forms.Padding(10, 3, 12, 3);
            this.tileBar.Location = new System.Drawing.Point(0, 563);
            this.tileBar.Margin = new System.Windows.Forms.Padding(5, 1, 5, 3);
            this.tileBar.MaxId = 4;
            this.tileBar.MaximumSize = new System.Drawing.Size(0, 120);
            this.tileBar.MinimumSize = new System.Drawing.Size(117, 120);
            this.tileBar.Name = "tileBar";
            this.tileBar.Padding = new System.Windows.Forms.Padding(34, 7, 34, 3);
            this.tileBar.Position = 109;
            this.tileBar.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.None;
            this.tileBar.SelectedItem = this.AboutUsTileBarItem;
            this.tileBar.SelectionBorderWidth = 2;
            this.tileBar.SelectionColorMode = DevExpress.XtraBars.Navigation.SelectionColorMode.UseItemBackColor;
            this.tileBar.ShowGroupText = false;
            this.tileBar.Size = new System.Drawing.Size(1456, 120);
            this.tileBar.TabIndex = 1;
            this.tileBar.Text = "tileBar";
            this.tileBar.WideTileWidth = 150;
            this.tileBar.SelectedItemChanged += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileBar_SelectedItemChanged);
            // 
            // tileBarGroupTables
            // 
            this.tileBarGroupTables.Items.Add(this.AboutUsTileBarItem);
            this.tileBarGroupTables.Items.Add(this.OurProductTileBarItem);
            this.tileBarGroupTables.Name = "tileBarGroupTables";
            this.tileBarGroupTables.Text = "TABLES";
            // 
            // AboutUsTileBarItem
            // 
            this.AboutUsTileBarItem.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(196)))));
            this.AboutUsTileBarItem.AppearanceItem.Normal.Options.UseBackColor = true;
            this.AboutUsTileBarItem.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            tileItemElement1.Text = "About us";
            this.AboutUsTileBarItem.Elements.Add(tileItemElement1);
            this.AboutUsTileBarItem.Name = "AboutUsTileBarItem";
            // 
            // OurProductTileBarItem
            // 
            this.OurProductTileBarItem.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(196)))));
            this.OurProductTileBarItem.AppearanceItem.Normal.Options.UseBackColor = true;
            this.OurProductTileBarItem.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            tileItemElement2.Text = "Our Product";
            this.OurProductTileBarItem.Elements.Add(tileItemElement2);
            this.OurProductTileBarItem.Id = 2;
            this.OurProductTileBarItem.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.OurProductTileBarItem.Name = "OurProductTileBarItem";
            // 
            // navigationFrame
            // 
            this.navigationFrame.Controls.Add(this.AboutUsNavigationPage);
            this.navigationFrame.Controls.Add(this.customersNavigationPage);
            this.navigationFrame.Controls.Add(this.navigationPage1);
            this.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame.Location = new System.Drawing.Point(0, 0);
            this.navigationFrame.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.navigationFrame.Name = "navigationFrame";
            this.navigationFrame.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.AboutUsNavigationPage,
            this.customersNavigationPage,
            this.navigationPage1});
            this.navigationFrame.SelectedPage = this.AboutUsNavigationPage;
            this.navigationFrame.Size = new System.Drawing.Size(1456, 563);
            this.navigationFrame.TabIndex = 0;
            this.navigationFrame.Text = "navigationFrame";
            // 
            // AboutUsNavigationPage
            // 
            this.AboutUsNavigationPage.Caption = "AboutUsNavigationPage";
            this.AboutUsNavigationPage.Controls.Add(this.tablePanel1);
            this.AboutUsNavigationPage.Controls.Add(this.employeesLabelControl);
            this.AboutUsNavigationPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AboutUsNavigationPage.Name = "AboutUsNavigationPage";
            this.AboutUsNavigationPage.Size = new System.Drawing.Size(1456, 563);
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 49.59F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50.41F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel1.Controls.Add(this.btnDetails);
            this.tablePanel1.Controls.Add(this.imageSlider2);
            this.tablePanel1.Controls.Add(this.panel2);
            this.tablePanel1.Controls.Add(this.label2);
            this.tablePanel1.Controls.Add(this.label1);
            this.tablePanel1.Controls.Add(this.panel1);
            this.tablePanel1.Controls.Add(this.btnNoti);
            this.tablePanel1.Controls.Add(this.btnSetting);
            this.tablePanel1.Controls.Add(this.btnFB);
            this.tablePanel1.Controls.Add(this.btnIG);
            this.tablePanel1.Controls.Add(this.btnGG);
            this.tablePanel1.Controls.Add(this.pictureEdit1);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(1456, 563);
            this.tablePanel1.TabIndex = 5;
            // 
            // btnDetails
            // 
            this.btnDetails.Appearance.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDetails.Appearance.BackColor2 = System.Drawing.Color.White;
            this.btnDetails.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetails.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnDetails.Appearance.Options.UseBackColor = true;
            this.btnDetails.Appearance.Options.UseFont = true;
            this.btnDetails.Appearance.Options.UseForeColor = true;
            this.btnDetails.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.btnDetails.AppearanceDisabled.Options.UseBackColor = true;
            this.tablePanel1.SetColumn(this.btnDetails, 12);
            this.tablePanel1.SetColumnSpan(this.btnDetails, 4);
            this.btnDetails.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDetails.ImageOptions.Image")));
            this.btnDetails.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnDetails.Location = new System.Drawing.Point(923, 507);
            this.btnDetails.Name = "btnDetails";
            this.tablePanel1.SetRow(this.btnDetails, 10);
            this.btnDetails.Size = new System.Drawing.Size(300, 53);
            this.btnDetails.TabIndex = 15;
            this.btnDetails.Text = "Thông tin chi tiết";
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // imageSlider2
            // 
            this.imageSlider2.AnimationTime = 500;
            this.tablePanel1.SetColumn(this.imageSlider2, 9);
            this.tablePanel1.SetColumnSpan(this.imageSlider2, 9);
            this.imageSlider2.CurrentImageIndex = 0;
            this.imageSlider2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageSlider2.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider2.Images"))));
            this.imageSlider2.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider2.Images1"))));
            this.imageSlider2.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider2.Images2"))));
            this.imageSlider2.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider2.Images3"))));
            this.imageSlider2.Location = new System.Drawing.Point(693, 59);
            this.imageSlider2.Name = "imageSlider2";
            this.tablePanel1.SetRow(this.imageSlider2, 1);
            this.tablePanel1.SetRowSpan(this.imageSlider2, 8);
            this.imageSlider2.Size = new System.Drawing.Size(684, 442);
            this.imageSlider2.TabIndex = 14;
            this.imageSlider2.Text = "imageSlider2";
            this.imageSlider2.Click += new System.EventHandler(this.imageSlider2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tablePanel1.SetColumn(this.panel2, 1);
            this.tablePanel1.SetColumnSpan(this.panel2, 6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(80, 214);
            this.panel2.Name = "panel2";
            this.tablePanel1.SetRow(this.panel2, 3);
            this.panel2.Size = new System.Drawing.Size(454, 7);
            this.panel2.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tablePanel1.SetColumn(this.label2, 1);
            this.tablePanel1.SetColumnSpan(this.label2, 7);
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(80, 168);
            this.label2.Name = "label2";
            this.tablePanel1.SetRow(this.label2, 3);
            this.label2.Size = new System.Drawing.Size(530, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "You Are My Everything";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tablePanel1.SetColumn(this.label1, 1);
            this.tablePanel1.SetColumnSpan(this.label1, 7);
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(80, 62);
            this.label1.Name = "label1";
            this.tablePanel1.SetRow(this.label1, 1);
            this.tablePanel1.SetRowSpan(this.label1, 2);
            this.label1.Size = new System.Drawing.Size(530, 106);
            this.label1.TabIndex = 1;
            this.label1.Text = "YAME.VN";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.tablePanel1.SetColumn(this.panel1, 0);
            this.tablePanel1.SetColumnSpan(this.panel1, 100);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.tablePanel1.SetRow(this.panel1, 0);
            this.panel1.Size = new System.Drawing.Size(1450, 10);
            this.panel1.TabIndex = 4;
            // 
            // btnNoti
            // 
            this.tablePanel1.SetColumn(this.btnNoti, 15);
            this.btnNoti.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNoti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoti.ForeColor = System.Drawing.Color.White;
            this.btnNoti.Location = new System.Drawing.Point(1152, 3);
            this.btnNoti.Name = "btnNoti";
            this.tablePanel1.SetRow(this.btnNoti, 0);
            this.tablePanel1.SetRowSpan(this.btnNoti, 2);
            this.btnNoti.Size = new System.Drawing.Size(71, 73);
            this.btnNoti.TabIndex = 11;
            this.btnNoti.UseVisualStyleBackColor = true;
            // 
            // btnSetting
            // 
            this.tablePanel1.SetColumn(this.btnSetting, 16);
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.ForeColor = System.Drawing.Color.White;
            this.btnSetting.Location = new System.Drawing.Point(1229, 3);
            this.btnSetting.Name = "btnSetting";
            this.tablePanel1.SetRow(this.btnSetting, 0);
            this.tablePanel1.SetRowSpan(this.btnSetting, 2);
            this.btnSetting.Size = new System.Drawing.Size(71, 73);
            this.btnSetting.TabIndex = 10;
            this.btnSetting.UseVisualStyleBackColor = true;
            // 
            // btnFB
            // 
            this.tablePanel1.SetColumn(this.btnFB, 11);
            this.btnFB.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFB.ForeColor = System.Drawing.Color.White;
            this.btnFB.Location = new System.Drawing.Point(845, 3);
            this.btnFB.Name = "btnFB";
            this.tablePanel1.SetRow(this.btnFB, 0);
            this.tablePanel1.SetRowSpan(this.btnFB, 2);
            this.btnFB.Size = new System.Drawing.Size(71, 73);
            this.btnFB.TabIndex = 7;
            this.btnFB.UseVisualStyleBackColor = true;
            this.btnFB.Click += new System.EventHandler(this.btnFB_Click);
            // 
            // btnIG
            // 
            this.tablePanel1.SetColumn(this.btnIG, 12);
            this.btnIG.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIG.ForeColor = System.Drawing.Color.White;
            this.btnIG.Location = new System.Drawing.Point(923, 3);
            this.btnIG.Name = "btnIG";
            this.tablePanel1.SetRow(this.btnIG, 0);
            this.tablePanel1.SetRowSpan(this.btnIG, 2);
            this.btnIG.Size = new System.Drawing.Size(71, 73);
            this.btnIG.TabIndex = 8;
            this.btnIG.UseVisualStyleBackColor = true;
            this.btnIG.Click += new System.EventHandler(this.btnIG_Click);
            // 
            // btnGG
            // 
            this.tablePanel1.SetColumn(this.btnGG, 13);
            this.btnGG.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGG.ForeColor = System.Drawing.Color.White;
            this.btnGG.Location = new System.Drawing.Point(999, 3);
            this.btnGG.Name = "btnGG";
            this.tablePanel1.SetRow(this.btnGG, 0);
            this.tablePanel1.SetRowSpan(this.btnGG, 2);
            this.btnGG.Size = new System.Drawing.Size(71, 73);
            this.btnGG.TabIndex = 9;
            this.btnGG.UseVisualStyleBackColor = true;
            this.btnGG.Click += new System.EventHandler(this.btnGG_Click);
            // 
            // pictureEdit1
            // 
            this.tablePanel1.SetColumn(this.pictureEdit1, 1);
            this.tablePanel1.SetColumnSpan(this.pictureEdit1, 7);
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureEdit1.EditValue = global::GUI.Properties.Resources._5490;
            this.pictureEdit1.Location = new System.Drawing.Point(80, 171);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit1.Properties.ZoomPercent = 140D;
            this.tablePanel1.SetRow(this.pictureEdit1, 3);
            this.tablePanel1.SetRowSpan(this.pictureEdit1, 10);
            this.pictureEdit1.Size = new System.Drawing.Size(530, 389);
            this.pictureEdit1.TabIndex = 13;
            // 
            // employeesLabelControl
            // 
            this.employeesLabelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 25.25F);
            this.employeesLabelControl.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.employeesLabelControl.Appearance.Options.UseFont = true;
            this.employeesLabelControl.Appearance.Options.UseForeColor = true;
            this.employeesLabelControl.Appearance.Options.UseTextOptions = true;
            this.employeesLabelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.employeesLabelControl.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.employeesLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.employeesLabelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeesLabelControl.Location = new System.Drawing.Point(0, 0);
            this.employeesLabelControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.employeesLabelControl.Name = "employeesLabelControl";
            this.employeesLabelControl.Size = new System.Drawing.Size(1456, 563);
            this.employeesLabelControl.TabIndex = 2;
            this.employeesLabelControl.Text = "Employees";
            // 
            // customersNavigationPage
            // 
            this.customersNavigationPage.Caption = "customersNavigationPage";
            this.customersNavigationPage.Controls.Add(this.formContact1);
            this.customersNavigationPage.Controls.Add(this.customersLabelControl);
            this.customersNavigationPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customersNavigationPage.Name = "customersNavigationPage";
            this.customersNavigationPage.Size = new System.Drawing.Size(1456, 563);
            // 
            // formContact1
            // 
            this.formContact1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formContact1.Location = new System.Drawing.Point(0, 0);
            this.formContact1.Name = "formContact1";
            this.formContact1.Size = new System.Drawing.Size(1456, 563);
            this.formContact1.TabIndex = 3;
            // 
            // customersLabelControl
            // 
            this.customersLabelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 25.25F);
            this.customersLabelControl.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.customersLabelControl.Appearance.Options.UseFont = true;
            this.customersLabelControl.Appearance.Options.UseForeColor = true;
            this.customersLabelControl.Appearance.Options.UseTextOptions = true;
            this.customersLabelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.customersLabelControl.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.customersLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.customersLabelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersLabelControl.Location = new System.Drawing.Point(0, 0);
            this.customersLabelControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customersLabelControl.Name = "customersLabelControl";
            this.customersLabelControl.Size = new System.Drawing.Size(1456, 563);
            this.customersLabelControl.TabIndex = 2;
            this.customersLabelControl.Text = "Customers";
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "navigationPage1";
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(1456, 563);
            // 
            // FormHome
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.navigationFrame);
            this.Controls.Add(this.tileBar);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormHome";
            this.Size = new System.Drawing.Size(1456, 683);
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).EndInit();
            this.navigationFrame.ResumeLayout(false);
            this.AboutUsNavigationPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.customersNavigationPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileBar tileBar;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroupTables;
        private DevExpress.XtraBars.Navigation.TileBarItem AboutUsTileBarItem;
        private DevExpress.XtraBars.Navigation.TileBarItem OurProductTileBarItem;
        private DevExpress.XtraBars.Navigation.NavigationPage AboutUsNavigationPage;
        private DevExpress.XtraBars.Navigation.NavigationPage customersNavigationPage;
        private DevExpress.XtraEditors.LabelControl employeesLabelControl;
        private DevExpress.XtraEditors.LabelControl customersLabelControl;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.SimpleButton btnDetails;
        private DevExpress.XtraEditors.Controls.ImageSlider imageSlider2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNoti;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnFB;
        private System.Windows.Forms.Button btnIG;
        private System.Windows.Forms.Button btnGG;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private formOurProduct formContact1;
    }
}
