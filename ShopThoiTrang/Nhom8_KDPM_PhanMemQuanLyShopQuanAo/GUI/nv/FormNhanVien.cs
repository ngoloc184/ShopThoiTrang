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
using System.Drawing;
using System.Linq;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace GUI
{
    public partial class FormNhanVien : XtraForm, IActionControlsSite, IContextMenuHolder, IWindowTemplate, IBarManagerHolder, ISupportViewChanged, ISupportUpdate, IViewSiteTemplate, ISupportStoreSettings, IViewHolder
    {
        private static readonly object viewChanged = new object();
        private static readonly object settingsReloaded = new object();
        private StatusMessagesHelper statusMessagesHelper;
        NhanVien_BLLDAL NhanVien_BLLDAL = new NhanVien_BLLDAL();
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
        public FormNhanVien()
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

        private void dataGridView1_Click(object sender, EventArgs e)
        {

            //NHANVIEN nv = db.NHANVIENs.Where(t => t.MANHANVIEN == int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString())).FirstOrDefault();        
            

        }
        public int IdNV = -1;
        public void loadData()
        {
            
            
            gridNhanVien.DataSource = nhanvien_BLLDAL.loadNV();

            List<string> gioiTinh = new List<string> { "Nam", "Nữ" };
            txtGioiTinh.DataSource = gioiTinh;
            List<string> tinhTrang =new List<string>{"Đang hoạt động","Đã nghỉ" };
            txtTinhTrang.DataSource = tinhTrang;
            List<string> chucVu = new List<string> { "Phục vụ", "Thu Ngân", "Nhân Viên", "Quản lý" };
            txtChucVU.DataSource = chucVu;
        }

        private void barThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn thoát khỏi chương trình không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormThemNV frmThemNV = new FormThemNV();
            frmThemNV.ShowDialog();
           //save();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show("Bạn có muốn xóa dòng này không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //lấy mã nhân viên:
                    int maNV = int.Parse(txtMaNV.Text);
                    NHANVIEN nv = NhanVien_BLLDAL.detailNV(maNV);

                    if (nhanvien_BLLDAL.kiemTraNhanVienDaTonTaiTrongHD(maNV) == true)
                    {
                        nhanvien_BLLDAL.xoaNV(maNV);
                        loadData();
                        XtraMessageBox.Show("Bạn đã xóa thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        XtraMessageBox.Show("Bạn Không được xóa nhân viên này!");
                }   
            }
            catch
            {
                XtraMessageBox.Show("Bạn Không được xóa nhân viên này!");
            }
        }

        private void gridNhanVien_EmbeddedNavigator_Click(object sender, EventArgs e)
        {

        }

        private void gridNhanVien_Click(object sender, EventArgs e)
        {
            int maNV = int.Parse(gridView1.GetFocusedRowCellValue("MANHANVIEN").ToString());
            NHANVIEN nv = nhanvien_BLLDAL.detailNV(maNV);

            try
            {
                pictureBox1.Image = new Bitmap(Application.StartupPath + "\\nhanvien\\" + nv.HINHANH);
            }
            catch
            {
                txtMaNV.Text = nv.MANHANVIEN.ToString();
                txtHoTen.Text = nv.TENNHANVIEN.ToString();
                txtNgaySinh.Text = nv.NGAYSINH.ToString();
                txtGioiTinh.Text = nv.GIOITINH.ToString();
                txtSDT.Text = nv.SDT.ToString();
                txtDiaChi.Text = nv.DIACHI.ToString();
                txtCMND.Text = nv.CMND.ToString();
                txtLuong.Text = nv.LUONG.ToString();
                txtTinhTrang.Text = nv.TINHTRANG.ToString();
                txtChucVU.Text = nv.CHUCVU.ToString();
            }
             
            txtMaNV.Text = nv.MANHANVIEN.ToString();
            txtHoTen.Text = nv.TENNHANVIEN.ToString();
            txtNgaySinh.Text = nv.NGAYSINH.ToString();
            txtGioiTinh.Text = nv.GIOITINH.ToString();
            txtSDT.Text = nv.SDT.ToString();
            txtDiaChi.Text = nv.DIACHI.ToString();
            txtCMND.Text = nv.CMND.ToString();
            txtLuong.Text = nv.LUONG.ToString();
            txtTinhTrang.Text = nv.TINHTRANG.ToString();
            txtChucVU.Text = nv.CHUCVU.ToString();
        }

        private bool save()
        {
            NHANVIEN nv = new NHANVIEN();
            string maNV = "";
            string tenNV = "";
            string ngaySinh = "";
            string gioiTinh = "";
            string sdt = "";
            string diaChi = "";
            string cmnd = "";
            string luong = "";
            string tinhTrang = "";
            string chucVu = "";
                  
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
            if(txtHoTen.Text !="")
            {
                tenNV = txtHoTen.Text.ToString();
            }
            else
            {
                XtraMessageBox.Show("Bạn chưa nhập họ tên", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoTen.Focus();
                return false;
            }
            if (txtNgaySinh.Text !="")
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
            if (txtTinhTrang.Text != "")
            {
                tinhTrang = txtTinhTrang.Text.ToString();
            }
            else
            {
                XtraMessageBox.Show("Bạn chưa nhập tình trạng","Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTinhTrang.Focus();
                return false;
            }
            if (txtChucVU.Text != "")
            {
                chucVu = txtChucVU.Text.ToString();
            }
            else
            {
                XtraMessageBox.Show("Bạn chưa nhập chức vụ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtChucVU.Focus();
                return false;
            }
            try
            {
                nv.MANHANVIEN = int.Parse(maNV);
                nv.TENNHANVIEN = tenNV;
                nv.NGAYSINH =DateTime.Parse(ngaySinh);
                nv.GIOITINH = gioiTinh;
                nv.SDT = sdt;                              
                nv.DIACHI = diaChi;
                nv.CMND = cmnd;
                nv.LUONG = double.Parse(luong);
                nv.TINHTRANG = tinhTrang;
                nv.CHUCVU = chucVu;
                
                db.NHANVIENs.InsertOnSubmit(nv);
                db.SubmitChanges();

                loadData();
                txtMaNV.Text = "";
                txtHoTen.Text = "";
                txtNgaySinh.Text = "";
                txtGioiTinh.Text = "";
                txtSDT.Text = "";
                txtDiaChi.Text = "";
                txtCMND.Text = "";
                txtLuong.Text = "";
                txtTinhTrang.Text = "";
                txtChucVU.Text = "";
                txtMaNV.Focus();
                XtraMessageBox.Show("Bạn đã thêm thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            catch
            {
                XtraMessageBox.Show("Thêm không thành công ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return true;
        }
        public Boolean kiemTraNhanVien()
        {
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
            if (txtChucVU.Text != "")
            {
                chucVu = txtChucVU.Text.ToString();
            }
            else
            {
                XtraMessageBox.Show("Bạn chưa nhập chức vụ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtChucVU.Focus();
                return false;
            }
            return true;
        }
        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            //if(kiemTraNhanVien()==false)
            //{
            //    return;
            //}
            //if (txtSDT.Text == "")
            //    return;
            //string maNV = gridView1.GetFocusedRowCellValue("MANHANVIEN").ToString();
            //string tenNV = txtHoTen.Text;
            //string ngaySinh = txtNgaySinh.Text;
            //string gioiTinh = txtGioiTinh.Text;
            //string dt = txtSDT.Text;
            //string dChi = txtDiaChi.Text;
            //string cmnd = txtCMND.Text;
            //string luong = txtLuong.Text;
            //string tTrang = txtTinhTrang.Text;
            //string chVu = txtChucVU.Text;
            //NhanVien_BLLDAL.suaNV(int.Parse(maNV), tenNV,DateTime.Parse(ngaySinh), gioiTinh, dt, dChi, cmnd,float.Parse(luong), tTrang, chVu);
            //XtraMessageBox.Show("Sửa Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            update();
            loadData();
        }
        private bool update()
        {
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
            if (txtSDT.Text.Length != 10)
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
            if (txtChucVU.Text != "")
            {
                chucVu = txtChucVU.Text.ToString();
            }
            else
            {
                XtraMessageBox.Show("Bạn chưa nhập chức vụ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtChucVU.Focus();
                return false;
            }
            
            try
            {
                int NVID= int.Parse(gridView1.GetFocusedRowCellValue("MANHANVIEN").ToString());
                var nv = db.NHANVIENs.Where(t => t.MANHANVIEN == NVID).SingleOrDefault();
                nv.TENNHANVIEN = tenNV;
                nv.NGAYSINH =DateTime.Parse(ngaySinh);
                nv.GIOITINH = gioiTinh;
                if (sdt != nv.SDT)
                {
                    nv.SDT = sdt;
                }
                else
                {
                    XtraMessageBox.Show("SDT không được trùng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                nv.SDT = sdt;
                nv.DIACHI = diaChi;
                nv.CMND = cmnd;
                nv.LUONG = double.Parse(luong);
                nv.TINHTRANG = tinhTrang;
                nv.CHUCVU = chucVu;

                db.SubmitChanges();
                XtraMessageBox.Show("Bạn đã sửa thành công ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loadData();
                
                txtMaNV.Focus();
                return true;
                
            }
            catch
            {
                XtraMessageBox.Show("Ngày sinh không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return true;
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            loadData();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormThemTKNV tknv = new FormThemTKNV();
            tknv.ShowDialog();
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
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
