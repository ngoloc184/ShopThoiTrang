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

namespace GUI.Cashier
{
    public partial class ChangePassword : DevExpress.XtraEditors.XtraUserControl
    {
        NhanVien_BLLDAL nvBLL = new NhanVien_BLLDAL();
        TaiKhoan tkBLL = new TaiKhoan();
        public ChangePassword()
        {
            InitializeComponent();
            loadChangeUser(nvBLL.load_OnlyNhanVien((int)Program.frmLogin.TaiKhoan.MANHANVIEN));
        }
        private void loadChangeUser(NHANVIEN nv)
        {
            picHinhAnh.Image = Image.FromFile(Program.linkURL_Image + @"nhanvien\" + nv.HINHANH);
            txtTenTaiKhoan.Text = nv.TAIKHOANNHANVIENs.First().TENTAIKHOAN;
        }
        private void optionEnable(bool f)
        {
            txtTenTaiKhoan.Enabled = f;
            txtMatKhauCu.Enabled = f;
            txtMatKhauMoi.Enabled = f;
            txtNhapMatKhau.Enabled = f;
            btnThayDoi.Enabled = !f;
            btnLuu.Enabled = f;
        }

        bool f1 = false;
        private void btnHienThiCu_Click(object sender, EventArgs e)
        {
            if (f1 == false)
            {
                this.txtMatKhauCu.Properties.UseSystemPasswordChar = false;
                btnHienThiCu.ImageOptions.Image = Image.FromFile(Program.linkURL_Image + "invisible.png");
                f1 = true;
            }
            else
            {
                this.txtMatKhauCu.Properties.UseSystemPasswordChar = true;
                btnHienThiCu.ImageOptions.Image = Image.FromFile(Program.linkURL_Image + "visibility.png");
                f1 = false;
            }
        }
        bool f2 = false;
        private void btnHienThiMoi_Click(object sender, EventArgs e)
        {
            if (f2 == false)
            {
                this.txtMatKhauMoi.Properties.UseSystemPasswordChar = false;
                btnHienThiMoi.ImageOptions.Image = Image.FromFile(Program.linkURL_Image + "invisible.png");
                f2 = true;
            }
            else
            {
                this.txtMatKhauMoi.Properties.UseSystemPasswordChar = true;
                btnHienThiMoi.ImageOptions.Image = Image.FromFile(Program.linkURL_Image + "visibility.png");
                f2 = false;
            }
        }

        private void btnThayDoi_Click(object sender, EventArgs e)
        {
            optionEnable(true);
        }

        private bool kiemTraTrong()
        {
            if (String.IsNullOrEmpty(txtTenTaiKhoan.Text))
            {
                txtTenTaiKhoan.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtMatKhauCu.Text))
            {
                txtMatKhauCu.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtMatKhauMoi.Text))
            {
                txtMatKhauMoi.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtNhapMatKhau.Text))
            {
                txtNhapMatKhau.Focus();
                return false;
            }
            return true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!kiemTraTrong())
            {
                MessageBox.Show("Thông tin điền còn thiếu, Vui lòng điền thêm.", "Không đạt yêu cầu");
                return;
            }
            if (txtTenTaiKhoan.Text.Length < 6)
            {
                MessageBox.Show("Tên tài khoản mới quá ngắn, vui lòng nhập ít nhất 6 ký tự","Lỗi tên tài khoản");
                return;
            }
            if (!txtMatKhauCu.Text.Equals(tkBLL.FindTaiKhoan((int)Program.frmLogin.TaiKhoan.MATAIKHOAN).MATKHAU)) {
                MessageBox.Show("Mật khẩu cũ nhập không đúng!", "Mật khẩu không đúng");
                txtMatKhauCu.Focus();
                return;
            }
            if (txtMatKhauMoi.Text.Length < 6)
            {
                MessageBox.Show("Độ dài mật khẩu vui lòng phải ít nhất 6 ký tự", "Độ dài mật khẩu không đủ");
                txtMatKhauMoi.Focus();
                return;
            }
            if (txtMatKhauMoi.Text.Equals(txtMatKhauCu.Text))
            {
                MessageBox.Show("Mật khẩu mới không được trùng với mật khẩu cũ", "Trùng mật khẩu cũ");
                txtMatKhauMoi.Focus();
                return;
            }
            if (!txtNhapMatKhau.Text.Equals(txtMatKhauMoi.Text))
            {
                txtNhapMatKhau.Focus();
                MessageBox.Show("Mật khẩu nhập lại không trùng với mật khẩu mới. Kiểm tra lại.", "Nhập lại không trùng mật khẩu");
                return;
            }
            TAIKHOANNHANVIEN tk = new TAIKHOANNHANVIEN();
            tk.MATAIKHOAN = Program.frmLogin.TaiKhoan.MATAIKHOAN;
            tk.TENTAIKHOAN = txtTenTaiKhoan.Text;
            tk.MATKHAU = txtMatKhauMoi.Text;
            if (tkBLL.ThayDoiTaiKhoan(tk))
            {
                MessageBox.Show("Thay đổi mật khẩu thành công", "Thành công");
                Program.frmLogin.TaiKhoan = tk;
                txtTenTaiKhoan.Text = Program.frmLogin.TaiKhoan.TENTAIKHOAN;
                optionEnable(false);
            }
            else
            {
                MessageBox.Show("Thay đổi mật khẩu thất bại", "Thất bại");
            }
            txtMatKhauCu.Text = txtMatKhauMoi.Text = txtNhapMatKhau.Text = "";
        }
    }
}
