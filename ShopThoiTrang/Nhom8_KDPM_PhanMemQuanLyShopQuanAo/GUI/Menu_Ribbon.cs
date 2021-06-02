using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_DAL;
using GUI.V_BaoHanh;
using DevExpress.XtraSplashScreen;

namespace GUI
{
    public partial class Menu_Ribbon : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Menu_Ribbon()
        {
            InitializeComponent();
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmBieuDo));
            if (frm != null)
                frm.Activate();
            else
            {
                SplashScreenManager.ShowDefaultWaitForm();
                frmBieuDo f = new frmBieuDo
                {
                    MdiParent = this
                };
                f.Show();
                SplashScreenManager.CloseDefaultSplashScreen();
            }

        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            Program.formTN = new FormTN();
            Program.formTN.Show();

        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(FormQLSP));
            if (frm != null)
                frm.Activate();
            else
            {
                SplashScreenManager.ShowDefaultWaitForm();
                FormQLSP f = new FormQLSP
                {
                    MdiParent = this
                };
                f.Show();
                SplashScreenManager.CloseDefaultSplashScreen();
            }
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
          
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(FormNhanVien));
            if (frm != null)
                frm.Activate();
            else
            {
                SplashScreenManager.ShowDefaultWaitForm();
                FormNhanVien f = new FormNhanVien
                {
                    MdiParent = this
                };
                f.Show();
                SplashScreenManager.CloseDefaultSplashScreen();
            }
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(FormGiamGia));
            if (frm != null)
                frm.Activate();
            else
            {
                SplashScreenManager.ShowDefaultWaitForm();
                FormGiamGia f = new FormGiamGia
                {
                    MdiParent = this
                };
                f.Show();
                SplashScreenManager.CloseDefaultSplashScreen();
            }
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(FormNhapHang));
            if (frm != null)
                frm.Activate();
            else
            {
                SplashScreenManager.ShowDefaultWaitForm();
                FormNhapHang f = new FormNhapHang
                {
                    MdiParent = this
                };
                f.Show();
                SplashScreenManager.CloseDefaultSplashScreen();
            }
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem2_ItemClick_1(object sender, ItemClickEventArgs e)
        {
           if(Program.frmLogin.TaiKhoan.NHANVIEN.CHUCVU== "QuanLy")
            {
                Form frm = this.KiemTraTonTai(typeof(FormNhanVien));
                if (frm != null)
                    frm.Activate();
                else
                {
                    SplashScreenManager.ShowDefaultWaitForm();
                    FormNhanVien f = new FormNhanVien
                    {
                        MdiParent = this
                    };
                    f.Show();
                    SplashScreenManager.CloseDefaultSplashScreen();
                }
                return;
            }
            MessageBox.Show("Chức năng này chỉ dành cho Quản Lý");           
        }

        private void Báo_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frStatistical));
            if (frm != null)
                frm.Activate();
            else
            {
                SplashScreenManager.ShowDefaultWaitForm();
                frStatistical f = new frStatistical
                {
                    MdiParent = this
                };
                f.Show();
                SplashScreenManager.CloseDefaultSplashScreen();
            }
        }
        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(FormBaoHanh));
            if (frm != null)
                frm.Activate();
            else
            {
                SplashScreenManager.ShowDefaultWaitForm();
                FormBaoHanh f = new FormBaoHanh
                {
                    MdiParent = this
                };
                f.Show();
                SplashScreenManager.CloseDefaultSplashScreen();
            }

        }
        #region Methods
        //Kiểm tra sự tồn tại của form con
        private Form KiemTraTonTai(Type fType)
        {
            foreach (Form f in MdiChildren)
            {
                if (f.GetType() == fType) //Neu Form duoc truyen vao da duoc mo
                    return f;
            }
            return null;
        }
        #endregion

    }
}