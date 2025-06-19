namespace ADMIN.viewform
{
    partial class AdminDashboard
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
            this.exitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CourseManagement = new System.Windows.Forms.Button();
            this.adminFormPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.exitBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(903, 50);
            this.panel1.TabIndex = 0;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exitBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitBtn.Location = new System.Drawing.Point(865, 11);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(27, 20);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "✖";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Profile ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.CourseManagement);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 539);
            this.panel2.TabIndex = 1;
            // 
            // CourseManagement
            // 
            this.CourseManagement.Location = new System.Drawing.Point(0, 281);
            this.CourseManagement.Name = "CourseManagement";
            this.CourseManagement.Size = new System.Drawing.Size(178, 39);
            this.CourseManagement.TabIndex = 0;
            this.CourseManagement.Text = "ATENDENCE  MANAGEMENT";
            this.CourseManagement.UseVisualStyleBackColor = true;
            this.CourseManagement.Click += new System.EventHandler(this.CourseManagement_Click);
            // 
            // adminFormPanel
            // 
            this.adminFormPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adminFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminFormPanel.Location = new System.Drawing.Point(207, 50);
            this.adminFormPanel.Name = "adminFormPanel";
            this.adminFormPanel.Size = new System.Drawing.Size(696, 539);
            this.adminFormPanel.TabIndex = 2;
            this.adminFormPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.adminFormPanel_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "STUDENT MANAGEMENT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CourseManagement_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 39);
            this.button2.TabIndex = 0;
            this.button2.Text = "LECTURER MANAGEMENT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.CourseManagement_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 146);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(178, 39);
            this.button3.TabIndex = 0;
            this.button3.Text = "STAFF  MANAGEMENT";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.CourseManagement_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 236);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(178, 39);
            this.button4.TabIndex = 0;
            this.button4.Text = "TIMETABLE MANAGEMENT";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.CourseManagement_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(0, 372);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(178, 39);
            this.button5.TabIndex = 0;
            this.button5.Text = "EXAMS  MANAGEMENT";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.CourseManagement_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(0, 191);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(178, 39);
            this.button6.TabIndex = 0;
            this.button6.Text = "ADMIN  MANAGEMENT";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.CourseManagement_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(0, 417);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(178, 39);
            this.button7.TabIndex = 0;
            this.button7.Text = "MARKS   MANAGEMENT";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.CourseManagement_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(0, 11);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(178, 39);
            this.button8.TabIndex = 0;
            this.button8.Text = "ADD REGISTERS ACCOUNT";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.CourseManagement_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(0, 326);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(178, 39);
            this.button9.TabIndex = 0;
            this.button9.Text = "COURSE  MANAGEMENT";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.CourseManagement_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 589);
            this.Controls.Add(this.adminFormPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminDashboard";
            this.Text = "MainDashBoard";
            this.Load += new System.EventHandler(this.MainDashBoard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button CourseManagement;
        private System.Windows.Forms.Panel adminFormPanel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
    }
}