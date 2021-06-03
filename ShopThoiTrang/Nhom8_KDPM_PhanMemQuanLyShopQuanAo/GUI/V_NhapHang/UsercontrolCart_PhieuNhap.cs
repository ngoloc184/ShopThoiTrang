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
using DevExpress.XtraReports.UI;

namespace GUI
{
    public partial class UsercontrolCart_PhieuNhap : DevExpress.XtraEditors.XtraUserControl
    {
        public UsercontrolCart_PhieuNhap()
        {
            InitializeComponent();
        }
        PhieuNhap_BLLDAL phieuNhap_BLLDAL = new PhieuNhap_BLLDAL();
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UsercontrolCart_PhieuNhap_Load(object sender, EventArgs e)
        {
            load_DL();
        }
        public void load_DL()
        {
            gridControl1.DataSource = Program.dsPhieuNhap.dsSP.ToList();
        }

        private void btnAo_Click(object sender, EventArgs e)
        {
            if(Program.dsPhieuNhap.dsSP.Count==0)
            {
                MessageBox.Show("Danh sách đang rỗng vui lòng thêm sản phẩm để lập!");
                return;
            }    
            foreach(var item in Program.dsPhieuNhap.dsSP)
            {
                if(item.SOLUONG<=0)
                {
                    MessageBox.Show("Số lượng  = 0!");
                    return;
                }    
            }    
            if (MessageBox.Show("Lưu và tạo Phiếu Nhập!", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                phieuNhap_BLLDAL.taoPhieuNhap(Program.dsPhieuNhap);
                //tao phiếu nhập.
                MessageBox.Show("Tạo thành công!");
                Program.dsPhieuNhap.dsSP.Clear();
                load_DL();
            }
          
            using (Reporting.frmPrint frmPrint = new Reporting.frmPrint())
            {
                frmPrint.PrintPhieuNhap(phieuNhap_BLLDAL.getMaPNMoi().MAPHIEUNHAP);
                frmPrint.ShowDialog();
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là xóa SP này khỏi danh sách?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int mactsp = int.Parse(gridView1.GetFocusedRowCellDisplayText("MACHITIETSANPHAM"));
                Program.dsPhieuNhap.XoaItem(mactsp);
                MessageBox.Show("Đã xóa Sản phẩm:  " + mactsp);
                load_DL();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
