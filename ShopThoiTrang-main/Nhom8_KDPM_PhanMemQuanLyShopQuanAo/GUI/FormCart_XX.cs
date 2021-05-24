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
using DevExpress.XtraReports.UI;

namespace GUI
{
    public partial class FormCart_XX : Form
    {
       
        public FormCart_XX( )
        {
            InitializeComponent();
            

        }
        QLSHOPDataContext db = new QLSHOPDataContext();
        SanPham_BLLDAL sanPhamBLL = new SanPham_BLLDAL();
        KhachHang_BLLDAL khbll = new KhachHang_BLLDAL();
        HoaDonBLLDAL hd = new HoaDonBLLDAL();

        private void FormCart_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSHOPDataSet.View_HoaDon' table. You can move, or remove it, as needed.

            Load_DuLieu();
        }
        private  void Load_DuLieu()
        {
           // this.view_HoaDonTableAdapter.Fill(this.qLSHOPDataSet.View_HoaDon);
            SanPham_BLLDAL db = new SanPham_BLLDAL();
            //gridControl1.DataSource = Program.dsGH.dsSP;
            gridControl1.DataSource = Program.dsGH.dsSP.ToList();
            lbTongTien.Text ="Tổng tiền:"+ Program.dsGH.tongThanhTien();
           // RepositoryItemGraphicsEdit repitemGraphicsEdit = new RepositoryItemGraphicsEdit();
           // SetupControls setupControls = new SetupControls();
          //  setupControls.setupPicture((gridView1 ("iHinhAnh").ColumnsEdit, Program.linkURL_SanPham + sanpham.HINHANH);

            ;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                QLSHOPDataContext db = new QLSHOPDataContext();
                //Tao Gio Hang
                if (Program.dsGH.dsSP.Count == 0)
                {
                    MessageBox.Show("Giỏ hàng rỗng rồi!");
                    return;
                }
                KhachHang_BLLDAL a = new KhachHang_BLLDAL();
                KHACHHANG kh = new KHACHHANG();
                if (txtSDT.Text.Length == 0)
                {
                    MessageBox.Show("Quên điền sdt khách hàng rồi!");
                    return;
                }


                kh = a.timKHtheoSDT(txtSDT.Text);
                if (kh == null)
                {
                    if (MessageBox.Show("Khách hàng này chưa có thông tin!\n Vui lòng chọn YES để thêm thông tin hoặc ghi sdt là NO!", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        FormTaoThanhVienKH_XX frmtaoKH = new FormTaoThanhVienKH_XX();
                        frmtaoKH.Show();
                        return;
                    }

                }
                else
                {
                    //kh = a.timKHtheoSDT(txtSDT.Text);  
                    //if(kh==null)
                    //{
                    //    MessageBox.Show("Số điện thoại khách hàng không tồn tại!");
                    //    return;
                    //}
                    a.TaoHoaDon(Program.dsGH, kh);
                    MessageBox.Show("Hóa đơn đã được ghi nhận!");
                    //Reporting.ReportHoaDon reportHoaDon = new Reporting.ReportHoaDon();
                    //ReportPrintTool printTool = new ReportPrintTool(reportHoaDon);
                    //printTool.PrintDialog();
                    //printTool.Print();
                    
                    //reportHoaDon.CreateDocument(false);
                    //XtraReport dummyReport = new XtraReport();

                    //dummyReport.Pages.Add(reportHoaDon.Pages[0]);
                    //dummyReport.ShowPreviewDialog();
                    //printTool.Print("Bill sold");

                    //using(Reporting.frmPrint frmPrint = new Reporting.frmPrint())
                    //{
                    //    frmPrint.PrintBillThuNgan(hd.getMaHDMoi().MAHOADON);
                    //    frmPrint.ShowDialog();
                    //}

                    Program.dsGH.dsSP.Clear();
                    Program.soLuong = 0;
                    this.Close();
                }
                FormTN frm = new FormTN();
                frm.Show();
            }
            catch
            {
                return;
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbKH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            int ma =  (gridView1.GetFocusedRow() as CartItem).iMaChiTietSP;
            if (MessageBox.Show("Bạn có chắc muốn xóa{(gridView1.GetFocusedRow()as CartItem).iTenSanPham}?","Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                MessageBox.Show("Đã xóa khỏi giỏ hàng!");
                Program.dsGH.XoaItem(ma);
                Load_DuLieu();
                return;
                

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
          //  cbKhachHang.DataSource = khbll.timKH(txtSDT.Text);
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
           
        }

        private void repositoryItemButtonEditTHEMSL1_Click(object sender, EventArgs e)
        {
            //int ma = (gridView1.GetFocusedRow() as CartItem).iMaSanPham;
            //if (sanPhamBLL.kiemTraSLTon(Program.dsGH, ma) == "duyệt")
            //{
            //    Program.soLuong++;
            //    Program.dsGH.Them(ma, 1);
            //    Load_DuLieu();
            //    return;
            //}
            //MessageBox.Show(sanPhamBLL.kiemTraSLTon(Program.dsGH, ma) +" ") ;
        }

        private void repositoryItemButtonEditGIAMSL_Click(object sender, EventArgs e)
        {
            int ma = (gridView1.GetFocusedRow() as CartItem).iMaChiTietSP;

            Boolean kq = Program.dsGH.giamSL(ma);
            if (kq == true)
            {
                Load_DuLieu();
                return;
            }
            MessageBox.Show("Số lượng còn lại là 1: Nếu không mua SP này vui lòng nhấn Button Delete");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc HỦY GIỎ HÀNG?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Đã Hủy Thanh Toán!");
                Program.dsGH.dsSP.Clear();
                Program.soLuong = 0;
                Load_DuLieu();
                FormTN frm = new FormTN();
                frm.Show();
                this.Hide();
                return;


            }

        }

        private void FormCart_XX_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.formTN.Show();
        }
    }
}
