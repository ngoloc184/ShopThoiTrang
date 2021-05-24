using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class UsercontrolCart_PhieuNhap : DevExpress.XtraEditors.XtraUserControl
    {
        public UsercontrolCart_PhieuNhap()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UsercontrolCart_PhieuNhap_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = Program.dsPhieuNhap.dsSP.ToList();
        }
    }
}
