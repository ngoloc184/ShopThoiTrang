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
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraReports.UI;

namespace GUI
{
    public partial class FormBillsSold : DevExpress.XtraEditors.XtraUserControl
    {
        HoaDonBLLDAL hoaDonBLL = new HoaDonBLLDAL();
        public FormBillsSold()
        {
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::GUI.WaitForm1), true, true, typeof(System.Windows.Forms.UserControl));
            this.splashScreenManager1.ClosingDelay = 500;
            this.splashScreenManager1.ShowWaitForm();
            InitializeComponent();
        }

        private void FormBillsSold_Load(object sender, EventArgs e)
        {
            //gridControl1.DataSource = hoaDonBLL.load_listHD().ToList<View_HoaDon>();
            //this.splashScreenManager1.CloseWaitForm();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
          
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            //ReportQLShop1 rp = new ReportQLShop1();
            //List<CHITIETHOADON> cthd = Common.Entities.CHITIETHOADONs.ToList<CHITIETHOADON>();

            //rp.DataSource = cthd;
            //ReportPrintTool tool = new ReportPrintTool(rp);
            //tool.ShowPreview();
        }
    }
}
