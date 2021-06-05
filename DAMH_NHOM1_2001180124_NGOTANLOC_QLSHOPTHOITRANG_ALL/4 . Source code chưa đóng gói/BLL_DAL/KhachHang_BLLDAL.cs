using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class KhachHang_BLLDAL
    {
        QLShopDataContext db = new QLShopDataContext();
        public IQueryable<KHACHHANG> layDSKH()
        {
            return db.KHACHHANGs.Select(t => t);
        }
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
        public bool themMoi(KHACHHANG a)
        {
            try
            {
                db.KHACHHANGs.InsertOnSubmit(a);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Boolean xoaKH(int maKH)
        {
            KHACHHANG kh = db.KHACHHANGs.Where(t => t.MAKHACHHANG == maKH).FirstOrDefault();
            if (kh != null)
            {
                HOADON hd = db.HOADONs.Where(t => t.MAKHACHHANG == maKH).FirstOrDefault();
                if (hd != null)
                {
                    return false;
                }
                db.KHACHHANGs.DeleteOnSubmit(kh);
                db.SubmitChanges();
                return true;
            }
            return false;
        }
        public bool suaKH(int maKH,string tenKH,string diaChi,string gioiTinh,DateTime ngaySinh,string sdt,string email,string picHinhAnh)
        {
            try
            {
                KHACHHANG kh = db.KHACHHANGs.Where(t => t.MAKHACHHANG == maKH).FirstOrDefault();
                kh.TENKHACHHANG = tenKH;
                kh.DIACHI = diaChi;
                kh.GIOITINH = gioiTinh;
                kh.NGAYSINH = ngaySinh;
                kh.SDT = sdt;
                if(!picHinhAnh.Equals("xtraOpenFileDialog1"))
                    kh.HINHANH = picHinhAnh;
                kh.EMAIL = email;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
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
       
    }
}
