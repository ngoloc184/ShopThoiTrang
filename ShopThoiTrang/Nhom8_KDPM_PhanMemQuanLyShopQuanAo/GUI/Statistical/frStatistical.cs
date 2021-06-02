using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BLL_DAL;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;

namespace GUI
{
    public partial class frStatistical : DevExpress.XtraEditors.XtraForm
    {
        HoaDonBLLDAL context = new HoaDonBLLDAL();
        Reportt report = new Reportt();
        public frStatistical()
        {
            InitializeComponent();
            cbbNam.Properties.Items.Clear();
            var list = Enumerable.Range(2000, DateTime.Now.Year - 2000 + 1).ToList();
            cbbNam.Properties.Items.AddRange(list);

        }
        private void Load()
        {
            if (cbbThang.Text != "Tháng" && cbbNam.Text != "Năm")
            {
                try
                {
                    gcThongKe.DataSource = null;
                    gvThongKe.Columns.Clear();

                    if (rdProduct.Checked == true)
                    {


                        Statistical_SP(gcThongKe, gvThongKe);
                        lbTong.Text = "Tổng số sản phẩm bán được: ";
                        load_tongTheoHangHoa();

                    }
                    if (rdRevenue.Checked == true)
                    {
                        Statistical_HD(gcThongKe, gvThongKe);
                        lbTong.Text = "Tổng doanh thu tháng: ";
                        load_tongTheoDoanhThu();
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                XtraMessageBox.Show("Bạn chưa chọn đủ ngày tháng", "Thông báo");
            }

        }
        public void Statistical_SP(GridControl gc, GridView gv)
        {
            try
            {
                gc.DataSource = context.thongKeSpTheoThang(Convert.ToInt32(cbbThang.Text), Convert.ToInt32(cbbNam.Text));
                gv.Columns[0].Caption = "Tên sản phẩm";
                gv.Columns[1].Name = "Col1";
                gv.Columns[1].Caption = "Số lượng đã bán trong tháng "+cbbThang.Text+" năm "+cbbNam.Text+"";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Statistical_HD(GridControl gc, GridView gv)
        {
            try
            {
                gc.DataSource = context.thongKeHoaDonTheoThang(Convert.ToInt32(cbbThang.Text), Convert.ToInt32(cbbNam.Text));
                gv.Columns[0].Caption = "Mã hoá đơn";
                gv.Columns[1].Caption = "Tên khách hàng";
                gv.Columns[2].Caption = "Ngày tạo";
                gv.Columns[3].Caption = "Tổng tiền";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void rdProduct_CheckedChanged(object sender, EventArgs e)
        {
            Load();
        }

        private void rdRevenue_CheckedChanged(object sender, EventArgs e)
        {
            Load();
        }
        void load_tongTheoHangHoa()
        {
            double tong = 0;
            if (gvThongKe.RowCount> 1)
            {
                for (int i = 0; i < gvThongKe.DataRowCount - 1; i++)
                {
                    
                    DataRow row = gvThongKe.GetDataRow(i);
                    tong += Convert.ToDouble(gvThongKe.GetRowCellValue(i,gvThongKe.Columns[1]));
                    label1.Text = string.Format("{0}", tong) + " món";
                }
            }
            else
            {
                tong = 0;
                label1.Text = tong + " đ";
            }
        }

        void load_tongTheoDoanhThu()
        {
            double tong = 0;
            if (gvThongKe.RowCount > 1)
            {
                for (int i = 0; i < gvThongKe.DataRowCount - 1; i++)
                {
                    DataRow row = gvThongKe.GetDataRow(i);
                    tong += Convert.ToDouble(gvThongKe.GetRowCellValue(i, gvThongKe.Columns[3]));
                    label1.Text = string.Format("{0:0,000}", tong) + " đ";
                }
            }
            else
            {
                tong = 0;
                label1.Text = tong + " đ";
            }
        }

        private void cbbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cbbThang.Text != "Tháng" && cbbNam.Text != "Năm"))
            {
                rdProduct.Enabled = true;
                rdRevenue.Enabled = true;
            }
            else
            {
                rdProduct.Enabled = false;
                rdRevenue.Enabled = false;
            }
            if (rdProduct.Checked)
            {
                rdProduct_CheckedChanged(sender, e);
            }
            if (rdRevenue.Checked)
            {
                rdRevenue_CheckedChanged(sender, e);
            }
        }

        private void cbbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cbbThang.Text != "Tháng" && cbbNam.Text != "Năm"))
            {
                rdProduct.Enabled = true;
                rdRevenue.Enabled = true;
            }
            else
            {
                rdProduct.Enabled = false;
                rdRevenue.Enabled = false;
            }
            if (rdProduct.Checked)
            {
                rdProduct_CheckedChanged(sender, e);
            }
            if (rdRevenue.Checked)
            {
                rdRevenue_CheckedChanged(sender, e);
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (cbbThang.Text != "Tháng" && cbbNam.Text != "Năm")
            {
                if (XtraMessageBox.Show(string.Format("Bạn có chắc xuất báo cáo doanh thu này chứ?"),
                 "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    ReportPrintTool tool = new ReportPrintTool(report);

                    report.DataSource = context.thongKeHoaDonTheoThang(Convert.ToInt32(cbbThang.Text), Convert.ToInt32(cbbNam.Text));
                    report.Parameters["CreateDate"].Value = DateTime.Now.Date;
                    report.Parameters["NguoiLap"].Value = "Thao";
                    report.Parameters["TotalPrice"].Value = label1.Text;
                    report.Parameters["Thang"].Value = cbbThang.Text.ToString();
                    tool.ShowPreview();
                }
            }
            else
            {
                XtraMessageBox.Show("Bạn chưa chọn đủ ngày tháng", "Thông báo");
            }

        }
        

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            frmBieuDo frm = new frmBieuDo();
            frm.ShowDialog();
        }
    }
}