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
        Size_BLLDAL size_BLLDAL = new Size_BLLDAL();
        Mau_BLLDAL mau_BLLDAL = new Mau_BLLDAL();
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
            string tenmau = cbMau.Text;
            string tensize = cbSize.Text;
            Boolean iSL = int.TryParse(txtSoLuong.Text, out int result);
            if (iSL==false || int.Parse(txtSoLuong.Text) <= 0)
            {
                MessageBox.Show("Vui lòng chỉ điền số lượng >0");
                return;
            }    
            CHITIETSANPHAM ctspt = chiTietSanPham_BLL.timCTSP_full(msp, tenmau, tensize);
            SIZE size = size_BLLDAL.laySize(tensize);
            MAU mau = mau_BLLDAL.layMau(tenmau);

            if (ctspt == null)//ct san pham vua chọn không có dữ liệu nên phải tạo mới
            {
                CHITIETSANPHAM ctsp= new CHITIETSANPHAM();
                ctsp.MASANPHAM = msp;
                ctsp.MAMAU = mau.MAMAU;
                ctsp.MASIZE = size.MASIZE;
                ctsp.MAVACH="SP00"+msp+"00"+ size.MASIZE+"00" + mau.MAMAU;
                ctsp.MASANPHAM = msp;
                ctsp.SOLUONGTON = 0;
                chiTietSanPham_BLL.themCTSP(ctsp);
               Program.dsPhieuNhap.Them(ctsp.MACHITIETSP, int.Parse(txtSoLuong.Text));
                lbThongBao.Text = ctsp.SANPHAM.TENSANPHAM + " " + ctsp.SIZE.TENSIZE + " " + ctsp.MAU.TENMAU + " " + txtSoLuong.Text;
                return;
                //đã thêm;
            }    
         
           Program.dsPhieuNhap.Them(ctspt.MACHITIETSP, int.Parse(txtSoLuong.Text));
            lbThongBao.Text = ctspt.SANPHAM.TENSANPHAM + " " + ctspt.SIZE.TENSIZE + " " + ctspt.MAU.TENMAU + " " + txtSoLuong.Text;
        }

        private void btnThem_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridControl2_Click(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click_1(object sender, EventArgs e)
        {

        }

        private void gridView1_Click_1(object sender, EventArgs e)
        {
            int msp = int.Parse(gridView1.GetFocusedRowCellDisplayText("MASANPHAM"));
            txtMaSP.Text = msp.ToString();
            if (int.Parse(txtSoLuongConDuoi.Text)==0)
            {
                gridControl2.DataSource = chiTietSanPham_BLL.timDSCT(msp).Select(t => new { t.MACHITIETSP, t.MAU.TENMAU, t.SIZE.TENSIZE, t.SOLUONGTON });
            }
            else
                gridControl2.DataSource = chiTietSanPham_BLL.timDSCT(msp).Where(h=>h.SOLUONGTON<= int.Parse(txtSoLuongConDuoi.Text)).Select(t => new { t.MACHITIETSP, t.MAU.TENMAU, t.SIZE.TENSIZE, t.SOLUONGTON });
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Boolean iSL = int.TryParse(txtSoLuongConDuoi.Text, out int result);
            if (iSL == false || int.Parse(txtSoLuongConDuoi.Text) <= 0)
            {
                MessageBox.Show("Vui lòng chỉ điền số lượng >0");
                return;
            }
            gridControl1.DataSource = sanphambll.listSPTheoSoLuongTon(int.Parse(txtSoLuongConDuoi.Text)).ToList();

        }
    }
}
