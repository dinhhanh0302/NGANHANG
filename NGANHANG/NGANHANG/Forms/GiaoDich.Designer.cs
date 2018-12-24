namespace NGANHANG.Forms
{
    partial class GiaoDich
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
            System.Windows.Forms.Label cMNDLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label sODTLabel;
            System.Windows.Forms.Label pHAILabel;
            System.Windows.Forms.Label mACN_TAOKHLabel;
            System.Windows.Forms.Label sOTKLabel;
            System.Windows.Forms.Label sODULabel;
            System.Windows.Forms.Label mACN_TAOTKLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbChiNhanh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cN_NGANHANG = new NGANHANG.CN_NGANHANG();
            this.sP_DS_TAIKHOANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_DS_TAIKHOANTableAdapter = new NGANHANG.CN_NGANHANGTableAdapters.SP_DS_TAIKHOANTableAdapter();
            this.tableAdapterManager = new NGANHANG.CN_NGANHANGTableAdapters.TableAdapterManager();
            this.sP_DS_TAIKHOANGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gbThongTinTK = new System.Windows.Forms.GroupBox();
            this.gioiTinhNu = new System.Windows.Forms.CheckBox();
            this.gioiTinhNam = new System.Windows.Forms.CheckBox();
            this.tbChiNhanhTaoTK = new System.Windows.Forms.TextBox();
            this.tbSoDu = new System.Windows.Forms.TextBox();
            this.tbSoTK = new System.Windows.Forms.TextBox();
            this.tbChiNhanhTaoKH = new System.Windows.Forms.TextBox();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.rtbDiaChi = new System.Windows.Forms.RichTextBox();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.tbHo = new System.Windows.Forms.TextBox();
            this.tbCMND = new System.Windows.Forms.TextBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnGiaoDich = new System.Windows.Forms.Button();
            this.tbSoTienGD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cN_NGANHANG1 = new NGANHANG.CN_NGANHANG();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbSoTaiKhoanGD = new System.Windows.Forms.TextBox();
            this.dateGD = new DevExpress.XtraEditors.DateEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbLoaiGD = new System.Windows.Forms.ComboBox();
            this.tbMaNVGD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            cMNDLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            sODTLabel = new System.Windows.Forms.Label();
            pHAILabel = new System.Windows.Forms.Label();
            mACN_TAOKHLabel = new System.Windows.Forms.Label();
            sOTKLabel = new System.Windows.Forms.Label();
            sODULabel = new System.Windows.Forms.Label();
            mACN_TAOTKLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cN_NGANHANG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DS_TAIKHOANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DS_TAIKHOANGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.gbThongTinTK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cN_NGANHANG1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateGD.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGD.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Location = new System.Drawing.Point(38, 41);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(55, 13);
            cMNDLabel.TabIndex = 0;
            cMNDLabel.Text = "Số CMND:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(69, 88);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(24, 13);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "Họ:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(338, 103);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(29, 13);
            tENLabel.TabIndex = 4;
            tENLabel.Text = "Tên:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(324, 172);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(43, 13);
            dIACHILabel.TabIndex = 6;
            dIACHILabel.Text = "Địa chỉ:";
            // 
            // sODTLabel
            // 
            sODTLabel.AutoSize = true;
            sODTLabel.Location = new System.Drawing.Point(22, 189);
            sODTLabel.Name = "sODTLabel";
            sODTLabel.Size = new System.Drawing.Size(73, 13);
            sODTLabel.TabIndex = 8;
            sODTLabel.Text = "Số điện thoại:";
            // 
            // pHAILabel
            // 
            pHAILabel.AutoSize = true;
            pHAILabel.Location = new System.Drawing.Point(46, 137);
            pHAILabel.Name = "pHAILabel";
            pHAILabel.Size = new System.Drawing.Size(49, 13);
            pHAILabel.TabIndex = 10;
            pHAILabel.Text = "Giới tính:";
            // 
            // mACN_TAOKHLabel
            // 
            mACN_TAOKHLabel.AutoSize = true;
            mACN_TAOKHLabel.Location = new System.Drawing.Point(558, 41);
            mACN_TAOKHLabel.Name = "mACN_TAOKHLabel";
            mACN_TAOKHLabel.Size = new System.Drawing.Size(94, 13);
            mACN_TAOKHLabel.TabIndex = 12;
            mACN_TAOKHLabel.Text = "Chi nhánh tạo KH:";
            // 
            // sOTKLabel
            // 
            sOTKLabel.AutoSize = true;
            sOTKLabel.Location = new System.Drawing.Point(297, 41);
            sOTKLabel.Name = "sOTKLabel";
            sOTKLabel.Size = new System.Drawing.Size(70, 13);
            sOTKLabel.TabIndex = 14;
            sOTKLabel.Text = "Số tài khoản:";
            // 
            // sODULabel
            // 
            sODULabel.AutoSize = true;
            sODULabel.Location = new System.Drawing.Point(613, 103);
            sODULabel.Name = "sODULabel";
            sODULabel.Size = new System.Drawing.Size(39, 13);
            sODULabel.TabIndex = 16;
            sODULabel.Text = "Số dư:";
            // 
            // mACN_TAOTKLabel
            // 
            mACN_TAOTKLabel.AutoSize = true;
            mACN_TAOTKLabel.Location = new System.Drawing.Point(559, 172);
            mACN_TAOTKLabel.Name = "mACN_TAOTKLabel";
            mACN_TAOTKLabel.Size = new System.Drawing.Size(93, 13);
            mACN_TAOTKLabel.TabIndex = 18;
            mACN_TAOTKLabel.Text = "Chi nhánh tạo TK:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbbChiNhanh);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1367, 56);
            this.panel1.TabIndex = 0;
            // 
            // cbbChiNhanh
            // 
            this.cbbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChiNhanh.FormattingEnabled = true;
            this.cbbChiNhanh.Location = new System.Drawing.Point(300, 19);
            this.cbbChiNhanh.Name = "cbbChiNhanh";
            this.cbbChiNhanh.Size = new System.Drawing.Size(163, 21);
            this.cbbChiNhanh.TabIndex = 1;
            this.cbbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cbbChiNhanh_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi nhánh:";
            // 
            // cN_NGANHANG
            // 
            this.cN_NGANHANG.DataSetName = "CN_NGANHANG";
            this.cN_NGANHANG.EnforceConstraints = false;
            this.cN_NGANHANG.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_DS_TAIKHOANBindingSource
            // 
            this.sP_DS_TAIKHOANBindingSource.DataMember = "SP_DS_TAIKHOAN";
            this.sP_DS_TAIKHOANBindingSource.DataSource = this.cN_NGANHANG;
            // 
            // sP_DS_TAIKHOANTableAdapter
            // 
            this.sP_DS_TAIKHOANTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NGANHANG.CN_NGANHANGTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sP_DS_TAIKHOANGridControl
            // 
            this.sP_DS_TAIKHOANGridControl.DataSource = this.sP_DS_TAIKHOANBindingSource;
            this.sP_DS_TAIKHOANGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.sP_DS_TAIKHOANGridControl.Location = new System.Drawing.Point(0, 56);
            this.sP_DS_TAIKHOANGridControl.MainView = this.gridView1;
            this.sP_DS_TAIKHOANGridControl.Name = "sP_DS_TAIKHOANGridControl";
            this.sP_DS_TAIKHOANGridControl.Size = new System.Drawing.Size(1367, 175);
            this.sP_DS_TAIKHOANGridControl.TabIndex = 2;
            this.sP_DS_TAIKHOANGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.sP_DS_TAIKHOANGridControl.Click += new System.EventHandler(this.sP_DS_TAIKHOANGridControl_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.sP_DS_TAIKHOANGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gbThongTinTK
            // 
            this.gbThongTinTK.Controls.Add(this.gioiTinhNu);
            this.gbThongTinTK.Controls.Add(this.gioiTinhNam);
            this.gbThongTinTK.Controls.Add(mACN_TAOTKLabel);
            this.gbThongTinTK.Controls.Add(this.tbChiNhanhTaoTK);
            this.gbThongTinTK.Controls.Add(sODULabel);
            this.gbThongTinTK.Controls.Add(this.tbSoDu);
            this.gbThongTinTK.Controls.Add(sOTKLabel);
            this.gbThongTinTK.Controls.Add(this.tbSoTK);
            this.gbThongTinTK.Controls.Add(mACN_TAOKHLabel);
            this.gbThongTinTK.Controls.Add(this.tbChiNhanhTaoKH);
            this.gbThongTinTK.Controls.Add(pHAILabel);
            this.gbThongTinTK.Controls.Add(sODTLabel);
            this.gbThongTinTK.Controls.Add(this.tbSDT);
            this.gbThongTinTK.Controls.Add(dIACHILabel);
            this.gbThongTinTK.Controls.Add(this.rtbDiaChi);
            this.gbThongTinTK.Controls.Add(tENLabel);
            this.gbThongTinTK.Controls.Add(this.tbTen);
            this.gbThongTinTK.Controls.Add(hOLabel);
            this.gbThongTinTK.Controls.Add(this.tbHo);
            this.gbThongTinTK.Controls.Add(cMNDLabel);
            this.gbThongTinTK.Controls.Add(this.tbCMND);
            this.gbThongTinTK.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbThongTinTK.Location = new System.Drawing.Point(0, 231);
            this.gbThongTinTK.Name = "gbThongTinTK";
            this.gbThongTinTK.Size = new System.Drawing.Size(846, 281);
            this.gbThongTinTK.TabIndex = 3;
            this.gbThongTinTK.TabStop = false;
            this.gbThongTinTK.Text = "Thông tin tài khoản";
            // 
            // gioiTinhNu
            // 
            this.gioiTinhNu.AutoSize = true;
            this.gioiTinhNu.Location = new System.Drawing.Point(182, 137);
            this.gioiTinhNu.Name = "gioiTinhNu";
            this.gioiTinhNu.Size = new System.Drawing.Size(40, 17);
            this.gioiTinhNu.TabIndex = 21;
            this.gioiTinhNu.Text = "Nữ";
            this.gioiTinhNu.UseVisualStyleBackColor = true;
            this.gioiTinhNu.CheckedChanged += new System.EventHandler(this.gioiTinhNu_CheckedChanged);
            // 
            // gioiTinhNam
            // 
            this.gioiTinhNam.AutoSize = true;
            this.gioiTinhNam.Location = new System.Drawing.Point(112, 137);
            this.gioiTinhNam.Name = "gioiTinhNam";
            this.gioiTinhNam.Size = new System.Drawing.Size(47, 17);
            this.gioiTinhNam.TabIndex = 20;
            this.gioiTinhNam.Text = "Nam";
            this.gioiTinhNam.UseVisualStyleBackColor = true;
            this.gioiTinhNam.CheckedChanged += new System.EventHandler(this.gioiTinhNam_CheckedChanged);
            // 
            // tbChiNhanhTaoTK
            // 
            this.tbChiNhanhTaoTK.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sP_DS_TAIKHOANBindingSource, "MACN_TAOTK", true));
            this.tbChiNhanhTaoTK.Location = new System.Drawing.Point(658, 164);
            this.tbChiNhanhTaoTK.Name = "tbChiNhanhTaoTK";
            this.tbChiNhanhTaoTK.Size = new System.Drawing.Size(160, 21);
            this.tbChiNhanhTaoTK.TabIndex = 19;
            // 
            // tbSoDu
            // 
            this.tbSoDu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sP_DS_TAIKHOANBindingSource, "SODU", true));
            this.tbSoDu.Location = new System.Drawing.Point(658, 100);
            this.tbSoDu.Name = "tbSoDu";
            this.tbSoDu.Size = new System.Drawing.Size(160, 21);
            this.tbSoDu.TabIndex = 17;
            // 
            // tbSoTK
            // 
            this.tbSoTK.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sP_DS_TAIKHOANBindingSource, "SOTK", true));
            this.tbSoTK.Location = new System.Drawing.Point(373, 36);
            this.tbSoTK.Name = "tbSoTK";
            this.tbSoTK.Size = new System.Drawing.Size(160, 21);
            this.tbSoTK.TabIndex = 15;
            // 
            // tbChiNhanhTaoKH
            // 
            this.tbChiNhanhTaoKH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sP_DS_TAIKHOANBindingSource, "MACN_TAOKH", true));
            this.tbChiNhanhTaoKH.Location = new System.Drawing.Point(658, 38);
            this.tbChiNhanhTaoKH.Name = "tbChiNhanhTaoKH";
            this.tbChiNhanhTaoKH.Size = new System.Drawing.Size(160, 21);
            this.tbChiNhanhTaoKH.TabIndex = 13;
            // 
            // tbSDT
            // 
            this.tbSDT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sP_DS_TAIKHOANBindingSource, "SODT", true));
            this.tbSDT.Location = new System.Drawing.Point(101, 186);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(160, 21);
            this.tbSDT.TabIndex = 9;
            // 
            // rtbDiaChi
            // 
            this.rtbDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sP_DS_TAIKHOANBindingSource, "DIACHI", true));
            this.rtbDiaChi.Location = new System.Drawing.Point(373, 169);
            this.rtbDiaChi.Name = "rtbDiaChi";
            this.rtbDiaChi.Size = new System.Drawing.Size(160, 41);
            this.rtbDiaChi.TabIndex = 7;
            this.rtbDiaChi.Text = "";
            // 
            // tbTen
            // 
            this.tbTen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sP_DS_TAIKHOANBindingSource, "TEN", true));
            this.tbTen.Location = new System.Drawing.Point(373, 103);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(160, 21);
            this.tbTen.TabIndex = 5;
            // 
            // tbHo
            // 
            this.tbHo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sP_DS_TAIKHOANBindingSource, "HO", true));
            this.tbHo.Location = new System.Drawing.Point(101, 85);
            this.tbHo.Name = "tbHo";
            this.tbHo.Size = new System.Drawing.Size(160, 21);
            this.tbHo.TabIndex = 3;
            // 
            // tbCMND
            // 
            this.tbCMND.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sP_DS_TAIKHOANBindingSource, "CMND", true));
            this.tbCMND.Location = new System.Drawing.Point(99, 38);
            this.tbCMND.Name = "tbCMND";
            this.tbCMND.Size = new System.Drawing.Size(160, 21);
            this.tbCMND.TabIndex = 1;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(178, 202);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 24;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnGiaoDich
            // 
            this.btnGiaoDich.Location = new System.Drawing.Point(332, 202);
            this.btnGiaoDich.Name = "btnGiaoDich";
            this.btnGiaoDich.Size = new System.Drawing.Size(75, 23);
            this.btnGiaoDich.TabIndex = 23;
            this.btnGiaoDich.Text = "Giao dịch";
            this.btnGiaoDich.UseVisualStyleBackColor = true;
            this.btnGiaoDich.Click += new System.EventHandler(this.btnGuiTien_Click);
            // 
            // tbSoTienGD
            // 
            this.tbSoTienGD.Location = new System.Drawing.Point(117, 103);
            this.tbSoTienGD.Name = "tbSoTienGD";
            this.tbSoTienGD.Size = new System.Drawing.Size(123, 21);
            this.tbSoTienGD.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Số tiền giao dịch:";
            // 
            // cN_NGANHANG1
            // 
            this.cN_NGANHANG1.DataSetName = "CN_NGANHANG";
            this.cN_NGANHANG1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbSoTaiKhoanGD);
            this.groupBox2.Controls.Add(this.dateGD);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbbLoaiGD);
            this.groupBox2.Controls.Add(this.tbMaNVGD);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbSoTienGD);
            this.groupBox2.Controls.Add(this.btnHuy);
            this.groupBox2.Controls.Add(this.btnGiaoDich);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(870, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(497, 281);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giao dịch";
            // 
            // tbSoTaiKhoanGD
            // 
            this.tbSoTaiKhoanGD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sP_DS_TAIKHOANBindingSource, "SOTK", true));
            this.tbSoTaiKhoanGD.Location = new System.Drawing.Point(117, 46);
            this.tbSoTaiKhoanGD.Name = "tbSoTaiKhoanGD";
            this.tbSoTaiKhoanGD.Size = new System.Drawing.Size(123, 21);
            this.tbSoTaiKhoanGD.TabIndex = 34;
            // 
            // dateGD
            // 
            this.dateGD.EditValue = null;
            this.dateGD.Location = new System.Drawing.Point(362, 46);
            this.dateGD.Name = "dateGD";
            this.dateGD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateGD.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateGD.Size = new System.Drawing.Size(123, 20);
            this.dateGD.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(303, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Ngày GD:";
            // 
            // cbbLoaiGD
            // 
            this.cbbLoaiGD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoaiGD.FormattingEnabled = true;
            this.cbbLoaiGD.Location = new System.Drawing.Point(117, 156);
            this.cbbLoaiGD.Name = "cbbLoaiGD";
            this.cbbLoaiGD.Size = new System.Drawing.Size(123, 21);
            this.cbbLoaiGD.TabIndex = 31;
            // 
            // tbMaNVGD
            // 
            this.tbMaNVGD.Location = new System.Drawing.Point(362, 103);
            this.tbMaNVGD.Name = "tbMaNVGD";
            this.tbMaNVGD.Size = new System.Drawing.Size(123, 21);
            this.tbMaNVGD.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Loại giao dịch:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Mã nhân viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Số tài khoản GD:";
            // 
            // GiaoDich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 512);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbThongTinTK);
            this.Controls.Add(this.sP_DS_TAIKHOANGridControl);
            this.Controls.Add(this.panel1);
            this.Name = "GiaoDich";
            this.Text = "GuiTien";
            this.Load += new System.EventHandler(this.GuiTien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cN_NGANHANG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DS_TAIKHOANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DS_TAIKHOANGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.gbThongTinTK.ResumeLayout(false);
            this.gbThongTinTK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cN_NGANHANG1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateGD.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGD.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbbChiNhanh;
        private System.Windows.Forms.Label label1;
        private CN_NGANHANG cN_NGANHANG;
        private System.Windows.Forms.BindingSource sP_DS_TAIKHOANBindingSource;
        private CN_NGANHANGTableAdapters.SP_DS_TAIKHOANTableAdapter sP_DS_TAIKHOANTableAdapter;
        private CN_NGANHANGTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl sP_DS_TAIKHOANGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox gbThongTinTK;
        private System.Windows.Forms.TextBox tbChiNhanhTaoTK;
        private System.Windows.Forms.TextBox tbSoDu;
        private System.Windows.Forms.TextBox tbSoTK;
        private System.Windows.Forms.TextBox tbChiNhanhTaoKH;
        private System.Windows.Forms.TextBox tbSDT;
        private System.Windows.Forms.RichTextBox rtbDiaChi;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.TextBox tbHo;
        private System.Windows.Forms.TextBox tbCMND;
        private CN_NGANHANG cN_NGANHANG1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnGiaoDich;
        private System.Windows.Forms.TextBox tbSoTienGD;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbbLoaiGD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.DateEdit dateGD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMaNVGD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSoTaiKhoanGD;
        private System.Windows.Forms.CheckBox gioiTinhNu;
        private System.Windows.Forms.CheckBox gioiTinhNam;
    }
}