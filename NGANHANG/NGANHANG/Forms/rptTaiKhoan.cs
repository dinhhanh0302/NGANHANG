using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace NGANHANG.Forms
{
    public partial class rptTaiKhoan : DevExpress.XtraReports.UI.XtraReport
    {
        public rptTaiKhoan(string quyen)
        {
            InitializeComponent();
            this.sP_THONGKE_TAIKHOANTableAdapter1.Connection.ConnectionString = Program.connectionstring;
            this.sP_THONGKE_TAIKHOANTableAdapter1.Fill(this.cN_NGANHANG1.SP_THONGKE_TAIKHOAN, quyen);
            
        }

       
    }
}
