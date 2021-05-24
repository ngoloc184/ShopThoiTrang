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
using GUI.QLSHOPDataSetTableAdapters;
using BLL_DAL;

namespace GUI.Reporting
{
    public partial class frmPrint : DevExpress.XtraEditors.XtraForm
    {
        public frmPrint()
        {
            InitializeComponent();
        }

        public void PrintBillThuNgan(int maHoaDon)
        {
            Reporting.ReportBill report = new ReportBill();
            foreach(DevExpress.XtraReports.Parameters.Parameter p in report.Parameters)
            {
                p.Visible = false;
            }
            report.InitData(maHoaDon);
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }
    }
}