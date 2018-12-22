namespace NGANHANG.Forms
{
    partial class ThongKe_GiaoDich
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSoTKThongKe = new System.Windows.Forms.TextBox();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.ngayBatDauTK = new System.Windows.Forms.DateTimePicker();
            this.ngayKetThucTK = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số tài khoản:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày bắt đầu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(522, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày kết thúc:";
            // 
            // tbSoTKThongKe
            // 
            this.tbSoTKThongKe.Location = new System.Drawing.Point(92, 46);
            this.tbSoTKThongKe.Name = "tbSoTKThongKe";
            this.tbSoTKThongKe.Size = new System.Drawing.Size(141, 21);
            this.tbSoTKThongKe.TabIndex = 3;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(775, 42);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(77, 27);
            this.btnThongKe.TabIndex = 6;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // ngayBatDauTK
            // 
            this.ngayBatDauTK.Location = new System.Drawing.Point(350, 43);
            this.ngayBatDauTK.Name = "ngayBatDauTK";
            this.ngayBatDauTK.Size = new System.Drawing.Size(141, 21);
            this.ngayBatDauTK.TabIndex = 7;
            // 
            // ngayKetThucTK
            // 
            this.ngayKetThucTK.Location = new System.Drawing.Point(597, 43);
            this.ngayKetThucTK.Name = "ngayKetThucTK";
            this.ngayKetThucTK.Size = new System.Drawing.Size(141, 21);
            this.ngayKetThucTK.TabIndex = 8;
            // 
            // ThongKe_GiaoDich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 106);
            this.Controls.Add(this.ngayKetThucTK);
            this.Controls.Add(this.ngayBatDauTK);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.tbSoTKThongKe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "ThongKe_GiaoDich";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê giao dịch tài khoản";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ThongKe_GiaoDich_FormClosed);
            this.Load += new System.EventHandler(this.ThongKe_GiaoDich_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSoTKThongKe;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.DateTimePicker ngayBatDauTK;
        private System.Windows.Forms.DateTimePicker ngayKetThucTK;
    }
}