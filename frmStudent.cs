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
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();
        }

        private void studentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.系部数据);

        }

        private void studentBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.系部数据);

        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“系部数据1.Student”中。您可以根据需要移动或删除它。
            this.studentTableAdapter.Fill(this.系部数据1.Student);
            // TODO: 这行代码将数据加载到表“系部数据1.Student”中。您可以根据需要移动或删除它。
            this.studentTableAdapter.Fill(this.系部数据1.Student);
            // TODO: 这行代码将数据加载到表“系部数据.Class”中。您可以根据需要移动或删除它。
            this.classTableAdapter.Fill(this.系部数据.Class);
            // TODO: 这行代码将数据加载到表“系部数据.Student”中。您可以根据需要移动或删除它。
            this.studentTableAdapter.Fill(this.系部数据.Student);

        }
    }
}
