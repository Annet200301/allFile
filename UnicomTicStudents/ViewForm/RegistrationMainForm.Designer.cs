namespace ADMIN.viewform
{
    partial class RegistrationMainForm
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
            this.memberSelectionBtn2 = new System.Windows.Forms.Button();
            this.memberCMB2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.registerMainPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.exitBtn);
            this.panel1.Controls.Add(this.memberSelectionBtn2);
            this.panel1.Controls.Add(this.memberCMB2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 55);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exitBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitBtn.Location = new System.Drawing.Point(647, 2);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(27, 20);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "✖";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // memberSelectionBtn2
            // 
            this.memberSelectionBtn2.Location = new System.Drawing.Point(594, 26);
            this.memberSelectionBtn2.Margin = new System.Windows.Forms.Padding(2);
            this.memberSelectionBtn2.Name = "memberSelectionBtn2";
            this.memberSelectionBtn2.Size = new System.Drawing.Size(63, 20);
            this.memberSelectionBtn2.TabIndex = 9;
            this.memberSelectionBtn2.Text = "SELECT";
            this.memberSelectionBtn2.UseVisualStyleBackColor = true;
            this.memberSelectionBtn2.Click += new System.EventHandler(this.memberSelectionBtn2_Click);
            // 
            // memberCMB2
            // 
            this.memberCMB2.FormattingEnabled = true;
            this.memberCMB2.Location = new System.Drawing.Point(409, 28);
            this.memberCMB2.Margin = new System.Windows.Forms.Padding(2);
            this.memberCMB2.Name = "memberCMB2";
            this.memberCMB2.Size = new System.Drawing.Size(175, 21);
            this.memberCMB2.TabIndex = 8;
            this.memberCMB2.Text = " ";
            this.memberCMB2.SelectedIndexChanged += new System.EventHandler(this.RegistrationMainForm_Load_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Choose your position";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTER ";
            // 
            // registerMainPanel
            // 
            this.registerMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registerMainPanel.Location = new System.Drawing.Point(0, 55);
            this.registerMainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.registerMainPanel.Name = "registerMainPanel";
            this.registerMainPanel.Size = new System.Drawing.Size(682, 366);
            this.registerMainPanel.TabIndex = 1;
            this.registerMainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.registerMainPanel_Paint);
            // 
            // RegistrationMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 421);
            this.Controls.Add(this.registerMainPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RegistrationMainForm";
            this.Text = "RegistrationMainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox memberCMB2;
        private System.Windows.Forms.Button memberSelectionBtn2;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Panel registerMainPanel;
    }
}