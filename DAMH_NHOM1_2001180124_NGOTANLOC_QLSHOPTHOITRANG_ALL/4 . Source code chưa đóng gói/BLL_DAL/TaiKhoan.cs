using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class TaiKhoan
    {

        QLShopDataContext dbContext = new QLShopDataContext();
        public TAIKHOANNHANVIEN FindTaiKhoan(string tenTaiKhoan, string matKhau)
        {
            try
            {
                List<TAIKHOANNHANVIEN> db = dbContext.TAIKHOANNHANVIENs.ToList();
                return dbContext.TAIKHOANNHANVIENs.Single(tk => tk.TENTAIKHOAN.Equals(tenTaiKhoan) && tk.MATKHAU.Equals(matKhau));
            }
            catch
            {
                return null;
            }
        }
        public TAIKHOANNHANVIEN FindTaiKhoan(int maTK)
        {
            try
            {
                List<TAIKHOANNHANVIEN> db = dbContext.TAIKHOANNHANVIENs.ToList();
                return dbContext.TAIKHOANNHANVIENs.Single(tk => tk.MATAIKHOAN.Equals(maTK));
            }
            catch
            {
                return null;
            }
        }
        public string FindPassword(string name, string email,string sdt)
        {
            //var taikhoan = dbContext.TAIKHOANNHANVIENs.Join(dbContext.NHANVIENs, tk => tk.MANHANVIEN, nv => nv.MANHANVIEN
            //, (tk, nv) => new
            //{
            //    pass = tk.MATKHAU,
            //    user = tk.TENTAIKHOAN,
            //    email = nv.EMAIL,
            //    sdt = nv.SDT
            //}).Where(a => a.user == name && a.sdt == sdt && a.email == email);
            //if (taikhoan.Select(t=>t.pass).AsEnumerable() == null)
            //    return null;
            //else
            //    return (IQueryable<TAIKHOANNHANVIEN>)taikhoan.Where(a => a.user == name && a.sdt == sdt && a.email == email).AsQueryable();
            try
            {
                int? maNhanVien = dbContext.NHANVIENs.Single(nv => nv.EMAIL == email && nv.SDT == sdt).MANHANVIEN;
                if (maNhanVien != null)
                    return dbContext.TAIKHOANNHANVIENs.Single(tk => tk.MANHANVIEN == maNhanVien && tk.TENTAIKHOAN == name).MATKHAU;
                return null;
            }
            catch
            {
                return null;
            }
        }
        public NHANVIEN timNVTheoTK(int manv)
        {
            return dbContext.NHANVIENs.Where(t => t.MANHANVIEN == manv).FirstOrDefault();
        }
        public bool ThayDoiTaiKhoan(TAIKHOANNHANVIEN tk)
        {
            try
            {
                TAIKHOANNHANVIEN _tk = dbContext.TAIKHOANNHANVIENs.Single(t => t.MATAIKHOAN == tk.MATAIKHOAN);
                _tk.TENTAIKHOAN = tk.TENTAIKHOAN;
                _tk.MATKHAU = tk.MATKHAU;
                dbContext.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
