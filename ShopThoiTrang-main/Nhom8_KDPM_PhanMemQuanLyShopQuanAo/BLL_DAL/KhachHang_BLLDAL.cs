using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class KhachHang_BLLDAL
    {
        QLSHOPDataContext db = new QLSHOPDataContext();
        public KHACHHANG TimKhachHang(string tenKH)
        {
            return db.KHACHHANGs.Where(t => t.TENKHACHHANG == tenKH).FirstOrDefault();
        }
        public List<String> listKH()
        {
            return db.KHACHHANGs.Select(t => t.TENKHACHHANG).ToList();
        }
        public void themKH(string tenKH)
        {
            KHACHHANG a = new KHACHHANG();
            a.TENKHACHHANG = tenKH;
            db.KHACHHANGs.InsertOnSubmit(a);
            db.SubmitChanges();

        }
        public KHACHHANG timKHTheoMaKH(int maKH)
        {
            return db.KHACHHANGs.Where(t => t.MAKHACHHANG == maKH).FirstOrDefault();

        }
        public void themMoi(KHACHHANG a)
        {
            db.KHACHHANGs.InsertOnSubmit(a);
            db.SubmitChanges();

        }
        public Boolean xoaKH(int maKH)
        {
            KHACHHANG kh = db.KHACHHANGs.Where(t => t.MAKHACHHANG == maKH).FirstOrDefault();
            HOADON hd = db.HOADONs.Where(t => t.MAKHACHHANG == maKH).FirstOrDefault();
            if (hd != null)
            {
                return false;
            }
            db.KHACHHANGs.DeleteOnSubmit(kh);
            db.SubmitChanges();
            return true;
        }
        public void suaKH(int maKH,string tenKH,string diaChi,string gioiTinh,DateTime ngaySinh,string sdt,string email)
        {
            KHACHHANG kh = db.KHACHHANGs.Where(t => t.MAKHACHHANG == maKH).FirstOrDefault();
            kh.TENKHACHHANG = tenKH;
            kh.DIACHI = diaChi;
            kh.GIOITINH = gioiTinh;
            kh.NGAYSINH = ngaySinh;
            kh.SDT = sdt;
            kh.EMAIL = email;
            db.SubmitChanges();
        }
        public KHACHHANG timKHtheoSDT(string sdt)
        {
            try
            {
                return db.KHACHHANGs.Single(t => t.SDT == sdt);
            }
            catch(Exception ex)
            {
                return null;
            }
        }
        public void TaoHoaDon(Cart GH, KHACHHANG kh)
        {

            // KHACHHANG khach = data.KHACHHANGs.Where(t => t.TENKHACHHANG == a.TENKHACHHANG).FirstOrDefault();
            //lưu hoa don

            int tong = 0;
            //kiem tra
            HOADON kiemTraHD = db.HOADONs.Where(t => t.MAKHACHHANG == kh.MAKHACHHANG).FirstOrDefault();
            if(kiemTraHD!=null)
                tong = int.Parse(db.HOADONs.Where(t => t.MAKHACHHANG == kh.MAKHACHHANG).Select(h => h.THANHTIEN).Sum().ToString());

            HOADON hd = new HOADON();
            hd.MANHANVIEN = 1;
            hd.MAKHACHHANG = kh.MAKHACHHANG;
            hd.NGAYTAO = DateTime.Now;
          //  kiem tra khach hàng thân thiết:

            //if (tong >= 5000000 && GH.tongThanhTien() > 1000000)
            //{
            //    hd.THANHTIEN = int.Parse((GH.tongThanhTien() * 0.85).ToString());
            //}
            //if (GH.tongThanhTien() > 1000000)
            //{
            //    hd.THANHTIEN = int.Parse((GH.tongThanhTien() * 0.9).ToString());
            //}
            //else { 
            //    hd.THANHTIEN = GH.tongThanhTien();
            //}
            db.HOADONs.InsertOnSubmit(hd);
            db.SubmitChanges();

            //luu chi tiet hao don
            foreach (CartItem sp in GH.dsSP)
            {
                CHITIETHOADON ct = new CHITIETHOADON();
                if (DateTime.Now.Month == 5 && GH.tongThanhTien() >=1000000)
                {
                    ct.THANHTIEN = int.Parse((sp.thanhTien).ToString());
                    //ct.KHUYENMAI= int.Parse((sp.thanhTien).ToString());
                }
                else
                {
                    ct.THANHTIEN = sp.thanhTien;
                }
                ct.MAHOADON = hd.MAHOADON;
                ct.MACHITIETSP = sp.iMaChiTietSP;
                ct.DONGIABAN = int.Parse(sp.iDonGia.ToString());
                ct.SOLUONG = sp.iSoLuong;
                db.CHITIETHOADONs.InsertOnSubmit(ct);
                db.SubmitChanges();
            }
            //foreach (CartItem item in GH.dsSP)
            //{
            //    SANPHAM sp = db.SANPHAMs.Where(t => t.MASANPHAM == item.iMaSanPham).FirstOrDefault();
            //    sp.SOLUONGTON -= item.iSoLuong;
            //    if (sp.SOLUONGTON == 0)
            //    {
            //        sp.TRANGTHAI = false;
            //    }
            //    db.SubmitChanges();
            //}

        }
    }
}
