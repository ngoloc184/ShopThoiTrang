using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL_DAL;

namespace GUI
{
    public partial class FormLogin : DevExpress.XtraEditors.XtraForm
    {
        TaiKhoan taikhoanBLL = new TaiKhoan();
        TAIKHOANNHANVIEN taiKhoan = new TAIKHOANNHANVIEN();

        public TAIKHOANNHANVIEN TaiKhoan { get => taiKhoan; set => taiKhoan = value; }

        public FormLogin()
        {
            InitializeComponent();
            this.CenterToParent();
            if (taikhoanBLL.FindTaiKhoan(GUI.Properties.Settings.Default.UserName, GUI.Properties.Settings.Default.Password) != null)
            {
                txtName.Text = GUI.Properties.Settings.Default.UserName;
                txtPass.Text = GUI.Properties.Settings.Default.Password;
            }
            checkEdit1.Checked = true;
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.CloseBox)
            {
                DialogResult r = MessageBox.Show("Do you want to exit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (r == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void linkForget_Click(object sender, EventArgs e)
        {
            FormForget frm = new FormForget();
            this.Hide();
            frm.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Equals("") && txtPass.Text.Equals(""))
            {
                MessageBox.Show("Name user or password cannot be null!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (taikhoanBLL.FindTaiKhoan(txtName.Text, txtPass.Text) != null)
            {
                if (taikhoanBLL.FindTaiKhoan(txtName.Text, txtPass.Text).TRANGTHAI != true)
                {
                    MessageBox.Show("Account is not longer active!", "NO ACTIVE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (checkEdit1.Checked)
                {
                    GUI.Properties.Settings.Default.UserName = txtName.Text;
                    GUI.Properties.Settings.Default.Password = txtPass.Text;
                }
                else
                {
                    GUI.Properties.Settings.Default.UserName = null;
                    GUI.Properties.Settings.Default.Password = null;
                }
                TAIKHOANNHANVIEN tk = taikhoanBLL.FindTaiKhoan(txtName.Text, txtPass.Text);
                NHANVIEN nv = taikhoanBLL.timNVTheoTK(int.Parse(tk.MANHANVIEN.ToString())); 
                taiKhoan = tk;
                if (nv.CHUCVU == "QuanLy"||nv.CHUCVU=="NhanVien")
                {
                    Menu_Ribbon frm = new Menu_Ribbon();
                    frm.Show();
                    Properties.Settings.Default.Save();
                    return;
                }
                Properties.Settings.Default.Save();
                Program.formTN = new FormTN();
                Program.formTN.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Account cannot find!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Program.formTN != null)
                Program.formTN.Close();
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

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text.Equals(""))
            {
                MessageBox.Show("Password user cannot be null !");
                dxErrorProvider2.SetError(txtPass, "Password cannot be null !");
                txtPass.Focus();
                return;
            }
            else
            {
                dxErrorProvider2.ClearErrors();
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
