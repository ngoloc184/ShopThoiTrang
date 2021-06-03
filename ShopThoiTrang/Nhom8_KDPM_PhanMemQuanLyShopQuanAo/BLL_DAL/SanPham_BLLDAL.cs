using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class SanPham_BLLDAL
    {
        QLShopDataContext dbContext = new QLShopDataContext();
       
        public IQueryable<SANPHAM> loadSanPham_ForLoai(int maLoai)
        {
            return dbContext.SANPHAMs.Where(sp => sp.MALOAISANPHAM == maLoai);
        }
        public List<SANPHAM> listSPTheoSoLuongTon(int soLuongTon)
        {
            List<SANPHAM> listSP = new List<SANPHAM>();
            var lSP = dbContext.SANPHAMs.ToList();
            foreach (var item in lSP)
            {
                var ctsp = dbContext.CHITIETSANPHAMs.Where(t => t.MASANPHAM == item.MASANPHAM).ToList();
                Boolean kt = false;
                foreach(var itemCT in ctsp)
                {
                    if (itemCT.SOLUONGTON <= soLuongTon)
                        kt = true;
                }
                if (kt == true)
                    listSP.Add(item);
            }
            return listSP;
        }
        //public List<SANPHAM> loadSPTheoLoai(int maLoai)
        //{
        //    var list = dbContext.SANPHAMs.Where(t => t.MALOAISANPHAM == maLoai).Select(t => new
        //    {
        //        t.MASANPHAM,
        //        t.TENSANPHAM,
        //        t.DONGIA,
        //        t.TRANGTHAI,
        //        t.MOTA
        //    }).ToList();
        //    return list;
        //}
        public void themSP(SANPHAM sp)
        {
            dbContext.SANPHAMs.InsertOnSubmit(sp);
            dbContext.SubmitChanges();
        }
        public void suaTTSP(SANPHAM sp)
        {
            SANPHAM s = dbContext.SANPHAMs.Where(t => t.MASANPHAM == sp.MASANPHAM).FirstOrDefault();

            s.DONGIA = sp.DONGIA;
            s.KHUYENMAI = sp.KHUYENMAI;
            s.TENSANPHAM = sp.TENSANPHAM;
            s.MOTA = sp.MOTA;

            dbContext.SubmitChanges();
        }
        public SANPHAM detailSanpham(int maSP)
        {
            return dbContext.SANPHAMs.FirstOrDefault(sp => sp.MASANPHAM == maSP);
        }
        public List<SANPHAM> loadSP()
        {
            return dbContext.SANPHAMs.ToList();
        }
        //public string kiemTraSLTon(Cart cart, int maSP)
        //{
        //    SANPHAM sp = dbContext.SANPHAMs.Where(t => t.MASANPHAM == maSP).FirstOrDefault();
        //    CartItem cartItem = cart.dsSP.Where(t => t.iMaSanPham == maSP).FirstOrDefault();
            
        //    if (sp.SOLUONGTON <= 0) return "ĐÃ HẾT HÀNG";
        //    if (cartItem == null) return "duyệt";
        //    if (sp.SOLUONGTON == cartItem.iSoLuong )
        //        return "Số lượng tồn không cung cấp đủ";
        //    return "duyệt";
        

        //}
        public IQueryable<SANPHAM> load_DSSP()
        {
            return dbContext.SANPHAMs.Select(t => t);
        }

        public List<SANPHAM> Search(string keywords)
        {
            return dbContext.SANPHAMs.Where(t => t.TENSANPHAM.Contains(keywords)).ToList();
        }

        public List<SANPHAM> sortDescPrice(List<SANPHAM> lstSP)
        {
            return lstSP.OrderByDescending(sp => sp.DONGIA).ToList();
        }
        public List<SANPHAM> sortAscPrice(List<SANPHAM> lstSP)
        {
            return lstSP.OrderBy(sp => sp.DONGIA).ToList();
        }
        public List<SANPHAM> sortAZName(List<SANPHAM> lstSP)
        {
            return lstSP.OrderByDescending(sp => sp.TENSANPHAM).ToList();
        }
        public List<SANPHAM> sortZAName(List<SANPHAM> lstSP)
        {
            return lstSP.OrderBy(sp => sp.TENSANPHAM).ToList();
        }
    }
}
