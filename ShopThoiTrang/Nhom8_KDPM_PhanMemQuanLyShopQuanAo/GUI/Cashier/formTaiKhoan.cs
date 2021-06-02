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
    public partial class formTaiKhoan : DevExpress.XtraEditors.XtraUserControl
    {
        NhanVien_BLLDAL nvBLL = new NhanVien_BLLDAL();
        public formTaiKhoan(NHANVIEN nv)
        {
            InitializeComponent();
            loadNhanVien(nv);
        }
        private void loadNhanVien(NHANVIEN nv)
        {
            picHinhAnh.Image = Image.FromFile(Program.linkURL_Image + @"nhanvien\" + nv.HINHANH);
            lbTenNhanVien.Text = nv.TENNHANVIEN;
            lbEmail.Text = nv.EMAIL;
            lbNgaySinh.Text = nv.NGAYSINH.Value.ToString();
            lbGioiTinh.Text = nv.GIOITINH;
            lbSDT.Text = nv.SDT;
            lbCMND.Text = nv.CMND;
            lbEmail.Text = nv.EMAIL;
        }

    }
}
