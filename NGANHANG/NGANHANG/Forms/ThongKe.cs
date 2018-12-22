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
    public partial class ThongKe : DevExpress.XtraEditors.XtraForm
    {
        public ThongKe()
        {
            InitializeComponent();
        }

        private void cbbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbChiNhanh.SelectedValue == null) return;
            if (cbbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView") return;
            Program.TenServer = cbbChiNhanh.SelectedValue.ToString();

            if (cbbChiNhanh.SelectedIndex != 0)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.loginDN;
                Program.password = Program.passwordDN;
            }
            bool rs = db_connect.KTDangNhap(Program.mlogin, Program.password);
            if (!rs)
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            else
            {
                //try
                //{
                //    btnDSGiaoDich.Enabled = true;
                //    this.sP_DS_TAIKHOANTableAdapter.Connection.ConnectionString = Program.connectionstring;
                //    this.sP_DS_TAIKHOANTableAdapter.Fill(this.cN_NGANHANG.SP_DS_TAIKHOAN);
                //}
                //catch (System.Data.SqlClient.SqlException ex)
                //{
                //    btnDSGiaoDich.Enabled = false;
                //    return;
                //}

            }
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            rbtnHienTai.Checked = true;
            rbtnGiaoDich.Checked = true;
            cbbChiNhanh.DataSource = Program.ChiNhanhbds;
            cbbChiNhanh.DisplayMember = "TENCN";
            cbbChiNhanh.ValueMember = "TENSERVER";

            if (Program.mGroup.Trim() == "CHINHANH")
            {
                cbbChiNhanh.Enabled = false;
                rbtnTatCa.Enabled = false;
                rbtnHienTai.Enabled = false;
            }
        }

        private void rbtnHienTai_CheckedChanged(object sender, EventArgs e)
        {
            rbtnTatCa.Checked = !rbtnHienTai.Checked;
        }

        private void rbtnTatCa_CheckedChanged(object sender, EventArgs e)
        {
            rbtnHienTai.Checked = !rbtnTatCa.Checked;
        }

        private void rbtnGiaoDich_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnGiaoDich.Checked)
            {
                rbtnTaiKhoan.Checked = rbtnKhachHang.Checked = false;
            }
        }

        private void rbtnTaiKhoan_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnTaiKhoan.Checked)
            {
                rbtnGiaoDich.Checked = rbtnKhachHang.Checked = false;
            }
            
        }

        private void rbtnKhachHang_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnKhachHang.Checked)
            {
                rbtnGiaoDich.Checked = rbtnTaiKhoan.Checked = false;
            }
            
        }

        private void btnPreView_Click(object sender, EventArgs e)
        {
            string quyen = "CHINHANH";
            if(rbtnTatCa.Checked == true)
            {
                quyen = "NGANHANG";
            }
           
            if(rbtnKhachHang.Checked == true)
            {
                rptKhachHang rpt = new rptKhachHang(quyen);
                ReportPrintTool print = new ReportPrintTool(rpt);
                print.ShowPreviewDialog();
            }
            else if(rbtnTaiKhoan.Checked == true)
            {
                rptTaiKhoan rpt = new rptTaiKhoan(quyen);
                ReportPrintTool print = new ReportPrintTool(rpt);
                print.ShowPreviewDialog();
                
            }
            else if (rbtnGiaoDich.Checked == true)
            {
                ThongKe_GiaoDich thongKe_GiaoDich = new ThongKe_GiaoDich();
                thongKe_GiaoDich.Owner = this;
                thongKe_GiaoDich.Show();
            }

        }
    }
}