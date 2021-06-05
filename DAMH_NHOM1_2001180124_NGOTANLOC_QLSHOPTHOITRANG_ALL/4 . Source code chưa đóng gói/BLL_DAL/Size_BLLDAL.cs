using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
     public   class Size_BLLDAL
    {
        QLShopDataContext db = new QLShopDataContext();
        public SIZE laySize(string tenSize)
        {
            return db.SIZEs.Where(t => t.TENSIZE == tenSize).FirstOrDefault();
        }
    }
}
