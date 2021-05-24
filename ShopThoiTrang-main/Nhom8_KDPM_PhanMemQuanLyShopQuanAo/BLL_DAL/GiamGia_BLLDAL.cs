using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class GiamGia_BLLDAL
    {
        QLSHOPDataContext db = new QLSHOPDataContext();
        public List<GIAMGIA> layDSGG()
        {
            return db.GIAMGIAs.ToList();
        }
        public GIAMGIA layGG(int maGG)
        {
            return db.GIAMGIAs.FirstOrDefault(s => s.MAGIAMGIA == maGG);
        }
        public void themGG(GIAMGIA g)
        {
            db.GIAMGIAs.InsertOnSubmit(g);
            db.SubmitChanges();
        }
        public void suaGG(GIAMGIA g)
        {
            GIAMGIA gg = db.GIAMGIAs.FirstOrDefault(t => t.MAGIAMGIA == g.MAGIAMGIA);
            gg.MOTA = g.MOTA;
            gg.NGAYBD = g.NGAYBD;
            gg.DONHANGTU = g.DONHANGTU;
            gg.GIATRITOIDA = g.GIATRITOIDA;
            gg.MUCGIAMGIA = g.MUCGIAMGIA;
            gg.TENGIAMGIA = g.TENGIAMGIA;
            gg.NGAYKT = g.NGAYKT;
            db.SubmitChanges();
        }
    }
}
