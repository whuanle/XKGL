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
    public partial class frmClass : Form
    {
        public frmClass()
        {
            InitializeComponent();
        }

        private void classBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.classBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.系部数据);

        }

        private void frmClass_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“系部数据.Departmrnt”中。您可以根据需要移动或删除它。
            this.departmrntTableAdapter.Fill(this.系部数据.Departmrnt);
            // TODO: 这行代码将数据加载到表“系部数据.Class”中。您可以根据需要移动或删除它。
            this.classTableAdapter.Fill(this.系部数据.Class);

        }
    }
}
