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
      
            if (CPublic.isManager)
            {
                toolStripStatusLabel2.Text = CPublic.LoginInfo["Username"].ToString();
                学生选课ToolStripMenuItem.Enabled = false;
            }
            else
            {
                toolStripStatusLabel2.Text = CPublic.LoginInfo["Stuname"].ToString();
                系部信息ToolStripMenuItem.Enabled = false;
                班级信息ToolStripMenuItem.Enabled = false;
                学生信息ToolStripMenuItem.Enabled = false;
                课程信息ToolStripMenuItem.Enabled = false;
                统计查询ToolStripMenuItem.Enabled = false;
                选课抽签结果ToolStripMenuItem.Enabled = false;
                LINQ示例ToolStripMenuItem.Enabled = false;
            }
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
            frmDrapartment fd = frmDrapartment.Instance();
            fd.MdiParent = this;
            fd.Show();
            fd.Focus();
        }

        private void 班级信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClass fc = frmClass.Instance();
            fc.MdiParent = this;
            fc.Show();
            fc.Focus();
        }

        private void Mouse_leave(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)sender).ForeColor = System.Drawing.Color.Black;
        }


        private void Mouse_move(object sender, MouseEventArgs e)
        {
            ((ToolStripMenuItem)sender).ForeColor = System.Drawing.Color.Blue;
        }


        private void 学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudent fs = frmStudent.Instance();
            fs.MdiParent = this;
            fs.Show();
            fs.Focus();
        }

        private void 课程信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCourse fcoure = frmCourse.Instance();
            fcoure.MdiParent = this;
            fcoure.Show();
            fcoure.Focus();
        }

        private void 选课填报志愿ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSelectCourse fs1 = frmSelectCourse.Instance();
            fs1.MdiParent = this;
            fs1.Show();
            fs1.Focus();
        }

        private void 我的报名结果ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMyResult fm = frmMyResult.Instance();
            fm.MdiParent = this;
            fm.Show();
            fm.Focus();
        }

        private void 按班级性别统计学生人数ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudentNumGroupByClassSex fs = frmStudentNumGroupByClassSex.Instance();
            fs.MdiParent = this;
            fs.Show();
            fs.Focus();

        }

        private void 未选课学生名单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudentNotSelectCourse fnm = frmStudentNotSelectCourse.Instance();
            fnm.MdiParent = this;
            fnm.Show();
            fnm.Show();
        }

        private void 随机抽签ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)  //判断是否最小化 
            {
                this.ShowInTaskbar = false;  //不显示在系统任务栏 
                
                    this.notifyIcon1.Visible = true;
                
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = true;  //显示在系统任务栏 
                this.WindowState = FormWindowState.Normal;  //还原窗体 
                this.notifyIcon1.Visible = false;  //托盘图标隐藏 
            }
        }

        private void open_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void qh_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            CPublic.LoginInfo = null;
            CPublic.isManager = false;
            frmLogin fg = new frmLogin();
            fg.Show();

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CPublic.minxh == null)
            {
                if (MessageBox.Show("是否隐藏到系统右下角任务栏？\n点击是隐藏\n点击否直接退出", "隐藏", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    e.Cancel = true;
                    this.WindowState = FormWindowState.Minimized;
                    this.ShowInTaskbar = false;  //不显示在系统任务栏 
                    this.notifyIcon1.Visible = true;
                    //托盘图标可见 ，其中binzhounotifyIcon为上述notifyicon控件的ID
                    CPublic.minxh = true;
                    
                }
                else if (CPublic.minxh == true)
                {
                    e.Cancel = true;
                    this.WindowState = FormWindowState.Minimized;
                    this.ShowInTaskbar = false;  //不显示在系统任务栏 
                    this.notifyIcon1.Visible = true;
                    //托盘图标可见 ，其中binzhounotifyIcon为上述notifyicon控件的ID
                }
            }
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


    }
}
