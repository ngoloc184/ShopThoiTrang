using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class CartItem
    {
        public int MASANPHAM { get; set; }
        public int MACHITIETSANPHAM { get; set; }
        public string TENSANPHAM { get; set; }
        public string HINHANH { get; set; }
        //public int imaSize { get; set; }
        //public string imauSac { get; set; }
        public int DONGIA { get; set; }
        public int SOLUONG { get; set; }
        public string MAVACH { get; set; }
        public string TENMAU { get; set; }
        public string TENSIZE { get; set; }
        public int THANHTIEN
        {
            get { return SOLUONG * DONGIA; }
        }
        public CartItem()
        {
            this.MACHITIETSANPHAM = 0;
        }
        public CartItem(int maCTSP)
        {
            ChiTietSanPham_BLL chiTietSanPham_BLL = new ChiTietSanPham_BLL();

            CHITIETSANPHAM ctsp = chiTietSanPham_BLL.timCTSP_THEOMACT(maCTSP);
            if (ctsp != null)
            {
                MACHITIETSANPHAM = maCTSP;
                TENSANPHAM = ctsp.SANPHAM.TENSANPHAM;
                TENSIZE = ctsp.SIZE.TENSIZE;
                TENMAU = ctsp.MAU.TENMAU;
                DONGIA = int.Parse((ctsp.SANPHAM.DONGIA * 0.7).ToString());
                HINHANH = ctsp.HINHANH;
                SOLUONG = 1;
            }

        }
    }
}
