using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;

namespace xk
{
    public partial class frmSelectCourse : Form
    {
        private static frmSelectCourse _Instance = null;
        public static frmSelectCourse Instance()
        {
            if (_Instance == null)
            {
                _Instance = new frmSelectCourse();
            }
            return _Instance;
        }
        private frmSelectCourse()
        {
            InitializeComponent();
        }
        
        DataSet ds = new DataSet();
        private int indexofitemundermousetodrag = -1;
        private int indexofitemundermousetodrop = -1;
        private int indexofitemundermousetover = -1;
        private Rectangle dragboxfrommousedown = Rectangle.Empty;
        private void femSelectCourse_Load(object sender, EventArgs e)
        {
            dgvCourse.AutoGenerateColumns = false;
            dgvSelectCourse.AutoGenerateColumns = false;
            getStuCou();
            getCourse();


        }
        private void getStuCou()
        {
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.XKDBConnectionString);
            string sql = "select Stucou.*,couname from Stucou,Course where Stucou.Couno = Course.Couno and Stuno=@stuno  order by Willorder";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            da.SelectCommand.Parameters.Add("@stuno", SqlDbType.NVarChar, 8).Value = CPublic.LoginInfo["Stuno"].ToString();
            cn.Open();
            da.Fill(ds, "Stucou");
            cn.Close();
            dgvSelectCourse.DataSource = ds.Tables["Stucou"];
        }
        private void getCourse()
        {
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.XKDBConnectionString);
            string sql = "select *from Course order by couno";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            cn.Open();
            da.Fill(ds, "Course");
            cn.Close();
            dgvCourse.DataSource = ds.Tables["Course"];
        }
        private void Scourse()
        {
            if (dgvCourse.CurrentRow != null)
            {
                
                if (ds.Tables["Stucou"].Rows.Count < 5)
                {
                    string Couno = dgvCourse.CurrentRow.Cells["Couno"].Value.ToString();
                    DataRow[] adr = ds.Tables["Stucou"].Select("Couno='" + Couno + "'");
                    if (adr.Length == 0)
                    {
                        
                        string Couname = dgvCourse.CurrentRow.Cells["Couname"].Value.ToString();
                        DataRow dr = ds.Tables["StuCou"].NewRow();
                        dr["Couno"] = Couno;
                        dr["Couname"] = Couname;
                        
                        ds.Tables["Stucou"].Rows.Add(dr);
                    }
                    else
                    {
                        MessageBox.Show("该课程已经报名！", "选课重复提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                    else 
                    {
                    MessageBox.Show("最多选5门课！！！","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }

            }
        }

        private void dgvCourse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCourse.Columns[e.ColumnIndex].Name == "Join")
            {
                Scourse();
            }
        }
        private void Ccourse()
        {
            if (dgvSelectCourse.CurrentRow != null)
            {
                int RowIndex = dgvSelectCourse.CurrentRow.Index;
                string Couno = dgvSelectCourse.CurrentRow.Cells["Selectcouno"].Value.ToString();
                DataRow[] adr;
                adr = ds.Tables["Stucou"].Select("Couno='" + Couno + "'");
                ds.Tables["Stucou"].Rows.Remove(adr[0]);
            }
        }

        private void dgvSelectCourse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSelectCourse.Columns[e.ColumnIndex].Name == "Cancel")
            {
                Ccourse();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.XKDBConnectionString);
            string sql = "DELETE FROM STUCOU WHERE stuno=@Stuno";
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.Parameters.Add("Stuno", SqlDbType.NVarChar, 8).Value = CPublic.LoginInfo["Stuno"].ToString();
            cn.Open();
                cmd.ExecuteNonQuery();
            cn.Close();
            for (int i = 0; i < dgvSelectCourse.Rows.Count; i++)
            {
                sql = "insert stucou(stuno,couno,willorder,state) values (@Stuno,@Couno,@Willorder,@State)";
                cmd = new SqlCommand(sql, cn);
                cmd.Parameters.Add("@Stuno", SqlDbType.NVarChar, 8).Value = CPublic.LoginInfo["Stuno"].ToString();
                cmd.Parameters.Add("@Couno", SqlDbType.NVarChar, 8).Value = dgvSelectCourse.Rows[i].Cells["Selectcouno"].Value;
                cmd.Parameters.Add("@Willorder", SqlDbType.SmallInt).Value = i + 1;
                cmd.Parameters.Add("@State", SqlDbType.NVarChar, 2).Value = "报名";
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

            }
            ds.Tables["Stucou"].Clear();
            getStuCou();
        }

        private void dgvSelectCourse_MouseDown(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo hitTest = dgvSelectCourse.HitTest(e.X, e.Y);
            if (hitTest.Type != DataGridViewHitTestType.Cell) return;
            indexofitemundermousetodrag = hitTest.RowIndex;
            if (indexofitemundermousetodrag > -1)
            {
                Size dragSize = SystemInformation.DragSize;
                dragboxfrommousedown = new Rectangle(new Point(e.X - (dragSize.Width / 2), e.Y - (dragSize.Height / 2)), dragSize);

            }
            else dragboxfrommousedown = Rectangle.Empty;
        }
        private void onrowdragover(int rowindex)
        {
            if (indexofitemundermousetover == rowindex)
                return;
            int old = indexofitemundermousetover;
            indexofitemundermousetover = rowindex;
            if (old > -1)
            {
                dgvSelectCourse.InvalidateRow(old);
                if (rowindex > -1)
                {
                    dgvSelectCourse.InvalidateRow(rowindex);
                }
            }
        }

        private void dgvCourse_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) != MouseButtons.Left) return;
            if ((dragboxfrommousedown == Rectangle.Empty || dragboxfrommousedown.Contains(e.X, e.Y))) return;
            if (indexofitemundermousetodrag < 0)
                return;
            DataGridViewRow row = dgvSelectCourse.Rows[indexofitemundermousetodrag];
            DragDropEffects dropeffect = dgvSelectCourse.DoDragDrop(row, DragDropEffects.All);
            onrowdragover(-1);
        }

        private void dgvSelectCourse_MouseUp(object sender, MouseEventArgs e)
        {
            dragboxfrommousedown = Rectangle.Empty;
        }

        private void dgvSelectCourse_DragOver(object sender, DragEventArgs e)
        {
            Point p = dgvSelectCourse.PointToClient(new Point(e.X, e.Y));
            DataGridView.HitTestInfo hitTest = dgvSelectCourse.HitTest(p.X, p.Y);
            if (hitTest.Type != DataGridViewHitTestType.Cell || hitTest.RowIndex == indexofitemundermousetodrag)
            {
                e.Effect = DragDropEffects.None;
                onrowdragover(-1);
                return;
            }
            e.Effect = DragDropEffects.Move;
            onrowdragover(hitTest.RowIndex);
        }

        private void dgvSelectCourse_DragDrop(object sender, DragEventArgs e)
        {
            Point p = dgvSelectCourse.PointToClient(new Point(e.X, e.Y));
            DataGridView.HitTestInfo hitTest = dgvSelectCourse.HitTest(p.X, p.Y);
            if (hitTest.Type != DataGridViewHitTestType.Cell || hitTest.RowIndex == indexofitemundermousetodrag + 1)
                return;
            indexofitemundermousetodrop = hitTest.RowIndex;
            DataRow tempRow = ds.Tables["Stucou"].NewRow();
            tempRow.ItemArray = ds.Tables["Stucou"].Rows[indexofitemundermousetodrag].ItemArray;
            ds.Tables["Stucou"].Rows.RemoveAt(indexofitemundermousetodrag);

            if (indexofitemundermousetodrag < indexofitemundermousetodrop)
                indexofitemundermousetodrop--;
            ds.Tables["Stucou"].Rows.InsertAt(tempRow, indexofitemundermousetodrop);
        }

        private void dgvSelectCourse_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (e.RowIndex == indexofitemundermousetover)
                e.Graphics.FillRectangle(Brushes.Red, e.RowBounds.X, e.RowBounds.Y, e.RowBounds.Width, 2);
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, dgvCourse.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dgvCourse.RowHeadersDefaultCellStyle.Font, rectangle, Color.Red, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);

        }
    }
}
