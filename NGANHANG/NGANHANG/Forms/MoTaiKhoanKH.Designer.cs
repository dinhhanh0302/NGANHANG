namespace NGANHANG.Forms
{
    partial class MoTaiKhoanKH
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKiemTraThongTin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNhapSoCMND = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbCMND = new System.Windows.Forms.TextBox();
            this.tbHo = new System.Windows.Forms.TextBox();
            this.tbChiNhanh = new System.Windows.Forms.TextBox();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.tbSoTK = new System.Windows.Forms.TextBox();
            this.tbSoDu = new System.Windows.Forms.TextBox();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.rtbDiaChi = new System.Windows.Forms.RichTextBox();
            this.btnTaoTK = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cN_NGANHANG = new NGANHANG.CN_NGANHANG();
            this.taiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taiKhoanTableAdapter = new NGANHANG.CN_NGANHANGTableAdapters.TaiKhoanTableAdapter();
            this.tableAdapterManager = new NGANHANG.CN_NGANHANGTableAdapters.TableAdapterManager();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cN_NGANHANG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnKiemTraThongTin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbNhapSoCMND);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 46);
            this.panel1.TabIndex = 0;
            // 
            // btnKiemTraThongTin
            // 
            this.btnKiemTraThongTin.Location = new System.Drawing.Point(387, 10);
            this.btnKiemTraThongTin.Name = "btnKiemTraThongTin";
            this.btnKiemTraThongTin.Size = new System.Drawing.Size(75, 23);
            this.btnKiemTraThongTin.TabIndex = 2;
            this.btnKiemTraThongTin.Text = "Kiểm tra";
            this.btnKiemTraThongTin.UseVisualStyleBackColor = true;
            this.btnKiemTraThongTin.Click += new System.EventHandler(this.btnKiemTraThongTin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập số CMND:";
            // 
            // tbNhapSoCMND
            // 
            this.tbNhapSoCMND.Location = new System.Drawing.Point(212, 12);
            this.tbNhapSoCMND.Name = "tbNhapSoCMND";
            this.tbNhapSoCMND.Size = new System.Drawing.Size(152, 21);
            this.tbNhapSoCMND.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số CMND:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số điện thoại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Địa chỉ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Họ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(316, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Thông tin KH:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(637, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Số tài khoản:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(359, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Tên:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(668, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Số dư:";
            // 
            // tbCMND
            // 
            this.tbCMND.Location = new System.Drawing.Point(92, 33);
            this.tbCMND.Name = "tbCMND";
            this.tbCMND.Size = new System.Drawing.Size(139, 21);
            this.tbCMND.TabIndex = 8;
            // 
            // tbHo
            // 
            this.tbHo.Location = new System.Drawing.Point(92, 81);
            this.tbHo.Name = "tbHo";
            this.tbHo.Size = new System.Drawing.Size(139, 21);
            this.tbHo.TabIndex = 9;
            // 
            // tbChiNhanh
            // 
            this.tbChiNhanh.Location = new System.Drawing.Point(394, 33);
            this.tbChiNhanh.Name = "tbChiNhanh";
            this.tbChiNhanh.Size = new System.Drawing.Size(139, 21);
            this.tbChiNhanh.TabIndex = 10;
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(394, 81);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(139, 21);
            this.tbTen.TabIndex = 11;
            // 
            // tbSoTK
            // 
            this.tbSoTK.Location = new System.Drawing.Point(713, 33);
            this.tbSoTK.Name = "tbSoTK";
            this.tbSoTK.Size = new System.Drawing.Size(139, 21);
            this.tbSoTK.TabIndex = 11;
            // 
            // tbSoDu
            // 
            this.tbSoDu.Location = new System.Drawing.Point(713, 84);
            this.tbSoDu.Name = "tbSoDu";
            this.tbSoDu.Size = new System.Drawing.Size(139, 21);
            this.tbSoDu.TabIndex = 12;
            // 
            // tbSDT
            // 
            this.tbSDT.Location = new System.Drawing.Point(92, 133);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(139, 21);
            this.tbSDT.TabIndex = 13;
            // 
            // rtbDiaChi
            // 
            this.rtbDiaChi.Location = new System.Drawing.Point(394, 130);
            this.rtbDiaChi.Name = "rtbDiaChi";
            this.rtbDiaChi.Size = new System.Drawing.Size(139, 43);
            this.rtbDiaChi.TabIndex = 14;
            this.rtbDiaChi.Text = "";
            // 
            // btnTaoTK
            // 
            this.btnTaoTK.Location = new System.Drawing.Point(755, 152);
            this.btnTaoTK.Name = "btnTaoTK";
            this.btnTaoTK.Size = new System.Drawing.Size(79, 21);
            this.btnTaoTK.TabIndex = 15;
            this.btnTaoTK.Text = "Xác nhận";
            this.btnTaoTK.UseVisualStyleBackColor = true;
            this.btnTaoTK.Click += new System.EventHandler(this.btnTaoTK_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(640, 152);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(79, 21);
            this.btnHuy.TabIndex = 16;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.btnTaoTK);
            this.groupBox1.Controls.Add(this.rtbDiaChi);
            this.groupBox1.Controls.Add(this.tbSDT);
            this.groupBox1.Controls.Add(this.tbSoDu);
            this.groupBox1.Controls.Add(this.tbSoTK);
            this.groupBox1.Controls.Add(this.tbTen);
            this.groupBox1.Controls.Add(this.tbChiNhanh);
            this.groupBox1.Controls.Add(this.tbHo);
            this.groupBox1.Controls.Add(this.tbCMND);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(872, 201);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản";
            // 
            // cN_NGANHANG
            // 
            this.cN_NGANHANG.DataSetName = "CN_NGANHANG";
            this.cN_NGANHANG.EnforceConstraints = false;
            this.cN_NGANHANG.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taiKhoanBindingSource
            // 
            this.taiKhoanBindingSource.DataMember = "TaiKhoan";
            this.taiKhoanBindingSource.DataSource = this.cN_NGANHANG;
            // 
            // taiKhoanTableAdapter
            // 
            this.taiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = this.taiKhoanTableAdapter;
            this.tableAdapterManager.UpdateOrder = NGANHANG.CN_NGANHANGTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // MoTaiKhoanKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 247);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "MoTaiKhoanKH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MoTaiKhoanKH";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MoTaiKhoanKH_FormClosed);
            this.Load += new System.EventHandler(this.MoTaiKhoanKH_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cN_NGANHANG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKiemTraThongTin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNhapSoCMND;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbCMND;
        private System.Windows.Forms.TextBox tbHo;
        private System.Windows.Forms.TextBox tbChiNhanh;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.TextBox tbSoTK;
        private System.Windows.Forms.TextBox tbSoDu;
        private System.Windows.Forms.TextBox tbSDT;
        private System.Windows.Forms.RichTextBox rtbDiaChi;
        private System.Windows.Forms.Button btnTaoTK;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.GroupBox groupBox1;
        private CN_NGANHANG cN_NGANHANG;
        private System.Windows.Forms.BindingSource taiKhoanBindingSource;
        private CN_NGANHANGTableAdapters.TaiKhoanTableAdapter taiKhoanTableAdapter;
        private CN_NGANHANGTableAdapters.TableAdapterManager tableAdapterManager;
    }
}