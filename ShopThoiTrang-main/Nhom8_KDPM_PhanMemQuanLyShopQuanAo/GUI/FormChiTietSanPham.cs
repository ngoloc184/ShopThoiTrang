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
    public partial class FormChiTietSanPham : Form
    {
        ChiTietSanPham_BLL ctsp = new ChiTietSanPham_BLL();
        QLSHOPDataContext db = new QLSHOPDataContext();
        int maSP;
        public FormChiTietSanPham(int masp)
        {
            maSP = masp;
            InitializeComponent();
        }

        private void FormChiTietSanPham_Load(object sender, EventArgs e)
        {
            gcCTSP.DataSource = ctsp.timDSCT(maSP);
            cboSize.DataSource = db.SIZEs.Select(s => s.TENSIZE).ToList();
            CboMau.DataSource = db.MAUs.Select(s => s.TENMAU).ToList();
            txtMaCTSP.Enabled = false;
            txtMaSP.Enabled = false;
            cboSize.Enabled = false;
            CboMau.Enabled = false;

        }

        private void gcCTSP_Click(object sender, EventArgs e)
        {
            int maCTSP = int.Parse(gridView1.GetFocusedRowCellValue("MACHITIETSP").ToString());
            CHITIETSANPHAM ct = ctsp.timCTSP_THEOMACT(maCTSP);
            txtMaCTSP.Text = ct.MACHITIETSP.ToString();
            txtSL.Text = ct.SOLUONGTON.ToString();
            cboSize.Text = ct.SIZE.TENSIZE;
            CboMau.Text = ct.MAU.TENMAU;
            txtMaSP.Text = maSP.ToString();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaCTSP.Text == "")
            {
                MessageBox.Show("Vui lòng chọn dòng muốn sửa thông tin");
            }
            else
            {
                if(txtSL.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn số lượng để đổi");
                    return;
                }    
                CHITIETSANPHAM ct = new CHITIETSANPHAM();
                ct.MACHITIETSP = int.Parse(txtMaCTSP.Text);
                ct.SOLUONGTON = int.Parse(txtSL.Text);
                ctsp.suaCTSP(ct);
                gcCTSP.DataSource = ctsp.timDSCT(maSP);

            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            this.Hide();
        }
    }
}
