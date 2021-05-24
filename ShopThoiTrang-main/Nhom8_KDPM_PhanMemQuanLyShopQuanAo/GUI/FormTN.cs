using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL_DAL;
using DevExpress.XtraEditors;

namespace GUI
{
    public partial class FormTN : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        LoaiSanPham_BLLDAL loaiSanPham = new LoaiSanPham_BLLDAL();
        SanPham_BLLDAL sanphamBLL = new SanPham_BLLDAL();
        TaiKhoan taikhoanBLL = new TaiKhoan();

        public SanPham_BLLDAL SanphamBLL
        {
            get { return sanphamBLL; }
            set { sanphamBLL = value; }
        }

        public List<SANPHAM> ListSanPham { get => listSanPham; set => listSanPham = value; }

        AccordionControlElement[] listAccord = null;
        List<SANPHAM> listSanPham = null;
        SetupControls setupControls = new SetupControls();
       
        static DetailForm detail;
        static FormCart_XX frmCart;
        Cart cart = new Cart();
        public bool flagBuy = false;
        public FormTN()
        {
            InitializeComponent();
        }
        private void setupAccordionControlElement(AccordionControlElement accordionControlElement, int position, string name, string urlFile, string text)
        {
            PictureEdit pictureBox = new PictureEdit();
            setupControls.setupPicture(pictureBox, urlFile);
            //
            accordionControlElement.ImageOptions.Image = pictureBox.Image;
            accordionControlElement.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            accordionControlElement.Name = name;
            accordionControlElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            accordionControlElement.Text = text;
            listAccord[position] = accordionControlElement;
        }
        private void setupItem_TypesProduct()
        {
            List<LOAISANPHAM> listTypes = loaiSanPham.load_DSLoai().ToList<LOAISANPHAM>();
            //Setup length for danh sach loai san pham 
            listAccord = new AccordionControlElement[listTypes.Count()];
            //Setup item product
            for (int i = 0; i < listAccord.Count(); i++)
            {
                AccordionControlElement a = new AccordionControlElement();
                setupAccordionControlElement(a, i, "loaiSP" + listTypes[i].MALOAISANPHAM, Program.linkURL_LoaiSP + listTypes[i].HINHANH, listTypes[i].TENLOAISANPHAM);
                a.Click += ItemProduct_Click;
                a.Tag = i+1;
            }
            //
            this.accordionControlElementProduct.Elements.AddRange(listAccord);
        }

