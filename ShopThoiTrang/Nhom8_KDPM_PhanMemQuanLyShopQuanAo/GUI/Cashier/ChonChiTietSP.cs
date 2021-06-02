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

namespace GUI.Cashier
{
    public partial class ChonChiTietSP : DevExpress.XtraEditors.XtraUserControl
    {
        ChiTietSanPham_BLL ctBLL = new ChiTietSanPham_BLL();
        List<View_DSCTSP> vw = new List<View_DSCTSP>();
        CHITIETSANPHAM _ctsp = new CHITIETSANPHAM();
        CTHD_BLLDAL _ctBLL = new CTHD_BLLDAL();
        public ChonChiTietSP(List<View_DSCTSP> lstSP)
        {
            InitializeComponent();
            vw = lstSP;
            _ctsp = ctBLL.timDSCT(vw[0].MASANPHAM)[0];
            setupProduct(lstSP);            
        }
        private void setupProduct(List<View_DSCTSP> dssp)
        {
            lbTenSP.Text = dssp[0].TENSANPHAM;
            picHinhAnh.Image = Image.FromFile(Program.linkURL_Image + @"sanpham\" + dssp[0].HINHANH);
            lbSoLuong.Text = dssp[0].KHUYENMAI.ToString()+" Hàng";
            lbDonGia.Text = dssp[0].DONGIA.ToString()+" VNĐ";
            if(dssp[0].MOTA.Length>100)
                lbMoTa.Text = dssp[0].MOTA.Substring(0,100)+"...";
            else
                lbMoTa.Text = dssp[0].MOTA.Substring(0, 50) + "...";
            loadComboBox(dssp);
        }
        private void loadComboBox(List<View_DSCTSP> dssp)
        {
            //Combox chọn màu sản phẩm
            cboChonMau.DataSource = dssp;
            cboChonMau.DisplayMember = "TENMAU";
            cboChonMau.ValueMember = "MAMAU";
            //Combox chọn size sản phẩm
            cboChonSize.DataSource = dssp;
            cboChonSize.DisplayMember = "TENSIZE";
            cboChonSize.ValueMember = "MASIZE";

        }
        private void linkReturn_Click(object sender, EventArgs e)
        {
                //Program.formTN.frmSP.luuGrp();
            Program.formTN.frmSP.quayTroLai();
        }
        bool flag = false;
        private void lbMoTa_DoubleClick(object sender, EventArgs e)
        {
            if (flag == false)
            {
                this.txtSoLuong.Visible = false;
                this.tablePanel1.SetRowSpan(this.lbMoTa, 5);
                lbSL.Visible = false;
                lbMoTa.Text = _ctsp.SANPHAM.MOTA;
                flag = true;
            }
            else
            {
                this.txtSoLuong.Visible = true;
                this.tablePanel1.SetRowSpan(this.lbMoTa, 4);
                lbSL.Visible = true;
                if (_ctsp.SANPHAM.MOTA.Length > 100)
                    lbMoTa.Text = _ctsp.SANPHAM.MOTA.Substring(0, 100) + "...";
                else
                    lbMoTa.Text = _ctsp.SANPHAM.MOTA.Substring(0, 50) + "...";
                flag = false;
            }
        }

        private void cboChonMau_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Combox chọn size sản phẩm
            //cboChonSize.DataSource = vw.Where(v=>v.MASIZE==int.Parse(cboChonSize.SelectedValue.ToString())).ToList();
            //cboChonSize.DisplayMember = "TENSIZE";
            //cboChonSize.ValueMember = "MASIZE";
        }
        private bool kTraTrong()
        {
            if(String.IsNullOrEmpty(txtSoLuong.Text))
            {
                txtSoLuong.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(cboChonMau.Text))
            {
                cboChonMau.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(cboChonSize.Text))
            {
                cboChonSize.Focus();
                return false;
            }
            return true;
        }
        private void clear()
        {
            txtSoLuong.Text = "";
            cboChonMau.Text = "";
            cboChonSize.Text = "";
        }
        private void capNhatBuy(int num)
        {
            Program.formTN.flagBuy = true;
            Program.formTN.checkBuy(num);
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                Program.formTN.visibleBillCreating(true);
                if (!kTraTrong())
                {
                    MessageBox.Show("Thông tin bạn lựa chọn chưa đủ, vui lòng coi lại.");
                    return;
                }

                if (int.Parse(txtSoLuong.Text) < 1)
                {
                    MessageBox.Show("Số lượng mua phải ít nhất là 1 sản phẩm!", "Số lượng không đúng");
                    txtSoLuong.Focus();
                    return;
                }
                if (_ctsp.SANPHAM.KHUYENMAI > 0)
                {
                    if(Program.formTN.gioHang == null)
                    {
                        Program.formTN.gioHang = new HOADON();
                    }
                    if(Program.formTN.chiTietGioHang == null)
                    {
                        Program.formTN.chiTietGioHang = new List<CartItem>();
                    }
                    CartItem ct = new CartItem();
                    ct.MASANPHAM = _ctsp.MASANPHAM;
                    ct.MACHITIETSANPHAM = ctBLL.timCTSP(_ctsp.MASANPHAM, int.Parse(cboChonMau.SelectedValue.ToString()), int.Parse(cboChonSize.SelectedValue.ToString())).MACHITIETSP;
                    ct.TENSANPHAM = lbTenSP.Text;
                    ct.DONGIA = (int)_ctsp.SANPHAM.DONGIA;
                    ct.HINHANH = ctBLL.timHinhAnh(ct.MASANPHAM).HINHANH;
                    ct.SOLUONG = int.Parse(txtSoLuong.Text);
                    ct.TENMAU = cboChonMau.Text;
                    ct.TENSIZE = cboChonSize.Text;
                    ct.MAVACH = ctBLL.timCTSP(ct.MACHITIETSANPHAM).MAVACH;
                    //ct.iTenSanPham = (ct.DONGIABAN * ct.SOLUONG);
                    int num = Program.formTN.chiTietGioHang.FindIndex(_ct=>_ct.MACHITIETSANPHAM == ct.MACHITIETSANPHAM);
                    View_DSCTSP item = _ctBLL.getCTHD_CTSP(ct.MACHITIETSANPHAM);
                    if (num != -1)
                    {
                        if (Program.formTN.chiTietGioHang[num].SOLUONG + ct.SOLUONG > _ctsp.SANPHAM.KHUYENMAI)
                        {
                            MessageBox.Show("Số lượng mua đã vượt quá số lượng tồn. Không thể mua thêm, cảm ơn.", "Mua quá số lượng tồn");
                            return;
                        }
                        Program.formTN.chiTietGioHang[num].SOLUONG += (int)ct.SOLUONG;
                        capNhatBuy((int)ct.SOLUONG);
                        //Program.formTN.chiTietGioHang[num].thanhTien = ct.DONGIABAN * Program.formTN.chiTietGioHang[num].SOLUONG;
                        MessageBox.Show("Đã tăng mua thêm"+ ct.SOLUONG + " "+vw[0].TENSANPHAM + " size " + item.TENSIZE + " màu " + item.TENMAU + " thành công!");
                        clear();
                    }
                    else
                    {
                        capNhatBuy((int)ct.SOLUONG);
                        Program.formTN.chiTietGioHang.Add(ct);
                        MessageBox.Show("Chọn mua " + ct.SOLUONG + " sản phẩm "+ vw[0].TENSANPHAM + " size "+item.TENSIZE+" màu "+item.TENMAU+" thành công!");
                        clear();
                        Program.formTN.frmSP.quayTroLai();
                    }
                }
                else
                {
                    MessageBox.Show("Số lượng tồn sản phẩm không đủ để lựa chọn mua. Mời bạn lựa chọn sản phẩm khác.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSoLuong_Leave(object sender, EventArgs e)
        {

                if (int.TryParse(txtSoLuong.Text, out int num))
                {
                    if (int.Parse(txtSoLuong.Text) > ctBLL.timDSCT(vw[0].MASANPHAM)[0].SANPHAM.KHUYENMAI)
                    {
                        MessageBox.Show("Số lượng bạn mua không được lớn hơn số lượng tồn!", "Không đủ số lượng tồn");
                        txtSoLuong.Focus();
                        return;
                    }
                }
        }
    }
}      
