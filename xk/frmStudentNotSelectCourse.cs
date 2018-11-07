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
    public partial class frmStudentNotSelectCourse : Form
    {
        private static frmStudentNotSelectCourse _Instance = null;
        public static frmStudentNotSelectCourse Instance()
        {
            if (_Instance == null)
            {
                _Instance = new frmStudentNotSelectCourse();
            }
            return _Instance;
        }
        private frmStudentNotSelectCourse()
        {
            InitializeComponent();
        }

        private void frmStudentNotSelectCourse_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            getClass();
            getStudent();
        }
        private void getClass()
        {
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.XKDBConnectionString);
            string sql = "select classno='',Classname='请选择班级' union select classno,classname from Class order by classno";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Class");
            cn.Close();
            cbClass.ValueMember = "Classno";
            cbClass.DisplayMember = "Classname";
            cbClass.DataSource = ds.Tables[0];
        }
        private void getStudent()
        {
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.XKDBConnectionString);
            string sql = "select s.*,classname from student s,class c where s.classno=c.classno and stuno not in (select stuno from stucou)";
            
            if (cbClass.SelectedIndex > 0)
                sql += "and s.classno=@classno ";
            sql += "order by stuno";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataSet ds = new DataSet();
            if (cbClass.SelectedIndex > 0)
                da.SelectCommand.Parameters.Add("@Classno", SqlDbType.NVarChar, 8).Value = cbClass.SelectedValue;
            cn.Open();
            da.Fill(ds, "Student");
            cn.Close();
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void cbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            getStudent();
        }
    }
}
