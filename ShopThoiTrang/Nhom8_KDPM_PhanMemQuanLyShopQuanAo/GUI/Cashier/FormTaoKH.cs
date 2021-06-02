using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
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
    public partial class FormTaoKH : DevExpress.XtraEditors.XtraUserControl
    {
        KhachHang_BLLDAL kh = new KhachHang_BLLDAL();
        public FormTaoKH()
        {
            InitializeComponent();
            rdoGroupGT.EditValue = rdoGroupGT.Properties.Items[0].Value;
            lbTB.Text = "";
        }
        private bool kiemTraTrong()
        {
            if (String.IsNullOrEmpty(txtTenKH.Text))
            {
                txtTenKH.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtDiaChi.Text))
            {
                txtDiaChi.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(dateNgaySinh.Text))
            {
                dateNgaySinh.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(btnHinhAnh.Text))
            {
                btnHinhAnh.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtEmail.Text) && txtEmail.Text.Length > 20)
            {
                txtEmail.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtSDT.Text)) {
                txtSDT.Focus();
                return false;
            }
            return true;
        }

        private void clear(){
            txtDiaChi.Text = "";
            txtTenKH.Text = "";
            dateNgaySinh.Text = "";
            rdoGroupGT.SelectedIndex = 0;
            txtSDT.Text = "";
            txtEmail.Text = "";
            btnHinhAnh.Text = "";
            txtEmail.Text = "";
            txtSDT.Text = "";
            //pictureHinh.Image = Image.FromFile(Program.linkURL_KhachHang+"male.jpg");
            pictureHinh.Image = null;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (kiemTraTrong() == false)
            {
                MessageBox.Show("Bạn nhập thông tin còn thiếu, mời bạn tiếp tục nhập thêm .");
                lbTB.Text = "";
                return;
            }

            KHACHHANG _kh = new KHACHHANG();
            _kh.TENKHACHHANG = txtTenKH.Text;
            _kh.NGAYSINH = DateTime.Parse(dateNgaySinh.Text);
            _kh.DIACHI = txtDiaChi.Text;
            _kh.DIEMTICHLUY = 0;
            _kh.EMAIL = txtEmail.Text;
            _kh.SDT = txtSDT.Text;
            _kh.GIOITINH = (String)rdoGroupGT.Properties.Items[rdoGroupGT.SelectedIndex].Value;
            _kh.HINHANH = btnHinhAnh.Text.Split('\\')[btnHinhAnh.Text.Split('\\').Length-1];

            if (!kh.themMoi(_kh))
            {
                MessageBox.Show("Thêm mới khách hàng thất bại!");
                lbTB.Text = "";
            }
            else
            {
                MessageBox.Show("Thêm khách hàng thành công!");
                lbTB.Text = "Chúc mừng đã thêm thành công khách hàng "+txtTenKH.Text+" .";
                clear();
            }
        }


        private void pictureHinh_DoubleClick(object sender, EventArgs e)
        {
            xtraOpenFileDialog1.InitialDirectory = Program.linkURL_Image + @"KhachHang\" ;
            xtraOpenFileDialog1.Title = "Browse Text Files";
            if (xtraOpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                btnHinhAnh.Text = xtraOpenFileDialog1.FileName;
                pictureHinh.Image = Image.FromFile(xtraOpenFileDialog1.FileName);
            }
        }

        private void btnHinhAnh_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            xtraOpenFileDialog1.InitialDirectory = Program.linkURL_Image + @"KhachHang  \" ;
            xtraOpenFileDialog1.Title = "Browse Text Files";
            if (xtraOpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                btnHinhAnh.Text = xtraOpenFileDialog1.FileName;
                pictureHinh.Image = Image.FromFile(xtraOpenFileDialog1.FileName);
            }
        }

        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
