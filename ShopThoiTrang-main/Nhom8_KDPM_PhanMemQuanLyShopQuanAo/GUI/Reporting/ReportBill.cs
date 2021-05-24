using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Collections.Generic;
using BLL_DAL;
using GUI.QLSHOPDataSetTableAdapters;

namespace GUI.Reporting
{
    public partial class ReportBill : DevExpress.XtraReports.UI.XtraReport
    {
        CTHD_BLLDAL cthd = new CTHD_BLLDAL();
        public ReportBill()
        {
            InitializeComponent();
        }
        public void InitData(int maHoaDon)
        {
            CHITIETHOADONTableAdapter db = new CHITIETHOADONTableAdapter();
            List<CHITIETHOADON> listChiTiet = cthd.getData_MaHoaDon(maHoaDon);
            pMaHoaDon.Value = maHoaDon;
            objectDataSource1.DataSource = listChiTiet;
        }

    }
}
