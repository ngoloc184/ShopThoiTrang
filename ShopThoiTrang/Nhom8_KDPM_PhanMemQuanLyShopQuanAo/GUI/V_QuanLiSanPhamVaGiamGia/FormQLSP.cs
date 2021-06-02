using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_DAL;
using DevExpress.XtraEditors;

namespace GUI
{
    public partial class FormQLSP : Form
    {
        SanPham_BLLDAL sp = new SanPham_BLLDAL();
        LoaiSanPham_BLLDAL loaisp = new LoaiSanPham_BLLDAL();
        QLShopDataContext db = new QLShopDataContext();
        public FormQLSP()
        {
            InitializeComponent();
        }

        private void FormQLSP_Load(object sender, EventArgs e)
        {
            cboTenLoai.Enabled = false;
            txtMaSP.Enabled = false;
            gcSanPham.DataSource = sp.loadSP();
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaSP.Text == "")
            {
                MessageBox.Show("Vui lòng chọn dòng muốn sửa thông tin");
            }
            else if (txtDonGia.Text == "" || txtKhuyenMai.Text == "" || txtMota.Text == "" || txtTenSP.Text == "")
            {
                MessageBox.Show("Vui lòng điền đủ thông tin");
            }
            else
            {
                //sp.luuSanPham(int.Parse(txtMaSP.Text), txtTenSP.Text, int.Parse(txtDonGia.Text), int.Parse(txtKhuyenMai.Text), txtMota.Text);
                SANPHAM s = new SANPHAM();
                s.MASANPHAM = int.Parse(gridView1.GetFocusedRowCellDisplayText("MASANPHAM"));
                s.DONGIA = int.Parse(txtDonGia.Text);
                s.KHUYENMAI = int.Parse(txtKhuyenMai.Text);
                s.TENSANPHAM = txtTenSP.Text;
                s.MOTA = txtMota.Text;
                sp.suaTTSP(s);


                gcSanPham.DataSource = sp.loadSP();
                MessageBox.Show("Sửa thành công sản phẩm " + s.MASANPHAM);
                txtDonGia.Clear();
                txtKhuyenMai.Clear();
                txtMaSP.Clear();
                txtMota.Clear();
                txtTenSP.Clear();
                cboTenLoai.Text = "";
                cboTenLoai.Enabled = false;

            }
        }



        private void gcSanPham_Click(object sender, EventArgs e)
        {
            cboTenLoai.Enabled = false;
            int maSP = int.Parse(gridView1.GetFocusedRowCellValue("MASANPHAM").ToString());
            SANPHAM s = sp.detailSanpham(maSP);
            txtMaSP.Text = s.MASANPHAM.ToString();
            txtMota.Text = s.MOTA;
            txtTenSP.Text = s.TENSANPHAM;
            txtDonGia.Text = s.DONGIA.ToString();
            txtKhuyenMai.Text = s.KHUYENMAI.ToString();
            cboTenLoai.Text = s.LOAISANPHAM.TENLOAISANPHAM;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaSP.Text == "")
            {
                MessageBox.Show("Vui lòng chọn dòng muốn sửa chi tiết");
            }
            else
            {
                FormChiTietSanPham ct = new FormChiTietSanPham(int.Parse(txtMaSP.Text));
                ct.Show();
            }
        }

        private void btnTaoMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cboTenLoai.Enabled = true;
            cboTenLoai.DataSource = loaisp.load_DSLoai().Select(s => s.TENLOAISANPHAM);
            txtDonGia.Clear();
            txtKhuyenMai.Clear();
            txtMaSP.Clear();
            txtMota.Clear();
            txtTenSP.Clear();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaSP.Text != "")
            {
                MessageBox.Show("Vui lòng chọn tạo mới");
            }
            else
            {
                if (txtDonGia.Text == "" || txtKhuyenMai.Text == "" || txtMota.Text == "" || txtTenSP.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                }
                else
                {
                    SANPHAM s = new SANPHAM();
                    s.DONGIA = int.Parse(txtDonGia.Text);
                    s.KHUYENMAI = int.Parse(txtKhuyenMai.Text);
                    s.MOTA = txtMota.Text;
                    s.TENSANPHAM = txtTenSP.Text;
                    s.MALOAISANPHAM = loaisp.loaiSP_tenLoai(cboTenLoai.Text).MALOAISANPHAM;
                    sp.themSP(s);
                    gcSanPham.DataSource = sp.loadSP();
                    MessageBox.Show("Thêm thành công");
                    txtDonGia.Clear();
                    txtKhuyenMai.Clear();
                    txtMaSP.Clear();
                    txtMota.Clear();
                    txtTenSP.Clear();
                    cboTenLoai.Text = "";
                    cboTenLoai.Enabled = false;
                }
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Menu_Ribbon menu = new Menu_Ribbon();
            menu.Show();
            this.Hide();
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtKhuyenMai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtMaSP_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
