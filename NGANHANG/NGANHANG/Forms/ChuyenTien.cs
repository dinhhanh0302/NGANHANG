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
    public partial class ChuyenTien : DevExpress.XtraEditors.XtraForm
    {
        public ChuyenTien()
        {
            InitializeComponent();
        }

        private void ChuyenTien_Load(object sender, EventArgs e)
        {
            try
            {
                this.sP_DS_TAIKHOANTableAdapter.Connection.ConnectionString = Program.connectionstring;
                this.sP_DS_TAIKHOANTableAdapter.Fill(this.cN_NGANHANG.SP_DS_TAIKHOAN);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                return;
            }
            cbbChiNhanh.DataSource = Program.ChiNhanhbds;
            cbbChiNhanh.DisplayMember = "TENCN";
            cbbChiNhanh.ValueMember = "TENSERVER";

            if (Program.mGroup.Trim() == "CHINHANH")
            {
                cbbChiNhanh.Enabled = false;
            }
            tbCMND.Enabled = gioiTinhNu.Enabled = gioiTinhNam.Enabled = tbHo.Enabled = tbdateGD.Enabled = tbmaNVGD.Enabled = tbTen.Enabled = tbSoDu.Enabled = tbHo.Enabled = tbTen.Enabled = tbChiNhanhTaoKH.Enabled = tbChiNhanhTaoTK.Enabled = rtbDiaChi.Enabled = tbSDT.Enabled = false;
            


            tbmaNVGD.Text = Program.username;
            string date = DateTime.Now.ToString("yyyy-MM-dd");        
            tbdateGD.Text = date;
            
            //Nếu không có thông tin gì về chuyển tiền
            try
            {
                string phai = ((DataRowView)sP_DS_TAIKHOANBindingSource[sP_DS_TAIKHOANBindingSource.Position])["PHAI"].ToString().Trim();
                gioiTinhNam.Checked = true;
                if (phai == "Nữ")
                {
                    gioiTinhNu.Checked = true;
                }
            }
            catch (System.IndexOutOfRangeException ex) { }
            tbSoTKNhan.Focus();

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

        bool kiemTraSo(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbSoTK.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số tài khoản chuyển", "", MessageBoxButtons.OK);
                tbSoTK.Focus();
                return;
            }
            else if (!kiemTraSo(tbSoTK.Text.Trim()))
            {
                MessageBox.Show("Số tài khoản gửi nhập vào số tài khoản không hợp lệ", "", MessageBoxButtons.OK);
                tbSoTK.Focus();
                return;
            }
            else if (tbSoTKNhan.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số tài khoản nhận", "", MessageBoxButtons.OK);
                tbSoTKNhan.Focus();
                return;
            }
            else if (!kiemTraSo(tbSoTKNhan.Text.Trim()))
            {
                MessageBox.Show("Số tài khoản nhận nhập vào số tài khoản không hợp lệ", "", MessageBoxButtons.OK);
                tbSoTKNhan.Focus();
                return;
            }
            else if (tbSoTKNhan.Text.Trim().Equals(tbSoTK.Text.Trim()))
            {
                MessageBox.Show("Số tài khoản nhận phải khác số tài khoản gửi", "", MessageBoxButtons.OK);
                tbSoTKNhan.Focus();
                return;
            }
            else if (KT_TaiKhoanKH.KiemTraSoTaiKhoan(tbSoTKNhan.Text) != 1)
            {
                MessageBox.Show("Số tài khoản không tồn tại trong hệ thống! Vui lòng nhập lại");
                tbSoTKNhan.Focus();
                return;
            }
            else if (tbSoTienChuyen.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số tiền cần chuyển", "", MessageBoxButtons.OK);
                tbSoTienChuyen.Focus();
                return;
            }
            else if (!kiemTraSo(tbSoTienChuyen.Text))
            {
                MessageBox.Show("Giá trị nhập vào số tiền chuyển không hợp lệ", "", MessageBoxButtons.OK);
                tbSoTienChuyen.Focus();
                return;
            }
            else if (Double.Parse(tbSoTienChuyen.Text) < 100000)
            {
                int soTienNap = Int32.Parse(tbSoTienChuyen.Text);
                MessageBox.Show("Số tiền chuyển vào phải lơn hơn 100000 VND", "", MessageBoxButtons.OK);
                tbSoTienChuyen.Focus();
                return;
            }
            else
            {
                Double soTienChuyen = Double.Parse(tbSoTienChuyen.Text);
                //Double soDu = Double.Parse(tbSoDu.Text);
                //Double soTienCon = soDu - soTienChuyen;
                //if (soTienCon < 100000)
                //{
                //    MessageBox.Show("Bạn phải giữ lại tối thiểu 100000 VND trong tài khoản", "", MessageBoxButtons.OK);
                //    tbSoTienChuyen.Focus();
                //    return;
                //}

                string date = DateTime.Now.ToString("yyyy-MM-dd h:mm:ss");
                int a = KT_TaiKhoanKH.GD_ChuyenTienTaiKhoan(tbCMND.Text.Trim(),tbSoTK.Text, tbSoTKNhan.Text, date, soTienChuyen, Program.username);

                if (a == 1)
                {
                    MessageBox.Show("Giao dịch thành công");
                    try
                    {
                        this.sP_DS_TAIKHOANTableAdapter.Connection.ConnectionString = Program.connectionstring;
                        this.sP_DS_TAIKHOANTableAdapter.Fill(this.cN_NGANHANG.SP_DS_TAIKHOAN);
                    }
                    catch (System.Data.SqlClient.SqlException ex)
                    {
                        return;
                    }
                    //MessageBox.Show("Giao dịch thành công");
                    tbSoTienChuyen.ResetText();
                    tbSoTKNhan.ResetText();
                }
                else if (a == 2)
                {
                    MessageBox.Show("Không tìm được số tài khoản gửi");
                }
                else if(a == 3)
                {
                    MessageBox.Show("Bạn phải để tối thiểu số dư trong tài khoản lớn hơn 100000 VND");
                }

                else
                {
                    MessageBox.Show("Giao dịch thất bại! Vui lòng kiểm tra lại thông tin");
                }

            }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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