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
    public partial class UserControl_NhapHang : DevExpress.XtraEditors.XtraUserControl
    {
        public UserControl_NhapHang()
        {
            InitializeComponent();
        }
        SanPham_BLLDAL sanPham_BLLDAL = new SanPham_BLLDAL();
        ChiTietSanPham_BLL chiTietSanPham_BLL = new ChiTietSanPham_BLL();
        private void gridControl1_Click(object sender, EventArgs e)
        {


        }

        private void UserControl_NhapHang_Load(object sender, EventArgs e)
        {

            Load_Item();


            // var data = chiTietSanPham_BLL.loadDS().Select(t => new { t.SANPHAM.TENSANPHAM });
            var data = sanPham_BLLDAL.loadSP().ToList();
            gridControl1.DataSource = new BindingList<SANPHAM>(data);
        }
        public void Load_Item()
        {
            try
            {
              var dt = sanPham_BLLDAL.loadSP().Select(t => new {
                            t.MASANPHAM,
                            t.TENSANPHAM,
                            t.LOAISANPHAM.TENLOAISANPHAM
                        }); 
                      //  repositoryMaSP.NullText = @"Chọn Sản Phẩm";
                        repositoryMaSP.DataSource = dt;
                        repositoryMaSP.ValueMember = "MASANPHAM";
                        repositoryMaSP.DisplayMember = "MASANPHAM";
                       
                        colMaSPP.ColumnEdit = repositoryMaSP;
            }
            catch { }
          
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            string msp = (string)gridView1.GetFocusedRowCellValue("TENSANPHAM");
            textBox1.Text = msp;
                
        }
    }
}
