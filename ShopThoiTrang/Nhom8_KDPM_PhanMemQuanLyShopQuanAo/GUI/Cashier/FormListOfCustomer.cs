﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.IO;
using DevExpress.XtraEditors.Repository;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using BLL_DAL;
using DevExpress.Utils;
using System.Collections;
using DevExpress.XtraGrid.Views.Grid;

namespace GUI.Cashier
{
    public partial class FormListOfCustomer : DevExpress.XtraEditors.XtraUserControl
    {
        KhachHang_BLLDAL kh = new KhachHang_BLLDAL();
        public FormListOfCustomer()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            kHACHHANGsBindingSource.DataSource = new BLL_DAL.QLShopDataContext().KHACHHANGs;
            addImage();
            //RepositoryItemPictureEdit rePictureEdit = gridControl1.RepositoryItems.Add("PictureEdit") as RepositoryItemPictureEdit;
            //rePictureEdit.NullText = " ";
            //rePictureEdit.SizeMode = PictureSizeMode.Squeeze;
            //gridView1.Columns[9].
            //gridView1.Columns[7].ColumnEdit = rePictureEdit;
            //string path = @"D:\CongNghePhanMem\ShopThoiTrang\Nhom8_KDPM_PhanMemQuanLyShopQuanAo\Image\KhachHang\";
            //gridView1.SetRowCellValue(0, gridView1.Columns[7], Image.FromFile(path + "male.jpg"));
            //gridView1.BestFitColumns();
        }

        public void addImage()
        {
            List<KHACHHANG> dsKH = kh.layDSKH().ToList();
            for (int i =0; i<gridView1.DataRowCount;i++)
            {
                RepositoryItemTextEdit textEdit = new RepositoryItemTextEdit();
                textEdit.ContextImageOptions.Image = Image.FromFile(@"D:\CongNghePhanMem\ShopThoiTrang\Nhom8_KDPM_PhanMemQuanLyShopQuanAo\Image\KhachHang\" + dsKH[i].HINHANH) ;
                gridView1.SetRowCellValue(i,gridView1.Columns.ColumnByFieldName("HinhAnh"),textEdit);
                gridControl1.RepositoryItems.Add(textEdit);
            }
        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn hủy bỏ thông tin khách hàng " + gridView1.GetRowCellValue(gridView1.FocusedRowHandle,gridView1.Columns[1]) + " không?", "Xóa khách hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (r == DialogResult.Yes)
            {
                if (gridView1.GetFocusedRowCellValue("MAKHACHHANG") == null)
                {
                    this.kHACHHANGsBindingSource.CancelEdit();
                    //MessageBox.Show("xóa thông tin thất bại !");
                }
                else
                {
                    this.kHACHHANGsBindingSource.RemoveCurrent();
                    //QLShopDataContext db = new QLShopDataContext();
                    if (!kh.xoaKH(int.Parse(gridView1.GetRowCellValue(gridView1.GetFocusedDataSourceRowIndex(),"MAKHACHHANG")+"")))
                        MessageBox.Show("xóa thông tin thất bại !");
                    //this.kHACHHANGsBindingSource.RemoveCurrent();
                    //Program.formTN.chiTietGioHang.Remove(Program.formTN.chiTietGioHang.Find(t => t.MAVACH == gridView1.GetFocusedRowCellValue("MAVACH") + ""));
                }
            }
        }
        private bool kiemTraTrong() {
            if (String.IsNullOrEmpty(txtTenKhachHang.Text))
            {
                txtTenKhachHang.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtDiaChi.Text))
            {
                txtDiaChi.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(cboGioiTinh.Text))
            {
                cboGioiTinh.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(dateNgaySinh.Text))
            {
                dateNgaySinh.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtSDT.Text))
            {
                txtSDT.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                txtEmail.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(picHinhAnh.Text))
            {
                picHinhAnh.Focus();
                return false;
            }
            return true;
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            btnLuu.Enabled = false ;
            btnClear.Enabled = false;
            btnCapNhat.Enabled = true;
            optionEnable(false);
            lbMaKH.Text = gridView1.GetFocusedRowCellValue("MAKHACHHANG") + "";
            txtTenKhachHang.Text = gridView1.GetFocusedRowCellValue("TENKHACHHANG") + "";
            txtDiaChi.Text = gridView1.GetFocusedRowCellValue("DIACHI") + "";
            if ((gridView1.GetFocusedRowCellValue("GIOITINH") + "").Equals("Nam"))
                cboGioiTinh.SelectedIndex = 0;
            else
                cboGioiTinh.SelectedIndex = 1;
            dateNgaySinh.Text = gridView1.GetFocusedRowCellValue("NGAYSINH")+"";
            txtSDT.Text = gridView1.GetFocusedRowCellValue("SDT") + "";
            txtEmail.Text = gridView1.GetFocusedRowCellValue("EMAIL") + "";
            if ((gridView1.GetFocusedRowCellValue("HINHANH") + ""!= null))
                picHinhAnh.Image = Image.FromFile(Program.linkURL_Image + @"KhachHang\" + gridView1.GetFocusedRowCellValue("HINHANH") + "");
            txtDiemTichLuy.Text = gridView1.GetFocusedRowCellValue("DIEMTICHLUY") + "";

        }
        private void optionEnable(bool flag)
        {
            txtTenKhachHang.Enabled = flag;
            txtDiaChi.Enabled = flag;
            cboGioiTinh.Enabled = flag;
            dateNgaySinh.Enabled = flag;
            txtSDT.Enabled = flag;
            txtEmail.Enabled = flag;
            picHinhAnh.Enabled = flag;
        }
        private void clear()
        {
            txtTenKhachHang.Text = "";
            txtDiaChi.Text = "";
            cboGioiTinh.Text = "";
            dateNgaySinh.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
            picHinhAnh.Text = "";
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnClear.Enabled = true;
            btnCapNhat.Enabled = false;
            optionEnable(true);
            lbTB.Text = "";
        }

        private void picHinhAnh_DoubleClick(object sender, EventArgs e)
        {
            xtraOpenFileDialog1.InitialDirectory = Program.linkURL_Image + @"KhachHang\" ;
            xtraOpenFileDialog1.Title = "Browse Text Files";
            if (xtraOpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picHinhAnh.Image = Image.FromFile(xtraOpenFileDialog1.FileName);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn lưu lại thông tin mới của khách hàng không ?", "Lưu thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                if (!kiemTraTrong()) {
                    MessageBox.Show("Thông tin bạn điền còn thiếu. Vui lòng bổ sung", "Thiếu thông tin");
                    return;
                }
                string pic = System.IO.Path.GetFileName(xtraOpenFileDialog1.FileName);
                if (kh.suaKH(int.Parse(lbMaKH.Text), txtTenKhachHang.Text, txtDiaChi.Text, cboGioiTinh.Text, DateTime.Parse(dateNgaySinh.Text), txtSDT.Text, txtEmail.Text, pic) )
                {
                    lbTB.Text = "Thông tin khách hàng " + txtTenKhachHang.Text + " đã được cập nhật";
                    btnLuu.Enabled = false;
                    btnClear.Enabled = false;
                    btnCapNhat.Enabled = true;
                    optionEnable(false);
                    kHACHHANGsBindingSource.DataSource = new BLL_DAL.QLShopDataContext().KHACHHANGs;
                }
            }
        }

        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {
            kHACHHANGsBindingSource.DataSource = new BLL_DAL.QLShopDataContext().KHACHHANGs;
        }
    }
}
