using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using NGANHANG.Process;

namespace NGANHANG.Forms
{
    public partial class ThongKe_GiaoDich : DevExpress.XtraEditors.XtraForm
    {
        public ThongKe_GiaoDich()
        {
            InitializeComponent();

        }

        private void ThongKe_GiaoDich_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Enabled = true;
        }

        private void ThongKe_GiaoDich_Load(object sender, EventArgs e)
        {
            this.Owner.Enabled = false;
        }

        bool kiemTraSo(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (tbSoTKThongKe.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số tài khoản");
                tbSoTKThongKe.Focus();
                return;
            }
            else if (!kiemTraSo(tbSoTKThongKe.Text))
            {
                MessageBox.Show("Giá trị nhập vào không hợp lệ", "", MessageBoxButtons.OK);
                tbSoTKThongKe.Focus();
                return;
            }
            if (tbSoTKThongKe.Text.Length > 9)
            {
                MessageBox.Show("Số tài khoản tối đa là 9 số");
                tbSoTKThongKe.Focus();
                return;
            }

            else if (KT_TaiKhoanKH.KiemTraSoTaiKhoan(tbSoTKThongKe.Text) != 1)
            {
                MessageBox.Show("Số tài khoản không tồn tại");
                tbSoTKThongKe.Focus();
                return;
            }
            else
            {
                rptGiaoDich rpt = new rptGiaoDich(tbSoTKThongKe.Text, ngayBatDauTK.Value, ngayKetThucTK.Value);
                ReportPrintTool print = new ReportPrintTool(rpt);
                print.ShowPreviewDialog();
            }
        }
    }
}