        private void ItemProduct_Click(object sender, EventArgs e)
        {
            AccordionControlElement ctr = (AccordionControlElement)sender;
            ListSanPham = sanphamBLL.loadSanPham_ForLoai(int.Parse(ctr.Tag.ToString())).ToList<SANPHAM>();
            setupItem_Types(ListSanPham);
            this.itemNav.Caption = $"{ctr.Text}";
        }
        public void loadTN()
        {
            splashScreenManager1.ShowWaitForm();
            setupItem_TypesProduct();
            //this.itemNav.Caption = $"{accordionControlElementBill.Text}";
            this.itemNav.Caption = $"{accordionControlElementHome.Text}";
            //setupItem_Types();
            splashScreenManager1.CloseWaitForm();
            lbSPVuaChon.Text = "Ưu đãi Tháng 5: Giảm 10% cho khách hàng có thẻ thành viên và hóa đơn từ 1 tr!";
        }
        FormHome frmHome ;
        public void FormThuNgan_Load(object sender, EventArgs e)
        {
            //TAIKHOANNHANVIEN tk = taikhoanBLL.FindTaiKhoan(GUI.Properties.Settings.Default.UserName, GUI.Properties.Settings.Default.Password);
            //NHANVIEN nv = taikhoanBLL.timNVTheoTK((int)tk.MANHANVIEN);
            //MessageBox.Show("Hệ thống chào mừng nhân viên " + nv.TENNHANVIEN + " đã làm việc. Chúc một ngày làm việc tốt lành .","Chào mừng");
            splashScreenManager1.ShowWaitForm();
            setupItem_TypesProduct();
            frmHome = new FormHome();
            this.container.Controls.Add(frmHome);
            frmHome.Dock = DockStyle.Fill;
            this.itemNav.Caption = "{accordionControlElementBill.Text}";
            this.itemNav.Caption = $"{accordionControlElementHome.Text}";
            //setupItem_Types();
            splashScreenManager1.CloseWaitForm();
            lbSPVuaChon.Text = "Ưu đãi Tháng 5: Giảm 10% cho khách hàng có thẻ thành viên và hóa đơn từ 1 tr!";
        }
        public void removeFrmHome()
        {
            this.container.Controls.Remove(frmHome);
            this.container.Controls.Clear();
            Program.formTN.container.Controls.Clear();
        }
        public void setupItem_Types(List<SANPHAM> listSanPham)
        {
            this.container.Controls.Clear();
            createSeachControl();
            createSortItems();
            int left = 50, top = 100;
            splashScreenManager1.ShowWaitForm();
            for (int i = 0; i < listSanPham.Count(); i++)
            {
                PanelControl panelControl = new PanelControl();
                setupPanelProduct(panelControl, left, top, listSanPham[i]);
                left += 500;
                if (left >= 1450)
                {
                    left = 50;
                    top += panelControl.Height + 350;
                }
            }
            splashScreenManager1.CloseWaitForm();
        }
        #region SearchControl
        SearchControl searchControl;
        public void createSeachControl()
        {
            searchControl = new SearchControl();
            searchControl.Location = new System.Drawing.Point(200, 25);
            searchControl.MenuManager = this.fluentFormDefaultManager1;
            searchControl.Name = "searchControl";
            searchControl.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            searchControl.Properties.Appearance.Options.UseFont = true;
            searchControl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            searchControl.Size = new System.Drawing.Size(606, 48);
            this.container.Controls.Add(searchControl);
            searchControl.TextChanged += SearchControl_TextChanged;
            //searchControl.Enter += searchControl_Enter;
            searchControl.KeyDown += searchControl_KeyDown;
        }
        LabelControl labelControl2;
        ComboBoxEdit cboSort;
        public void createSortItems()
        {
            labelControl2 = new LabelControl();
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(900, 25);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(143, 24);
            this.labelControl2.Text = "Tìm kiếm theo";
            this.container.Controls.Add(labelControl2);


            cboSort = new ComboBoxEdit();
            cboSort.Location = new System.Drawing.Point(1110, 25);
            cboSort.MenuManager = this.fluentFormDefaultManager1;
            cboSort.Name = "cboSort";
            cboSort.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cboSort.Properties.Appearance.Options.UseFont = true;
            //cboSort.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            //new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            cboSort.Properties.Items.AddRange(new object[] {
            "Giá giảm dần",
            "Giá tăng dần",
            "A-Z",
            "Z-A"});
            cboSort.Size = new System.Drawing.Size(237, 48);
            this.container.Controls.Add(cboSort);
            cboSort.SelectedValueChanged += cboSort_SelectedValueChanged;

        }

        void cboSort_SelectedValueChanged(object sender, EventArgs e)
        {
            List<SANPHAM> listProduce = sanphamBLL.Search(searchControl.Text);
            List<SANPHAM> lstSortPriceDesc = sanphamBLL.sortDescPrice(listProduce);
            List<SANPHAM> lstSortPriceAsc = sanphamBLL.sortAscPrice(listProduce);
            List<SANPHAM> lstSortNameDesc = sanphamBLL.sortAZName(listProduce);
            List<SANPHAM> lstSortNameAsc = sanphamBLL.sortZAName(listProduce);
            if (cboSort.Text == "Giá giảm dần")
            {
                int left = 50, top = 100;
                clearPanelProduct();
                splashScreenManager1.ShowWaitForm();
                for (int i = 0; i < lstSortPriceDesc.Count(); i++)
                {
                    PanelControl panelControl = new PanelControl();
                    setupPanelProduct(panelControl, left, top, lstSortPriceDesc[i]);
                    left += 500;
                    if (left >= 1450)
                    {
                        left = 50;
                        top += panelControl.Height + 350;
                    }
                }
                splashScreenManager1.CloseWaitForm();
            }
            else if (cboSort.Text == "Giá tăng dần")
            {
                int left = 50, top = 100;
                clearPanelProduct();
                splashScreenManager1.ShowWaitForm();
                for (int i = 0; i < lstSortPriceAsc.Count(); i++)
                {
                    PanelControl panelControl = new PanelControl();
                    setupPanelProduct(panelControl, left, top, lstSortPriceAsc[i]);
                    left += 500;
                    if (left >= 1450)
                    {
                        left = 50;
                        top += panelControl.Height + 350;
                    }
                }
                splashScreenManager1.CloseWaitForm();
            }
            else if (cboSort.Text == "A-Z")
            {
                int left = 50, top = 100;
                clearPanelProduct();
                splashScreenManager1.ShowWaitForm();
                for (int i = 0; i < lstSortNameDesc.Count(); i++)
                {
                    PanelControl panelControl = new PanelControl();
                    setupPanelProduct(panelControl, left, top, lstSortNameDesc[i]);
                    left += 500;
                    if (left >= 1450)
                    {
                        left = 50;
                        top += panelControl.Height + 350;
                    }
                }
                splashScreenManager1.CloseWaitForm();
            }
            else if (cboSort.Text == "Z-A")
            {
                int left = 50, top = 100;
                clearPanelProduct();
                splashScreenManager1.ShowWaitForm();
                for (int i = 0; i < lstSortNameAsc.Count(); i++)
                {
                    PanelControl panelControl = new PanelControl();
                    setupPanelProduct(panelControl, left, top, lstSortNameAsc[i]);
                    left += 500;
                    if (left >= 1450)
                    {
                        left = 50;
                        top += panelControl.Height + 350;
                    }
                }
                splashScreenManager1.CloseWaitForm();
            }
        }
        void clearPanelProduct()
        {
            foreach (Control item in this.container.Controls)
            {
                if (item.GetType() == typeof(PanelControl))
                {
                    item.Visible = false;
                }
            }
        }
        void searchControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (searchControl.Text == "")
                {
                    MessageBox.Show("Enter a string to search");
                    return;
                }
                List<SANPHAM> listProduce = sanphamBLL.Search(searchControl.Text);

                int left = 50, top = 100;
                clearPanelProduct();
                splashScreenManager1.ShowWaitForm();
                for (int i = 0; i < listProduce.Count(); i++)
                {
                    PanelControl panelControl = new PanelControl();
                    setupPanelProduct(panelControl, left, top, listProduce[i]);
                    left += 500;
                    if (left >= 1450)
                    {
                        left = 50;
                        top += panelControl.Height + 350;
                    }
                }
                splashScreenManager1.CloseWaitForm();
            }


        }

        void searchControl_Enter(object sender, EventArgs e)
        {
            SearchControl ctr = new SearchControl();
            List<SANPHAM> listProduce = sanphamBLL.Search(sender.ToString());

            int left = 50, top = 100;
            splashScreenManager1.ShowWaitForm();

            for (int i = 0; i < listProduce.Count(); i++)
            {
                PanelControl panelControl = new PanelControl();
                setupPanelProduct(panelControl, left, top, listProduce[i]);
                left += 500;
                if (left >= 1450)
                {
                    left = 50;
                    top += panelControl.Height + 350;
                }
            }
            splashScreenManager1.CloseWaitForm();
            //throw new NotImplementedException();
        }

        private void SearchControl_TextChanged(object sender, EventArgs e)
        {
            SearchControl ctr = new SearchControl();
            List<SANPHAM> tenSp = new List<SANPHAM>();
            foreach (SANPHAM item in ListSanPham)
            {
                if (item.TENSANPHAM.Contains(ctr.Text))
                    tenSp.Add(item);
            }
            SANPHAM[] kq = tenSp.ToArray();
            ListBoxControl listBoxControl = new ListBoxControl();
            listBoxControl.Items.AddRange(kq);
            ctr.Client = listBoxControl;
        }

        #endregion


        private void setupPanelProduct(DevExpress.XtraEditors.PanelControl panelControl, int topPos, int leftPos, SANPHAM sanpham)
        {
            panelControl = new DevExpress.XtraEditors.PanelControl();
            this.container.Controls.Add(panelControl);
            panelControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;

            PictureEdit pictureEdit = new PictureEdit();
            setupControls.setupPicture(pictureEdit, Program.linkURL_SanPham + sanpham.HINHANH);
            panelControl.Controls.Add(pictureEdit);
            pictureEdit.Location = new System.Drawing.Point(5, 5);
            pictureEdit.Size = new System.Drawing.Size(265, 390);
            pictureEdit.Tag = sanpham.MASANPHAM;
            pictureEdit.Click += PictureEdit_Click ;

            int top = 29, left = 286;

            LabelControl labelTenSanPham = new LabelControl();
            setupControls.setupLabel(labelTenSanPham, top, left, sanpham.TENSANPHAM);
            panelControl.Controls.Add(labelTenSanPham);
            top +=80;

            LabelControl labelTrangThai = new LabelControl();
            string trangthai = sanpham.TRANGTHAI == true ? "Còn Hàng" : "Hết Hàng";
            setupControls.setupLabel(labelTrangThai, top, left, "Trạng thái: " + trangthai);
            panelControl.Controls.Add(labelTrangThai);
            top +=30;

            //LabelControl labelSoLuongTon = new LabelControl();
            //setupControls.setupLabel(labelSoLuongTon, top, left, "Số lượng: "+sanpham.SOLUONGTON + " hàng");
            //panelControl.Controls.Add(labelSoLuongTon);
            //top += 30;

            LabelControl labelDonGia = new LabelControl();
            setupControls.setupLabel(labelDonGia, top, left, "Đơn giá: " + sanpham.DONGIA + " VND");
            labelDonGia.Font = new Font(labelDonGia.Font, FontStyle.Bold);
            labelDonGia.ForeColor = Color.Red;
            panelControl.Controls.Add(labelDonGia);
            top += 80;

            SimpleButton btnBuy = new SimpleButton();
            setupControls.setupButton(btnBuy, top, left, sanpham.MASANPHAM, "BUY PRODUCT", sanpham.MASANPHAM);
            btnBuy.Click += BtnBuy_Click;
            panelControl.Controls.Add(btnBuy);
            top += 60;

            SimpleButton btnDetail = new SimpleButton();
            setupControls.setupButton(btnDetail, top, left, sanpham.MASANPHAM, "DETAIL PRODUCT",sanpham.MASANPHAM);
            panelControl.Controls.Add(btnDetail);
            btnDetail.Click += BtnDetail_Click;

            panelControl.Location = new System.Drawing.Point(topPos, leftPos);
            panelControl.Size = new System.Drawing.Size(480, 400);
        }

        private void BtnDetail_Click(object sender, EventArgs e)
        {

            if (detail != null)
                detail.Close();
            SimpleButton ctr = (SimpleButton)sender;
            detail = new DetailForm(int.Parse(ctr.Tag.ToString()), flagBuy);
            detail.Show();
        }

        private void BtnBuy_Click(object sender, EventArgs e)
        {
            //SimpleButton ctr = (SimpleButton)sender;
            //int ma = int.Parse(ctr.Tag.ToString());
            //if (sanphamBLL.kiemTraSLTon(Program.dsGH, ma) == "duyệt")
            //{
            //    Program.soLuong++;
            //    this.barButtonItemCart.Caption = "CART(" + Program.soLuong.ToString() + ")";

            //    SANPHAM sp = sanphamBLL.detailSanpham(int.Parse(ctr.Tag.ToString()));
            //    Program.dsGH.Them(ma, 1);
            //    lbSPVuaChon.Text = "Sản phẩm vừa chọn vào Giỏ Hàng: " + sp.TENSANPHAM;
            //    return;
            //}
            //lbSPVuaChon.Text = sanphamBLL.kiemTraSLTon(Program.dsGH, ma);





        }
        private void PictureEdit_Click(object sender, EventArgs e)
        {
            if (detail != null)
                detail.Close();
            PictureEdit ctr = (PictureEdit)sender;
            detail = new DetailForm(int.Parse(ctr.Tag.ToString()),flagBuy);
            detail.Show();
        }
        public void checkBuy()
        {
            if (flagBuy == true)
            {
                flagBuy = false;
                Program.soLuong++;
                this.barButtonItemCart.Caption = "CART(" + Program.soLuong.ToString() + ")";
            }
        }

        private void FormTN_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.frmLogin.Show();
        }

        private void accordionControlElementLogOut_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Do you want to log out?","LOG OUT", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                this.Hide();
                Program.frmLogin.Show();
            }

        }

        private void accordionControlElementBills_Click(object sender, EventArgs e)
        {
            this.itemNav.Caption = $"{accordionControlElementBills.Text}";
            this.container.Controls.Clear();
            FormBillsSold frm = new FormBillsSold();
            this.container.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
        }

        private void accordionControlElementProduct_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItemCart_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCart = new FormCart_XX();
            frmCart.Show();
            this.Hide();

           
        }

        private void fluentDesignFormControl1_Click(object sender, EventArgs e)
        {

        }
        int x = 206, y = 8,a=2;

        private void itemNav_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void accordionControlElementHome_Click(object sender, EventArgs e)
        {
            this.container.Controls.Clear();
            frmHome = new FormHome();
            this.container.Controls.Add(frmHome);
            frmHome.Dock = DockStyle.Fill;
            this.itemNav.Caption = $"{accordionControlElementHome.Text}";
        }

        //637, 8
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                x += a;
                lbSPVuaChon.Location = new Point(x, y);
                if (lbSPVuaChon.Text == "ĐÃ HẾT HÀNG")
                {

                    if (lbSPVuaChon.ForeColor == Color.Red)
                    {
                        lbSPVuaChon.ForeColor = Color.White;
                        if (x >= 530)
                            a = -2;
                        if (x <= 206)
                            a = 1;
                        return;
                    }
                    if (x >= 530)
                        a = -2;
                    if (x <= 206)
                        a = 1;
                    lbSPVuaChon.ForeColor = Color.Red;
                    return;
                }
                lbSPVuaChon.ForeColor = Color.Black;
                if (x >= 530)
                    a = -2;
                if (x <= 206)
                    a = 1;
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    //frmCart = new FormCart_XX();
        //    //frmCart.Show();
        //    //this.Hide();
        //}
    }
}
