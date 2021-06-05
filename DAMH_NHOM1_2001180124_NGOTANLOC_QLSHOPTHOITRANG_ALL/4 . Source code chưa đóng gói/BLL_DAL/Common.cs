using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class Common
    {
        private static QLShopDataContext _Entities = new QLShopDataContext();

        public static QLShopDataContext Entities
        {
            get { return Common._Entities; }
            set { Common._Entities = value; }
        }
    }
}
