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
    public partial class TaoLogin : DevExpress.XtraEditors.XtraForm
    {
        public TaoLogin()
        {
            InitializeComponent();
        }
        

        private void TaoLogin_Load(object sender, EventArgs e)
        {
            cbChiNhanh.DataSource = Program.ChiNhanhbds;
            cbChiNhanh.DisplayMember = "TENCN";
            cbChiNhanh.ValueMember = "TENSERVER";
            cbNganHang.Checked = true;
            if (Program.mGroup.Trim() == "CHINHANH")
            {
                cbChiNhanh.Enabled = false;
            }
        }

        private void cbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView") return;
            Program.TenServer = cbChiNhanh.SelectedValue.ToString();

            if (cbChiNhanh.SelectedIndex != 0)
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
                
            }
        }

        private void cbNganHang_CheckedChanged(object sender, EventArgs e)
        {
            checkboxChiNhanh.Checked = !cbNganHang.Checked;
        }

        private void checkboxChiNhanh_CheckedChanged(object sender, EventArgs e)
        {
            cbNganHang.Checked = !checkboxChiNhanh.Checked;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTaoLogin_Click(object sender, EventArgs e)
        {
            string role = "NGANHANG";
            if(checkboxChiNhanh.Checked == true)
            {
                role = "CHINHANH";
            }
            if (tbMaNV.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập mã nhân viên", "", MessageBoxButtons.OK);
                tbMaNV.Focus();
                return;
            }
            else if (KT_MaNhanVien.KiemTraMaNhanVien(tbMaNV.Text) == 0)
            {
                MessageBox.Show("Mã nhân viên không tồn tại! Vui lòng nhập lại", "", MessageBoxButtons.OK);
                tbMaNV.Focus();
                return;
            }
            else if (tbTaiKhoan.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập tài khoản cho nhân viên", "", MessageBoxButtons.OK);
                tbTaiKhoan.Focus();
                return;
            }
            else if (tbMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu cho nhân viên", "", MessageBoxButtons.OK);
                tbMatKhau.Focus();
                return;
            }
            else if (tbRePass.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập lại mật khẩu cho nhân viên", "", MessageBoxButtons.OK);
                tbRePass.Focus();
                return;
            }
            else if (!tbMatKhau.Text.Equals(tbRePass.Text))
            {
                MessageBox.Show("Hai mật khẩu phải giống nhau", "", MessageBoxButtons.OK);
                tbRePass.Focus();
                return;
            }
            else
            {
                int checkLogin = KT_TaoLogin.KiemTraTaoLogin(tbTaiKhoan.Text.Trim(), tbMaNV.Text.Trim());
                if (checkLogin == 2)
                {
                    MessageBox.Show("Nhân viên này đã tồn tại tài khoản", "", MessageBoxButtons.OK);
                    return;
                }
                else if (checkLogin == 1)
                {
                    MessageBox.Show("Tên tài khoản bị trùng! Vui lòng nhập lại", "", MessageBoxButtons.OK);
                    tbTaiKhoan.Focus();
                    return;
                }
                else
                {
                    if(KT_TaoLogin.TaoLogin(tbTaiKhoan.Text.Trim(), tbMatKhau.Text.Trim(), tbMaNV.Text.Trim(), role) == 0)
                    {
                        MessageBox.Show("Tạo tài khoản thành công cho nhân viên: " + tbMaNV.Text);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Đã có lỗi trong quá trình tạo tài khoản! Vui lòng kiểm tra lại");
                        return;
                    }
                }
                
            }
           
        }
    }
}