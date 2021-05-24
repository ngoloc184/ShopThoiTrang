using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class Common
    {
        private static QLSHOPDataContext _Entities = new QLSHOPDataContext();

        public static QLSHOPDataContext Entities
        {
            get { return Common._Entities; }
            set { Common._Entities = value; }
        }
    }
}
