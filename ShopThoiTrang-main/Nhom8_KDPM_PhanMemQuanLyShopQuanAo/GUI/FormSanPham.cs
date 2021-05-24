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
    public partial class FormSanPham : Form
    {
        public FormSanPham()
        {
            InitializeComponent();
        }
        QLSHOPDataContext db = new QLSHOPDataContext();
        LoaiSanPham_BLLDAL loaiSP_BLL = new LoaiSanPham_BLLDAL();
        SanPham_BLLDAL sanPham_BLL = new SanPham_BLLDAL();
        ChiTietSanPham_BLL ctspList = new ChiTietSanPham_BLL();

        string mau;
        string size;
        private void FormSanPham_Load(object sender, EventArgs e)
        {
         
            Load_SP();
        }
        public void Load_SP()
        {
            gridSanPham.DataSource = sanPham_BLL.loadSP();
            cbLoaiSP.DataSource = loaiSP_BLL.load_LoaiSP().ToList();
            cbLoaiSP.Tag = cbLoaiSP;

           
            
            
        }

        private void cbLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            //LOAISANPHAM loaiSP = loaiSP_BLL.loaiSP_tenLoai(cbLoaiSP.Text);
            //var listSP = sanPham_BLL.loadSanPham_ForLoai(loaiSP.MALOAISANPHAM).Select(t => new {
            //    t.MASANPHAM,
            //    t.TENSANPHAM,
            //    t.SOLUONGTON,
            //    t.DONGIA,
            //    t.TRANGTHAI,
            //    t.MOTA
            //}).ToList();
            //dataGridView1.DataSource = listSP;



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //SANPHAM sanpham = sanPham_BLL.detailSanpham(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            //pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image\\sanpham\\" + sanpham.HINHANH);
            //txtMaSP.Text = sanpham.MASANPHAM.ToString();
            //txtTenSP.Text = sanpham.TENSANPHAM;
            //txtSoLuongTon.Text = sanpham.SOLUONGTON.ToString();
            //txtDonGia.Text = sanpham.DONGIA.ToString();
            //txtMoTa.Text = sanpham.MOTA;

            //if (sanpham.TRANGTHAI == true)
            //{
            //    txtTrangThai.Text = "Còn hàng";
            //}
            //else
            //    txtTrangThai.Text = "Hết hàng";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormGioHang frmCart = new FormGioHang();
            frmCart.Show();
            this.Hide();
        }

        private void btnThemGH_Click(object sender, EventArgs e)
        {
            //try { SANPHAM sanpham = sanPham_BLL.detailSanpham(int.Parse(txtMaSP.Text));
            //if (sanPham_BLL.kiemTraSLTon(Program.dsGH, sanpham.MASANPHAM) == "duyệt")
            //{
            //    if (sanpham == null) return;
            //    Program.dsGH.Them(sanpham.MASANPHAM, 1);
            //    lbsubTB.Text = "Đã thêm sản phẩm:";
            //    lbThongBao.Text =sanpham.TENSANPHAM.ToString();
            //    lbSoLuongGioHang.Text = Program.dsGH.dsSP.Select(t => t.iSoLuong).Sum().ToString();
            //    return;
            //}
            //lbsubTB.Text = "";
            //lbThongBao.Text = sanPham_BLL.kiemTraSLTon(Program.dsGH, sanpham.MASANPHAM);
            //}

            //catch { }

            //c2:
            CHITIETSANPHAM ctSP = ctspList.timCTSP(int.Parse(txtMaSP.Text), mau, size);
            Program.dsGH.Them(ctSP.MACHITIETSP, 1);
           



        }
        int x = 354, y = 9, a = 2;

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void gridSanPham_Click(object sender, EventArgs e)
        {
            int maSP = int.Parse(gridView1.GetFocusedRowCellValue("MASANPHAM").ToString());
            SANPHAM sanpham = sanPham_BLL.detailSanpham(maSP);
            pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image\\sanpham\\" + sanpham.HINHANH);
            txtMaSP.Text = sanpham.MASANPHAM.ToString();
            txtTenSP.Text = sanpham.TENSANPHAM;
            txtDonGia.Text = sanpham.DONGIA.ToString();
            txtMoTa.Text = sanpham.MOTA;

            if (sanpham.TRANGTHAI == true)
            {
                txtTrangThai.Text = "Còn hàng";
            }
            else
                txtTrangThai.Text = "Hết hàng";



            List<CHITIETSANPHAM> listCTSP = ctspList.timDSCT(maSP);
            List<string> listMau=new List<string>();
            PnBtnMau.Controls.Clear();
            foreach (CHITIETSANPHAM item in listCTSP)
            {
                int kq=0;
                foreach (string color in listMau)
                {
                    if (color == item.MAU.TENMAU)
                        kq = 1;
                }
                if (kq == 0)
                {
                    listMau.Add(item.MAU.TENMAU);
                }    
                
            }
            foreach(string item in listMau)
            {
                Button mau = new Button();
                mau.Text = item;
                mau.Size = new System.Drawing.Size(60, 40);
                PnBtnMau.Controls.Add(mau);
                mau.Click += btnMau_click;
                mau.Dock = DockStyle.Left;
                mau.Tag = item;
           
            }   
           
            
        }

        //637, 8
        public void btnMau_click(object sender, EventArgs e)
        {
            PnColor.Controls.Clear();
            Button ctr = (Button)sender;
            List<CHITIETSANPHAM> ctsp = ctspList.timDSTheo_Mau(int.Parse(txtMaSP.Text), ctr.Tag.ToString());
            mau = ctr.Tag.ToString();
            ctr.Enabled = false;
            foreach (CHITIETSANPHAM item in ctsp)
            {
                Button color = new Button();
                color.Text = item.SIZE.TENSIZE;
                color.Tag = color.Text;
                color.Click += btnSize_Click;
                color.Dock = DockStyle.Left;
                PnColor.Controls.Add(color);
                color.Size = new System.Drawing.Size(60, 40);


            }
        }
        public void btnSize_Click(object sender, EventArgs e)
        {
            Button ctr = (Button)sender;
            size = ctr.Tag.ToString();

        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            try
            {
                if (lbThongBao.Text == "ĐÃ HẾT HÀNG")
                {
                    lbsubTB.Text = "";
                    if (lbThongBao.ForeColor == Color.Red)
                    {
                        lbThongBao.ForeColor = Color.White;
                        return;
                    }

                    lbThongBao.ForeColor = Color.Red;
                    return;
                }
                lbThongBao.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {

            }
        }
    }
}
