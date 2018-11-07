namespace xk
{
    partial class frmDrapartment
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
            _Instance = null;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDrapartment));
            this.departmrntBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.departmrntDataGridView = new System.Windows.Forms.DataGridView();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.departmrntBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmrntBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.系部数据 = new xk.系部数据();
            this.departmrntTableAdapter = new xk.系部数据TableAdapters.DepartmrntTableAdapter();
            this.tableAdapterManager = new xk.系部数据TableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.departmrntBindingNavigator)).BeginInit();
            this.departmrntBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmrntDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmrntBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.系部数据)).BeginInit();
            this.SuspendLayout();
            // 
            // departmrntBindingNavigator
            // 
            this.departmrntBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.departmrntBindingNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.departmrntBindingNavigator.BindingSource = this.departmrntBindingSource;
            this.departmrntBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.departmrntBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.departmrntBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.departmrntBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.departmrntBindingNavigatorSaveItem});
            this.departmrntBindingNavigator.Location = new System.Drawing.Point(97, 9);
            this.departmrntBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.departmrntBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.departmrntBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.departmrntBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.departmrntBindingNavigator.Name = "departmrntBindingNavigator";
            this.departmrntBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.departmrntBindingNavigator.Size = new System.Drawing.Size(276, 25);
            this.departmrntBindingNavigator.TabIndex = 0;
            this.departmrntBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // departmrntDataGridView
            // 
            this.departmrntDataGridView.AutoGenerateColumns = false;
            this.departmrntDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.departmrntDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.departmrntDataGridView.DataSource = this.departmrntBindingSource;
            this.departmrntDataGridView.Location = new System.Drawing.Point(97, 56);
            this.departmrntDataGridView.Name = "departmrntDataGridView";
            this.departmrntDataGridView.RowTemplate.Height = 23;
            this.departmrntDataGridView.Size = new System.Drawing.Size(300, 373);
            this.departmrntDataGridView.TabIndex = 1;
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
            // departmrntBindingNavigatorSaveItem
            // 
            this.departmrntBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.departmrntBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("departmrntBindingNavigatorSaveItem.Image")));
            this.departmrntBindingNavigatorSaveItem.Name = "departmrntBindingNavigatorSaveItem";
            this.departmrntBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.departmrntBindingNavigatorSaveItem.Text = "保存数据";
            this.departmrntBindingNavigatorSaveItem.Click += new System.EventHandler(this.departmrntBindingNavigatorSaveItem_Click_1);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Departno";
            this.dataGridViewTextBoxColumn1.HeaderText = "Departno";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Departname";
            this.dataGridViewTextBoxColumn2.HeaderText = "Departname";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // departmrntBindingSource
            // 
            this.departmrntBindingSource.DataMember = "Departmrnt";
            this.departmrntBindingSource.DataSource = this.系部数据;
            // 
            // 系部数据
            // 
            this.系部数据.DataSetName = "系部数据";
            this.系部数据.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmrntTableAdapter
            // 
            this.departmrntTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassTableAdapter = null;
            this.tableAdapterManager.DepartmrntTableAdapter = this.departmrntTableAdapter;
            this.tableAdapterManager.UpdateOrder = xk.系部数据TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmDrapartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 473);
            this.Controls.Add(this.departmrntDataGridView);
            this.Controls.Add(this.departmrntBindingNavigator);
            this.Name = "frmDrapartment";
            this.Text = "frmDrapartment";
            this.Load += new System.EventHandler(this.frmDrapartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.departmrntBindingNavigator)).EndInit();
            this.departmrntBindingNavigator.ResumeLayout(false);
            this.departmrntBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmrntDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmrntBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.系部数据)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private 系部数据 系部数据;
        private System.Windows.Forms.BindingSource departmrntBindingSource;
        private 系部数据TableAdapters.DepartmrntTableAdapter departmrntTableAdapter;
        private 系部数据TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator departmrntBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton departmrntBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView departmrntDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;

    }
}