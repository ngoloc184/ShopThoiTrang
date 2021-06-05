using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class NhanVien_BLLDAL
    {
        QLShopDataContext db = new QLShopDataContext();
        public List<NHANVIEN> loadNV()
        {
            return db.NHANVIENs.ToList();
        }
        public List<string> loaDSNV()
        {
            return db.NHANVIENs.Select(t=>t.MANHANVIEN+" - "+t.TENNHANVIEN).ToList();
        }
        public List<TAIKHOANNHANVIEN> loadTKNV()
        {
            return db.TAIKHOANNHANVIENs.ToList();
        }

        public Boolean kiemTraNhanVienDaTonTaiTrongHD(int maNV)
        {
            HOADON hd = db.HOADONs.Where(t => t.MANHANVIEN == maNV).FirstOrDefault();

            if (hd == null)
                return true;//cho phép xóa vì chauw có hóa đơn
            return false;
        }
        public void xoaNV(int maNV)
        {
            NHANVIEN nv = db.NHANVIENs.Where(t => t.MANHANVIEN == maNV).First();
            db.NHANVIENs.DeleteOnSubmit(nv);
            db.SubmitChanges();
        }

        public void suaNV(int maNV, string tenNV, DateTime ngaySinh, string gioiTinh, string sdt, string diaChi, string CMND, float luong, string tinhTrang, string chucVu)
        {
            NHANVIEN nv = db.NHANVIENs.Where(t => t.MANHANVIEN == maNV).FirstOrDefault();
            nv.MANHANVIEN = maNV;
            nv.TENNHANVIEN = tenNV;
            nv.NGAYSINH = ngaySinh;
            nv.GIOITINH = gioiTinh;
            nv.SDT = sdt;
            nv.DIACHI = diaChi;
            nv.CMND = CMND;
            nv.LUONG = luong;
            nv.TINHTRANG = tinhTrang;
            nv.CHUCVU = chucVu;

            db.SubmitChanges();
        }
        public NHANVIEN detailNV(int maNV)
        {
            return db.NHANVIENs.FirstOrDefault(nv => nv.MANHANVIEN == maNV);
        }
        public NHANVIEN load_OnlyNhanVien(int maTaiKhoan)
        {
            try
            {
                return db.NHANVIENs.Single(nv => nv.MANHANVIEN == maTaiKhoan);
            }
            catch
            {
                return null;
            }
        }
        public bool ThemNhanVien(NHANVIEN nv)
        {
            try
            {
                db.NHANVIENs.Attach(nv);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
       
    }
}
