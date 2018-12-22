using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace NGANHANG.Forms
{
    public partial class rptGiaoDich : DevExpress.XtraReports.UI.XtraReport
    {
        public rptGiaoDich(string sotk, DateTime ngaybatdau, DateTime ngayketthuc)
        {
            InitializeComponent();
            lbNgayGD.Text = "(Từ ngày " + ngaybatdau.ToString().Substring(0,10) + " đến ngày " + ngayketthuc.ToString().Substring(0,10)+")" ;
            this.sP_THONGKE_GIAODICHTableAdapter1.Connection.ConnectionString = Program.connectionstring;
            this.sP_THONGKE_GIAODICHTableAdapter1.Fill(this.cN_NGANHANG1.SP_THONGKE_GIAODICH, sotk, ngaybatdau, ngayketthuc);
        }

    }
}
