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
namespace GUI
{
    public partial class frmBieuDo : DevExpress.XtraEditors.XtraForm
    {
        public frmBieuDo()
        {
            InitializeComponent();
            cboNam.Properties.Items.Clear();
            var list = Enumerable.Range(2000, DateTime.Now.Year - 2000 + 1).ToList();
            cboNam.Properties.Items.AddRange(list);
        }

        ThongKe xl = new ThongKe();
        void BD_doanhthu(string nam)
        {
            // Create new DataTable and DataSource objects.
            DataTable table = new DataTable();
            xl = new ThongKe();
            // Declare DataColumn and DataRow variables.
            DataColumn column;
            DataRow row;
            DataView view;

            
            column = new DataColumn();

            column.DataType = System.Type.GetType("System.Double");
            column.ColumnName = "Thang";
            table.Columns.Add(column);

            // Create second column.
            column = new DataColumn();
            column.DataType = Type.GetType("System.Double");
            column.ColumnName = "TongTien_BAN";
            table.Columns.Add(column);

            // Create second column.
            column = new DataColumn();
            column.DataType = Type.GetType("System.Double");
            column.ColumnName = "TongTien_NHAP";
            table.Columns.Add(column);


            // Create new DataRow objects and add to DataTable.    
            for (int i = 1; i <= 12; i++)
            {
                if (xl.TONGTIENNHAP_NAM_THANG(nam, i.ToString()).Rows.Count > 0)
                {
                    if (xl.TienBan_NAM_THANG(nam, i.ToString()).Rows.Count > 0)
                    {
                        row = table.NewRow();
                        row["Thang"] = i;
                        row["TongTien_BAN"] = xl.TienBan_NAM_THANG(nam, i.ToString()).Rows[0]["TongTien"];
                        row["TongTien_NHAP"] = xl.TONGTIENNHAP_NAM_THANG(nam, i.ToString()).Rows[0]["TongTien"];
                        table.Rows.Add(row);
                    }
                    else
                    {
                        row = table.NewRow();
                        row["Thang"] = i;
                        row["TongTien_BAN"] = 0;
                        row["TongTien_NHAP"] = xl.TONGTIENNHAP_NAM_THANG(nam, i.ToString()).Rows[0]["TongTien"];
                        table.Rows.Add(row);
                    }
                }
                else
                {
                    if (xl.TienBan_NAM_THANG(nam, i.ToString()).Rows.Count > 0)
                    {
                        row = table.NewRow();
                        row["Thang"] = i;
                        row["TongTien_BAN"] = xl.TienBan_NAM_THANG(nam, i.ToString()).Rows[0]["TongTien"];
                        row["TongTien_NHAP"] = 0;
                        table.Rows.Add(row);
                    }
                    else
                    {
                        row = table.NewRow();
                        row["Thang"] = i;
                        row["TongTien_BAN"] = 0;
                        row["TongTien_NHAP"] = 0;
                        table.Rows.Add(row);
                    }
                }

            }

            // Create a DataView using the DataTable.
            view = new DataView(table);

            // Set a DataGrid control's DataSource to the DataView.
            //dataGrid1.DataSource = view;


            //Load vào biểu đồ

            chart1.DataSource = view;
            //chart1.Series["Nhập hàng"].ArgumentDataMember = "Thang";
            chart1.Series["Bán hàng"].XValueMember = "Thang";
            chart1.Series["Bán hàng"].YValueMembers = "TongTien_BAN";


            chart1.Series["Nhập hàng"].XValueMember = "Thang";
            chart1.Series["Nhập hàng"].YValueMembers = "TongTien_NHAP";


            //Biểu đồ thống kê doanh thu 
            chart1.Titles[0].Text = "Biểu đồ thống kê Nhập hàng - Bán hàng của cửa hàng trong năm " + nam;
            chart1.DataBind();
        }
        
        string nam = "";
        private void comboBoxEx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            nam = cboNam.Text.Trim();
            BD_doanhthu(nam);
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (cboNam.Text=="")
            {
                MessageBox.Show("Vui lòng chọn năm");
            }
            else
            {
                BD_doanhthu(cboNam.Text);

            }
        }
        //Tạo datatable lưu dữ liệu
        void BD_HangHoabanduoc(string ngaybatdau, string ngayketthuc, string chuoi)
        {

            //chart1.Series["Nhập hàng"].ArgumentDataMember = "Thang";
            if (cboHH.Text.Trim() == "Hàng hoá bán")
            {
                chart2.DataSource = xl.SanPhamban(ngaybatdau, ngayketthuc);
            }
            else if (cboHH.Text.Trim() == "Hàng hoá nhập")
            {
                chart2.DataSource = xl.SanPhamNhap(ngaybatdau, ngayketthuc);
            }
            chart2.Series["Sản phẩm"].XValueMember = "TENSANPHAM";
            chart2.Series["Sản phẩm"].YValueMembers = "soluong";

            //Biểu đồ thống kê doanh thu khách sạn và tour trong năm
            chart2.Titles[0].Text = "Biểu đồ thống kê số lượng " + chuoi + " từ " + dateBD.Text.ToString() + " đến ngày " + dateKT.Text.ToString();
            chart2.DataBind(); 
        }
        

        private void btnXem2_Click(object sender, EventArgs e)
        {
            if (cboHH.Text.Trim() == "Hàng hoá bán")
            {
                BD_HangHoabanduoc(dateBD.Text.ToString(), dateKT.Text.ToString(), "hàng hoá bán");
            }
            else if (cboHH.Text.Trim() == "Hàng hoá nhập")
            {
                BD_HangHoabanduoc(dateBD.Text.ToString(), dateKT.Text.ToString(), "hàng hoá nhập");
            }
        }
        
    }
}