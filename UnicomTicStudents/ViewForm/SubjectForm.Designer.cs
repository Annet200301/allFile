namespace UnicomTicStudents.ViewForm
{
    partial class SubjectForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.subjectDGV = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.subjectNameTXT = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpdateCourse = new System.Windows.Forms.Button();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnDeleteCourse = new System.Windows.Forms.Button();
            this.courseNameLoad = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.subjectDGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "CourseName";
            // 
            // subjectDGV
            // 
            this.subjectDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjectDGV.Location = new System.Drawing.Point(12, 222);
            this.subjectDGV.Name = "subjectDGV";
            this.subjectDGV.Size = new System.Drawing.Size(377, 189);
            this.subjectDGV.TabIndex = 2;
            this.subjectDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.subjectDGV_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "SubjectName";
            // 
            // subjectNameTXT
            // 
            this.subjectNameTXT.Location = new System.Drawing.Point(165, 92);
            this.subjectNameTXT.Name = "subjectNameTXT";
            this.subjectNameTXT.Size = new System.Drawing.Size(137, 20);
            this.subjectNameTXT.TabIndex = 1;
            this.subjectNameTXT.Text = " ";
            this.subjectNameTXT.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUpdateCourse);
            this.panel1.Controls.Add(this.btnAddCourse);
            this.panel1.Controls.Add(this.btnDeleteCourse);
            this.panel1.Location = new System.Drawing.Point(55, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 73);
            this.panel1.TabIndex = 5;
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
            // btnDeleteCourse
            // 
            this.btnDeleteCourse.Location = new System.Drawing.Point(163, 7);
            this.btnDeleteCourse.Name = "btnDeleteCourse";
            this.btnDeleteCourse.Size = new System.Drawing.Size(75, 57);
            this.btnDeleteCourse.TabIndex = 3;
            this.btnDeleteCourse.Text = "DELETE ";
            this.btnDeleteCourse.UseVisualStyleBackColor = true;
            this.btnDeleteCourse.Click += new System.EventHandler(this.btnDeleteCourse_Click);
            // 
            // courseNameLoad
            // 
            this.courseNameLoad.FormattingEnabled = true;
            this.courseNameLoad.Location = new System.Drawing.Point(167, 34);
            this.courseNameLoad.Name = "courseNameLoad";
            this.courseNameLoad.Size = new System.Drawing.Size(135, 21);
            this.courseNameLoad.TabIndex = 6;
            this.courseNameLoad.SelectedIndexChanged += new System.EventHandler(this.courseNameLoad_SelectedIndexChanged);
            // 
            // comboBox1
            // 
  
            // 
            // selectBtn
        
            // 
            // SubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 446);
            this.Controls.Add(this.courseNameLoad);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.subjectDGV);
            this.Controls.Add(this.subjectNameTXT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SubjectForm";
            this.Text = "SubjectForm";
            this.Load += new System.EventHandler(this.SubjectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.subjectDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView subjectDGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox subjectNameTXT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUpdateCourse;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnDeleteCourse;
        private System.Windows.Forms.ComboBox courseNameLoad;
    }
}