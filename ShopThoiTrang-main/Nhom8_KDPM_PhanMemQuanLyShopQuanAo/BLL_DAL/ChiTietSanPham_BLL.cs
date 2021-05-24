using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
   public class ChiTietSanPham_BLL
    {
        QLSHOPDataContext db = new QLSHOPDataContext();
        public void suaCTSP(CHITIETSANPHAM ct)
        {
            CHITIETSANPHAM s = db.CHITIETSANPHAMs.Where(t => t.MACHITIETSP == ct.MACHITIETSP).FirstOrDefault();
            s.SOLUONGTON = ct.SOLUONGTON;
            db.SubmitChanges();
        }
        public List<CHITIETSANPHAM> timDSCT(int maSP)
        {
            return db.CHITIETSANPHAMs.Where(t => t.MASANPHAM == maSP).ToList();
        }
        public List<CHITIETSANPHAM> timDSTheo_Mau(int maSP,string mau)
        {
            return db.CHITIETSANPHAMs.Where(t => t.MASANPHAM == maSP &&t.MAU.TENMAU==mau).ToList();
        }
        public List<CHITIETSANPHAM> loadDS()
        {
            return db.CHITIETSANPHAMs.ToList();
        }
        public CHITIETSANPHAM timCTSP(int maSP, string mau,string size)
        {
            return db.CHITIETSANPHAMs.Where(t => t.MASANPHAM == maSP && t.MAU.TENMAU == mau && t.SIZE.TENSIZE==size).FirstOrDefault();
        }
        public CHITIETSANPHAM timCTSP_THEOMACT(int maCT )
        {
            return db.CHITIETSANPHAMs.Where(t => t.MACHITIETSP==maCT).FirstOrDefault();
        }
        public List<SIZE> listSize()
        {
            return db.SIZEs.ToList();
        }
        public List<MAU> listMau()
        {
            return db.MAUs.ToList();
        }
    }
}
