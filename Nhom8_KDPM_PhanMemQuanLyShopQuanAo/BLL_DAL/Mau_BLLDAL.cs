﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class Mau_BLLDAL
    {
        QLSHOPDataContext db = new QLSHOPDataContext();
        public MAU layMau(string tenMau)
        {
            return db.MAUs.Where(t => t.TENMAU == tenMau).FirstOrDefault();
        }
    }
}
