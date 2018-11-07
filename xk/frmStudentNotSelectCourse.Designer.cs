namespace xk
{
    partial class frmStudentNotSelectCourse
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
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Classname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stuno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stuname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbClass
            // 
            this.cbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(12, 12);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(121, 20);
            this.cbClass.TabIndex = 0;
            this.cbClass.SelectedIndexChanged += new System.EventHandler(this.cbClass_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Classname,
            this.Stuno,
            this.Stuname,
            this.Sex,
            this.Birthday});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(592, 321);
            this.dataGridView1.TabIndex = 1;
            // 
            // Classname
            // 
            this.Classname.DataPropertyName = "Classname";
            this.Classname.HeaderText = "班级";
            this.Classname.Name = "Classname";
            this.Classname.ReadOnly = true;
            // 
            // Stuno
            // 
            this.Stuno.DataPropertyName = "Stuno";
            this.Stuno.HeaderText = "学号";
            this.Stuno.Name = "Stuno";
            this.Stuno.ReadOnly = true;
            // 
            // Stuname
            // 
            this.Stuname.DataPropertyName = "Stuname";
            this.Stuname.HeaderText = "姓名";
            this.Stuname.Name = "Stuname";
            this.Stuname.ReadOnly = true;
            // 
            // Sex
            // 
            this.Sex.DataPropertyName = "Sex";
            this.Sex.HeaderText = "性别";
            this.Sex.Name = "Sex";
            this.Sex.ReadOnly = true;
            // 
            // Birthday
            // 
            this.Birthday.DataPropertyName = "Birthday";
            this.Birthday.HeaderText = "生日";
            this.Birthday.Name = "Birthday";
            this.Birthday.ReadOnly = true;
            // 
            // frmStudentNotSelectCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 373);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbClass);
            this.Name = "frmStudentNotSelectCourse";
            this.Text = "未选课学生名单";
            this.Load += new System.EventHandler(this.frmStudentNotSelectCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stuno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stuname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
    }
}