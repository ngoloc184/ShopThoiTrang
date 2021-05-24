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
        QLSHOPDataContext db = new QLSHOPDataContext();
        public FormQLSP()
        {
            InitializeComponent();
        }

        private void FormQLSP_Load(object sender, EventArgs e)
        {
            txtTenLoai.Enabled = false;
            txtMaSP.Enabled = false;
            gcSanPham.DataSource = sp.loadSP();
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(txtMaSP.Text == "")
            {
                MessageBox.Show("Vui lòng chọn dòng muốn sửa thông tin");
            }
            else if(txtDonGia.Text =="" ||txtKhuyenMai.Text == ""||txtMota.Text==""||txtTenSP.Text=="")
            {
                MessageBox.Show("Vui lòng điền đủ thông tin");
            }    
            else {
                //sp.luuSanPham(int.Parse(txtMaSP.Text), txtTenSP.Text, int.Parse(txtDonGia.Text), int.Parse(txtKhuyenMai.Text), txtMota.Text);
                SANPHAM s = new SANPHAM();
                s.MASANPHAM = int.Parse(gridView1.GetFocusedRowCellDisplayText("MASANPHAM"));
                s.DONGIA = int.Parse(txtDonGia.Text);
                s.KHUYENMAI = int.Parse(txtKhuyenMai.Text);
                s.TENSANPHAM = txtTenSP.Text;
                s.MOTA = txtMota.Text;
                sp.suaTTSP(s);

                
                gcSanPham.DataSource = sp.loadSP();
                

            }
        }



        private void gcSanPham_Click(object sender, EventArgs e)
        {
            int maSP = int.Parse(gridView1.GetFocusedRowCellValue("MASANPHAM").ToString());
            SANPHAM s = sp.detailSanpham(maSP);
            txtMaSP.Text = s.MASANPHAM.ToString();
            txtMota.Text = s.MOTA;
            txtTenSP.Text = s.TENSANPHAM;
            txtDonGia.Text = s.DONGIA.ToString();
            txtKhuyenMai.Text = s.KHUYENMAI.ToString();
            txtTenLoai.Text = s.LOAISANPHAM.TENLOAISANPHAM;
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
    }
}
