namespace NGANHANG.Forms
{
    partial class TaoLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbChiNhanh = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkboxChiNhanh = new System.Windows.Forms.CheckBox();
            this.cbNganHang = new System.Windows.Forms.CheckBox();
            this.tbRePass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTaoLogin = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.tbMatKhau = new System.Windows.Forms.TextBox();
            this.tbTaiKhoan = new System.Windows.Forms.TextBox();
            this.tbMaNV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbChiNhanh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 67);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chi nhánh:";
            // 
            // cbChiNhanh
            // 
            this.cbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChiNhanh.FormattingEnabled = true;
            this.cbChiNhanh.Location = new System.Drawing.Point(254, 26);
            this.cbChiNhanh.Name = "cbChiNhanh";
            this.cbChiNhanh.Size = new System.Drawing.Size(140, 21);
            this.cbChiNhanh.TabIndex = 0;
            this.cbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cbChiNhanh_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.checkboxChiNhanh);
            this.groupBox1.Controls.Add(this.cbNganHang);
            this.groupBox1.Controls.Add(this.tbRePass);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnTaoLogin);
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.tbMatKhau);
            this.groupBox1.Controls.Add(this.tbTaiKhoan);
            this.groupBox1.Controls.Add(this.tbMaNV);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(844, 410);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tạo tài khoản Login";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(157, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Quyền:";
            // 
            // checkboxChiNhanh
            // 
            this.checkboxChiNhanh.AutoSize = true;
            this.checkboxChiNhanh.Location = new System.Drawing.Point(439, 286);
            this.checkboxChiNhanh.Name = "checkboxChiNhanh";
            this.checkboxChiNhanh.Size = new System.Drawing.Size(74, 17);
            this.checkboxChiNhanh.TabIndex = 12;
            this.checkboxChiNhanh.Text = "Chi nhánh";
            this.checkboxChiNhanh.UseVisualStyleBackColor = true;
            this.checkboxChiNhanh.CheckedChanged += new System.EventHandler(this.checkboxChiNhanh_CheckedChanged);
            // 
            // cbNganHang
            // 
            this.cbNganHang.AutoSize = true;
            this.cbNganHang.Location = new System.Drawing.Point(254, 290);
            this.cbNganHang.Name = "cbNganHang";
            this.cbNganHang.Size = new System.Drawing.Size(78, 17);
            this.cbNganHang.TabIndex = 11;
            this.cbNganHang.Text = "Ngân hàng";
            this.cbNganHang.UseVisualStyleBackColor = true;
            this.cbNganHang.CheckedChanged += new System.EventHandler(this.cbNganHang_CheckedChanged);
            // 
            // tbRePass
            // 
            this.tbRePass.Location = new System.Drawing.Point(236, 234);
            this.tbRePass.Name = "tbRePass";
            this.tbRePass.Size = new System.Drawing.Size(311, 21);
            this.tbRePass.TabIndex = 10;
            this.tbRePass.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nhập lại mật khẩu:";
            // 
            // btnTaoLogin
            // 
            this.btnTaoLogin.Location = new System.Drawing.Point(427, 346);
            this.btnTaoLogin.Name = "btnTaoLogin";
            this.btnTaoLogin.Size = new System.Drawing.Size(101, 29);
            this.btnTaoLogin.TabIndex = 8;
            this.btnTaoLogin.Text = "Tạo tài khoản";
            this.btnTaoLogin.UseVisualStyleBackColor = true;
            this.btnTaoLogin.Click += new System.EventHandler(this.btnTaoLogin_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(217, 346);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(93, 29);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // tbMatKhau
            // 
            this.tbMatKhau.Location = new System.Drawing.Point(236, 175);
            this.tbMatKhau.Name = "tbMatKhau";
            this.tbMatKhau.Size = new System.Drawing.Size(311, 21);
            this.tbMatKhau.TabIndex = 6;
            this.tbMatKhau.UseSystemPasswordChar = true;
            // 
            // tbTaiKhoan
            // 
            this.tbTaiKhoan.Location = new System.Drawing.Point(236, 116);
            this.tbTaiKhoan.Name = "tbTaiKhoan";
            this.tbTaiKhoan.Size = new System.Drawing.Size(311, 21);
            this.tbTaiKhoan.TabIndex = 5;
            // 
            // tbMaNV
            // 
            this.tbMaNV.Location = new System.Drawing.Point(236, 50);
            this.tbMaNV.Name = "tbMaNV";
            this.tbMaNV.Size = new System.Drawing.Size(311, 21);
            this.tbMaNV.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mật khẩu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tài khoản:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(120, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã nhân viên:";
            // 
            // TaoLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 477);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "TaoLogin";
            this.Text = "TaoLogin";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.TaoLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbChiNhanh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkboxChiNhanh;
        private System.Windows.Forms.CheckBox cbNganHang;
        private System.Windows.Forms.TextBox tbRePass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTaoLogin;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.TextBox tbMatKhau;
        private System.Windows.Forms.TextBox tbTaiKhoan;
        private System.Windows.Forms.TextBox tbMaNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}