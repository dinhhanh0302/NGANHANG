namespace NGANHANG.Forms
{
    partial class ThongKe
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
            this.btnPreView = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbChiNhanh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.rbtnHienTai = new System.Windows.Forms.CheckBox();
            this.rbtnTatCa = new System.Windows.Forms.CheckBox();
            this.rbtnGiaoDich = new System.Windows.Forms.CheckBox();
            this.rbtnTaiKhoan = new System.Windows.Forms.CheckBox();
            this.rbtnKhachHang = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPreView
            // 
            this.btnPreView.Location = new System.Drawing.Point(372, 244);
            this.btnPreView.Name = "btnPreView";
            this.btnPreView.Size = new System.Drawing.Size(75, 23);
            this.btnPreView.TabIndex = 0;
            this.btnPreView.Text = "Preview";
            this.btnPreView.UseVisualStyleBackColor = true;
            this.btnPreView.Click += new System.EventHandler(this.btnPreView_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbbChiNhanh);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 88);
            this.panel1.TabIndex = 1;
            // 
            // cbbChiNhanh
            // 
            this.cbbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChiNhanh.FormattingEnabled = true;
            this.cbbChiNhanh.Location = new System.Drawing.Point(262, 38);
            this.cbbChiNhanh.Name = "cbbChiNhanh";
            this.cbbChiNhanh.Size = new System.Drawing.Size(143, 21);
            this.cbbChiNhanh.TabIndex = 1;
            this.cbbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cbbChiNhanh_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi nhánh:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnPreView);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(862, 378);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnTatCa);
            this.groupBox2.Controls.Add(this.rbtnHienTai);
            this.groupBox2.Location = new System.Drawing.Point(75, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(493, 77);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thống kê trên Server:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbtnKhachHang);
            this.groupBox3.Controls.Add(this.rbtnTaiKhoan);
            this.groupBox3.Controls.Add(this.rbtnGiaoDich);
            this.groupBox3.Location = new System.Drawing.Point(75, 134);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(493, 80);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Loại thống kê:";
            // 
            // rbtnHienTai
            // 
            this.rbtnHienTai.AutoSize = true;
            this.rbtnHienTai.Location = new System.Drawing.Point(32, 37);
            this.rbtnHienTai.Name = "rbtnHienTai";
            this.rbtnHienTai.Size = new System.Drawing.Size(62, 17);
            this.rbtnHienTai.TabIndex = 9;
            this.rbtnHienTai.Text = "Hiện tại";
            this.rbtnHienTai.UseVisualStyleBackColor = true;
            this.rbtnHienTai.CheckedChanged += new System.EventHandler(this.rbtnHienTai_CheckedChanged);
            // 
            // rbtnTatCa
            // 
            this.rbtnTatCa.AutoSize = true;
            this.rbtnTatCa.Location = new System.Drawing.Point(209, 37);
            this.rbtnTatCa.Name = "rbtnTatCa";
            this.rbtnTatCa.Size = new System.Drawing.Size(56, 17);
            this.rbtnTatCa.TabIndex = 10;
            this.rbtnTatCa.Text = "Tất cả";
            this.rbtnTatCa.UseVisualStyleBackColor = true;
            this.rbtnTatCa.CheckedChanged += new System.EventHandler(this.rbtnTatCa_CheckedChanged);
            // 
            // rbtnGiaoDich
            // 
            this.rbtnGiaoDich.AutoSize = true;
            this.rbtnGiaoDich.Location = new System.Drawing.Point(32, 42);
            this.rbtnGiaoDich.Name = "rbtnGiaoDich";
            this.rbtnGiaoDich.Size = new System.Drawing.Size(69, 17);
            this.rbtnGiaoDich.TabIndex = 4;
            this.rbtnGiaoDich.Text = "Giao dịch";
            this.rbtnGiaoDich.UseVisualStyleBackColor = true;
            this.rbtnGiaoDich.CheckedChanged += new System.EventHandler(this.rbtnGiaoDich_CheckedChanged);
            // 
            // rbtnTaiKhoan
            // 
            this.rbtnTaiKhoan.AutoSize = true;
            this.rbtnTaiKhoan.Location = new System.Drawing.Point(209, 42);
            this.rbtnTaiKhoan.Name = "rbtnTaiKhoan";
            this.rbtnTaiKhoan.Size = new System.Drawing.Size(72, 17);
            this.rbtnTaiKhoan.TabIndex = 5;
            this.rbtnTaiKhoan.Text = "Tài khoản";
            this.rbtnTaiKhoan.UseVisualStyleBackColor = true;
            this.rbtnTaiKhoan.CheckedChanged += new System.EventHandler(this.rbtnTaiKhoan_CheckedChanged);
            // 
            // rbtnKhachHang
            // 
            this.rbtnKhachHang.AutoSize = true;
            this.rbtnKhachHang.Location = new System.Drawing.Point(383, 42);
            this.rbtnKhachHang.Name = "rbtnKhachHang";
            this.rbtnKhachHang.Size = new System.Drawing.Size(82, 17);
            this.rbtnKhachHang.TabIndex = 6;
            this.rbtnKhachHang.Text = "Khách hàng";
            this.rbtnKhachHang.UseVisualStyleBackColor = true;
            this.rbtnKhachHang.CheckedChanged += new System.EventHandler(this.rbtnKhachHang_CheckedChanged);
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 466);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "ThongKe";
            this.Text = "ThongKe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ThongKe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPreView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbbChiNhanh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox rbtnKhachHang;
        private System.Windows.Forms.CheckBox rbtnTaiKhoan;
        private System.Windows.Forms.CheckBox rbtnGiaoDich;
        private System.Windows.Forms.CheckBox rbtnTatCa;
        private System.Windows.Forms.CheckBox rbtnHienTai;
    }
}