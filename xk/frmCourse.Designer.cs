namespace xk
{
    partial class frmCourse
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
            System.Windows.Forms.Label counoLabel;
            System.Windows.Forms.Label counameLabel;
            System.Windows.Forms.Label creditLabel;
            System.Windows.Forms.Label limitnumLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCourse));
            this.courseBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.counoTextBox = new System.Windows.Forms.TextBox();
            this.counameTextBox = new System.Windows.Forms.TextBox();
            this.creditTextBox = new System.Windows.Forms.TextBox();
            this.limitnumTextBox = new System.Windows.Forms.TextBox();
            this.gdEdit = new System.Windows.Forms.GroupBox();
            this.tsControl = new System.Windows.Forms.ToolStrip();
            this.tsInsert = new System.Windows.Forms.ToolStripButton();
            this.tsDetele = new System.Windows.Forms.ToolStripButton();
            this.tsEdit = new System.Windows.Forms.ToolStripButton();
            this.tsSave = new System.Windows.Forms.ToolStripButton();
            this.tsCancel = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.系部数据 = new xk.系部数据();
            this.courseTableAdapter = new xk.系部数据TableAdapters.CourseTableAdapter();
            this.tableAdapterManager = new xk.系部数据TableAdapters.TableAdapterManager();
            counoLabel = new System.Windows.Forms.Label();
            counameLabel = new System.Windows.Forms.Label();
            creditLabel = new System.Windows.Forms.Label();
            limitnumLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingNavigator)).BeginInit();
            this.courseBindingNavigator.SuspendLayout();
            this.gdEdit.SuspendLayout();
            this.tsControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.系部数据)).BeginInit();
            this.SuspendLayout();
            // 
            // courseBindingNavigator
            // 
            this.courseBindingNavigator.AddNewItem = null;
            this.courseBindingNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.courseBindingNavigator.BindingSource = this.courseBindingSource;
            this.courseBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.courseBindingNavigator.DeleteItem = null;
            this.courseBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.courseBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.courseBindingNavigator.Location = new System.Drawing.Point(137, 9);
            this.courseBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.courseBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.courseBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.courseBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.courseBindingNavigator.Name = "courseBindingNavigator";
            this.courseBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.courseBindingNavigator.Size = new System.Drawing.Size(207, 25);
            this.courseBindingNavigator.TabIndex = 0;
            this.courseBindingNavigator.Text = "bindingNavigator1";
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
            // counoLabel
            // 
            counoLabel.AutoSize = true;
            counoLabel.Location = new System.Drawing.Point(47, 38);
            counoLabel.Name = "counoLabel";
            counoLabel.Size = new System.Drawing.Size(59, 12);
            counoLabel.TabIndex = 1;
            counoLabel.Text = "课程代码:";
            // 
            // counoTextBox
            // 
            this.counoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courseBindingSource, "Couno", true));
            this.counoTextBox.Location = new System.Drawing.Point(112, 35);
            this.counoTextBox.Name = "counoTextBox";
            this.counoTextBox.ReadOnly = true;
            this.counoTextBox.Size = new System.Drawing.Size(100, 21);
            this.counoTextBox.TabIndex = 2;
            // 
            // counameLabel
            // 
            counameLabel.AutoSize = true;
            counameLabel.Location = new System.Drawing.Point(47, 65);
            counameLabel.Name = "counameLabel";
            counameLabel.Size = new System.Drawing.Size(59, 12);
            counameLabel.TabIndex = 3;
            counameLabel.Text = "课程名称:";
            // 
            // counameTextBox
            // 
            this.counameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courseBindingSource, "Couname", true));
            this.counameTextBox.Location = new System.Drawing.Point(112, 62);
            this.counameTextBox.Name = "counameTextBox";
            this.counameTextBox.ReadOnly = true;
            this.counameTextBox.Size = new System.Drawing.Size(100, 21);
            this.counameTextBox.TabIndex = 4;
            // 
            // creditLabel
            // 
            creditLabel.AutoSize = true;
            creditLabel.Location = new System.Drawing.Point(47, 92);
            creditLabel.Name = "creditLabel";
            creditLabel.Size = new System.Drawing.Size(35, 12);
            creditLabel.TabIndex = 5;
            creditLabel.Text = "学分:";
            // 
            // creditTextBox
            // 
            this.creditTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courseBindingSource, "Credit", true));
            this.creditTextBox.Location = new System.Drawing.Point(112, 89);
            this.creditTextBox.Name = "creditTextBox";
            this.creditTextBox.ReadOnly = true;
            this.creditTextBox.Size = new System.Drawing.Size(100, 21);
            this.creditTextBox.TabIndex = 6;
            // 
            // limitnumLabel
            // 
            limitnumLabel.AutoSize = true;
            limitnumLabel.Location = new System.Drawing.Point(47, 119);
            limitnumLabel.Name = "limitnumLabel";
            limitnumLabel.Size = new System.Drawing.Size(59, 12);
            limitnumLabel.TabIndex = 7;
            limitnumLabel.Text = "限选人数:";
            // 
            // limitnumTextBox
            // 
            this.limitnumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courseBindingSource, "Limitnum", true));
            this.limitnumTextBox.Location = new System.Drawing.Point(112, 116);
            this.limitnumTextBox.Name = "limitnumTextBox";
            this.limitnumTextBox.ReadOnly = true;
            this.limitnumTextBox.Size = new System.Drawing.Size(100, 21);
            this.limitnumTextBox.TabIndex = 8;
            // 
            // gdEdit
            // 
            this.gdEdit.Controls.Add(counoLabel);
            this.gdEdit.Controls.Add(this.limitnumTextBox);
            this.gdEdit.Controls.Add(this.counoTextBox);
            this.gdEdit.Controls.Add(limitnumLabel);
            this.gdEdit.Controls.Add(counameLabel);
            this.gdEdit.Controls.Add(this.creditTextBox);
            this.gdEdit.Controls.Add(this.counameTextBox);
            this.gdEdit.Controls.Add(creditLabel);
            this.gdEdit.Location = new System.Drawing.Point(72, 47);
            this.gdEdit.Name = "gdEdit";
            this.gdEdit.Size = new System.Drawing.Size(331, 191);
            this.gdEdit.TabIndex = 9;
            this.gdEdit.TabStop = false;
            // 
            // tsControl
            // 
            this.tsControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsInsert,
            this.tsDetele,
            this.tsEdit,
            this.tsSave,
            this.tsCancel});
            this.tsControl.Location = new System.Drawing.Point(0, 448);
            this.tsControl.Name = "tsControl";
            this.tsControl.Size = new System.Drawing.Size(492, 25);
            this.tsControl.TabIndex = 10;
            this.tsControl.Text = "toolStrip1";
            // 
            // tsInsert
            // 
            this.tsInsert.Image = global::xk.Properties.Resources._1_3;
            this.tsInsert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsInsert.Name = "tsInsert";
            this.tsInsert.Size = new System.Drawing.Size(49, 22);
            this.tsInsert.Text = "新增";
            this.tsInsert.Click += new System.EventHandler(this.tsInsert_Click);
            // 
            // tsDetele
            // 
            this.tsDetele.Image = global::xk.Properties.Resources._1_4;
            this.tsDetele.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDetele.Name = "tsDetele";
            this.tsDetele.Size = new System.Drawing.Size(49, 22);
            this.tsDetele.Text = "删除";
            this.tsDetele.Click += new System.EventHandler(this.tsDetele_Click);
            // 
            // tsEdit
            // 
            this.tsEdit.Image = global::xk.Properties.Resources._6_1;
            this.tsEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEdit.Name = "tsEdit";
            this.tsEdit.Size = new System.Drawing.Size(49, 22);
            this.tsEdit.Text = "修改";
            this.tsEdit.Click += new System.EventHandler(this.tsEdit_Click);
            // 
            // tsSave
            // 
            this.tsSave.Enabled = false;
            this.tsSave.Image = global::xk.Properties.Resources._6_9;
            this.tsSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSave.Name = "tsSave";
            this.tsSave.Size = new System.Drawing.Size(49, 22);
            this.tsSave.Text = "保存";
            this.tsSave.Click += new System.EventHandler(this.tsSave_Click);
            // 
            // tsCancel
            // 
            this.tsCancel.Enabled = false;
            this.tsCancel.Image = global::xk.Properties.Resources._8_6;
            this.tsCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsCancel.Name = "tsCancel";
            this.tsCancel.Size = new System.Drawing.Size(49, 22);
            this.tsCancel.Text = "放弃";
            this.tsCancel.Click += new System.EventHandler(this.tsCancel_Click);
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
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.系部数据;
            // 
            // 系部数据
            // 
            this.系部数据.DataSetName = "系部数据";
            this.系部数据.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassTableAdapter = null;
            this.tableAdapterManager.CourseTableAdapter = this.courseTableAdapter;
            this.tableAdapterManager.DepartmrntTableAdapter = null;
            this.tableAdapterManager.StudentTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = xk.系部数据TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 473);
            this.Controls.Add(this.tsControl);
            this.Controls.Add(this.gdEdit);
            this.Controls.Add(this.courseBindingNavigator);
            this.Name = "frmCourse";
            this.Text = "课程信息";
            this.Load += new System.EventHandler(this.frmCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingNavigator)).EndInit();
            this.courseBindingNavigator.ResumeLayout(false);
            this.courseBindingNavigator.PerformLayout();
            this.gdEdit.ResumeLayout(false);
            this.gdEdit.PerformLayout();
            this.tsControl.ResumeLayout(false);
            this.tsControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.系部数据)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private 系部数据 系部数据;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private 系部数据TableAdapters.CourseTableAdapter courseTableAdapter;
        private 系部数据TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator courseBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox counoTextBox;
        private System.Windows.Forms.TextBox counameTextBox;
        private System.Windows.Forms.TextBox creditTextBox;
        private System.Windows.Forms.TextBox limitnumTextBox;
        private System.Windows.Forms.GroupBox gdEdit;
        private System.Windows.Forms.ToolStrip tsControl;
        private System.Windows.Forms.ToolStripButton tsInsert;
        private System.Windows.Forms.ToolStripButton tsDetele;
        private System.Windows.Forms.ToolStripButton tsEdit;
        private System.Windows.Forms.ToolStripButton tsSave;
        private System.Windows.Forms.ToolStripButton tsCancel;
    }
}