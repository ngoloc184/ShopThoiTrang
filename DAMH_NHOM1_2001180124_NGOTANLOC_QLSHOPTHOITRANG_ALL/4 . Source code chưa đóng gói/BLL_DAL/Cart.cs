using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class Cart
    {
        QLShopDataContext data = new QLShopDataContext();

        public List<CartItem> dsSP;
        public Cart()
        {
            dsSP = new List<CartItem>();
        }
        public Cart(List<CartItem> lst)
        {
            dsSP = lst;
        }
        //phương thức thanh toán
        public int soMatHang()
        {
            if (dsSP == null)
                return 0;
            return dsSP.Count();
        }
        public int tongSoLuong()
        {
            if (dsSP == null)
                return 0;
            return dsSP.Sum(t => t.SOLUONG);
        }
        public int tongThanhTien()
        {
            if (dsSP == null)
                return 0;
            return dsSP.Sum(t => t.THANHTIEN);
        }

        public int Them(int iMaSP, int soLuong)
        {
            CartItem sanPham = dsSP.SingleOrDefault(n => n.MACHITIETSANPHAM == iMaSP);
            if (sanPham == null)
            {
                CartItem sp = new CartItem(iMaSP);
                sp.SOLUONG = soLuong;
                if (sp == null)
                    return -1;
                dsSP.Add(sp);
            }
            else
            {
                sanPham.SOLUONG += soLuong;
            }
            return 1;
        }
        public void XoaItem(int iMaSP)
        {
            foreach (CartItem item in dsSP)
            {
                if (item.MACHITIETSANPHAM == iMaSP)
                {
                    dsSP.Remove(item);
                    return;
                }
            }

        }
        public Boolean giamSL(int maSP)
        {
            CartItem cartItem = dsSP.Where(t => t.MACHITIETSANPHAM == maSP).FirstOrDefault();
            if (cartItem.SOLUONG == 1)
            {
                return false;
            }
            else
            {
                cartItem.SOLUONG--;
                return true;
            }

        }

    }
}
