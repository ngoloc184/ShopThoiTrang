using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class Cart
    {
        QLSHOPDataContext data = new QLSHOPDataContext();

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
            return dsSP.Sum(t => t.iSoLuong);
        }
        public int tongThanhTien()
        {
            if (dsSP == null)
                return 0;
            return dsSP.Sum(t => t.thanhTien);
        }

        //thêm sản phẩm
        public int Them(int iMaSP, int soLuong)
        {
            CartItem sanPham = dsSP.SingleOrDefault(n => n.iMaChiTietSP == iMaSP);
            if (sanPham == null)
            {
                CartItem sp = new CartItem(iMaSP);
                sp.iSoLuong = soLuong;
                if (sp == null)
                    return -1;
                dsSP.Add(sp);
            }
            else
            {
                sanPham.iSoLuong+= soLuong;
            }
            return 1;
        }
        public void XoaItem(int iMaSP)
        {
            foreach (CartItem item in dsSP)
            {
                if (item.iMaChiTietSP == iMaSP)
                {
                    dsSP.Remove(item);
                    return;
                }
            }

        }
        public Boolean giamSL(int maSP)
        {
            CartItem cartItem = dsSP.Where(t => t.iMaChiTietSP == maSP).FirstOrDefault();
            if (cartItem.iSoLuong == 1)
            {
                return false;
            }
            else
            {
                cartItem.iSoLuong--;
                return true;
            } 
                
        }
        
    }
}
