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
using System.Data.SqlClient;

namespace NGANHANG.Forms
{
    public partial class DS_GiaoDich : DevExpress.XtraEditors.XtraForm
    {
        private string macn;
        public DS_GiaoDich(string macn)
        {
            InitializeComponent();
            this.macn = macn;
        }

        private void GetData(string macn)
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(Program.connectionstring);
            SqlCommand com = new SqlCommand("SP_DS_GIAODICH", con);
            com.Parameters.AddWithValue("@MACN", macn);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            try
            {
                con.Open();
                da.Fill(dt);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            gridControl1.DataSource = dt;
        }

        private void DS_GiaoDich_Load(object sender, EventArgs e)
        {
            this.Owner.Enabled = false;
            GetData(macn);
        }

        private void DS_GiaoDich_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Enabled = true;

        }
    }

    
}