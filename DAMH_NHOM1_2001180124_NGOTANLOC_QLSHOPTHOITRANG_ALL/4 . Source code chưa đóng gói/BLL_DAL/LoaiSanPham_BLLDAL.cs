using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class LoaiSanPham_BLLDAL
    {
        QLShopDataContext dbContext = new QLShopDataContext();
        public IQueryable<LOAISANPHAM> load_DSLoai()
        {
            return dbContext.LOAISANPHAMs.Select(t => t);
        }
        public LOAISANPHAM loaiSP_tenLoai(string tenLoai)
        {
            return dbContext.LOAISANPHAMs.Where(t => t.TENLOAISANPHAM == tenLoai).FirstOrDefault();
        }
        public List<string> load_LoaiSP()
        {
            return dbContext.LOAISANPHAMs.Select(t=>t.TENLOAISANPHAM).ToList();
        }
    }
}
