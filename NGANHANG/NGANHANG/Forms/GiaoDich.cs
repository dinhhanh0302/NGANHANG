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
using NGANHANG.Process;

namespace NGANHANG.Forms
{
    public partial class GiaoDich : DevExpress.XtraEditors.XtraForm
    {
        public GiaoDich()
        {
            InitializeComponent();
        }

        private void cbbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                try
                {
                    this.sP_DS_TAIKHOANTableAdapter.Connection.ConnectionString = Program.connectionstring;
                    this.sP_DS_TAIKHOANTableAdapter.Fill(this.cN_NGANHANG.SP_DS_TAIKHOAN);
                }
                catch(System.Data.SqlClient.SqlException ex)
                {
                }

            }
        }

        private void GuiTien_Load(object sender, EventArgs e)
        {
            try
            {
                this.sP_DS_TAIKHOANTableAdapter.Connection.ConnectionString = Program.connectionstring;
                this.sP_DS_TAIKHOANTableAdapter.Fill(this.cN_NGANHANG.SP_DS_TAIKHOAN);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                //return;
            }
            cbbChiNhanh.DataSource = Program.ChiNhanhbds;
            cbbChiNhanh.DisplayMember = "TENCN";
            cbbChiNhanh.ValueMember = "TENSERVER";

            if (Program.mGroup.Trim() == "CHINHANH")
            {
                cbbChiNhanh.Enabled = false;
            }
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            cbbLoaiGD.DataSource = null;
            cbbLoaiGD.Items.Add("Gửi tiền");
            cbbLoaiGD.Items.Add("Rút tiền");
            cbbLoaiGD.SelectedIndex = 0;
            
            cbbLoaiGD.SelectedIndex = 1;

            dateGD.Text = date;
            tbMaNVGD.Text = Program.username;
            tbSoTaiKhoanGD.Text = tbSoTK.Text;
            tbMaNVGD.Enabled = dateGD.Enabled = false;
            tbCMND.Enabled = gioiTinhNam.Enabled = gioiTinhNu.Enabled = tbHo.Enabled = tbTen.Enabled  = tbSoTK.Enabled = tbSoDu.Enabled = tbHo.Enabled = tbTen.Enabled = tbChiNhanhTaoKH.Enabled = tbChiNhanhTaoTK.Enabled = rtbDiaChi.Enabled = tbSDT.Enabled = false;

            //Nếu không có thông tin gì về giao dịch
            try
            {
                string phai = ((DataRowView)sP_DS_TAIKHOANBindingSource[sP_DS_TAIKHOANBindingSource.Position])["PHAI"].ToString().Trim();
                gioiTinhNam.Checked = true;
                if (phai == "Nữ")
                {
                    gioiTinhNu.Checked = true;
                }
            }
            catch(System.IndexOutOfRangeException ex) { }
            tbSoTienGD.Focus();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnGuiTien_Click(object sender, EventArgs e)
        {
            if (tbSoTaiKhoanGD.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tài khoản", "", MessageBoxButtons.OK);
                tbSoTaiKhoanGD.Focus();
                return;
            }
            else if (!kiemTraSo(tbSoTaiKhoanGD.Text.Trim()))
            {
                MessageBox.Show("Số tài khoản nhập vào không hợp lệ", "", MessageBoxButtons.OK);
                tbSoTaiKhoanGD.Focus();
                return;
            }
            else if (tbSoTienGD.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số tiền nạp", "", MessageBoxButtons.OK);
                tbSoTienGD.Focus();
                return;
            }
            else if (!kiemTraSo(tbSoTienGD.Text))
            {
                MessageBox.Show("Giá trị nhập vào không hợp lệ", "", MessageBoxButtons.OK);
                tbSoTienGD.Focus();
                return;
            }
            else if (Double.Parse(tbSoTienGD.Text) < 100000)
            {
                MessageBox.Show("Số tiền giao dịch vào phải lơn hơn 100000 VND", "", MessageBoxButtons.OK);
                tbSoTienGD.Focus();
                return;
            }
            
            else
            {
                //Double soTienRut = Double.Parse(tbSoTienGD.Text);
                //Double soTienTK = Double.Parse(tbSoDu.Text);
                //if (((soTienTK - soTienRut) < 100000) && (cbbLoaiGD.SelectedIndex == 1))
                //{
                //    MessageBox.Show("Số dư còn lại phải tối thiểu là 100000 VND", "", MessageBoxButtons.OK);
                //    tbSoTienGD.Focus();
                //    return;
                //}
                Double soTienDG = Double.Parse(tbSoTienGD.Text);
                
                string loaigd = "RT";
                if(cbbLoaiGD.SelectedIndex == 0)
                {
                    loaigd = "GT";
                }
                string dateGR = DateTime.Now.ToString("yyyy-MM-dd h:mm:ss");
                int a = KT_TaiKhoanKH.CapNhatSoDuTaiKhoan(tbCMND.Text.Trim(),tbSoTaiKhoanGD.Text.Trim(), loaigd, dateGR, soTienDG, Program.username);
                if (a == 1)
                {
                    MessageBox.Show("Giao dịch thành công");
                }
                else if(a == 2)
                {
                    MessageBox.Show("Không tìm được số tài khoản");
                }
                else if (a == 3)
                {
                    MessageBox.Show("Bạn phải để tối thiểu số dư trong tài khoản lớn hơn 100000 VND");
                }
                else
                {
                    MessageBox.Show("Giao dịch thất bại! Vui lòng kiểm tra lại");
                }

                try
                {
                    this.sP_DS_TAIKHOANTableAdapter.Connection.ConnectionString = Program.connectionstring;
                    this.sP_DS_TAIKHOANTableAdapter.Fill(this.cN_NGANHANG.SP_DS_TAIKHOAN);
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    return;
                }

                tbSoTienGD.ResetText();

            }
        }

      

        private void sP_DS_TAIKHOANGridControl_Click(object sender, EventArgs e)
        {
            string phai = ((DataRowView)sP_DS_TAIKHOANBindingSource[sP_DS_TAIKHOANBindingSource.Position])["PHAI"].ToString().Trim();
            gioiTinhNam.Checked = true;
            if (phai == "Nữ")
            {
                gioiTinhNu.Checked = true;
            }
        }

        private void gioiTinhNam_CheckedChanged(object sender, EventArgs e)
        {
            gioiTinhNu.Checked = !gioiTinhNam.Checked;
        }

        private void gioiTinhNu_CheckedChanged(object sender, EventArgs e)
        {
            gioiTinhNam.Checked = !gioiTinhNu.Checked;
        }
    }
}