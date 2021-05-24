using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace GUI
{
    public partial class FormHome : DevExpress.XtraEditors.XtraUserControl
    {
        public FormHome()
        {
            InitializeComponent();
        }
        private void tileBar_SelectedItemChanged(object sender, TileItemEventArgs e)
        {
            navigationFrame.SelectedPageIndex = tileBarGroupTables.Items.IndexOf(e.Item);
        }

        private void btnFB_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://www.facebook.com/www.YaMe.vn");
            }
            catch (Exception)
            {
                
                throw;
            }
            

        }

        private void btnIG_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://www.instagram.com/yame_vn/");
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }

        private void btnGG_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://yame.vn/");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://yame.vn/xuhuong/read/m-ban-16-04-lb1?lb=fdea1065-cd24-4816-b955-5003b5961bb0");
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }

        private void imageSlider2_Click(object sender, EventArgs e)
        {

        }
    }
}
