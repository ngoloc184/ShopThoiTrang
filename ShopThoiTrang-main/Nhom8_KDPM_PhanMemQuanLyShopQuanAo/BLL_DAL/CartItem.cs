using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class CartItem
    {
        public int iMaChiTietSP { get; set; }
        public string iTenSanPham { get; set; }
        public string iSize { get; set; }
        public string imausac { get; set; }
        public int iDonGia { get; set; }
        public string iHinhAnh { get; set; }
        public int iSoLuong { get; set; }
        public int thanhTien
        {
            get { return iSoLuong * iDonGia; }
        }
        //tạo giỏ hàng
        QLSHOPDataContext db = new QLSHOPDataContext();
        public CartItem()
        {
            this.iMaChiTietSP = 0;
        }
        public CartItem(int maCTSP)
        {
            ChiTietSanPham_BLL chiTietSanPham_BLL = new ChiTietSanPham_BLL();

            CHITIETSANPHAM ctsp = chiTietSanPham_BLL.timCTSP_THEOMACT(maCTSP);
            if (ctsp != null)
            {
                iMaChiTietSP = maCTSP;
                iTenSanPham = ctsp.SANPHAM.TENSANPHAM;
                iSize = ctsp.SIZE.TENSIZE;
                imausac = ctsp.MAU.TENMAU;
                iDonGia = int.Parse(ctsp.SANPHAM.DONGIA.ToString());
                iHinhAnh = ctsp.HINHANH;
                iSoLuong = 1;
            }

        }
    }
}
