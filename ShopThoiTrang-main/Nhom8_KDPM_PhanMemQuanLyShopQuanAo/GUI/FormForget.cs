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
using BLL_DAL;

namespace GUI
{
    public partial class FormForget : DevExpress.XtraEditors.XtraForm
    {
        TaiKhoan taiKhoanBLL = new TaiKhoan();
        public FormForget()
        {
            splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::GUI.WaitForm1), true, true);
            splashScreenManager1.ClosingDelay = 500;
            splashScreenManager1.ShowWaitForm();
            InitializeComponent();
            this.CenterToParent();
            splashScreenManager1.CloseWaitForm();
        }

        private void linkSignIn_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.frmLogin.Show();
        }

        private void FormForget_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.CloseBox)
            {
                Program.frmLogin.Show();
            }
        }
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if(txtEmail.Text.Equals("") && txtName.Text.Equals("") && txtPhone.Text.Equals(""))
            {
                MessageBox.Show("User name or email or phone cannot be null !");
                return;
            }
            try
            {
                string pass = taiKhoanBLL.FindPassword(txtName.Text, txtEmail.Text, txtPhone.Text);
                if (pass != null)
                {
                    lbPass.Text = "Your password: " + pass;
                    lbPass.Visible = true;
                }
                else
                    MessageBox.Show("The information you provided was incorrect. Please check again !");
            }
            catch
            {
                lbPass.Text = "";
                lbPass.Visible = false;
                MessageBox.Show("The information you provided was incorrect. Please check again !");
                return;
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text.Equals(""))
            {
                MessageBox.Show("Name user cannot be null !");
                dxErrorProvider1.SetError(txtName, "Name cannot be null !");
                txtName.Focus();
                return;
            }
            else
            {
                dxErrorProvider1.ClearErrors();
            }
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            if (txtPhone.Text.Equals(""))
            {
                MessageBox.Show("Phone cannot be null !");
                dxErrorProvider2.SetError(txtPhone, "Phone be null !");
                txtPhone.Focus();
                return;
            }
            else
            {
                dxErrorProvider2.ClearErrors();
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text.Equals(""))
            {
                MessageBox.Show("Email cannot be null !");
                dxErrorProvider3.SetError(txtEmail, "Email be null !");
                txtEmail.Focus();
                return;
            }
            else
            {
                dxErrorProvider3.ClearErrors();
            }
        }
    }
}