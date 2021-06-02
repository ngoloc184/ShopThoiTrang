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
    public partial class FormGiamGia : Form
    {
        GiamGia_BLLDAL g = new GiamGia_BLLDAL();
        public FormGiamGia()
        {
            InitializeComponent();
        }

        private void gcGiamGia_Click(object sender, EventArgs e)
        {
            int maGG = int.Parse(gridView1.GetFocusedRowCellValue("MAGIAMGIA").ToString());
            GIAMGIA giam = g.layGG(maGG);
            txtGiaTri.Text = giam.GIATRITOIDA.ToString();
            txtMaGG.Text = giam.MAGIAMGIA.ToString();
            txtMoTa.Text = giam.MOTA;
            txtTenGG.Text = giam.TENGIAMGIA;
            txtYeuCau.Text = giam.DONHANGTU.ToString();
            txtMucGG.Text = giam.MUCGIAMGIA.ToString();
            dtpNgayBD.Text = giam.NGAYBD.ToString();
            dtpNgayKT.Text = giam.NGAYKT.ToString();
        }

        private void FormGiamGia_Load(object sender, EventArgs e)
        {
            txtMaGG.Enabled = false;
            gcGiamGia.DataSource = g.layDSGG();

        }

        private void btnTaoMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtGiaTri.Clear();
            txtMaGG.Clear();
            txtMoTa.Clear();
            txtMucGG.Clear();
            txtYeuCau.Clear();
            txtTenGG.Clear();
            dtpNgayBD.Text = DateTime.Now.ToString();
            dtpNgayKT.Text = DateTime.Now.ToString();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GiamGia_BLLDAL g = new GiamGia_BLLDAL();
            if (dtpNgayBD.Value > dtpNgayKT.Value)
            {
                MessageBox.Show("Vui lòng chọn ngày bắt đầu lớn hơn ngày kết thúc");
            }
            else if (txtTenGG.Text == "" || txtGiaTri.Text == "" || txtMoTa.Text == "" || txtMucGG.Text == "" || txtYeuCau.Text == "")
            {
                MessageBox.Show("Không được để trống các thông tin");
            }
            else
            {
                if (txtMaGG.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn dòng muốn sửa thông tin");
                }
                else
                {
                    GIAMGIA gg = new GIAMGIA();
                    gg.MAGIAMGIA = int.Parse(txtMaGG.Text);
                    gg.NGAYBD = dtpNgayBD.Value;
                    gg.NGAYKT = dtpNgayKT.Value;
                    gg.MUCGIAMGIA = double.Parse(txtMucGG.Text);
                    gg.MOTA = txtMoTa.Text;
                    gg.GIATRITOIDA = int.Parse(txtGiaTri.Text);
                    gg.DONHANGTU = int.Parse(txtYeuCau.Text);
                    gg.TENGIAMGIA = txtTenGG.Text;
                    g.suaGG(gg);
                    gcGiamGia.DataSource = g.layDSGG();
                    MessageBox.Show("Sửa thành công giảm giá " + gg.MAGIAMGIA);
                    dtpNgayBD.Text = DateTime.Now.ToString();
                    dtpNgayKT.Text = DateTime.Now.ToString();
                    txtGiaTri.Clear();
                    txtMoTa.Clear();
                    txtMaGG.Clear();
                    txtTenGG.Clear();
                    txtYeuCau.Clear();
                    txtMucGG.Clear();
                }

            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dtpNgayBD.Value > dtpNgayKT.Value)
            {
                MessageBox.Show("Vui lòng chọn ngày bắt đầu lớn hơn ngày kết thúc");
            }
            else if (txtTenGG.Text == "" || txtGiaTri.Text == "" || txtMoTa.Text == "" || txtMucGG.Text == "" || txtYeuCau.Text == "")
            {
                MessageBox.Show("Không được để trống các thông tin");

            }
            else if (txtMaGG.Text != "")
            {
                MessageBox.Show("Vui lòng bấm tạo mới");
            }
            else
            {
                GIAMGIA gg = new GIAMGIA();
                gg.NGAYBD = dtpNgayBD.Value;
                gg.NGAYKT = dtpNgayKT.Value;
                gg.MUCGIAMGIA = double.Parse(txtMucGG.Text);
                gg.MOTA = txtMoTa.Text;
                gg.GIATRITOIDA = int.Parse(txtGiaTri.Text);
                gg.DONHANGTU = int.Parse(txtYeuCau.Text);
                gg.TENGIAMGIA = txtTenGG.Text;
                g.themGG(gg);
                gcGiamGia.DataSource = g.layDSGG();
                MessageBox.Show("Thêm thành công");
                dtpNgayBD.Text = DateTime.Now.ToString();
                dtpNgayKT.Text = DateTime.Now.ToString();
                txtGiaTri.Clear();
                txtMoTa.Clear();
                txtMaGG.Clear();
                txtTenGG.Clear();
                txtYeuCau.Clear();
                txtMucGG.Clear();
            }
        }

        private void btnQuayLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Menu_Ribbon menu = new Menu_Ribbon();
            menu.Show();
            this.Hide();
        }

        private void txtGiaTri_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtMucGG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && (e.KeyChar != '.' || (e.KeyChar == '.' && (txtMucGG.Text.Length == 0 || txtMucGG.Text.IndexOf('.') != -1))))
                e.Handled = true;
        }

        private void txtYeuCau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
