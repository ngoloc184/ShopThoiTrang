using BLL_DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormTaoThanhVienKH_XX : Form
    {
        public FormTaoThanhVienKH_XX()
        {
            InitializeComponent();
        }
        QLSHOPDataContext db = new QLSHOPDataContext();
        KhachHang_BLLDAL khachHang_BLLDAL = new KhachHang_BLLDAL();
        private void FormTaoThanhVienKH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSHOPDataSet.KHACHHANG' table. You can move, or remove it, as needed.
            Load_form();
        }
        public void Load_form()
        {
            this.kHACHHANGTableAdapter.Fill(this.qLSHOPDataSet.KHACHHANG);
           // txtTenkhachHang.Text = txtSDT.Text = txtNgaySinh.Text = txtGioiTinh.Text = txtEmail.Text = txtDiaChi.Text = "";
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
        Boolean them = false;
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (them == false)
            {
                
                txtTenkhachHang.Text = txtSDT.Text = txtNgaySinh.Text = txtGioiTinh.Text = txtEmail.Text = txtDiaChi.Text = "";
                them = true;
                return;
            }
           if( kiemTraDieuKienTrong()==false)
            {
                return;
            }    
            
            if (khachHang_BLLDAL.timKHtheoSDT(txtSDT.Text) != null)
            {
                MessageBox.Show("Số điện thoại này đã dùng cho khách hàng khác!");
               // txtTenkhachHang.Text = txtSDT.Text = txtNgaySinh.Text = txtGioiTinh.Text = txtEmail.Text = txtDiaChi.Text = "";
                return;
            }
            
            //string tenkh = txtTenkhachHang.Text;
            //string diaChi = txtDiaChi.Text;
            //string GioiTinh = txtGioiTinh.Text;
            //string NgaySinh = txtNgaySinh.Text;
            //string SDT = txtSDT.Text;
            //string Email = txtEmail.Text;
            //KHACHHANG khNew = new KHACHHANG();

            //khNew.TENKHACHHANG = tenkh;
            //khNew.DIACHI = diaChi;
            //if (GioiTinh == "Nam")
            //    khNew.GIOITINH = GioiTinh;
            //else
            //    khNew.GIOITINH = "Nữ";
            //if (NgaySinh == "") 
            //    khNew.NGAYSINH = DateTime.Now;
            //else
            //     khNew.NGAYSINH = DateTime.Parse(NgaySinh);
            //khNew.SDT = SDT;
            //khNew.EMAIL = Email;

            //khachHang_BLLDAL.themMoi(khNew);
            //them = false;
            //MessageBox.Show("Đã thêm thành công khách hàng!");
            //Load_form();

        }

        public Boolean kiemTraDieuKienTrong()
        {
            if (txtTenkhachHang.Text == "Vãng Lai")
            {
                lbThongBao.Text = "Xin lỗi khách hàng này chúng tôi không cho sửa!";
                return false;
            }
            if (txtTenkhachHang.Text=="")
            {
                lbThongBao.Text = "Vui lòng điềm thông tin: Tên khách hàng";
                return false;
            }
            if (txtDiaChi.Text == "")
            {
                lbThongBao.Text = "Vui lòng điềm thông tin: Địa chỉ";
                return false;
            }
            if (txtNgaySinh.Text == "")
            {
                lbThongBao.Text = "Vui lòng điềm thông tin: Ngày sinh";
                return false;
            }
            if (DateTime.Parse(txtNgaySinh.Text) > DateTime.Now)
            {
                lbThongBao.Text = "Ngày sinh phải bé hơn ngày hiện tại: " + DateTime.Now + " !"; return false;
            }
            if (txtSDT.Text == "")
            {
                lbThongBao.Text = "Vui lòng điềm thông tin: Số điện thoại - 10 số";
                return false;
            }
            if (txtSDT.Text.Length != 10)
            {
                lbThongBao.Text = "SDT không đúng định dạng 10 kí tự!"; return false;
            }

            
            if(txtGioiTinh.Text!="Nam" && txtGioiTinh.Text!="Nữ")
            {
                lbThongBao.Text = "Vui lòng chọn giới tính hợp lệ!(Nam hoặc Nữ)";
                return false;
            }
            if (txtEmail.Text == "")
            {
                lbThongBao.Text = "Vui lòng điềm thông tin: Email";
                return false;
            }
            Regex regex = new Regex(@"^[\w-]+@([\w-]+\.)+[\w-]+$");
            if (!regex.IsMatch(txtEmail.Text))
            {
                lbThongBao.Text = "Email không đúng định dạng!"; return false;
            }
            return true;
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            int maKH = int.Parse(gridView1.GetFocusedRowCellValue("MAKHACHHANG").ToString());
            if (khachHang_BLLDAL.xoaKH(maKH) == false)
            {
                MessageBox.Show("Khách hàng này không thể xóa vì khách hàng có mua hàng rồi!");
                return;
            }
            else
            {
                MessageBox.Show("Đã xóa thành công!");

            }
            Load_form();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {


            if (kiemTraDieuKienTrong() == false)
            {
                return;
            }
            if (txtSDT.Text == "") return;
            string maKH = gridView1.GetFocusedRowCellValue("MAKHACHHANG").ToString();
            string tenkh = txtTenkhachHang.Text;
            string diaChi = txtDiaChi.Text;
            string GioiTinh = txtGioiTinh.Text;
            string NgaySinh = txtNgaySinh.Text;
            string SDT = txtSDT.Text;
            string Email = txtEmail.Text;

            if (GioiTinh == "Nam")
                GioiTinh = "Nam";
            else
                GioiTinh = "Nữ";

            khachHang_BLLDAL.suaKH(int.Parse(maKH), tenkh, diaChi, GioiTinh, DateTime.Parse(NgaySinh), SDT, Email);

            MessageBox.Show("Sửa thành công!");
            Load_form();

        }

        private void gIOITINHTextEdit_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string maKH = gridView1.GetFocusedRowCellValue("MAKHACHHANG").ToString();
            string tenkh = gridView1.GetFocusedRowCellValue("TENKHACHHANG").ToString();
            string diaChi = gridView1.GetFocusedRowCellValue("DIACHI").ToString();
            string GioiTinh = gridView1.GetFocusedRowCellValue("GIOITINH").ToString();
            string NgaySinh = gridView1.GetFocusedRowCellValue("NGAYSINH").ToString();
            string SDT = gridView1.GetFocusedRowCellValue("SDT").ToString();
            string Email = gridView1.GetFocusedRowCellValue("EMAIL").ToString();
            if (txtSDT.Text != "")
            { 
            if (GioiTinh == "Nam")
                GioiTinh = "Nam";
            else
                GioiTinh = "Nữ";

            khachHang_BLLDAL.suaKH(int.Parse(maKH), tenkh, diaChi, GioiTinh, DateTime.Parse(NgaySinh), SDT, Email);

            MessageBox.Show("Sửa thành công!");
            Load_form();
             }
        }
    }
}
