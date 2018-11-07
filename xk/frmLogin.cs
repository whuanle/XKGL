using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace xk
{
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
            this.txtid.Region = new Region(GetRoundRectPath(new RectangleF(0, 0, this.txtid.Width, this.txtid.Height), 10f));
            this.txtpwd.Region = new Region(GetRoundRectPath(new RectangleF(0, 0, this.txtpwd.Width, this.txtpwd.Height), 10f));
            this.label3.Region = new Region(GetRoundRectPath(new RectangleF(0, 0, this.label3.Width, this.label3.Height), 10f));
            txtid.Focus();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            skinLabel1.Text = "";
            if (skinTextBox1.Text == skinCode1.CodeStr)
            {
                if (checkBox1.Checked)
                {
                    CPublic.CheckUsers(txtid.Text, txtpwd.Text);

                }
                else
                    CPublic.CheckStudent(txtid.Text, txtpwd.Text);

                if (CPublic.LoginInfo == null)
                {
                    MessageBox.Show("账号或密码错误", "登陆错误", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else Close();
            }
            else skinLabel1.Text = "验证码不正确！";
        }

        public GraphicsPath GetRoundRectPath(RectangleF rect, float radius)
        {
            return GetRoundRectPath(rect.X, rect.Y, rect.Width, rect.Height, radius);
        }

        public GraphicsPath GetRoundRectPath(float X, float Y, float width, float height, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddLine(X + radius, Y, (X + width) - (radius * 2f), Y);
            path.AddArc((X + width) - (radius * 2f), Y, radius * 2f, radius * 2f, 270f, 90f);
            path.AddLine((float)(X + width), (float)(Y + radius), (float)(X + width), (float)((Y + height) - (radius * 2f)));
            path.AddArc((float)((X + width) - (radius * 2f)), (float)((Y + height) - (radius * 2f)), (float)(radius * 2f), (float)(radius * 2f), 0f, 90f);
            path.AddLine((float)((X + width) - (radius * 2f)), (float)(Y + height), (float)(X + radius), (float)(Y + height));
            path.AddArc(X, (Y + height) - (radius * 2f), radius * 2f, radius * 2f, 90f, 90f);
            path.AddLine(X, (Y + height) - (radius * 2f), X, Y + radius);
            path.AddArc(X, Y, radius * 2f, radius * 2f, 180f, 90f);
            path.CloseFigure();
            return path;
        }

        private void btn_MouseMove(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackColor = Color.IndianRed;
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Gainsboro;
        }

        private void txt_MouseLeave(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
        }

        private void txt_MouseMove(object sender, MouseEventArgs e)
        {
            ((TextBox)sender).BackColor = Color.GreenYellow;
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void skinTextBox1_MouseMove(object sender, MouseEventArgs e)
        {

            skinLabel1.Text = "";
               
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
