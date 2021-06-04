using BLL_DAL;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using GUI.Cashier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GUI.V_BaoHanh;
namespace GUI
{
    static class Program
    {
        
        public static FormLogin frmLogin;
        public static string linkURL_Image = @"E:\Hoc\CNPM\GopDoAn\ShopThoiTrang\ShopThoiTrang\Nhom8_KDPM_PhanMemQuanLyShopQuanAo\Image\";
        public static string linkURL_SanPham = @"E:\Hoc\CNPM\GopDoAn\ShopThoiTrang\ShopThoiTrang\Nhom8_KDPM_PhanMemQuanLyShopQuanAo\Image\sanpham\";
        public static string linkURL_LoaiSP = @"E:\Hoc\CNPM\GopDoAn\ShopThoiTrang\ShopThoiTrang\Nhom8_KDPM_PhanMemQuanLyShopQuanAo\Image\loaisanpham\";
        public static string linkURL_KhachHang = @"E:\Hoc\CNPM\GopDoAn\ShopThoiTrang\ShopThoiTrang\Nhom8_KDPM_PhanMemQuanLyShopQuanAo\Image\KhachHang\";
        public static string linkURL_NhanVien = @"E:\Hoc\CNPM\GopDoAn\ShopThoiTrang\ShopThoiTrang\Nhom8_KDPM_PhanMemQuanLyShopQuanAo\Image\nhanvien\"; 
        public static FormTN formTN =null;
        public static List<CHITIETHOADON> dsBaoHanh = new List<CHITIETHOADON>();
        public static Cart dsPhieuNhap = new Cart();
        public static Cart dsGH = new Cart();
        public static int soLuong = Program.dsGH.tongSoLuong();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmBieuDo ());

        }
    }
}
