using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
   public class ChiTietSanPham_BLL
    {
        QLShopDataContext db = new QLShopDataContext();
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
        public SANPHAM timHinhAnh(int maSP)
        {
            try
            {
                return db.SANPHAMs.Single(t => t.MASANPHAM == maSP);
            }
            catch
            {
                return null;
            }
        }
        public List<View_DSCTSP> tim_DSCT(int maSP)
        {
            return db.View_DSCTSPs.Where(t => t.MASANPHAM  == maSP).ToList();
        }
        public CHITIETSANPHAM timCTSP_full(int maSP, string mau, string size)
        {
            return db.CHITIETSANPHAMs.Where(t => t.MASANPHAM == maSP && t.MAU.TENMAU == mau && t.SIZE.TENSIZE == size).FirstOrDefault();
        }
        public CHITIETSANPHAM timCTSP_THEOMACT(int maCT)
        {
            return db.CHITIETSANPHAMs.Where(t => t.MACHITIETSP == maCT).FirstOrDefault();
        }
        public CHITIETSANPHAM timCTSP(int maCTSP)
        {
            try
            {
                return db.CHITIETSANPHAMs.Single(t => t.MACHITIETSP == maCTSP);
            }
            catch
            {
                return null;
            }
        }
        public View_DSCTSP loadCTSP(string maVach)
        {
            try
            {
                return db.View_DSCTSPs.Single(t => t.MAVACH == (maVach));
            }
            catch
            {
                return null;
            }
        }
        public CHITIETSANPHAM timDSCT_MaVach(string maVach)
        {
            try
            {
                return db.CHITIETSANPHAMs.Single(t => t.MAVACH == maVach);
            }
            catch
            {
                return null;
            }
        }
        public List<CHITIETSANPHAM> timDSTheo_Mau(int maSP,string mau)
        {
            return db.CHITIETSANPHAMs.Where(t => t.MASANPHAM == maSP &&t.MAU.TENMAU==mau).ToList();
        }
        public CHITIETSANPHAM timCTSP(int maSP, int mau,int size)
        {
            return db.CHITIETSANPHAMs.Where(t => t.MASANPHAM == maSP && t.MAMAU == mau && t.MASIZE == size).FirstOrDefault();
        }
        public List<View_DSCTSP> loadDSCTSP(int maSP)
        {
            return db.View_DSCTSPs.Where(ct => ct.MASANPHAM == maSP).ToList();
        }
        public void themCTSP(CHITIETSANPHAM ctsp)
        {
            ctsp.SOLUONGTON = 0;
            db.CHITIETSANPHAMs.InsertOnSubmit(ctsp);
            db.SubmitChanges();
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
