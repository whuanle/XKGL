namespace xk
{
    partial class frmStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudent));
            System.Windows.Forms.Label stunoLabel;
            System.Windows.Forms.Label classnoLabel;
            System.Windows.Forms.Label stunameLabel;
            System.Windows.Forms.Label sexLabel;
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label pwdLabel;
            this.系部数据 = new xk.系部数据();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new xk.系部数据TableAdapters.StudentTableAdapter();
            this.tableAdapterManager = new xk.系部数据TableAdapters.TableAdapterManager();
            this.studentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.studentBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.stunoTextBox = new System.Windows.Forms.TextBox();
            this.birthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pwdTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.studentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.系部数据BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classTableAdapter = new xk.系部数据TableAdapters.ClassTableAdapter();
            this.系部数据1 = new xk.系部数据();
            this.stunameTextBox = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.系部数据1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            stunoLabel = new System.Windows.Forms.Label();
            classnoLabel = new System.Windows.Forms.Label();
            stunameLabel = new System.Windows.Forms.Label();
            sexLabel = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            pwdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.系部数据)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingNavigator)).BeginInit();
            this.studentBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.系部数据BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.系部数据1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.系部数据1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // 系部数据
            // 
            this.系部数据.DataSetName = "系部数据";
            this.系部数据.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.系部数据;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassTableAdapter = this.classTableAdapter;
            this.tableAdapterManager.DepartmrntTableAdapter = null;
            this.tableAdapterManager.StudentTableAdapter = this.studentTableAdapter;
            this.tableAdapterManager.UpdateOrder = xk.系部数据TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // studentBindingNavigator
            // 
            this.studentBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.studentBindingNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.studentBindingNavigator.BindingSource = this.studentBindingSource;
            this.studentBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.studentBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.studentBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.studentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.studentBindingNavigatorSaveItem});
            this.studentBindingNavigator.Location = new System.Drawing.Point(75, 9);
            this.studentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.studentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.studentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.studentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.studentBindingNavigator.Name = "studentBindingNavigator";
            this.studentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.studentBindingNavigator.Size = new System.Drawing.Size(276, 25);
            this.studentBindingNavigator.TabIndex = 0;
            this.studentBindingNavigator.Text = "bindingNavigator1";
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
            // studentBindingNavigatorSaveItem
            // 
            this.studentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.studentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("studentBindingNavigatorSaveItem.Image")));
            this.studentBindingNavigatorSaveItem.Name = "studentBindingNavigatorSaveItem";
            this.studentBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.studentBindingNavigatorSaveItem.Text = "保存数据";
            this.studentBindingNavigatorSaveItem.Click += new System.EventHandler(this.studentBindingNavigatorSaveItem_Click_1);
            // 
            // stunoLabel
            // 
            stunoLabel.AutoSize = true;
            stunoLabel.Location = new System.Drawing.Point(85, 48);
            stunoLabel.Name = "stunoLabel";
            stunoLabel.Size = new System.Drawing.Size(35, 12);
            stunoLabel.TabIndex = 1;
            stunoLabel.Text = "学号:";
            // 
            // stunoTextBox
            // 
            this.stunoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Stuno", true));
            this.stunoTextBox.Location = new System.Drawing.Point(150, 45);
            this.stunoTextBox.Name = "stunoTextBox";
            this.stunoTextBox.Size = new System.Drawing.Size(200, 21);
            this.stunoTextBox.TabIndex = 2;
            // 
            // classnoLabel
            // 
            classnoLabel.AutoSize = true;
            classnoLabel.Location = new System.Drawing.Point(85, 75);
            classnoLabel.Name = "classnoLabel";
            classnoLabel.Size = new System.Drawing.Size(35, 12);
            classnoLabel.TabIndex = 3;
            classnoLabel.Text = "班级:";
            // 
            // stunameLabel
            // 
            stunameLabel.AutoSize = true;
            stunameLabel.Location = new System.Drawing.Point(85, 102);
            stunameLabel.Name = "stunameLabel";
            stunameLabel.Size = new System.Drawing.Size(35, 12);
            stunameLabel.TabIndex = 5;
            stunameLabel.Text = "姓名:";
            // 
            // sexLabel
            // 
            sexLabel.AutoSize = true;
            sexLabel.Location = new System.Drawing.Point(85, 129);
            sexLabel.Name = "sexLabel";
            sexLabel.Size = new System.Drawing.Size(35, 12);
            sexLabel.TabIndex = 7;
            sexLabel.Text = "性别:";
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(85, 157);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(59, 12);
            birthdayLabel.TabIndex = 9;
            birthdayLabel.Text = "出生日期:";
            // 
            // birthdayDateTimePicker
            // 
            this.birthdayDateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.birthdayDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.studentBindingSource, "Birthday", true));
            this.birthdayDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthdayDateTimePicker.Location = new System.Drawing.Point(150, 153);
            this.birthdayDateTimePicker.Name = "birthdayDateTimePicker";
            this.birthdayDateTimePicker.Size = new System.Drawing.Size(200, 21);
            this.birthdayDateTimePicker.TabIndex = 10;
            // 
            // pwdLabel
            // 
            pwdLabel.AutoSize = true;
            pwdLabel.Location = new System.Drawing.Point(85, 183);
            pwdLabel.Name = "pwdLabel";
            pwdLabel.Size = new System.Drawing.Size(35, 12);
            pwdLabel.TabIndex = 11;
            pwdLabel.Text = "密码:";
            // 
            // pwdTextBox
            // 
            this.pwdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Pwd", true));
            this.pwdTextBox.Location = new System.Drawing.Point(150, 180);
            this.pwdTextBox.Name = "pwdTextBox";
            this.pwdTextBox.Size = new System.Drawing.Size(200, 21);
            this.pwdTextBox.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.studentBindingSource, "Classno", true));
            this.comboBox1.DataSource = this.classBindingSource;
            this.comboBox1.DisplayMember = "Classname";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(150, 75);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(201, 20);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.ValueMember = "Classno";
            // 
            // studentBindingSource1
            // 
            this.studentBindingSource1.DataMember = "Student";
            this.studentBindingSource1.DataSource = this.系部数据;
            // 
            // 系部数据BindingSource
            // 
            this.系部数据BindingSource.DataSource = this.系部数据;
            this.系部数据BindingSource.Position = 0;
            // 
            // studentBindingSource2
            // 
            this.studentBindingSource2.DataMember = "Student";
            this.studentBindingSource2.DataSource = this.系部数据BindingSource;
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataMember = "Class";
            this.classBindingSource.DataSource = this.系部数据BindingSource;
            // 
            // classTableAdapter
            // 
            this.classTableAdapter.ClearBeforeFill = true;
            // 
            // 系部数据1
            // 
            this.系部数据1.DataSetName = "系部数据";
            this.系部数据1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stunameTextBox
            // 
            this.stunameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Stuname", true));
            this.stunameTextBox.Location = new System.Drawing.Point(150, 99);
            this.stunameTextBox.Name = "stunameTextBox";
            this.stunameTextBox.Size = new System.Drawing.Size(200, 21);
            this.stunameTextBox.TabIndex = 6;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.studentBindingSource3, "Sex", true));
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "男",
            "女"});
            this.comboBox2.Location = new System.Drawing.Point(150, 127);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 20);
            this.comboBox2.TabIndex = 14;
            this.comboBox2.ValueMember = "Sex";
            // 
            // 系部数据1BindingSource
            // 
            this.系部数据1BindingSource.DataSource = this.系部数据1;
            this.系部数据1BindingSource.Position = 0;
            // 
            // studentBindingSource3
            // 
            this.studentBindingSource3.DataMember = "Student";
            this.studentBindingSource3.DataSource = this.系部数据1BindingSource;
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 507);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(stunoLabel);
            this.Controls.Add(this.stunoTextBox);
            this.Controls.Add(classnoLabel);
            this.Controls.Add(stunameLabel);
            this.Controls.Add(this.stunameTextBox);
            this.Controls.Add(sexLabel);
            this.Controls.Add(birthdayLabel);
            this.Controls.Add(this.birthdayDateTimePicker);
            this.Controls.Add(pwdLabel);
            this.Controls.Add(this.pwdTextBox);
            this.Controls.Add(this.studentBindingNavigator);
            this.Name = "frmStudent";
            this.Text = "学生信息";
            this.Load += new System.EventHandler(this.frmStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.系部数据)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingNavigator)).EndInit();
            this.studentBindingNavigator.ResumeLayout(false);
            this.studentBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.系部数据BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.系部数据1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.系部数据1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private 系部数据 系部数据;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private 系部数据TableAdapters.StudentTableAdapter studentTableAdapter;
        private 系部数据TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator studentBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton studentBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox stunoTextBox;
        private System.Windows.Forms.DateTimePicker birthdayDateTimePicker;
        private System.Windows.Forms.TextBox pwdTextBox;
        private 系部数据TableAdapters.ClassTableAdapter classTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource studentBindingSource2;
        private System.Windows.Forms.BindingSource 系部数据BindingSource;
        private System.Windows.Forms.BindingSource studentBindingSource1;
        private System.Windows.Forms.BindingSource classBindingSource;
        private 系部数据 系部数据1;
        private System.Windows.Forms.TextBox stunameTextBox;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource 系部数据1BindingSource;
        private System.Windows.Forms.BindingSource studentBindingSource3;

    }
}