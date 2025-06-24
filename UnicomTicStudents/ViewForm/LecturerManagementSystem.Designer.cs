namespace UnicomTicStudents.ViewForm
{
    partial class LecturerManagementSystem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpdateCourse = new System.Windows.Forms.Button();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnDeleteCourse = new System.Windows.Forms.Button();
            this.LecturerDGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nicTXT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.indexTXT = new System.Windows.Forms.TextBox();
            this.lecturerCMB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LecturerDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUpdateCourse);
            this.panel1.Controls.Add(this.btnAddCourse);
            this.panel1.Controls.Add(this.btnDeleteCourse);
            this.panel1.Location = new System.Drawing.Point(214, 202);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 68);
            this.panel1.TabIndex = 6;
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
            // LecturerDGV
            // 
            this.LecturerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LecturerDGV.Location = new System.Drawing.Point(41, 285);
            this.LecturerDGV.Name = "LecturerDGV";
            this.LecturerDGV.Size = new System.Drawing.Size(592, 210);
            this.LecturerDGV.TabIndex = 7;
            this.LecturerDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LecturerDGV_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name";
            // 
            // nameTXT
            // 
            this.nameTXT.Location = new System.Drawing.Point(309, 49);
            this.nameTXT.Name = "nameTXT";
            this.nameTXT.Size = new System.Drawing.Size(121, 20);
            this.nameTXT.TabIndex = 9;
            this.nameTXT.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(239, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "NIC";
            // 
            // nicTXT
            // 
            this.nicTXT.Location = new System.Drawing.Point(309, 84);
            this.nicTXT.Name = "nicTXT";
            this.nicTXT.Size = new System.Drawing.Size(121, 20);
            this.nicTXT.TabIndex = 9;
            this.nicTXT.Text = " ";
            this.nicTXT.TextChanged += new System.EventHandler(this.nicTXT_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(239, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Index";
            // 
            // indexTXT
            // 
            this.indexTXT.Location = new System.Drawing.Point(309, 118);
            this.indexTXT.Name = "indexTXT";
            this.indexTXT.Size = new System.Drawing.Size(121, 20);
            this.indexTXT.TabIndex = 9;
            this.indexTXT.Text = " ";
            this.indexTXT.TextChanged += new System.EventHandler(this.nicTXT_TextChanged);
            // 
            // lecturerCMB
            // 
            this.lecturerCMB.FormattingEnabled = true;
            this.lecturerCMB.Location = new System.Drawing.Point(309, 166);
            this.lecturerCMB.Name = "lecturerCMB";
            this.lecturerCMB.Size = new System.Drawing.Size(121, 21);
            this.lecturerCMB.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(239, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Subject";
            // 
            // LecturerManagementSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 498);
            this.Controls.Add(this.lecturerCMB);
            this.Controls.Add(this.indexTXT);
            this.Controls.Add(this.nicTXT);
            this.Controls.Add(this.nameTXT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LecturerDGV);
            this.Controls.Add(this.panel1);
            this.Name = "LecturerManagementSystem";
            this.Text = "LecturerManagementSystem";
            this.Load += new System.EventHandler(this.LecturerManagementSystem_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LecturerDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUpdateCourse;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnDeleteCourse;
        private System.Windows.Forms.DataGridView LecturerDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nicTXT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox indexTXT;
        private System.Windows.Forms.ComboBox lecturerCMB;
        private System.Windows.Forms.Label label4;
    }
}