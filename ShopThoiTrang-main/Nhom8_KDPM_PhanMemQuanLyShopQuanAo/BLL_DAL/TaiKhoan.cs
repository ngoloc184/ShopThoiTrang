using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class TaiKhoan
    {

        QLSHOPDataContext dbContext = new QLSHOPDataContext();
        public TAIKHOANNHANVIEN FindTaiKhoan(string tenTaiKhoan, string matKhau)
        {
            try
            {
                List<TAIKHOANNHANVIEN> db = dbContext.TAIKHOANNHANVIENs.ToList();
                return dbContext.TAIKHOANNHANVIENs.Single(tk => tk.TENTAIKHOAN == tenTaiKhoan && tk.MATKHAU == matKhau);
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
    }
}
