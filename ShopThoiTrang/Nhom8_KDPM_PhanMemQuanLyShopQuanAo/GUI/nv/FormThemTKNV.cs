using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Templates.ActionControls;
using DevExpress.ExpressApp.Win.Controls;
using DevExpress.ExpressApp.Win.SystemModule;
using DevExpress.ExpressApp.Win.Templates;
using DevExpress.ExpressApp.Win.Templates.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BLL_DAL;

namespace GUI
{
    public partial class FormThemTKNV : XtraForm, IActionControlsSite, IContextMenuHolder, IWindowTemplate, IBarManagerHolder, ISupportViewChanged, ISupportUpdate, IViewSiteTemplate, ISupportStoreSettings, IViewHolder
    {
        private static readonly object viewChanged = new object();
        private static readonly object settingsReloaded = new object();
        private StatusMessagesHelper statusMessagesHelper;

        protected virtual void RaiseViewChanged(DevExpress.ExpressApp.View view)
        {
            EventHandler<TemplateViewChangedEventArgs> handler = (EventHandler<TemplateViewChangedEventArgs>)Events[viewChanged];
            if (handler != null)
            {
                handler(this, new TemplateViewChangedEventArgs(view));
            }
        }
        protected virtual void RaiseSettingsReloaded()
        {
            EventHandler handler = (EventHandler)Events[settingsReloaded];
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }
        protected override FormShowMode ShowMode
        {
            get { return FormShowMode.AfterInitialization; }
        }
        public FormThemTKNV()
        {
            InitializeComponent();
            barManager.ForceLinkCreate();
            statusMessagesHelper = new StatusMessagesHelper(barContainerStatusMessages);
        }

        #region IActionControlsSite Members
        IEnumerable<IActionControl> IActionControlsSite.ActionControls
        {
            get { return barManager.ActionControls; }
        }
        IEnumerable<IActionControlContainer> IActionControlsSite.ActionContainers
        {
            get { return barManager.ActionContainers; }
        }
        IActionControlContainer IActionControlsSite.DefaultContainer
        {
            get { return actionContainerView; }
        }
        #endregion

        #region IFrameTemplate Members
        void IFrameTemplate.SetView(DevExpress.ExpressApp.View view)
        {
            viewSiteManager.SetView(view);
            RaiseViewChanged(view);
        }
        ICollection<IActionContainer> IFrameTemplate.GetContainers()
        {
            { return new IActionContainer[0]; }
        }
        IActionContainer IFrameTemplate.DefaultContainer
        {
            get { return null; }
        }
        #endregion

        #region IWindowTemplate Members
        void IWindowTemplate.SetCaption(string caption)
        {
            Text = caption;
        }
        void IWindowTemplate.SetStatus(ICollection<string> statusMessages)
        {
            statusMessagesHelper.SetMessages(statusMessages);
        }
        bool IWindowTemplate.IsSizeable
        {
            get { return FormBorderStyle == FormBorderStyle.Sizable; }
            set { FormBorderStyle = (value ? FormBorderStyle.Sizable : FormBorderStyle.FixedDialog); }
        }
        #endregion

        #region IBarManagerHolder Members
        BarManager IBarManagerHolder.BarManager
        {
            get { return barManager; }
        }
        event EventHandler IBarManagerHolder.BarManagerChanged
        {
            add { }
            remove { }
        }
        #endregion

        #region IContextMenuHolder
        PopupMenu IContextMenuHolder.ContextMenu
        {
            get { return contextMenu; }
        }
        #endregion

        #region ISupportViewChanged Members
        event EventHandler<TemplateViewChangedEventArgs> ISupportViewChanged.ViewChanged
        {
            add { Events.AddHandler(viewChanged, value); }
            remove { Events.RemoveHandler(viewChanged, value); }
        }
        #endregion

        #region ISupportUpdate Members
        void ISupportUpdate.BeginUpdate()
        {
            barManager.BeginUpdate();
        }
        void ISupportUpdate.EndUpdate()
        {
            barManager.EndUpdate();
            barManager.UpdateLayout();
        }
        #endregion

