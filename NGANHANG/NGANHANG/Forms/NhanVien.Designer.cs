namespace NGANHANG.Forms
{
    partial class NhanVien
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
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label sODTLabel;
            System.Windows.Forms.Label mACNLabel;
            System.Windows.Forms.Label pHAILabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanVien));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.Windows.Forms.Label trangThaiXoaLabel;
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.label1 = new System.Windows.Forms.Label();
            this.cbChiNhanh = new System.Windows.Forms.ComboBox();
            this.cN_NGANHANG = new NGANHANG.CN_NGANHANG();
            this.chiNhanhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chiNhanhTableAdapter = new NGANHANG.CN_NGANHANGTableAdapters.ChiNhanhTableAdapter();
            this.tableAdapterManager = new NGANHANG.CN_NGANHANGTableAdapters.TableAdapterManager();
            this.nhanVienTableAdapter = new NGANHANG.CN_NGANHANGTableAdapters.NhanVienTableAdapter();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gioiTinhNam = new System.Windows.Forms.CheckBox();
            this.gbTaoTaiKhoan = new System.Windows.Forms.GroupBox();
            this.tbMatKhau = new System.Windows.Forms.TextBox();
            this.chiNhanh = new System.Windows.Forms.CheckBox();
            this.tbTaiKhoan = new System.Windows.Forms.TextBox();
            this.nganHang = new System.Windows.Forms.CheckBox();
            this.lbMatKhau = new System.Windows.Forms.Label();
            this.lbTaiKhoan = new System.Windows.Forms.Label();
            this.gioiTinhNu = new System.Windows.Forms.CheckBox();
            this.cbTaoTaiKhoan = new System.Windows.Forms.CheckBox();
            this.maChiNhanh = new System.Windows.Forms.TextBox();
            this.SDTNhanVien = new System.Windows.Forms.TextBox();
            this.diaChiNV = new System.Windows.Forms.RichTextBox();
            this.tenNhanVien = new System.Windows.Forms.TextBox();
            this.hoNhanVien = new System.Windows.Forms.TextBox();
            this.maNhanVien = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.trangThaiXoaNV = new System.Windows.Forms.ComboBox();
            mANVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            sODTLabel = new System.Windows.Forms.Label();
            mACNLabel = new System.Windows.Forms.Label();
            pHAILabel = new System.Windows.Forms.Label();
            trangThaiXoaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cN_NGANHANG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiNhanhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbTaoTaiKhoan.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(53, 31);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(75, 13);
            mANVLabel.TabIndex = 0;
            mANVLabel.Text = "Mã nhân viên:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(371, 31);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(24, 13);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "Họ:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(646, 31);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(29, 13);
            tENLabel.TabIndex = 4;
            tENLabel.Text = "Tên:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(352, 137);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(43, 13);
            dIACHILabel.TabIndex = 6;
            dIACHILabel.Text = "Địa chỉ:";
            // 
            // sODTLabel
            // 
            sODTLabel.AutoSize = true;
            sODTLabel.Location = new System.Drawing.Point(322, 83);
            sODTLabel.Name = "sODTLabel";
            sODTLabel.Size = new System.Drawing.Size(73, 13);
            sODTLabel.TabIndex = 10;
            sODTLabel.Text = "Số điện thoại:";
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Location = new System.Drawing.Point(54, 137);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(74, 13);
            mACNLabel.TabIndex = 15;
            mACNLabel.Text = "Mã chi nhánh:";
            // 
            // pHAILabel
            // 
            pHAILabel.AutoSize = true;
            pHAILabel.Location = new System.Drawing.Point(79, 78);
            pHAILabel.Name = "pHAILabel";
            pHAILabel.Size = new System.Drawing.Size(49, 13);
            pHAILabel.TabIndex = 16;
            pHAILabel.Text = "Giới tính:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnLuu,
            this.btnPhucHoi,
            this.btnThoat,
            this.barButtonItem7,
            this.barButtonItem1});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.LargeImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu lại";
            this.btnLuu.Id = 3;
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.LargeImage")));
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Reset";
            this.btnPhucHoi.Id = 4;
            this.btnPhucHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.Image")));
            this.btnPhucHoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.LargeImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 5;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 1;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar2.FloatLocation = new System.Drawing.Point(1155, 645);
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            this.bar2.Visible = false;
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
            this.bar3.Text = "Status bar";
            this.bar3.Visible = false;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1150, 47);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 515);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1150, 43);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 468);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1150, 47);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 468);
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "barButtonItem7";
            this.barButtonItem7.Id = 6;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 7;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chi nhánh";
            // 
            // cbChiNhanh
            // 
            this.cbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChiNhanh.Location = new System.Drawing.Point(324, 9);
            this.cbChiNhanh.Name = "cbChiNhanh";
            this.cbChiNhanh.Size = new System.Drawing.Size(147, 21);
            this.cbChiNhanh.TabIndex = 0;
            this.cbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cbChiNhanh_SelectedIndexChanged);
            // 
            // cN_NGANHANG
            // 
            this.cN_NGANHANG.DataSetName = "CN_NGANHANG";
            this.cN_NGANHANG.EnforceConstraints = false;
            this.cN_NGANHANG.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chiNhanhBindingSource
            // 
            this.chiNhanhBindingSource.DataMember = "ChiNhanh";
            this.chiNhanhBindingSource.DataSource = this.cN_NGANHANG;
            // 
            // chiNhanhTableAdapter
            // 
            this.chiNhanhTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = this.chiNhanhTableAdapter;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = this.nhanVienTableAdapter;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NGANHANG.CN_NGANHANGTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.cN_NGANHANG;
            // 
            // nhanVienGridControl
            // 
            this.nhanVienGridControl.DataSource = this.nhanVienBindingSource;
            this.nhanVienGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            gridLevelNode1.RelationName = "Level1";
            this.nhanVienGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.nhanVienGridControl.Location = new System.Drawing.Point(0, 84);
            this.nhanVienGridControl.MainView = this.gridView1;
            this.nhanVienGridControl.MenuManager = this.barManager1;
            this.nhanVienGridControl.Name = "nhanVienGridControl";
            this.nhanVienGridControl.Size = new System.Drawing.Size(1150, 169);
            this.nhanVienGridControl.TabIndex = 12;
            this.nhanVienGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.nhanVienGridControl.Click += new System.EventHandler(this.nhanVienGridControl_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.nhanVienGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gioiTinhNam);
            this.groupBox1.Controls.Add(this.gbTaoTaiKhoan);
            this.groupBox1.Controls.Add(this.gioiTinhNu);
            this.groupBox1.Controls.Add(pHAILabel);
            this.groupBox1.Controls.Add(mACNLabel);
            this.groupBox1.Controls.Add(this.cbTaoTaiKhoan);
            this.groupBox1.Controls.Add(this.maChiNhanh);
            this.groupBox1.Controls.Add(trangThaiXoaLabel);
            this.groupBox1.Controls.Add(this.trangThaiXoaNV);
            this.groupBox1.Controls.Add(sODTLabel);
            this.groupBox1.Controls.Add(this.SDTNhanVien);
            this.groupBox1.Controls.Add(dIACHILabel);
            this.groupBox1.Controls.Add(this.diaChiNV);
            this.groupBox1.Controls.Add(tENLabel);
            this.groupBox1.Controls.Add(this.tenNhanVien);
            this.groupBox1.Controls.Add(hOLabel);
            this.groupBox1.Controls.Add(this.hoNhanVien);
            this.groupBox1.Controls.Add(mANVLabel);
            this.groupBox1.Controls.Add(this.maNhanVien);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 253);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1150, 262);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhân viên";
            // 
            // gioiTinhNam
            // 
            this.gioiTinhNam.AutoSize = true;
            this.gioiTinhNam.Location = new System.Drawing.Point(144, 75);
            this.gioiTinhNam.Name = "gioiTinhNam";
            this.gioiTinhNam.Size = new System.Drawing.Size(47, 17);
            this.gioiTinhNam.TabIndex = 27;
            this.gioiTinhNam.Text = "Nam";
            this.gioiTinhNam.UseVisualStyleBackColor = true;
            this.gioiTinhNam.CheckedChanged += new System.EventHandler(this.gioiTinhNam_CheckedChanged);
            // 
            // gbTaoTaiKhoan
            // 
            this.gbTaoTaiKhoan.Controls.Add(this.tbMatKhau);
            this.gbTaoTaiKhoan.Controls.Add(this.chiNhanh);
            this.gbTaoTaiKhoan.Controls.Add(this.tbTaiKhoan);
            this.gbTaoTaiKhoan.Controls.Add(this.nganHang);
            this.gbTaoTaiKhoan.Controls.Add(this.lbMatKhau);
            this.gbTaoTaiKhoan.Controls.Add(this.lbTaiKhoan);
            this.gbTaoTaiKhoan.Location = new System.Drawing.Point(866, 61);
            this.gbTaoTaiKhoan.Name = "gbTaoTaiKhoan";
            this.gbTaoTaiKhoan.Size = new System.Drawing.Size(278, 157);
            this.gbTaoTaiKhoan.TabIndex = 26;
            this.gbTaoTaiKhoan.TabStop = false;
            this.gbTaoTaiKhoan.Text = "Thông tin tài khoản";
            // 
            // tbMatKhau
            // 
            this.tbMatKhau.Location = new System.Drawing.Point(105, 72);
            this.tbMatKhau.Name = "tbMatKhau";
            this.tbMatKhau.Size = new System.Drawing.Size(141, 21);
            this.tbMatKhau.TabIndex = 23;
            // 
            // chiNhanh
            // 
            this.chiNhanh.AutoSize = true;
            this.chiNhanh.Location = new System.Drawing.Point(160, 118);
            this.chiNhanh.Name = "chiNhanh";
            this.chiNhanh.Size = new System.Drawing.Size(74, 17);
            this.chiNhanh.TabIndex = 25;
            this.chiNhanh.Text = "Chi nhánh";
            this.chiNhanh.UseVisualStyleBackColor = true;
            this.chiNhanh.CheckedChanged += new System.EventHandler(this.chiNhanh_CheckedChanged);
            // 
            // tbTaiKhoan
            // 
            this.tbTaiKhoan.Location = new System.Drawing.Point(105, 27);
            this.tbTaiKhoan.Name = "tbTaiKhoan";
            this.tbTaiKhoan.Size = new System.Drawing.Size(141, 21);
            this.tbTaiKhoan.TabIndex = 22;
            // 
            // nganHang
            // 
            this.nganHang.AutoSize = true;
            this.nganHang.Location = new System.Drawing.Point(59, 118);
            this.nganHang.Name = "nganHang";
            this.nganHang.Size = new System.Drawing.Size(78, 17);
            this.nganHang.TabIndex = 24;
            this.nganHang.Text = "Ngân hàng";
            this.nganHang.UseVisualStyleBackColor = true;
            this.nganHang.CheckedChanged += new System.EventHandler(this.nganHang_CheckedChanged);
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.AutoSize = true;
            this.lbMatKhau.Location = new System.Drawing.Point(42, 75);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(55, 13);
            this.lbMatKhau.TabIndex = 21;
            this.lbMatKhau.Text = "Mật khẩu:";
            // 
            // lbTaiKhoan
            // 
            this.lbTaiKhoan.AutoSize = true;
            this.lbTaiKhoan.Location = new System.Drawing.Point(42, 30);
            this.lbTaiKhoan.Name = "lbTaiKhoan";
            this.lbTaiKhoan.Size = new System.Drawing.Size(57, 13);
            this.lbTaiKhoan.TabIndex = 20;
            this.lbTaiKhoan.Text = "Tài khoản:";
            // 
            // gioiTinhNu
            // 
            this.gioiTinhNu.AutoSize = true;
            this.gioiTinhNu.Location = new System.Drawing.Point(205, 77);
            this.gioiTinhNu.Name = "gioiTinhNu";
            this.gioiTinhNu.Size = new System.Drawing.Size(40, 17);
            this.gioiTinhNu.TabIndex = 18;
            this.gioiTinhNu.Text = "Nữ";
            this.gioiTinhNu.UseVisualStyleBackColor = true;
            this.gioiTinhNu.CheckedChanged += new System.EventHandler(this.gioiTinhNu_CheckedChanged);
            // 
            // cbTaoTaiKhoan
            // 
            this.cbTaoTaiKhoan.AutoSize = true;
            this.cbTaoTaiKhoan.Location = new System.Drawing.Point(874, 30);
            this.cbTaoTaiKhoan.Name = "cbTaoTaiKhoan";
            this.cbTaoTaiKhoan.Size = new System.Drawing.Size(91, 17);
            this.cbTaoTaiKhoan.TabIndex = 19;
            this.cbTaoTaiKhoan.Text = "Tạo tài khoản";
            this.cbTaoTaiKhoan.UseVisualStyleBackColor = true;
            this.cbTaoTaiKhoan.CheckedChanged += new System.EventHandler(this.cbTaoTaiKhoan_CheckedChanged);
            // 
            // maChiNhanh
            // 
            this.maChiNhanh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "MACN", true));
            this.maChiNhanh.Location = new System.Drawing.Point(144, 134);
            this.maChiNhanh.Name = "maChiNhanh";
            this.maChiNhanh.Size = new System.Drawing.Size(135, 21);
            this.maChiNhanh.TabIndex = 16;
            // 
            // SDTNhanVien
            // 
            this.SDTNhanVien.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "SODT", true));
            this.SDTNhanVien.Location = new System.Drawing.Point(403, 80);
            this.SDTNhanVien.Name = "SDTNhanVien";
            this.SDTNhanVien.Size = new System.Drawing.Size(135, 21);
            this.SDTNhanVien.TabIndex = 11;
            // 
            // diaChiNV
            // 
            this.diaChiNV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "DIACHI", true));
            this.diaChiNV.Location = new System.Drawing.Point(406, 134);
            this.diaChiNV.Name = "diaChiNV";
            this.diaChiNV.Size = new System.Drawing.Size(312, 44);
            this.diaChiNV.TabIndex = 7;
            this.diaChiNV.Text = "";
            // 
            // tenNhanVien
            // 
            this.tenNhanVien.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "TEN", true));
            this.tenNhanVien.Location = new System.Drawing.Point(682, 28);
            this.tenNhanVien.Name = "tenNhanVien";
            this.tenNhanVien.Size = new System.Drawing.Size(135, 21);
            this.tenNhanVien.TabIndex = 5;
            // 
            // hoNhanVien
            // 
            this.hoNhanVien.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "HO", true));
            this.hoNhanVien.Location = new System.Drawing.Point(403, 28);
            this.hoNhanVien.Name = "hoNhanVien";
            this.hoNhanVien.Size = new System.Drawing.Size(135, 21);
            this.hoNhanVien.TabIndex = 3;
            // 
            // maNhanVien
            // 
            this.maNhanVien.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "MANV", true));
            this.maNhanVien.Location = new System.Drawing.Point(144, 28);
            this.maNhanVien.Name = "maNhanVien";
            this.maNhanVien.Size = new System.Drawing.Size(135, 21);
            this.maNhanVien.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbChiNhanh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1150, 37);
            this.panel1.TabIndex = 4;
            // 
            // trangThaiXoaNV
            // 
            this.trangThaiXoaNV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "TrangThaiXoa", true));
            this.trangThaiXoaNV.FormattingEnabled = true;
            this.trangThaiXoaNV.Location = new System.Drawing.Point(682, 75);
            this.trangThaiXoaNV.Name = "trangThaiXoaNV";
            this.trangThaiXoaNV.Size = new System.Drawing.Size(135, 21);
            this.trangThaiXoaNV.TabIndex = 15;
            this.trangThaiXoaNV.Visible = false;
            // 
            // trangThaiXoaLabel
            // 
            trangThaiXoaLabel.AutoSize = true;
            trangThaiXoaLabel.Location = new System.Drawing.Point(593, 78);
            trangThaiXoaLabel.Name = "trangThaiXoaLabel";
            trangThaiXoaLabel.Size = new System.Drawing.Size(81, 13);
            trangThaiXoaLabel.TabIndex = 14;
            trangThaiXoaLabel.Text = "Trạng thái xóa:";
            trangThaiXoaLabel.Visible = false;
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 558);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nhanVienGridControl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cN_NGANHANG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiNhanhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbTaoTaiKhoan.ResumeLayout(false);
            this.gbTaoTaiKhoan.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private System.Windows.Forms.BindingSource chiNhanhBindingSource;
        private CN_NGANHANG cN_NGANHANG;
        private System.Windows.Forms.ComboBox cbChiNhanh;
        private CN_NGANHANGTableAdapters.ChiNhanhTableAdapter chiNhanhTableAdapter;
        private CN_NGANHANGTableAdapters.TableAdapterManager tableAdapterManager;
        private CN_NGANHANGTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox SDTNhanVien;
        private System.Windows.Forms.RichTextBox diaChiNV;
        private System.Windows.Forms.TextBox tenNhanVien;
        private System.Windows.Forms.TextBox hoNhanVien;
        private System.Windows.Forms.TextBox maNhanVien;
        private DevExpress.XtraGrid.GridControl nhanVienGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TextBox maChiNhanh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox gioiTinhNu;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private System.Windows.Forms.CheckBox cbTaoTaiKhoan;
        private System.Windows.Forms.CheckBox chiNhanh;
        private System.Windows.Forms.CheckBox nganHang;
        private System.Windows.Forms.TextBox tbMatKhau;
        private System.Windows.Forms.TextBox tbTaiKhoan;
        private System.Windows.Forms.Label lbMatKhau;
        private System.Windows.Forms.Label lbTaiKhoan;
        private System.Windows.Forms.GroupBox gbTaoTaiKhoan;
        private System.Windows.Forms.CheckBox gioiTinhNam;
        private System.Windows.Forms.ComboBox trangThaiXoaNV;
    }
}