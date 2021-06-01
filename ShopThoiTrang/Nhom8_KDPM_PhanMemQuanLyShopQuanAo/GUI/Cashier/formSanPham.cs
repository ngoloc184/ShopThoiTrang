﻿using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
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
    public partial class formSanPham : DevExpress.XtraEditors.XtraUserControl
    {
        ChonChiTietSP _formCTSP = null;
        SanPham_BLLDAL spBLL = new SanPham_BLLDAL();
        ChiTietSanPham_BLL ctBLL = new ChiTietSanPham_BLL();
        public formSanPham(int maLoai)
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            if (maLoai == 0)
            {
                sANPHAMsBindingSource.DataSource = new BLL_DAL.QLShopDataContext().SANPHAMs;
                lbNumber.Text = "" + (new BLL_DAL.QLShopDataContext().SANPHAMs).Count();
                lbTenLoai.Text = "TẤT CẢ LOẠI QUẦN ÁO";
            }
            else
            {
                sANPHAMsBindingSource.DataSource = new BLL_DAL.QLShopDataContext().SANPHAMs.Where(sp => sp.MALOAISANPHAM == maLoai);
                lbNumber.Text = "" + (new BLL_DAL.QLShopDataContext().SANPHAMs.Where(sp => sp.MALOAISANPHAM == maLoai)).Count();
                lbTenLoai.Text = "" + (new BLL_DAL.QLShopDataContext().LOAISANPHAMs.Single(l => l.MALOAISANPHAM == maLoai).TENLOAISANPHAM);
            }
        }
        GroupControl grpTam = null;
        private void gridView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if ((e.IsGetData) && (e.Column.FieldName == "HINHANH"))
            {
                string fileName = gridView1.GetListSourceRowCellValue(e.ListSourceRowIndex, colHINHANH).ToString();
                e.Value = Bitmap.FromFile(Program.linkURL_SanPham+fileName);
            }
        }
        public bool flag = false;
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            quayTroLai();
            lbMaSP.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]) + "";
            lbTenSp.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[1]) + "";
            lbDonGia.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[2]) + " VNĐ";
            lbSoLuongTon.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[3]) + " Hàng";
            if (Boolean.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[4]) + "") == true)
                lbTrangThai.Text = "Còn hàng";
            else
                lbTrangThai.Text = "Hết hàng";
            if ((gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[6]) + "").Length > 150)
                lbMoTa.Text = (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[6]) + "").Substring(0, 150) + "...";
            else
                lbMoTa.Text = (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[6]) + "");
            picHinhAnh.Image = Image.FromFile(Program.linkURL_SanPham + gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[5]));

        }

        public void luuGrp()
        {
            foreach(Control ctr in Program.formTN.frmSP.grpSanPham.Controls)
            {
                Program.formTN.frmSP.grpTam.Controls.Add(ctr);
            }
        }

        public void quayTroLai()
        {
            if (flag == true)
            {
                flag = false;
                Program.formTN.frmSP.grpSanPham.Controls.Clear();
                foreach (Control ctr in Program.formTN.frmSP.grpTam.Controls)
                {
                    Program.formTN.frmSP.grpSanPham.Controls.Add(ctr);
                }
            }
        }

        private void btnMuaHang_Click(object sender, EventArgs e)
        {
            List<View_DSCTSP> lst = ctBLL.loadDSCTSP(int.Parse(lbMaSP.Text));
            var s = lbSoLuongTon.Text.Trim().Split(' ');
            if (int.Parse(lbSoLuongTon.Text.Trim().Split(' ')[0]) == 0) {
                MessageBox.Show("Số lượng tồn sản phẩm không đủ để lựa chọn mua. Mời bạn lựa chọn sản phẩm khác.");
                return;
            }
            if (lst.Count == 0)
            {
                MessageBox.Show("Sản phẩm này chưa được shop nhập chi tiết. Bạn vui lòng chọn sản phẩm khác.", "Thiếu chi tiết sản phẩm");
                return;
            }
            grpTam = new GroupControl();
            flag = true;
            luuGrp();
            SANPHAM sp =spBLL.detailSanpham(int.Parse(lbMaSP.Text));
            this.grpSanPham.Controls.Clear();
            _formCTSP = new ChonChiTietSP(lst);
            this.grpSanPham.Controls.Add(_formCTSP);
            _formCTSP.Dock = DockStyle.Fill;
        }
    }
}