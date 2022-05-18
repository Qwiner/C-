
namespace HomeWork
{
    partial class Form7
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.学号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.学生姓名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.学生性别 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.学生年龄 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.班级编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.生源所在地 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.已修学分总数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.学号,
            this.学生姓名,
            this.学生性别,
            this.学生年龄,
            this.班级编号,
            this.生源所在地,
            this.已修学分总数});
            this.dataGridView1.Location = new System.Drawing.Point(-2, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1066, 497);
            this.dataGridView1.TabIndex = 0;
            // 
            // 学号
            // 
            this.学号.DataPropertyName = "学号";
            this.学号.HeaderText = "学号";
            this.学号.MinimumWidth = 6;
            this.学号.Name = "学号";
            this.学号.Width = 125;
            // 
            // 学生姓名
            // 
            this.学生姓名.DataPropertyName = "学生姓名";
            this.学生姓名.HeaderText = "学生姓名";
            this.学生姓名.MinimumWidth = 6;
            this.学生姓名.Name = "学生姓名";
            this.学生姓名.Width = 125;
            // 
            // 学生性别
            // 
            this.学生性别.DataPropertyName = "学生性别";
            this.学生性别.HeaderText = "学生性别";
            this.学生性别.MinimumWidth = 6;
            this.学生性别.Name = "学生性别";
            this.学生性别.Width = 125;
            // 
            // 学生年龄
            // 
            this.学生年龄.DataPropertyName = "学生年龄";
            this.学生年龄.HeaderText = "学生年龄";
            this.学生年龄.MinimumWidth = 6;
            this.学生年龄.Name = "学生年龄";
            this.学生年龄.Width = 125;
            // 
            // 班级编号
            // 
            this.班级编号.DataPropertyName = "班级编号";
            this.班级编号.HeaderText = "班级编号";
            this.班级编号.MinimumWidth = 6;
            this.班级编号.Name = "班级编号";
            this.班级编号.Width = 125;
            // 
            // 生源所在地
            // 
            this.生源所在地.DataPropertyName = "生源所在地";
            this.生源所在地.HeaderText = "生源所在地";
            this.生源所在地.MinimumWidth = 6;
            this.生源所在地.Name = "生源所在地";
            this.生源所在地.Width = 125;
            // 
            // 已修学分总数
            // 
            this.已修学分总数.DataPropertyName = "已修学分总数";
            this.已修学分总数.HeaderText = "已修学分总数";
            this.已修学分总数.MinimumWidth = 6;
            this.已修学分总数.Name = "已修学分总数";
            this.已修学分总数.Width = 125;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(169, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 25);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, -6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "查找学号";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 531);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form7";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学生姓名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学生性别;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学生年龄;
        private System.Windows.Forms.DataGridViewTextBoxColumn 班级编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 生源所在地;
        private System.Windows.Forms.DataGridViewTextBoxColumn 已修学分总数;
    }
}