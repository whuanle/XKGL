using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace xk
{
    public partial class frmMyResult : Form
    {
        private static frmMyResult _Instance = null;
        public static frmMyResult Instance()
        {
            if (_Instance == null)
            {
                _Instance = new frmMyResult();
            }
            return _Instance;
        }
        private frmMyResult()
        {
            InitializeComponent();
        }

        private void frmMyResult_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            getStucou();
        }
        private void getStucou()
        {
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.XKDBConnectionString);
            string sql = "select stucou.*,couname from stucou,course where stuno=@stuno and stucou.couno=course.couno order by willorder";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            da.SelectCommand.Parameters.Add("@Stuno", SqlDbType.NVarChar, 8).Value = CPublic.LoginInfo["Stuno"];
            DataSet ds = new DataSet();
            da.Fill(ds, "Stuno");
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
