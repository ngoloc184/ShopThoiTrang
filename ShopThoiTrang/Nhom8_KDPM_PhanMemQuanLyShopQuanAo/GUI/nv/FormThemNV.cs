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
using System.Linq;
namespace GUI
{

    public partial class FormThemNV : XtraForm, IActionControlsSite, IContextMenuHolder, IWindowTemplate, IBarManagerHolder, ISupportViewChanged, ISupportUpdate, IViewSiteTemplate, ISupportStoreSettings, IViewHolder
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
        public FormThemNV()
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
        NhanVien_BLLDAL nhanvien_BLLDAL = new NhanVien_BLLDAL();
        
        private void viewSitePanel_Paint(object sender, PaintEventArgs e)
        {

        }

    
        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            save();
        }
        private bool save()
        {
            NHANVIEN nv = new NHANVIEN();

            string tenNV = "";
            string ngaySinh = "";
            string gioiTinh = "";
            string sdt = "";
            string diaChi = "";
            string cmnd = "";
            string luong = "";
            string tinhTrang = "";
            string chucVu = "";
            

            if (txtHoTen.Text != "")
            {
                tenNV = txtHoTen.Text.ToString();
            }
            else
            {
                XtraMessageBox.Show("Bạn chưa nhập họ tên", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoTen.Focus();
                return false;
            }
            if (txtNgaySinh.Text != "")
            {
                ngaySinh = txtNgaySinh.Text.ToString();
            }
            else
            {
                XtraMessageBox.Show("Bạn chưa nhập ngày sinh", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNgaySinh.Focus();
                return false;
            }
            if (txtGioiTinh.Text != "")
            {
                gioiTinh = txtGioiTinh.Text.ToString();
            }
            else
            {
                XtraMessageBox.Show("Bạn chưa nhập giới tính", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGioiTinh.Focus();
                return false;
            }

            if (txtSDT.Text != "")
            {
                sdt = txtSDT.Text.ToString();
            }
            else
            {
             
                XtraMessageBox.Show("Bạn chưa nhập số điện thoại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSDT.Focus();
                return false;
            }
            if(txtSDT.Text.Length != 10)
            {
                XtraMessageBox.Show("Số điện thoại phải 10 số!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
              
            if (txtDiaChi.Text != "")
            {
                diaChi = txtDiaChi.Text.ToString();
            }
            else
            {
                XtraMessageBox.Show("Bạn chưa nhập địa chỉ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiaChi.Focus();
                return false;
            }
            if (txtCMND.Text != "")
            {
                cmnd = txtCMND.Text.ToString();
            }
            else
            {
                XtraMessageBox.Show("Bạn chưa nhập CMND", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCMND.Focus();
                return false;
            }
            if (txtLuong.Text != "")
            {
                luong = txtLuong.Text.ToString();
            }
            else
            {
                XtraMessageBox.Show("Bạn chưa nhập lương", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLuong.Focus();
                return false;
            }
            float n;
            if (!float.TryParse(txtLuong.Text, out n))
            {
                XtraMessageBox.Show("Lương chỉ được nhập số", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLuong.Focus();
                return false;
            }
            if (txtTinhTrang.Text != "")
            {
                tinhTrang = txtTinhTrang.Text.ToString();
            }
            else
            {
                XtraMessageBox.Show("Bạn chưa nhập tình trạng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTinhTrang.Focus();
                return false;
            }
            if (txtChucVu.Text != "")
            {
                chucVu = txtChucVu.Text.ToString();
            }
            else
            {
                XtraMessageBox.Show("Bạn chưa nhập chức vụ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtChucVu.Focus();
                return false;
            }
             
            try
            {
                   
                nv.TENNHANVIEN = tenNV;
                nv.NGAYSINH = DateTime.Parse(ngaySinh);
                nv.GIOITINH = gioiTinh;
                nv.SDT = sdt;
                nv.DIACHI = diaChi;
                nv.CMND = cmnd;
                nv.LUONG = double.Parse(luong);
                nv.TINHTRANG = tinhTrang;
                nv.CHUCVU = chucVu;

                db.NHANVIENs.InsertOnSubmit(nv);
                db.SubmitChanges();

                //loadData();

                txtHoTen.Text = "";
                txtNgaySinh.Text = "";
                txtGioiTinh.Text = "";
                txtSDT.Text = "";
                txtDiaChi.Text = "";
                txtCMND.Text = "";
                txtLuong.Text = "";
                txtTinhTrang.Text = "";
                txtChucVu.Text = "";
                txtHoTen.Focus();
                XtraMessageBox.Show("Bạn đã thêm thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            catch
            {
                XtraMessageBox.Show("Ngày sinh không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return true;
        }

        private void FormThemNV_Load(object sender, EventArgs e)
        {
            List<string> gioiTinh = new List<string> { "Nam", "Nữ" };
            txtGioiTinh.DataSource = gioiTinh;
            List<string> tinhTrang =new List<string>{"Đang hoạt động","Đã nghỉ" };
            txtTinhTrang.DataSource = tinhTrang;
            List<string> chucVu = new List<string> { "Phục vụ", "Thu Ngân", "Nhân Viên", "Quản lý" };
            txtChucVu.DataSource = chucVu;
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
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
