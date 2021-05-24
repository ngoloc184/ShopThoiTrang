using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class CTHD_BLLDAL
    {
        QLSHOPDataContext db = new QLSHOPDataContext();
        //public List<vw_report> getData_MaHoaDon(int maHoaDon)
        //{
        //    return db.vw_reports.Where(ct => ct.MAHOADON == maHoaDon).ToList();
        //}
        public List<CHITIETHOADON> getData_MaHoaDon(int maHoaDon)
        {
            return db.CHITIETHOADONs.Where(ct => ct.MAHOADON == maHoaDon).ToList();
        }
    }
}
