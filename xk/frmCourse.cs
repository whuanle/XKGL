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
    public partial class frmCourse : Form
    {
        private static frmCourse _Instance = null;
        public static frmCourse Instance()
        {
            if (_Instance == null)
            {
                _Instance = new frmCourse();
            }
            return _Instance;
        }
        private frmCourse()
        {
            InitializeComponent();
        }

        private void courseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.courseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.系部数据);

        }

        private void frmCourse_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“系部数据.Course”中。您可以根据需要移动或删除它。
            this.courseTableAdapter.Fill(this.系部数据.Course);

        }
        private void ChangeEnabledState()
        {
            courseBindingNavigator.Enabled = !courseBindingNavigator.Enabled;
            foreach (ToolStripItem b in tsControl.Items)
            {
                b.Enabled = !b.Enabled;
            }
            foreach (Control c in gdEdit.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).ReadOnly = !((TextBox)c).ReadOnly;
            }
        }

        private void tsInsert_Click(object sender, EventArgs e)
        {
            ChangeEnabledState();
            courseBindingSource.AddNew();
            counoTextBox.Focus();
        }

        private void tsEdit_Click(object sender, EventArgs e)
        {
            ChangeEnabledState();
            counoTextBox.Focus();
        }

        private void tsSave_Click(object sender, EventArgs e)
        {
            ChangeEnabledState();
            this.Validate();
            courseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.系部数据);
        }

        private void tsCancel_Click(object sender, EventArgs e)
        {
            ChangeEnabledState();
            courseBindingSource.CancelEdit();
        }

        private void tsDetele_Click(object sender, EventArgs e)
        {
            if (courseBindingSource.Current != null)
            {
                if (MessageBox.Show("确认删除吗？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    courseBindingSource.RemoveCurrent();
                    this.tableAdapterManager.UpdateAll(this.系部数据);
                }
            }
        }

    }
}
