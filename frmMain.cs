using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace xk
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void 选课ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            this.Invalidate(true);
        }

        private void 系部信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDrapartment fd = new frmDrapartment();
            fd.MdiParent = this;
            fd.Show();
        }

        private void 班级信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClass fc = new frmClass();
            fc.MdiParent = this;
            fc.Show();
        }

        private void 系部信息ToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            系部信息ToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
        }

        private void 系部信息ToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            系部信息ToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
        }

        private void 班级信息ToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            班级信息ToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
        }

        private void 班级信息ToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            班级信息ToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
        }

        private void 学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudent fs = new frmStudent();
            fs.MdiParent = this;
            fs.Show();
        }

        private void 学生信息ToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            学生信息ToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
        
        }

        private void 学生信息ToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            学生信息ToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
        }

        private void 系部信息ToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            系部信息ToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
        }

        private void 班级信息ToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            班级信息ToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
        }

        private void 课程信息ToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            课程信息ToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
        }

        private void 课程信息ToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            课程信息ToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
        }

        private void 课程信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCourse fcoure = new frmCourse();
            fcoure.MdiParent = this;
            fcoure.Show();
        }


    }
}
