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
    public partial class FormGioHang : Form
    {
        public FormGioHang()
        {
            InitializeComponent();
        }
        SanPham_BLLDAL sanPhamBLL = new SanPham_BLLDAL();
        private void FormGioHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSHOPDataSet.DataTable1' table. You can move, or remove it, as needed.
            Load_GH();
        }
        public void Load_GH()
        {
            //dataGridView1.DataSource = Program.dsGH.dsSP.ToList();

              dataGridView1.DataSource = Program.dsGH.dsSP.ToList();
            lbTongTien.Text = "Tổng tiền:" + Program.dsGH.tongThanhTien();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dataGridView1.Columns[e.ColumnIndex].Name == "Plus")
            //{
            //    int ma = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            //    if (sanPhamBLL.kiemTraSLTon(Program.dsGH, ma) == "duyệt")
            //    {
            //        Program.soLuong++;
            //        Program.dsGH.Them(ma, 1);
            //        Load_GH();
            //        return;
            //    }
            //    MessageBox.Show(sanPhamBLL.kiemTraSLTon(Program.dsGH, ma) + " ");
            //}
            //if (dataGridView1.Columns[e.ColumnIndex].Name == "Minus")
            //{
            //    int ma = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            //    Boolean kq = Program.dsGH.giamSL(ma);
            //    if (kq == true)
            //    {
            //        Load_GH();
            //        return;
            //    }
            //    MessageBox.Show("Số lượng còn lại là 1: Nếu không mua SP này vui lòng nhấn Button Delete");
            //}
            //if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            //{
            //    SANPHAM sanpham = sanPhamBLL.detailSanpham(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            //    if (MessageBox.Show("Bạn có chắc muốn xóa "+sanpham.TENSANPHAM+"?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    {
            //        MessageBox.Show("Đã xóa khỏi giỏ hàng!");
            //        Program.dsGH.XoaItem(sanpham.MASANPHAM);
            //        Load_GH();
            //        return;


            //    }
            //}
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            ////Tao Gio Hang
            //if (Program.dsGH.dsSP.Count == 0)
            //{
            //    MessageBox.Show("Giỏ hàng rỗng rồi!");
            //    return;
            //}
            //KhachHang_BLLDAL a = new KhachHang_BLLDAL();
            //KHACHHANG kh = new KHACHHANG();
            //if (txtSDT.Text.Length == 0)
            //{
            //    MessageBox.Show("Quên điền sdt khách hàng rồi!");
            //    return;
            //}


            //kh = a.timKHtheoSDT(txtSDT.Text);
            //if (kh == null)
            //{
            //    if (MessageBox.Show("Khách hàng này chưa có thông tin!\n Vui lòng chọn YES để thêm thông tin hoặc ghi sdt là NO!", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //    {
            //        FormTaoThanhVienKhachHang frmtaoKH = new FormTaoThanhVienKhachHang();
            //        frmtaoKH.Show();
            //        return;
            //    }

            //}
            //else
            //{
            //    kh = a.timKHtheoSDT(txtSDT.Text);
            //    a.TaoHoaDon(Program.dsGH, kh);
            //    MessageBox.Show("Hóa đơn đã được ghi nhận!");
            //    Program.dsGH.dsSP.Clear();
            //    Program.soLuong = 0;
            //    FormSanPham frm = new FormSanPham();
            //    frm.Show();
            //    this.Hide();
            //}
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc HỦY GIỎ HÀNG?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Đã Hủy Thanh Toán!");
                Program.dsGH.dsSP.Clear();
                Program.soLuong = 0;
                FormSanPham frm = new FormSanPham();
                frm.Show();
                this.Hide();
                return;


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormSanPham frm = new FormSanPham();
            frm.Show();
            this.Hide();
        }

        private void btnTang_Click(object sender, EventArgs e)
        {
            //int ma = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            //if (sanPhamBLL.kiemTraSLTon(Program.dsGH, ma) == "duyệt")
            //{
            //    Program.soLuong++;
            //    Program.dsGH.Them(ma, 1);
            //    Load_GH();
            //    lbThongBao.Text = "Đã tăng thêm 1";
            //    return;
            //}
            //MessageBox.Show(sanPhamBLL.kiemTraSLTon(Program.dsGH, ma) + " ");
        }

        private void btnGiam_Click(object sender, EventArgs e)
        {
          
                int ma = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                Boolean kq = Program.dsGH.giamSL(ma);
                if (kq == true)
                {
                    Load_GH();
                    lbThongBao.Text = "Đã giảm đi 1";
                    return;
                }
                MessageBox.Show("Số lượng còn lại là 1: Nếu không mua SP này vui lòng nhấn Button Delete");
        }
    }
}

