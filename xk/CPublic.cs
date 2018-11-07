using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace xk
{
    class CPublic
    {
        public static DataRow LoginInfo;
        public static bool isManager;
        public static bool? minxh=null;    //这里保存设置，下次点击关闭窗口时是否直接小化
        public static  void CheckUsers(string UserId,string pwd)
    {
        SqlConnection cn = new SqlConnection(Properties.Settings.Default.XKDBConnectionString);
        SqlDataAdapter da = new SqlDataAdapter("select *from users where userid=@Userid and pwd =@pwd", cn);
        da.SelectCommand.Parameters.Add("@userid", SqlDbType.NVarChar, 8).Value = UserId;
        da.SelectCommand.Parameters.Add("@pwd", SqlDbType.NVarChar, 8).Value = pwd;
        DataSet ds = new DataSet();
        da.Fill(ds);
        if (ds.Tables[0].Rows.Count > 0)
        {
            LoginInfo = ds.Tables[0].Rows[0];
            isManager = true;
        }
        else
            LoginInfo = null;
    }
        public static void CheckStudent(string StuNo,string pwd)
        {
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.XKDBConnectionString);
            SqlDataAdapter da = new SqlDataAdapter("select *from student where stuno=@stuno and pwd =@pwd", cn);
            da.SelectCommand.Parameters.Add("@stuno", SqlDbType.NVarChar, 8).Value = StuNo;
            da.SelectCommand.Parameters.Add("@pwd", SqlDbType.NVarChar, 8).Value = pwd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                LoginInfo = ds.Tables[0].Rows[0];
                isManager = false;
            }
            else
                LoginInfo = null;
        }
    }
}
