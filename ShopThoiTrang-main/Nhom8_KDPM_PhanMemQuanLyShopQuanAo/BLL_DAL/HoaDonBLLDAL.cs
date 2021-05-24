using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class HoaDonBLLDAL
    {
        QLSHOPDataContext dbContext = new QLSHOPDataContext();
        //public IQueryable<HOADON> load_listHD()
        //{
        //    return dbContext.HOADONs.Select(hd => hd);
        //}
        //public IQueryable<View_HoaDon> load_listHD()
        //{
        //    return dbContext.View_HoaDons.Select(hd => hd);
        //}
        //public HOADON getMaHDMoi()
        //{
        //    return dbContext.HOADONs.OrderByDescending(hd => hd.MAHOADON).First();
        //}
    }
}