        #region IViewSiteTemplate Members
        object IViewSiteTemplate.ViewSiteControl
        {
            get { return viewSiteManager.ViewSiteControl; }
        }
        #endregion

        #region ISupportStoreSettings Members
        void ISupportStoreSettings.SetSettings(IModelTemplate settings)
        {
            IModelTemplateWin templateModel = (IModelTemplateWin)settings;
            TemplatesHelper templatesHelper = new TemplatesHelper(templateModel);
            IModelFormState formState;
            if (viewSiteManager.View != null)
            {
                formState = templatesHelper.GetFormStateNode(viewSiteManager.View.Id);
            }
            else
            {
                formState = templatesHelper.GetFormStateNode();
            }
            formStateModelSynchronizer.Model = formState;
        }
        void ISupportStoreSettings.ReloadSettings()
        {
            modelSynchronizationManager.ApplyModel();
            RaiseSettingsReloaded();
        }
        void ISupportStoreSettings.SaveSettings()
        {
            SuspendLayout();
            try
            {
                modelSynchronizationManager.SynchronizeModel();
            }
            finally
            {
                ResumeLayout();
            }
        }
        event EventHandler ISupportStoreSettings.SettingsReloaded
        {
            add { Events.AddHandler(settingsReloaded, value); }
            remove { Events.RemoveHandler(settingsReloaded, value); }
        }
        #endregion

        #region IViewHolder Members
        DevExpress.ExpressApp.View IViewHolder.View
        {
            get { return viewSiteManager.View; }
        }
        #endregion

        QLShopDataContext db = new QLShopDataContext();
        private void viewSitePanel_Paint(object sender, PaintEventArgs e)
        {
            
            txtMK.PasswordChar = '*';
            txtNhapLaiMK.PasswordChar = '*';
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            luu();
        }
        private bool luu()
        {
            TAIKHOANNHANVIEN tk = new TAIKHOANNHANVIEN();
            string tenTk = "";
            string mk = "";
            string reMK = "";
            string maNV = "";


            if (txtTenTK.Text != "")
            {
                tenTk = txtTenTK.Text.ToString();  
            }
            else
            {
                XtraMessageBox.Show("Bạn chưa nhập tên tài khoản", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenTK.Focus();
                return false;
            }
            if (txtMK.Text != "")
            {
                mk = txtMK.Text.ToString();
            }
            else
            {
                XtraMessageBox.Show("Bạn chưa nhập mật khẩu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMK.Focus();
                return false;
            }
            if (txtNhapLaiMK.Text != "")
            {
                reMK = txtNhapLaiMK.Text.ToString();
            }
            else
            {
                XtraMessageBox.Show("Bạn chưa nhập lại mật khẩu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNhapLaiMK.Focus();
                return false;
            }
            if (txtMaNV.Text != "")
            {
                maNV = txtMaNV.Text.ToString();
            }
            else
            {
                XtraMessageBox.Show("Bạn chưa nhập mã nhân viên", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaNV.Focus();
                return false;
            }
            try
            {
                if (mk != reMK)
                {
                    XtraMessageBox.Show("Mật khẩu chưa khớp!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                   
                    if (tenTk==tk.TENTAIKHOAN)
                    {
                        XtraMessageBox.Show("Tài khoản đã có người sử dụng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }     
                    else
                    {
                        tk.TENTAIKHOAN = tenTk;
                    }    
                    tk.MATKHAU = mk;
                    tk.TRANGTHAI = bool.Parse(txtTrangThai.Text);
                    tk.MANHANVIEN = int.Parse(maNV);
                    tk.NGAYTAO = DateTime.Now;
                    db.TAIKHOANNHANVIENs.InsertOnSubmit(tk);
                    db.SubmitChanges();

                    txtTenTK.Text = "";
                    txtMK.Text = "";
                    txtNhapLaiMK.Text = "";
                    txtMaNV.Text = "";
                    XtraMessageBox.Show("Tạo tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            catch
            {
                XtraMessageBox.Show("Thêm thất bại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return true;
        }

        private void FormThemTKNV_Load(object sender, EventArgs e)
        {
            List<string> gioiTinh = new List<string> { "true", "false" };
            txtTrangThai.DataSource = gioiTinh;
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn thoát khỏi Form Không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
