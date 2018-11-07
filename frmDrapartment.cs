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
    public partial class frmDrapartment : Form
    {
        public frmDrapartment()
        {
            InitializeComponent();
        }

        private void departmrntBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void frmDrapartment_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“系部数据.Departmrnt”中。您可以根据需要移动或删除它。
            this.departmrntTableAdapter.Fill(this.系部数据.Departmrnt);

        }

        private void departmrntBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.departmrntBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.系部数据);

        }
    }
}
