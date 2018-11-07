namespace xk
{
    partial class frmClass
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClass));
            this.classBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.classBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.classDataGridView = new System.Windows.Forms.DataGridView();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.系部数据 = new xk.系部数据();
            this.classTableAdapter = new xk.系部数据TableAdapters.ClassTableAdapter();
            this.tableAdapterManager = new xk.系部数据TableAdapters.TableAdapterManager();
            this.departmrntBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmrntTableAdapter = new xk.系部数据TableAdapters.DepartmrntTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingNavigator)).BeginInit();
            this.classBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.系部数据)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmrntBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // classBindingNavigator
            // 
            this.classBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.classBindingNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.classBindingNavigator.BindingSource = this.classBindingSource;
            this.classBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.classBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.classBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.classBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.classBindingNavigatorSaveItem});
            this.classBindingNavigator.Location = new System.Drawing.Point(102, 9);
            this.classBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.classBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.classBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.classBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.classBindingNavigator.Name = "classBindingNavigator";
            this.classBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.classBindingNavigator.Size = new System.Drawing.Size(276, 25);
            this.classBindingNavigator.TabIndex = 0;
            this.classBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "新添";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "删除";
            // 
            // classBindingNavigatorSaveItem
            // 
            this.classBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.classBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("classBindingNavigatorSaveItem.Image")));
            this.classBindingNavigatorSaveItem.Name = "classBindingNavigatorSaveItem";
            this.classBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.classBindingNavigatorSaveItem.Text = "保存数据";
            this.classBindingNavigatorSaveItem.Click += new System.EventHandler(this.classBindingNavigatorSaveItem_Click);
            // 
            // classDataGridView
            // 
            this.classDataGridView.AllowUserToOrderColumns = true;
            this.classDataGridView.AutoGenerateColumns = false;
            this.classDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.classDataGridView.DataSource = this.classBindingSource;
            this.classDataGridView.Location = new System.Drawing.Point(102, 81);
            this.classDataGridView.Name = "classDataGridView";
            this.classDataGridView.RowTemplate.Height = 23;
            this.classDataGridView.Size = new System.Drawing.Size(300, 393);
            this.classDataGridView.TabIndex = 1;
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataMember = "Class";
            this.classBindingSource.DataSource = this.系部数据;
            // 
            // 系部数据
            // 
            this.系部数据.DataSetName = "系部数据";
            this.系部数据.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classTableAdapter
            // 
            this.classTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassTableAdapter = this.classTableAdapter;
            this.tableAdapterManager.DepartmrntTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = xk.系部数据TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // departmrntBindingSource
            // 
            this.departmrntBindingSource.DataMember = "Departmrnt";
            this.departmrntBindingSource.DataSource = this.系部数据;
            // 
            // departmrntTableAdapter
            // 
            this.departmrntTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Classno";
            this.dataGridViewTextBoxColumn1.HeaderText = "班级代码";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Departno";
            this.dataGridViewTextBoxColumn2.DataSource = this.departmrntBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "Departname";
            this.dataGridViewTextBoxColumn2.HeaderText = "所在系部";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "Departno";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Classname";
            this.dataGridViewTextBoxColumn3.HeaderText = "班级名称";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // frmClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 473);
            this.Controls.Add(this.classDataGridView);
            this.Controls.Add(this.classBindingNavigator);
            this.Name = "frmClass";
            this.Text = "班级信息";
            this.Load += new System.EventHandler(this.frmClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classBindingNavigator)).EndInit();
            this.classBindingNavigator.ResumeLayout(false);
            this.classBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.系部数据)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmrntBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private 系部数据 系部数据;
        private System.Windows.Forms.BindingSource classBindingSource;
        private 系部数据TableAdapters.ClassTableAdapter classTableAdapter;
        private 系部数据TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator classBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton classBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView classDataGridView;
        private System.Windows.Forms.BindingSource departmrntBindingSource;
        private 系部数据TableAdapters.DepartmrntTableAdapter departmrntTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}