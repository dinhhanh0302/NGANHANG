using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace NGANHANG.Forms
{
    public partial class rptKhachHang : DevExpress.XtraReports.UI.XtraReport
    {
        public rptKhachHang(string quyen)
        {
            InitializeComponent();
            this.sP_THONGKE_KHACHHANGTableAdapter1.Connection.ConnectionString = Program.connectionstring;
            this.sP_THONGKE_KHACHHANGTableAdapter1.Fill(this.cN_NGANHANG1.SP_THONGKE_KHACHHANG, quyen);
        }

    }
}
