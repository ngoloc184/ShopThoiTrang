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
    public partial class DetailForm : DevExpress.XtraEditors.XtraForm
    {
        SanPham_BLLDAL sanPhamBLL = new SanPham_BLLDAL();
        SetupControls setupControls = new SetupControls();
        public DetailForm(int MaSP, bool flag)
        {
            InitializeComponent();
            this.CenterToParent();
            SANPHAM sanpham = sanPhamBLL.detailSanpham(MaSP);
            setupControls.setupPicture(pictureEdit, Program.linkURL_SanPham + sanpham.HINHANH);
            lbTenSp.Text += sanpham.TENSANPHAM;
            lbTrangThai.Text += sanpham.TRANGTHAI == true ? "Còn Hàng" : "Hết Hàng";
            lbDonGia.Text += sanpham.DONGIA+" VND";
            
            lbMoTa.Text += sanpham.MOTA;
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            Program.formTN.flagBuy = true;
            Program.formTN.checkBuy();
        }

        private void DetailForm_Load(object sender, EventArgs e)
        {

        }
    }
}