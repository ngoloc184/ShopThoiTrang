using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Navigation;
using BLL_DAL;

namespace GUI
{
    public partial class formOurProduct : DevExpress.XtraEditors.XtraUserControl
    {
        FormTN frm = new FormTN();
        LoaiSanPham_BLLDAL loaiSanPham = new LoaiSanPham_BLLDAL();
        SanPham_BLLDAL sanphamBLL = new SanPham_BLLDAL();
        public formOurProduct()
        {
            InitializeComponent();
        }

        private void btnAo_Click(object sender, EventArgs e)
        {
            
            Program.formTN.ListSanPham = sanphamBLL.loadSanPham_ForLoai(int.Parse(btnAo.Tag.ToString())).ToList<SANPHAM>();
            frm.removeFrmHome();
            Program.formTN.setupItem_Types(Program.formTN.ListSanPham);
        }

        private void btnQuan_Click(object sender, EventArgs e)
        {
            Program.formTN.ListSanPham = sanphamBLL.loadSanPham_ForLoai(int.Parse(btnQuan.Tag.ToString())).ToList<SANPHAM>();
            frm.removeFrmHome();
            Program.formTN.setupItem_Types(Program.formTN.ListSanPham);
        }

        private void btnPK_Click(object sender, EventArgs e)
        {
            Program.formTN.ListSanPham = sanphamBLL.loadSanPham_ForLoai(int.Parse(btnPK.Tag.ToString())).ToList<SANPHAM>();
            frm.removeFrmHome();
            Program.formTN.setupItem_Types(Program.formTN.ListSanPham);
        }
    }
}
