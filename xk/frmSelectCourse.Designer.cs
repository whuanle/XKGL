namespace xk
{
    partial class frmSelectCourse
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCourse = new System.Windows.Forms.DataGridView();
            this.Couno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Couname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LimitNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Join = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvSelectCourse = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.Selectcouno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Selectcouname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Willoder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cancel = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "课程列表";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "已选课列表";
            // 
            // dgvCourse
            // 
            this.dgvCourse.AllowUserToAddRows = false;
            this.dgvCourse.AllowUserToDeleteRows = false;
            this.dgvCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Couno,
            this.Couname,
            this.Credit,
            this.LimitNum,
            this.Join});
            this.dgvCourse.Location = new System.Drawing.Point(-2, 19);
            this.dgvCourse.MultiSelect = false;
            this.dgvCourse.Name = "dgvCourse";
            this.dgvCourse.ReadOnly = true;
            this.dgvCourse.RowTemplate.Height = 23;
            this.dgvCourse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCourse.Size = new System.Drawing.Size(694, 265);
            this.dgvCourse.TabIndex = 2;
            this.dgvCourse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCourse_CellContentClick);
            this.dgvCourse.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgvCourse_MouseMove);
            // 
            // Couno
            // 
            this.Couno.DataPropertyName = "Couno";
            this.Couno.HeaderText = "课程代码";
            this.Couno.Name = "Couno";
            this.Couno.ReadOnly = true;
            // 
            // Couname
            // 
            this.Couname.DataPropertyName = "Couname";
            this.Couname.HeaderText = "课程名称";
            this.Couname.Name = "Couname";
            this.Couname.ReadOnly = true;
            // 
            // Credit
            // 
            this.Credit.DataPropertyName = "Credit";
            this.Credit.HeaderText = "学分";
            this.Credit.Name = "Credit";
            this.Credit.ReadOnly = true;
            // 
            // LimitNum
            // 
            this.LimitNum.DataPropertyName = "LimitNum";
            this.LimitNum.HeaderText = "限选人数";
            this.LimitNum.Name = "LimitNum";
            this.LimitNum.ReadOnly = true;
            // 
            // Join
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Join.DefaultCellStyle = dataGridViewCellStyle5;
            this.Join.HeaderText = "报名";
            this.Join.Name = "Join";
            this.Join.ReadOnly = true;
            this.Join.Text = "报名";
            this.Join.UseColumnTextForButtonValue = true;
            // 
            // dgvSelectCourse
            // 
            this.dgvSelectCourse.AllowDrop = true;
            this.dgvSelectCourse.AllowUserToAddRows = false;
            this.dgvSelectCourse.AllowUserToDeleteRows = false;
            this.dgvSelectCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectCourse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selectcouno,
            this.Selectcouname,
            this.Willoder,
            this.Cancel});
            this.dgvSelectCourse.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSelectCourse.Location = new System.Drawing.Point(0, 355);
            this.dgvSelectCourse.MultiSelect = false;
            this.dgvSelectCourse.Name = "dgvSelectCourse";
            this.dgvSelectCourse.ReadOnly = true;
            this.dgvSelectCourse.RowTemplate.Height = 23;
            this.dgvSelectCourse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSelectCourse.Size = new System.Drawing.Size(692, 218);
            this.dgvSelectCourse.TabIndex = 3;
            this.dgvSelectCourse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSelectCourse_CellContentClick);
            this.dgvSelectCourse.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvSelectCourse_RowPostPaint);
            this.dgvSelectCourse.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvSelectCourse_DragDrop);
            this.dgvSelectCourse.DragOver += new System.Windows.Forms.DragEventHandler(this.dgvSelectCourse_DragOver);
            this.dgvSelectCourse.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvSelectCourse_MouseDown);
            this.dgvSelectCourse.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgvSelectCourse_MouseUp);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(617, 290);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "提交";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Selectcouno
            // 
            this.Selectcouno.DataPropertyName = "Couno";
            this.Selectcouno.HeaderText = "课程代码";
            this.Selectcouno.Name = "Selectcouno";
            this.Selectcouno.ReadOnly = true;
            // 
            // Selectcouname
            // 
            this.Selectcouname.DataPropertyName = "Couname";
            this.Selectcouname.HeaderText = "课程名称";
            this.Selectcouname.Name = "Selectcouname";
            this.Selectcouname.ReadOnly = true;
            // 
            // Willoder
            // 
            this.Willoder.DataPropertyName = "willorder";
            this.Willoder.HeaderText = "原志愿号";
            this.Willoder.Name = "Willoder";
            this.Willoder.ReadOnly = true;
            // 
            // Cancel
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Cancel.DefaultCellStyle = dataGridViewCellStyle6;
            this.Cancel.HeaderText = "取消";
            this.Cancel.Name = "Cancel";
            this.Cancel.ReadOnly = true;
            this.Cancel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Cancel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Cancel.Text = "取消";
            // 
            // frmSelectCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 573);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvSelectCourse);
            this.Controls.Add(this.dgvCourse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSelectCourse";
            this.Text = "femSelectCourse";
            this.Load += new System.EventHandler(this.femSelectCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCourse;
        private System.Windows.Forms.DataGridView dgvSelectCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Couno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Couname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn LimitNum;
        private System.Windows.Forms.DataGridViewButtonColumn Join;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Selectcouno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Selectcouname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Willoder;
        private System.Windows.Forms.DataGridViewButtonColumn Cancel;
    }
}