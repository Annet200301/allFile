namespace UnicomTicStudents
{
    partial class CourseForm
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
            this.NameCtextBox = new System.Windows.Forms.TextBox();
            this.courseDataGridView = new System.Windows.Forms.DataGridView();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnUpdateCourse = new System.Windows.Forms.Button();
            this.btnDeleteCourse = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameCtextBox
            // 
            this.NameCtextBox.Location = new System.Drawing.Point(112, 26);
            this.NameCtextBox.Name = "NameCtextBox";
            this.NameCtextBox.Size = new System.Drawing.Size(153, 20);
            this.NameCtextBox.TabIndex = 1;
            this.NameCtextBox.Text = " ";
            this.NameCtextBox.TextChanged += new System.EventHandler(this.NameCtextBox_TextChanged_1);
            // 
            // courseDataGridView
            // 
            this.courseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseDataGridView.Location = new System.Drawing.Point(12, 203);
            this.courseDataGridView.Name = "courseDataGridView";
            this.courseDataGridView.Size = new System.Drawing.Size(262, 309);
            this.courseDataGridView.TabIndex = 2;
            this.courseDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.courseDataGridView_CellContentClick);
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(3, 7);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(75, 57);
            this.btnAddCourse.TabIndex = 3;
            this.btnAddCourse.Text = "ADD";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // btnUpdateCourse
            // 
            this.btnUpdateCourse.Location = new System.Drawing.Point(84, 7);
            this.btnUpdateCourse.Name = "btnUpdateCourse";
            this.btnUpdateCourse.Size = new System.Drawing.Size(75, 57);
            this.btnUpdateCourse.TabIndex = 3;
            this.btnUpdateCourse.Text = "UPDATE";
            this.btnUpdateCourse.UseVisualStyleBackColor = true;
            this.btnUpdateCourse.Click += new System.EventHandler(this.btnUpdateCourse_Click);
            // 
            // btnDeleteCourse
            // 
            this.btnDeleteCourse.Location = new System.Drawing.Point(165, 7);
            this.btnDeleteCourse.Name = "btnDeleteCourse";
            this.btnDeleteCourse.Size = new System.Drawing.Size(75, 57);
            this.btnDeleteCourse.TabIndex = 3;
            this.btnDeleteCourse.Text = "DELETE ";
            this.btnDeleteCourse.UseVisualStyleBackColor = true;
            this.btnDeleteCourse.Click += new System.EventHandler(this.btnDeleteCourse_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUpdateCourse);
            this.panel1.Controls.Add(this.btnAddCourse);
            this.panel1.Controls.Add(this.btnDeleteCourse);
            this.panel1.Location = new System.Drawing.Point(15, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 73);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Course Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(358, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = " To add subject click here";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(280, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(408, 469);
            this.panel2.TabIndex = 7;
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 537);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.courseDataGridView);
            this.Controls.Add(this.NameCtextBox);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CourseForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.CourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox NameCtextBox;
        private System.Windows.Forms.DataGridView courseDataGridView;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnUpdateCourse;
        private System.Windows.Forms.Button btnDeleteCourse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}