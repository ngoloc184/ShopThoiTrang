using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class ThongKe
    {
        public string ChuoiKN = @"Data Source=.\sqlexpress;Initial Catalog=QLSHOPTHOITRANG;Integrated Security=True";
        public DataTable LayDuLieu(string lenhSql)
        {
            DataTable kq = new DataTable();
            SqlConnection ketnoi = new SqlConnection(ChuoiKN);
            SqlDataAdapter boDocGhi = new SqlDataAdapter(lenhSql, ketnoi);
            boDocGhi.Fill(kq);
            return kq;
        }
        public void ThucHienLenh(string lenh)
        {
            SqlConnection kn = new SqlConnection(ChuoiKN);
            kn.Open();
            SqlCommand cmd = new SqlCommand(lenh, kn);
            cmd.ExecuteNonQuery();
            kn.Close();
        }

        //Biểu đồ
        public DataTable TienBan_NAM_THANG(string nam, string thang)
        {
            string codeSQL = "SELECT   SUM(CHITIETHOADON.SOLUONG) AS 'soluong', SUM(CAST(CHITIETHOADON.DONGIABAN as DECIMAL(38))*CAST(CHITIETHOADON.SOLUONG as DECIMAL(38))) AS 'TongTien' FROM     CHITIETHOADON INNER JOIN CHITIETSANPHAM ON CHITIETHOADON.MACHITIETSP = CHITIETSANPHAM.MACHITIETSP INNER JOIN HOADON ON CHITIETHOADON.MAHOADON = HOADON.MAHOADON WHERE    MONTH(HOADON.NGAYTAO) = "+thang+" AND YEAR(HOADON.NGAYTAO )= "+nam;
            return LayDuLieu(codeSQL);
        }
        public DataTable TONGTIENNHAP_NAM_THANG(string nam, string thang)
        {
            string codeSQL = "SELECT   SUM(CHITIETPHIEUNHAP.SOLUONG) AS 'soluong', SUM(CAST(CHITIETPHIEUNHAP.DONGIA as DECIMAL(38))*CAST(CHITIETPHIEUNHAP.SOLUONG as DECIMAL(38))) as 'TongTien' from CHITIETSANPHAM,CHITIETPHIEUNHAP,PHIEUNHAP  where CHITIETSANPHAM.MACHITIETSP =CHITIETPHIEUNHAP.MACHITIETSP and PHIEUNHAP.MAPHIEUNHAP=CHITIETPHIEUNHAP.MAPHIEUNHAP and YEAR(PHIEUNHAP.NGAYLAP)= " + nam+ " and MONTH(PHIEUNHAP.NGAYLAP)=" + thang;
            return LayDuLieu(codeSQL);
        }

        public DataTable SanPhamNhap(string ngaybatdau, string ngayketthuc)
        {
            string codeSQL = "select SANPHAM.MASANPHAM, SANPHAM.TENSANPHAM, sum(CHITIETPHIEUNHAP.SOLUONG) AS 'soluong', SUM(CAST(CHITIETPHIEUNHAP.DONGIA as DECIMAL(38))*CAST(CHITIETPHIEUNHAP.SOLUONG as DECIMAL(38))) as 'TongTien' from CHITIETSANPHAM, SANPHAM,CHITIETPHIEUNHAP,PHIEUNHAP where CHITIETSANPHAM.MASANPHAM = SANPHAM.MASANPHAM and CHITIETSANPHAM.MACHITIETSP=CHITIETPHIEUNHAP.MACHITIETSP and PHIEUNHAP.MAPHIEUNHAP=CHITIETPHIEUNHAP.MAPHIEUNHAP and  (PHIEUNHAP.NGAYLAP >= CAST('" + ngaybatdau+"' as date)) AND (PHIEUNHAP.NGAYLAP <=  CAST('"+ngayketthuc+"' as date)) GROUP BY SANPHAM.MASANPHAM, SANPHAM.TENSANPHAM ";
            return LayDuLieu(codeSQL);
        }
        public DataTable SanPhamban(string ngaybatdau, string ngayketthuc)
        {
            string codeSQL = "SELECT SANPHAM.MASANPHAM, SANPHAM.TENSANPHAM, SUM(CHITIETHOADON.SOLUONG) AS 'soluong', SUM(CAST(CHITIETHOADON.DONGIABAN as DECIMAL(38))*CAST(CHITIETHOADON.SOLUONG as DECIMAL(38))) AS 'TongTien'  FROM     CHITIETHOADON INNER JOIN CHITIETSANPHAM ON CHITIETHOADON.MACHITIETSP = CHITIETSANPHAM.MACHITIETSP INNER JOIN HOADON ON CHITIETHOADON.MAHOADON = HOADON.MAHOADON INNER JOIN SANPHAM ON CHITIETSANPHAM.MASANPHAM = SANPHAM.MASANPHAM WHERE (HOADON.NGAYTAO >= CAST('" + ngaybatdau + "' as date)) AND (HOADON.NGAYTAO <=  CAST('" + ngayketthuc + "' as date)) GROUP BY SANPHAM.MASANPHAM, SANPHAM.TENSANPHAM";
            return LayDuLieu(codeSQL);
        }
    }
}
