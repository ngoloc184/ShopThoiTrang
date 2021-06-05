using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class BaoHanh_BLLDAL
    {
        QLShopDataContext db = new QLShopDataContext();
        public List<CHITIETHOADON> listCtHD(int maHD)
        {
            return db.CHITIETHOADONs.Where(t => t.MAHOADON == maHD).ToList();
        }
        public List<CHITIETBAOHANH> listCTBH(int maBH)
        {
            return db.CHITIETBAOHANHs.Where(t => t.MAPHIEUBH == maBH).ToList();
        }
        public BAOHANH getMaPNMoi()
        {
            return db.BAOHANHs.OrderByDescending(hd => hd.MAPHIEUBH).First();
        }
        public KHACHHANG timKH(int maPHIEUBH)
        {
            CHITIETBAOHANH ctbh = db.CHITIETBAOHANHs.Where(t => t.MAPHIEUBH == maPHIEUBH).First();

            return db.KHACHHANGs.Where(t => t.MAKHACHHANG == ctbh.CHITIETHOADON.HOADON.KHACHHANG.MAKHACHHANG).FirstOrDefault();
        }
        public void daBaoHanhXong(int maPHIEUBH)
        {
            BAOHANH bh = db.BAOHANHs.Where(t => t.MAPHIEUBH == maPHIEUBH).FirstOrDefault();
            bh.TRANGTHAI = "Đã Bảo Hành";
            db.SubmitChanges();
        }
        public List<BAOHANH> listBH()
        {
            return db.BAOHANHs.ToList();
        }
        public void luuPhieuBaoHanh(List<CHITIETHOADON> dsBH,List<string> lyDo)
        {
            BAOHANH bh = new BAOHANH();
            foreach(var item in lyDo)
            {
                bh.MOTA += item;
            }
            bh.NGAYLAPBH = DateTime.Now;
            bh.TRANGTHAI = "Đang bảo hành";
            db.BAOHANHs.InsertOnSubmit(bh);
            db.SubmitChanges();

            //them ctbh
            foreach(var item in dsBH)
            {
                CHITIETBAOHANH ctbh = new CHITIETBAOHANH();
                ctbh.MAPHIEUBH = bh.MAPHIEUBH;
                ctbh.MACHITIETHD = item.MACHITIETHD;
                ctbh.MAHOADON = item.MAHOADON;
                ctbh.MACHITIETSP = item.MACHITIETSP;
                db.CHITIETBAOHANHs.InsertOnSubmit(ctbh);
                db.SubmitChanges();
            }    
        }

    }
}
