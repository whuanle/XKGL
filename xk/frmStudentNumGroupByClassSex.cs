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
    public partial class frmStudentNumGroupByClassSex : Form
    {
        private static frmStudentNumGroupByClassSex _Instance = null;
        public static frmStudentNumGroupByClassSex Instance()
        {
            if (_Instance == null)
            {
                _Instance = new frmStudentNumGroupByClassSex();
            }
            return _Instance;
        }
        private frmStudentNumGroupByClassSex()
        {
            InitializeComponent();
        }
        DataSet ds;
        private void frmStudentNumGroupByClassSex_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.XKDBConnectionString);
            string sql = "select classname,sex,studentnum=count(*) from student s,class c where s.classno=c.classno group by c.classno,classname,sex order by c.classno,sex";

            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            ds = new DataSet();
            cn.Open();
            da.Fill(ds, "Studentnumbysex");
            cn.Close();
            dataGridView1.DataSource = ds.Tables[0];
                        string classname = "";
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            if (ds.Tables[0].Rows[i]["Classname"].ToString() == classname)
                            {
                                ds.Tables[0].Rows[i]["Classname"] = "";
                            }
                            else
                                classname = ds.Tables[0].Rows[i]["Classname"].ToString();
                        }
                 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
