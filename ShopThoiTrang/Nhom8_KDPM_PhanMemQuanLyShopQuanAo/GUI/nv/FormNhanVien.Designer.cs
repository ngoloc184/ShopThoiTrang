﻿
namespace GUI
{
    partial class FormNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                this.barManager = null;
                this.barDockControlBottom = null;
                this.barDockControlLeft = null;
                this.barDockControlRight = null;
                this.barDockControlTop = null;
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhanVien));
            this.barManager = new DevExpress.ExpressApp.Win.Templates.Bars.XafBarManagerV2(this.components);
            this.actionContainerObjectsCreation = new DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer();
            this.barContainerObjectsCreation = new DevExpress.XtraBars.BarLinkContainerExItem();
            this.actionContainerFile = new DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer();
            this.barContainerFile = new DevExpress.XtraBars.BarLinkContainerExItem();
            this.actionContainerClose = new DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer();
            this.barContainerClose = new DevExpress.XtraBars.BarLinkContainerExItem();
            this.actionContainerSave = new DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer();
            this.barContainerSave = new DevExpress.XtraBars.BarLinkContainerExItem();
            this.actionContainerExport = new DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer();
            this.barContainerExport = new DevExpress.XtraBars.BarLinkContainerExItem();
            this.actionContainerPrint = new DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer();
            this.barContainerPrint = new DevExpress.XtraBars.BarLinkContainerExItem();
            this.actionContainerUndoRedo = new DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer();
            this.barContainerUndoRedo = new DevExpress.XtraBars.BarLinkContainerExItem();
            this.actionContainerEdit = new DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer();
            this.barContainerEdit = new DevExpress.XtraBars.BarLinkContainerExItem();
            this.actionContainerRecordEdit = new DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer();
            this.barContainerRecordEdit = new DevExpress.XtraBars.BarLinkContainerExItem();
            this.actionContainerWorkflow = new DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer();
            this.barContainerWorkflow = new DevExpress.XtraBars.BarLinkContainerExItem();
            this.actionContainerOpenObject = new DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer();
            this.barContainerOpenObject = new DevExpress.XtraBars.BarLinkContainerExItem();
            this.actionContainerRecordsNavigation = new DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer();
            this.barContainerRecordsNavigation = new DevExpress.XtraBars.BarLinkContainerExItem();
            this.actionContainerView = new DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer();
            this.barContainerView = new DevExpress.XtraBars.BarLinkContainerExItem();
            this.actionContainerReports = new DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer();
            this.barContainerReports = new DevExpress.XtraBars.BarLinkContainerExItem();
            this.actionContainerSearch = new DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer();
            this.barContainerSearch = new DevExpress.XtraBars.BarLinkContainerExItem();
            this.actionContainerFullTextSearch = new DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer();
            this.barContainerFullTextSearch = new DevExpress.XtraBars.BarLinkContainerExItem();
            this.actionContainerFilters = new DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer();
            this.barContainerFilters = new DevExpress.XtraBars.BarLinkContainerExItem();
            this.actionContainerTools = new DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer();
            this.barContainerTools = new DevExpress.XtraBars.BarLinkContainerExItem();
            this.actionContainerOptions = new DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer();
            this.barContainerOptions = new DevExpress.XtraBars.BarLinkContainerExItem();
            this.actionContainerDiagnostic = new DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer();
            this.barContainerDiagnostic = new DevExpress.XtraBars.BarLinkContainerExItem();
            this.actionContainerAbout = new DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer();
            this.barContainerAbout = new DevExpress.XtraBars.BarLinkContainerExItem();
            this.actionContainerMenu = new DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer();
            this.barContainerMenu = new DevExpress.XtraBars.BarLinkContainerExItem();
            this.actionContainerNotifications = new DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer();
            this.barContainerNotifications = new DevExpress.XtraBars.BarLinkContainerExItem();
            this._statusBar = new DevExpress.XtraBars.Bar();
            this.barContainerStatusMessages = new DevExpress.XtraBars.BarLinkContainerExItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barSubItemFile = new DevExpress.XtraBars.BarSubItem();
            this.barSubItemEdit = new DevExpress.XtraBars.BarSubItem();
            this.barSubItemView = new DevExpress.XtraBars.BarSubItem();
            this.barSubItemTools = new DevExpress.XtraBars.BarSubItem();
            this.barSubItemHelp = new DevExpress.XtraBars.BarSubItem();
            this.modelSynchronizationManager = new DevExpress.ExpressApp.Win.Templates.ModelSynchronizationManager(this.components);
            this.formStateModelSynchronizer = new DevExpress.ExpressApp.Win.Core.FormStateModelSynchronizer(this.components);
            this.viewSiteManager = new DevExpress.ExpressApp.Win.Templates.ViewSiteManager(this.components);
            this.viewSitePanel = new DevExpress.XtraEditors.PanelControl();
            this.gridNhanVien = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGioiTinh = new System.Windows.Forms.ComboBox();
            this.txtChucVU = new System.Windows.Forms.ComboBox();
            this.txtTinhTrang = new System.Windows.Forms.ComboBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CMND = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtDiaChi = new System.Windows.Forms.RichTextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.qLSHOPDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSHOPDataSet = new GUI.DataSet1();
            this.contextMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionContainerObjectsCreation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionContainerFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionContainerClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionContainerSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionContainerExport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionContainerPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionContainerUndoRedo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionContainerEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionContainerRecordEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionContainerWorkflow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionContainerOpenObject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionContainerRecordsNavigation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionContainerView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionContainerReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionContainerSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionContainerFullTextSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionContainerFilters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionContainerTools)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionContainerOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionContainerDiagnostic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionContainerAbout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionContainerMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionContainerNotifications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSitePanel)).BeginInit();
            this.viewSitePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSHOPDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSHOPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager
            // 
            this.barManager.ActionContainers.Add(this.actionContainerObjectsCreation);
            this.barManager.ActionContainers.Add(this.actionContainerFile);
            this.barManager.ActionContainers.Add(this.actionContainerClose);
            this.barManager.ActionContainers.Add(this.actionContainerSave);
            this.barManager.ActionContainers.Add(this.actionContainerExport);
            this.barManager.ActionContainers.Add(this.actionContainerPrint);
            this.barManager.ActionContainers.Add(this.actionContainerUndoRedo);
            this.barManager.ActionContainers.Add(this.actionContainerEdit);
            this.barManager.ActionContainers.Add(this.actionContainerRecordEdit);
            this.barManager.ActionContainers.Add(this.actionContainerWorkflow);
            this.barManager.ActionContainers.Add(this.actionContainerOpenObject);
            this.barManager.ActionContainers.Add(this.actionContainerRecordsNavigation);
            this.barManager.ActionContainers.Add(this.actionContainerView);
            this.barManager.ActionContainers.Add(this.actionContainerReports);
            this.barManager.ActionContainers.Add(this.actionContainerSearch);
            this.barManager.ActionContainers.Add(this.actionContainerFullTextSearch);
            this.barManager.ActionContainers.Add(this.actionContainerFilters);
            this.barManager.ActionContainers.Add(this.actionContainerTools);
            this.barManager.ActionContainers.Add(this.actionContainerOptions);
            this.barManager.ActionContainers.Add(this.actionContainerDiagnostic);
            this.barManager.ActionContainers.Add(this.actionContainerAbout);
            this.barManager.ActionContainers.Add(this.actionContainerMenu);
            this.barManager.ActionContainers.Add(this.actionContainerNotifications);
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this._statusBar});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItemFile,
            this.barSubItemEdit,
            this.barSubItemView,
            this.barSubItemTools,
            this.barSubItemHelp,
            this.barContainerFile,
            this.barContainerObjectsCreation,
            this.barContainerClose,
            this.barContainerSave,
            this.barContainerEdit,
            this.barContainerOpenObject,
            this.barContainerUndoRedo,
            this.barContainerReports,
            this.barContainerPrint,
            this.barContainerExport,
            this.barContainerMenu,
            this.barContainerRecordEdit,
            this.barContainerWorkflow,
            this.barContainerRecordsNavigation,
            this.barContainerSearch,
            this.barContainerFullTextSearch,
            this.barContainerFilters,
            this.barContainerView,
            this.barContainerTools,
            this.barContainerOptions,
            this.barContainerDiagnostic,
            this.barContainerAbout,
            this.barContainerNotifications,
            this.barContainerStatusMessages});
            this.barManager.MaxItemId = 28;
            this.barManager.StatusBar = this._statusBar;
            // 
            // actionContainerObjectsCreation
            // 
            this.actionContainerObjectsCreation.ActionCategory = "ObjectsCreation";
            this.actionContainerObjectsCreation.BarContainerItem = this.barContainerObjectsCreation;
            // 
            // barContainerObjectsCreation
            // 
            resources.ApplyResources(this.barContainerObjectsCreation, "barContainerObjectsCreation");
            this.barContainerObjectsCreation.Id = 5;
            this.barContainerObjectsCreation.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems;
            this.barContainerObjectsCreation.Name = "barContainerObjectsCreation";
            // 
            // actionContainerFile
            // 
            this.actionContainerFile.ActionCategory = "File";
            this.actionContainerFile.BarContainerItem = this.barContainerFile;
            // 
            // barContainerFile
            // 
            resources.ApplyResources(this.barContainerFile, "barContainerFile");
            this.barContainerFile.Id = 6;
            this.barContainerFile.MergeOrder = 2;
            this.barContainerFile.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems;
            this.barContainerFile.Name = "barContainerFile";
            // 
            // actionContainerClose
            // 
            this.actionContainerClose.ActionCategory = "Close";
            this.actionContainerClose.BarContainerItem = this.barContainerClose;
            // 
            // barContainerClose
            // 
            resources.ApplyResources(this.barContainerClose, "barContainerClose");
            this.barContainerClose.Id = 7;
            this.barContainerClose.MergeOrder = 2;
            this.barContainerClose.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems;
            this.barContainerClose.Name = "barContainerClose";
            // 
            // actionContainerSave
            // 
            this.actionContainerSave.ActionCategory = "Save";
            this.actionContainerSave.BarContainerItem = this.barContainerSave;
            // 
            // barContainerSave
            // 
            resources.ApplyResources(this.barContainerSave, "barContainerSave");
            this.barContainerSave.Id = 8;
            this.barContainerSave.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems;
            this.barContainerSave.Name = "barContainerSave";
            // 
            // actionContainerExport
            // 
            this.actionContainerExport.ActionCategory = "Export";
            this.actionContainerExport.BarContainerItem = this.barContainerExport;
            // 
            // barContainerExport
            // 
            resources.ApplyResources(this.barContainerExport, "barContainerExport");
            this.barContainerExport.Id = 9;
            this.barContainerExport.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems;
            this.barContainerExport.Name = "barContainerExport";
            // 
            // actionContainerPrint
            // 
            this.actionContainerPrint.ActionCategory = "Print";
            this.actionContainerPrint.BarContainerItem = this.barContainerPrint;
            // 
            // barContainerPrint
            // 
            resources.ApplyResources(this.barContainerPrint, "barContainerPrint");
            this.barContainerPrint.Id = 10;
            this.barContainerPrint.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems;
            this.barContainerPrint.Name = "barContainerPrint";
            // 
            // actionContainerUndoRedo
            // 
            this.actionContainerUndoRedo.ActionCategory = "UndoRedo";
            this.actionContainerUndoRedo.BarContainerItem = this.barContainerUndoRedo;
            // 
            // barContainerUndoRedo
            // 
            resources.ApplyResources(this.barContainerUndoRedo, "barContainerUndoRedo");
            this.barContainerUndoRedo.Id = 11;
            this.barContainerUndoRedo.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems;
            this.barContainerUndoRedo.Name = "barContainerUndoRedo";
            // 
            // actionContainerEdit
            // 
            this.actionContainerEdit.ActionCategory = "Edit";
            this.actionContainerEdit.BarContainerItem = this.barContainerEdit;
            // 
            // barContainerEdit
            // 
            resources.ApplyResources(this.barContainerEdit, "barContainerEdit");
            this.barContainerEdit.Id = 12;
            this.barContainerEdit.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems;
            this.barContainerEdit.Name = "barContainerEdit";
            // 
            // actionContainerRecordEdit
            // 
            this.actionContainerRecordEdit.ActionCategory = "RecordEdit";
            this.actionContainerRecordEdit.BarContainerItem = this.barContainerRecordEdit;
            // 
            // barContainerRecordEdit
            // 
            resources.ApplyResources(this.barContainerRecordEdit, "barContainerRecordEdit");
            this.barContainerRecordEdit.Id = 13;
            this.barContainerRecordEdit.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems;
            this.barContainerRecordEdit.Name = "barContainerRecordEdit";
            // 
            // actionContainerWorkflow
            // 
            this.actionContainerWorkflow.ActionCategory = "Workflow";
            this.actionContainerWorkflow.BarContainerItem = this.barContainerWorkflow;
            // 
            // barContainerWorkflow
            // 
            resources.ApplyResources(this.barContainerWorkflow, "barContainerWorkflow");
            this.barContainerWorkflow.Id = 14;
            this.barContainerWorkflow.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems;
            this.barContainerWorkflow.Name = "barContainerWorkflow";
            // 
            // actionContainerOpenObject
            // 
            this.actionContainerOpenObject.ActionCategory = "OpenObject";
            this.actionContainerOpenObject.BarContainerItem = this.barContainerOpenObject;
            // 
            // barContainerOpenObject
            // 
            resources.ApplyResources(this.barContainerOpenObject, "barContainerOpenObject");
            this.barContainerOpenObject.Id = 15;
            this.barContainerOpenObject.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems;
            this.barContainerOpenObject.Name = "barContainerOpenObject";
            // 
            // actionContainerRecordsNavigation
            // 
            this.actionContainerRecordsNavigation.ActionCategory = "RecordsNavigation";
            this.actionContainerRecordsNavigation.BarContainerItem = this.barContainerRecordsNavigation;
            // 
            // barContainerRecordsNavigation
            // 
            resources.ApplyResources(this.barContainerRecordsNavigation, "barContainerRecordsNavigation");
            this.barContainerRecordsNavigation.Id = 16;
            this.barContainerRecordsNavigation.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems;
            this.barContainerRecordsNavigation.Name = "barContainerRecordsNavigation";
            // 
            // actionContainerView
            // 
            this.actionContainerView.ActionCategory = "View";
            this.actionContainerView.BarContainerItem = this.barContainerView;
            // 
            // barContainerView
            // 
            resources.ApplyResources(this.barContainerView, "barContainerView");
            this.barContainerView.Id = 17;
            this.barContainerView.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems;
            this.barContainerView.Name = "barContainerView";
            // 
            // actionContainerReports
            // 
            this.actionContainerReports.ActionCategory = "Reports";
            this.actionContainerReports.BarContainerItem = this.barContainerReports;
            // 
            // barContainerReports
            // 
            resources.ApplyResources(this.barContainerReports, "barContainerReports");
            this.barContainerReports.Id = 18;
            this.barContainerReports.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems;
            this.barContainerReports.Name = "barContainerReports";
            // 
            // actionContainerSearch
            // 
            this.actionContainerSearch.ActionCategory = "Search";
            this.actionContainerSearch.BarContainerItem = this.barContainerSearch;
            // 
            // barContainerSearch
            // 
            resources.ApplyResources(this.barContainerSearch, "barContainerSearch");
            this.barContainerSearch.Id = 19;
            this.barContainerSearch.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems;
            this.barContainerSearch.Name = "barContainerSearch";
            // 
            // actionContainerFullTextSearch
            // 
            this.actionContainerFullTextSearch.ActionCategory = "FullTextSearch";
            this.actionContainerFullTextSearch.BarContainerItem = this.barContainerFullTextSearch;
            // 
            // barContainerFullTextSearch
            // 
            this.barContainerFullTextSearch.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            resources.ApplyResources(this.barContainerFullTextSearch, "barContainerFullTextSearch");
            this.barContainerFullTextSearch.Id = 20;
            this.barContainerFullTextSearch.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems;
            this.barContainerFullTextSearch.Name = "barContainerFullTextSearch";
            // 
            // actionContainerFilters
            // 
            this.actionContainerFilters.ActionCategory = "Filters";
            this.actionContainerFilters.BarContainerItem = this.barContainerFilters;
            // 
            // barContainerFilters
            // 
            resources.ApplyResources(this.barContainerFilters, "barContainerFilters");
            this.barContainerFilters.Id = 21;
            this.barContainerFilters.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems;
            this.barContainerFilters.Name = "barContainerFilters";
            // 
            // actionContainerTools
            // 
            this.actionContainerTools.ActionCategory = "Tools";
            this.actionContainerTools.BarContainerItem = this.barContainerTools;
            this.actionContainerTools.IsMenuMode = true;
            // 
            // barContainerTools
            // 
            resources.ApplyResources(this.barContainerTools, "barContainerTools");
            this.barContainerTools.Id = 22;
            this.barContainerTools.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems;
            this.barContainerTools.Name = "barContainerTools";
            // 
            // actionContainerOptions
            // 
            this.actionContainerOptions.ActionCategory = "Options";
            this.actionContainerOptions.BarContainerItem = this.barContainerOptions;
            this.actionContainerOptions.IsMenuMode = true;
            // 
            // barContainerOptions
            // 
            resources.ApplyResources(this.barContainerOptions, "barContainerOptions");
            this.barContainerOptions.Id = 23;
            this.barContainerOptions.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems;
            this.barContainerOptions.Name = "barContainerOptions";
            // 
            // actionContainerDiagnostic
            // 
            this.actionContainerDiagnostic.ActionCategory = "Diagnostic";
            this.actionContainerDiagnostic.BarContainerItem = this.barContainerDiagnostic;
            this.actionContainerDiagnostic.IsMenuMode = true;
            // 
            // barContainerDiagnostic
            // 
            resources.ApplyResources(this.barContainerDiagnostic, "barContainerDiagnostic");
            this.barContainerDiagnostic.Id = 24;
            this.barContainerDiagnostic.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems;
            this.barContainerDiagnostic.Name = "barContainerDiagnostic";
            // 
            // actionContainerAbout
            // 
            this.actionContainerAbout.ActionCategory = "About";
            this.actionContainerAbout.BarContainerItem = this.barContainerAbout;
            this.actionContainerAbout.IsMenuMode = true;
            // 
            // barContainerAbout
            // 
            resources.ApplyResources(this.barContainerAbout, "barContainerAbout");
            this.barContainerAbout.Id = 25;
            this.barContainerAbout.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems;
            this.barContainerAbout.Name = "barContainerAbout";
            // 
            // actionContainerMenu
            // 
            this.actionContainerMenu.ActionCategory = "Menu";
            this.actionContainerMenu.BarContainerItem = this.barContainerMenu;
            // 
            // barContainerMenu
            // 
            resources.ApplyResources(this.barContainerMenu, "barContainerMenu");
            this.barContainerMenu.Id = 26;
            this.barContainerMenu.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems;
            this.barContainerMenu.Name = "barContainerMenu";
            // 
            // actionContainerNotifications
            // 
            this.actionContainerNotifications.ActionCategory = "Notifications";
            this.actionContainerNotifications.BarContainerItem = this.barContainerNotifications;
            // 
            // barContainerNotifications
            // 
            this.barContainerNotifications.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            resources.ApplyResources(this.barContainerNotifications, "barContainerNotifications");
            this.barContainerNotifications.Id = 27;
            this.barContainerNotifications.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems;
            this.barContainerNotifications.Name = "barContainerNotifications";
            // 
            // _statusBar
            // 
            this._statusBar.BarName = "StatusBar";
            this._statusBar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this._statusBar.DockCol = 0;
            this._statusBar.DockRow = 0;
            this._statusBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this._statusBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barContainerStatusMessages),
            new DevExpress.XtraBars.LinkPersistInfo(this.barContainerNotifications)});
            this._statusBar.OptionsBar.AllowQuickCustomization = false;
            this._statusBar.OptionsBar.DisableClose = true;
            this._statusBar.OptionsBar.DisableCustomization = true;
            this._statusBar.OptionsBar.DrawDragBorder = false;
            this._statusBar.OptionsBar.DrawSizeGrip = true;
            this._statusBar.OptionsBar.UseWholeRow = true;
            resources.ApplyResources(this._statusBar, "_statusBar");
            // 
            // barContainerStatusMessages
            // 
            resources.ApplyResources(this.barContainerStatusMessages, "barContainerStatusMessages");
            this.barContainerStatusMessages.Id = 28;
            this.barContainerStatusMessages.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems;
            this.barContainerStatusMessages.Name = "barContainerStatusMessages";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            resources.ApplyResources(this.barDockControlTop, "barDockControlTop");
            this.barDockControlTop.Manager = this.barManager;
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            resources.ApplyResources(this.barDockControlBottom, "barDockControlBottom");
            this.barDockControlBottom.Manager = this.barManager;
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            resources.ApplyResources(this.barDockControlLeft, "barDockControlLeft");
            this.barDockControlLeft.Manager = this.barManager;
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            resources.ApplyResources(this.barDockControlRight, "barDockControlRight");
            this.barDockControlRight.Manager = this.barManager;
            // 
            // barSubItemFile
            // 
            resources.ApplyResources(this.barSubItemFile, "barSubItemFile");
            this.barSubItemFile.HideWhenEmpty = true;
            this.barSubItemFile.Id = 0;
            this.barSubItemFile.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barContainerObjectsCreation, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barContainerFile, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barContainerClose, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barContainerSave, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barContainerExport, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barContainerPrint, true)});
            this.barSubItemFile.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems;
            this.barSubItemFile.Name = "barSubItemFile";
            // 
            // barSubItemEdit
            // 
            resources.ApplyResources(this.barSubItemEdit, "barSubItemEdit");
            this.barSubItemEdit.HideWhenEmpty = true;
            this.barSubItemEdit.Id = 1;
            this.barSubItemEdit.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barContainerUndoRedo, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barContainerEdit, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barContainerRecordEdit, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barContainerWorkflow, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barContainerOpenObject, true)});
            this.barSubItemEdit.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems;
            this.barSubItemEdit.Name = "barSubItemEdit";
            // 
            // barSubItemView
            // 
            resources.ApplyResources(this.barSubItemView, "barSubItemView");
            this.barSubItemView.HideWhenEmpty = true;
            this.barSubItemView.Id = 2;
            this.barSubItemView.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barContainerRecordsNavigation, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barContainerView, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barContainerReports, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barContainerSearch, true),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.None, false, this.barContainerFullTextSearch, true),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.None, false, this.barContainerFilters, true)});
            this.barSubItemView.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems;
            this.barSubItemView.Name = "barSubItemView";
            // 
            // barSubItemTools
            // 
            resources.ApplyResources(this.barSubItemTools, "barSubItemTools");
            this.barSubItemTools.HideWhenEmpty = true;
            this.barSubItemTools.Id = 3;
            this.barSubItemTools.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barContainerTools, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barContainerOptions, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barContainerDiagnostic, true)});
            this.barSubItemTools.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems;
            this.barSubItemTools.Name = "barSubItemTools";
            // 
            // barSubItemHelp
            // 
            resources.ApplyResources(this.barSubItemHelp, "barSubItemHelp");
            this.barSubItemHelp.HideWhenEmpty = true;
            this.barSubItemHelp.Id = 4;
            this.barSubItemHelp.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barContainerAbout, true)});
            this.barSubItemHelp.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems;
            this.barSubItemHelp.Name = "barSubItemHelp";
            // 
            // modelSynchronizationManager
            // 
            this.modelSynchronizationManager.ModelSynchronizableComponents.Add(this.formStateModelSynchronizer);
            // 
            // formStateModelSynchronizer
            // 
            this.formStateModelSynchronizer.Form = this;
            // 
            // viewSiteManager
            // 
            this.viewSiteManager.ViewSiteControl = this.viewSitePanel;
            // 
            // viewSitePanel
            // 
            this.viewSitePanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.viewSitePanel.Controls.Add(this.gridNhanVien);
            this.viewSitePanel.Controls.Add(this.groupBox1);
            resources.ApplyResources(this.viewSitePanel, "viewSitePanel");
            this.viewSitePanel.Name = "viewSitePanel";
            this.viewSitePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.viewSitePanel_Paint);
            // 
            // gridNhanVien
            // 
            this.gridNhanVien.EmbeddedNavigator.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("gridNhanVien.EmbeddedNavigator.Margin")));
            this.gridNhanVien.EmbeddedNavigator.Click += new System.EventHandler(this.gridNhanVien_EmbeddedNavigator_Click);
            resources.ApplyResources(this.gridNhanVien, "gridNhanVien");
            this.gridNhanVien.MainView = this.gridView1;
            this.gridNhanVien.MenuManager = this.barManager;
            this.gridNhanVien.Name = "gridNhanVien";
            this.gridNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridNhanVien.Click += new System.EventHandler(this.gridNhanVien_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.gridNhanVien;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn1
            // 
            resources.ApplyResources(this.gridColumn1, "gridColumn1");
            this.gridColumn1.FieldName = "MANHANVIEN";
            this.gridColumn1.MinWidth = 21;
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            resources.ApplyResources(this.gridColumn2, "gridColumn2");
            this.gridColumn2.FieldName = "TENNHANVIEN";
            this.gridColumn2.MinWidth = 21;
            this.gridColumn2.Name = "gridColumn2";
            // 
            // gridColumn3
            // 
            resources.ApplyResources(this.gridColumn3, "gridColumn3");
            this.gridColumn3.FieldName = "NGAYSINH";
            this.gridColumn3.MinWidth = 21;
            this.gridColumn3.Name = "gridColumn3";
            // 
            // gridColumn4
            // 
            resources.ApplyResources(this.gridColumn4, "gridColumn4");
            this.gridColumn4.FieldName = "GIOITINH";
            this.gridColumn4.MinWidth = 21;
            this.gridColumn4.Name = "gridColumn4";
            // 
            // gridColumn5
            // 
            resources.ApplyResources(this.gridColumn5, "gridColumn5");
            this.gridColumn5.FieldName = "SDT";
            this.gridColumn5.MinWidth = 21;
            this.gridColumn5.Name = "gridColumn5";
            // 
            // gridColumn6
            // 
            resources.ApplyResources(this.gridColumn6, "gridColumn6");
            this.gridColumn6.FieldName = "DIACHI";
            this.gridColumn6.MinWidth = 21;
            this.gridColumn6.Name = "gridColumn6";
            // 
            // gridColumn7
            // 
            resources.ApplyResources(this.gridColumn7, "gridColumn7");
            this.gridColumn7.FieldName = "CMND";
            this.gridColumn7.MinWidth = 21;
            this.gridColumn7.Name = "gridColumn7";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGioiTinh);
            this.groupBox1.Controls.Add(this.txtChucVU);
            this.groupBox1.Controls.Add(this.txtTinhTrang);
            this.groupBox1.Controls.Add(this.txtLuong);
            this.groupBox1.Controls.Add(this.txtCMND);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.CMND);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtNgaySinh);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.FormattingEnabled = true;
            resources.ApplyResources(this.txtGioiTinh, "txtGioiTinh");
            this.txtGioiTinh.Name = "txtGioiTinh";
            // 
            // txtChucVU
            // 
            this.txtChucVU.FormattingEnabled = true;
            resources.ApplyResources(this.txtChucVU, "txtChucVU");
            this.txtChucVU.Name = "txtChucVU";
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.FormattingEnabled = true;
            resources.ApplyResources(this.txtTinhTrang, "txtTinhTrang");
            this.txtTinhTrang.Name = "txtTinhTrang";
            // 
            // txtLuong
            // 
            resources.ApplyResources(this.txtLuong, "txtLuong");
            this.txtLuong.Name = "txtLuong";
            // 
            // txtCMND
            // 
            resources.ApplyResources(this.txtCMND, "txtCMND");
            this.txtCMND.Name = "txtCMND";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // CMND
            // 
            resources.ApplyResources(this.CMND, "CMND");
            this.CMND.Name = "CMND";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // txtDiaChi
            // 
            resources.ApplyResources(this.txtDiaChi, "txtDiaChi");
            this.txtDiaChi.Name = "txtDiaChi";
            // 
            // txtSDT
            // 
            resources.ApplyResources(this.txtSDT, "txtSDT");
            this.txtSDT.Name = "txtSDT";
            // 
            // txtNgaySinh
            // 
            resources.ApplyResources(this.txtNgaySinh, "txtNgaySinh");
            this.txtNgaySinh.Name = "txtNgaySinh";
            // 
            // txtHoTen
            // 
            resources.ApplyResources(this.txtHoTen, "txtHoTen");
            this.txtHoTen.Name = "txtHoTen";
            // 
            // txtMaNV
            // 
            resources.ApplyResources(this.txtMaNV, "txtMaNV");
            this.txtMaNV.Name = "txtMaNV";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // qLSHOPDataSetBindingSource
            // 
            this.qLSHOPDataSetBindingSource.DataSource = this.qLSHOPDataSet;
            this.qLSHOPDataSetBindingSource.Position = 0;
            // 
            // qLSHOPDataSet
            // 
            this.qLSHOPDataSet.DataSetName = "QLSHOPDataSet";
            this.qLSHOPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contextMenu
            // 
            this.contextMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barContainerObjectsCreation, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barContainerSave, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barContainerEdit, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barContainerOpenObject, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barContainerUndoRedo, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barContainerReports, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barContainerClose, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barContainerRecordEdit, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barContainerView, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barContainerPrint, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barContainerExport, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barContainerMenu, true)});
            this.contextMenu.Manager = this.barManager;
            this.contextMenu.Name = "contextMenu";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControl1);
            this.barManager1.DockControls.Add(this.barDockControl2);
            this.barManager1.DockControls.Add(this.barDockControl3);
            this.barManager1.DockControls.Add(this.barDockControl4);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barThoat,
            this.barButtonItem4});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 5;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.FloatLocation = new System.Drawing.Point(225, 230);
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem2, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem3, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem4, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Offset = 1;
            resources.ApplyResources(this.bar1, "bar1");
            // 
            // barButtonItem1
            // 
            resources.ApplyResources(this.barButtonItem1, "barButtonItem1");
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            resources.ApplyResources(this.barButtonItem2, "barButtonItem2");
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            resources.ApplyResources(this.barButtonItem3, "barButtonItem3");
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barThoat
            // 
            resources.ApplyResources(this.barThoat, "barThoat");
            this.barThoat.Id = 3;
            this.barThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barThoat.ImageOptions.Image")));
            this.barThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barThoat.ImageOptions.LargeImage")));
            this.barThoat.Name = "barThoat";
            this.barThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barThoat_ItemClick);
            // 
            // barButtonItem4
            // 
            resources.ApplyResources(this.barButtonItem4, "barButtonItem4");
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            resources.ApplyResources(this.bar2, "bar2");
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            resources.ApplyResources(this.bar3, "bar3");
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            resources.ApplyResources(this.barDockControl1, "barDockControl1");
            this.barDockControl1.Manager = this.barManager1;
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            resources.ApplyResources(this.barDockControl2, "barDockControl2");
            this.barDockControl2.Manager = this.barManager1;
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            resources.ApplyResources(this.barDockControl3, "barDockControl3");
            this.barDockControl3.Manager = this.barManager1;
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            resources.ApplyResources(this.barDockControl4, "barDockControl4");
            this.barDockControl4.Manager = this.barManager1;
            // 
            // FormNhanVien
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.viewSitePanel);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Name = "FormNhanVien";
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionContainerObjectsCreation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionContainerFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionContainerClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionContainerSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionContainerExport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionContainerPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionContainerUndoRedo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionContainerEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionContainerRecordEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionContainerWorkflow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionContainerOpenObject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionContainerRecordsNavigation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionContainerView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionContainerReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionContainerSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionContainerFullTextSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionContainerFilters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionContainerTools)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionContainerOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionContainerDiagnostic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionContainerAbout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionContainerMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionContainerNotifications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSitePanel)).EndInit();
            this.viewSitePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSHOPDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSHOPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private DevExpress.ExpressApp.Win.Templates.Bars.XafBarManagerV2 barManager;
        private DevExpress.XtraEditors.PanelControl viewSitePanel;
        private DevExpress.ExpressApp.Win.Core.FormStateModelSynchronizer formStateModelSynchronizer;
        private DevExpress.ExpressApp.Win.Templates.ModelSynchronizationManager modelSynchronizationManager;
        private DevExpress.ExpressApp.Win.Templates.ViewSiteManager viewSiteManager;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.Bar _statusBar;
        private DevExpress.XtraBars.BarSubItem barSubItemFile;
        private DevExpress.XtraBars.BarSubItem barSubItemEdit;
        private DevExpress.XtraBars.BarSubItem barSubItemView;
        private DevExpress.XtraBars.BarSubItem barSubItemTools;
        private DevExpress.XtraBars.BarSubItem barSubItemHelp;
        private DevExpress.XtraBars.PopupMenu contextMenu;
        private DevExpress.XtraBars.BarLinkContainerExItem barContainerFile;
        private DevExpress.XtraBars.BarLinkContainerExItem barContainerObjectsCreation;
        private DevExpress.XtraBars.BarLinkContainerExItem barContainerClose;
        private DevExpress.XtraBars.BarLinkContainerExItem barContainerSave;
        private DevExpress.XtraBars.BarLinkContainerExItem barContainerEdit;
        private DevExpress.XtraBars.BarLinkContainerExItem barContainerOpenObject;
        private DevExpress.XtraBars.BarLinkContainerExItem barContainerUndoRedo;
        private DevExpress.XtraBars.BarLinkContainerExItem barContainerReports;
        private DevExpress.XtraBars.BarLinkContainerExItem barContainerPrint;
        private DevExpress.XtraBars.BarLinkContainerExItem barContainerExport;
        private DevExpress.XtraBars.BarLinkContainerExItem barContainerMenu;
        private DevExpress.XtraBars.BarLinkContainerExItem barContainerRecordEdit;
        private DevExpress.XtraBars.BarLinkContainerExItem barContainerWorkflow;
        private DevExpress.XtraBars.BarLinkContainerExItem barContainerRecordsNavigation;
        private DevExpress.XtraBars.BarLinkContainerExItem barContainerSearch;
        private DevExpress.XtraBars.BarLinkContainerExItem barContainerFullTextSearch;
        private DevExpress.XtraBars.BarLinkContainerExItem barContainerFilters;
        private DevExpress.XtraBars.BarLinkContainerExItem barContainerView;
        private DevExpress.XtraBars.BarLinkContainerExItem barContainerTools;
        private DevExpress.XtraBars.BarLinkContainerExItem barContainerOptions;
        private DevExpress.XtraBars.BarLinkContainerExItem barContainerAbout;
        private DevExpress.XtraBars.BarLinkContainerExItem barContainerDiagnostic;
        private DevExpress.XtraBars.BarLinkContainerExItem barContainerNotifications;
        private DevExpress.XtraBars.BarLinkContainerExItem barContainerStatusMessages;
        private DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer actionContainerFile;
        private DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer actionContainerObjectsCreation;
        private DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer actionContainerClose;
        private DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer actionContainerSave;
        private DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer actionContainerEdit;
        private DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer actionContainerOpenObject;
        private DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer actionContainerUndoRedo;
        private DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer actionContainerReports;
        private DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer actionContainerPrint;
        private DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer actionContainerExport;
        private DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer actionContainerRecordEdit;
        private DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer actionContainerWorkflow;
        private DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer actionContainerRecordsNavigation;
        private DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer actionContainerSearch;
        private DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer actionContainerFullTextSearch;
        private DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer actionContainerFilters;
        private DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer actionContainerView;
        private DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer actionContainerTools;
        private DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer actionContainerOptions;
        private DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer actionContainerAbout;
        private DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer actionContainerDiagnostic;
        private DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer actionContainerMenu;
        private DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer actionContainerNotifications;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barThoat;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label CMND;
        private DevExpress.XtraGrid.GridControl gridNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource qLSHOPDataSetBindingSource;
        private DataSet1 qLSHOPDataSet;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private System.Windows.Forms.ComboBox txtTinhTrang;
        private System.Windows.Forms.ComboBox txtChucVU;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private System.Windows.Forms.ComboBox txtGioiTinh;
    }
}