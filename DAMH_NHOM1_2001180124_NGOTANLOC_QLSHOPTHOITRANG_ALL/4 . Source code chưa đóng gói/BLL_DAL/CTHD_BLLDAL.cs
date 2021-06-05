using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class CTHD_BLLDAL
    {
        QLShopDataContext db = new QLShopDataContext();
        //public List<vw_report> getData_MaHoaDon(int maHoaDon)
        //{
        //    return db.vw_reports.Where(ct => ct.MAHOADON == maHoaDon).ToList();
        //}
        public List<CHITIETHOADON> getData_MaHoaDon(int maHoaDon)
        {
            return db.CHITIETHOADONs.Where(ct => ct.MAHOADON == maHoaDon).ToList();
        }
        public CHITIETSANPHAM getCTSP(int maCTSP)
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
        public vw_CTHD getCTHD(string maVach)
        {
            try
            {
                return db.vw_CTHDs.Single(t=>t.MAVACH == maVach);
            }
            catch
            {
                return null;
            }
        }
        public View_DSCTSP getCTHD_CTSP(int maCTSP)
        {
            try
            {
                return db.View_DSCTSPs.Single(t => t.MACHITIETSP == maCTSP);
            }
            catch
            {
                return null;
            }
        }
        public bool ThemCTHD(CHITIETHOADON cthd)
        {
            try
            {
                db.CHITIETHOADONs.InsertOnSubmit(cthd);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public CHITIETHOADON CTHD(int maCTHD)
        {
            return db.CHITIETHOADONs.Where(t => t.MACHITIETHD == maCTHD).FirstOrDefault();
        }
    }
}
