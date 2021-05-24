using DevExpress.XtraEditors;
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
namespace GUI
{
    public partial class formNhapHang_main : DevExpress.XtraEditors.XtraUserControl
    {
        public formNhapHang_main()
        {
            InitializeComponent();
        }
        SanPham_BLLDAL sanphambll = new SanPham_BLLDAL();
        LoaiSanPham_BLLDAL loaispBLL = new LoaiSanPham_BLLDAL();
        ChiTietSanPham_BLL chiTietSanPham_BLL = new ChiTietSanPham_BLL();
            
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void formNhapHang_main_Load(object sender, EventArgs e)
        {
            cbLoaiSP.DataSource = loaispBLL.load_DSLoai().Select(t => t.TENLOAISANPHAM).ToList();
            var db = (from sp in sanphambll.load_DSSP()
                      select new
                      {
                          MASANPHAM = sp.MASANPHAM,
                          TENSANPHAM = sp.TENSANPHAM,
                          DONGIA = sp.DONGIA * 0.7,
                          LOAISANPHAM = sp.LOAISANPHAM.TENLOAISANPHAM
                      }).ToList();
            gridControl1.DataSource = db;

            cbSize.DataSource = chiTietSanPham_BLL.listSize().Select(t=>t.TENSIZE).ToList();
            cbMau.DataSource = chiTietSanPham_BLL.listMau().Select(t => t.TENMAU).ToList();
            txtMaSP.Enabled = false;
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            LOAISANPHAM loaiSP = loaispBLL.loaiSP_tenLoai(cbLoaiSP.Text);
            var db = (from sp in sanphambll.loadSanPham_ForLoai(loaiSP.MALOAISANPHAM)
                      select new
                      {
                          MASANPHAM = sp.MASANPHAM,
                          TENSANPHAM = sp.TENSANPHAM,
                          DONGIA = sp.DONGIA * 0.7,
                          LOAISANPHAM = sp.LOAISANPHAM.TENLOAISANPHAM
                      }).ToList();
            gridControl1.DataSource = db;

        }
        private void gridView1_Click(object sender, EventArgs e)
        {
            int msp = int.Parse(gridView1.GetFocusedRowCellDisplayText ("MASANPHAM"));
            txtMaSP.Text = msp.ToString();
            gridControl2.DataSource = chiTietSanPham_BLL.timDSCT(msp).Select(t=>new { t.MACHITIETSP,t.MAU.TENMAU,t.SIZE.TENSIZE,t.SOLUONGTON});


        }
        public Boolean kiemTraDKTHem()
        {
            if (cbSize.Text == "")
            {
                MessageBox.Show("Vui lòng chọn size cho sản phẩm này!");
                return false;
            }
            if (cbMau.Text == "")
            {
                MessageBox.Show("Vui lòng chọn mau cho sản phẩm này!"); return false;
            }
            if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Vui lòng chọn số lượng cho sản phẩm này!"); return false;
            }
            return true;
        }
         private void gridView2_Click(object sender, EventArgs e)
        {
            try {int msp = int.Parse(gridView2.GetFocusedRowCellDisplayText("MACHITIETSP")); CHITIETSANPHAM ctsp = chiTietSanPham_BLL.timCTSP_THEOMACT(msp);
                cbMau.Text = ctsp.MAU.TENMAU;
                cbSize.Text = ctsp.SIZE.TENSIZE;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Chua chọn Sản phẩm!");
                return;
            }
            
          

        }

        

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (kiemTraDKTHem() == false) return;
            int msp = int.Parse(gridView1.GetFocusedRowCellDisplayText("MASANPHAM"));
            string mau = cbMau.Text;
            string size = cbSize.Text;
            CHITIETSANPHAM ctsp = chiTietSanPham_BLL.timCTSP(msp, mau, size);

         
            Program.dsPhieuNhap.Them(ctsp.MACHITIETSP, int.Parse(txtSoLuong.Text));
            lbThongBao.Text = ctsp.SANPHAM.TENSANPHAM + " " + ctsp.SIZE.TENSIZE + " " + ctsp.MAU.TENMAU + " " + txtSoLuong.Text;
        }

        private void btnThem_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
