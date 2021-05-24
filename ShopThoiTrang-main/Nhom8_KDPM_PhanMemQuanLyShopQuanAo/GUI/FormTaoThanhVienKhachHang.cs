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
using System.Text.RegularExpressions;
namespace GUI
{
    public partial class FormTaoThanhVienKhachHang : Form
    {
        public FormTaoThanhVienKhachHang()
        {
            InitializeComponent();
        }

        KhachHang_BLLDAL KhachHang_BLL = new KhachHang_BLLDAL();
        private void FormTaoThanhVienKhachHang_Load(object sender, EventArgs e)
        {
            Load_form();

        }
        public void Load_form()
        {
            //this.kHACHHANGTableAdapter.Fill(this.qLSHOPDataSet.KHACHHANG);
            //txtGioiTinh.Items.Add("Nam"); txtGioiTinh.Items.Add("Nữ");
            //KHACHHANG khachHang = KhachHang_BLL.timKHTheoMaKH(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            //txtTenkhachHang.Text = khachHang.TENKHACHHANG;
            //txtDiaChi.Text = khachHang.DIACHI;
            //txtNgaySinh.Value = DateTime.Parse(khachHang.NGAYSINH.ToString());
            //txtSDT.Text = khachHang.SDT;
            //txtGioiTinh.Text = khachHang.GIOITINH;
            //txtEmail.Text = khachHang.EMAIL;
            //// txtTenkhachHang.Text = txtSDT.Text = txtNgaySinh.Text = txtGioiTinh.Text = txtEmail.Text = txtDiaChi.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //KHACHHANG khachHang = KhachHang_BLL.timKHTheoMaKH(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            //txtTenkhachHang.Text = khachHang.TENKHACHHANG;
            //txtDiaChi.Text = khachHang.DIACHI;
            //txtNgaySinh.Value = DateTime.Parse(khachHang.NGAYSINH.ToString());
            //txtSDT.Text = khachHang.SDT;
            //txtGioiTinh.Text = khachHang.GIOITINH;
            //txtEmail.Text = khachHang.EMAIL;
            //them = false;
        }
        Boolean them = false;
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //if (them == false)
            //{

            //    txtTenkhachHang.Text = txtSDT.Text = txtNgaySinh.Text = txtGioiTinh.Text = txtEmail.Text = txtDiaChi.Text = "";
            //    them = true;
            //    return;
            //}
            //if (kiemTraDieuKienTrong() == false)
            //{
            //    return;
            //}

            //if (KhachHang_BLL.timKHtheoSDT(txtSDT.Text) != null)
            //{
            //    MessageBox.Show("Số điện thoại này đã dùng cho khách hàng khác!");
                
            //    // txtTenkhachHang.Text = txtSDT.Text = txtNgaySinh.Text = txtGioiTinh.Text = txtEmail.Text = txtDiaChi.Text = "";
            //    return;
            //}

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
            //    khNew.NGAYSINH = DateTime.Parse(NgaySinh);
            //khNew.SDT = SDT;
            //khNew.EMAIL = Email;

            //KhachHang_BLL.themMoi(khNew);
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
            if (txtTenkhachHang.Text == "")
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
                lbThongBao.Text = "Ngày sinh phải bé hơn ngày hiện tại: "+" !"; return false;
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


            if (txtGioiTinh.Text != "Nam" && txtGioiTinh.Text != "Nữ")
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //int maKH = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            //if(MessageBox.Show("Bạn có chắc xóa?","Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes){
            //    if (KhachHang_BLL.xoaKH(maKH) == false)
            //    {
            //        MessageBox.Show("Khách hàng này không thể xóa vì khách hàng có mua hàng rồi!");
            //        return;
            //    }
            //    else
            //    {
            //        MessageBox.Show("Đã xóa thành công!");

            //    }
            //    Load_form();
            //}
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //if (kiemTraDieuKienTrong() == false)
            //{
            //    return;
            //}
            //if (txtSDT.Text == "") return;
            //int maKH = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            //string tenkh = txtTenkhachHang.Text;
            //string diaChi = txtDiaChi.Text;
            //string GioiTinh = txtGioiTinh.Text;
            //string NgaySinh = txtNgaySinh.Text;
            //string SDT = txtSDT.Text;
            //string Email = txtEmail.Text;

            //if (GioiTinh == "Nam")
            //    GioiTinh = "Nam";
            //else
            //    GioiTinh = "Nữ";

            //KhachHang_BLL.suaKH(maKH, tenkh, diaChi, GioiTinh, DateTime.Parse(NgaySinh), SDT, Email);
            //MessageBox.Show("Sửa thành công!");
            //Load_form();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }
       
    }
}
