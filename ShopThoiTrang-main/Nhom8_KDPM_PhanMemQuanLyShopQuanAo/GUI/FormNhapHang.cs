using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormNhapHang : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public FormNhapHang()
        {
            InitializeComponent();
        }
        private void accordionControlElement7_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            UsercontrolCart_PhieuNhap frm = new UsercontrolCart_PhieuNhap();
            pnMain.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            formNhapHang_main frm = new formNhapHang_main();
            pnMain.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            

        }
    }
}
