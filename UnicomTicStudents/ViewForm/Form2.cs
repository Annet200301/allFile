using ADMIN.viewform;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADMIN
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Constructorform constructorform = new Constructorform();  
            LoadFormIntoPanel(constructorform); 
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to exit?","Exit Application",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                Application.Exit(); 
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            LoadFormIntoPanel(loginForm);     
        }      
        private void newAccBtn_Click(object sender, EventArgs e)
        {
            RegistrationMainForm registrationMainForm = new RegistrationMainForm();
            LoadFormIntoPanel(registrationMainForm);
            
            
        }

        private void aboutUmsBtn_Click(object sender, EventArgs e)
        {

            AboutUmsForm aboutUmsForm = new AboutUmsForm();
            LoadFormIntoPanel(aboutUmsForm);    
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LoadFormIntoPanel(Form form)
        {
            if (formPanel.Controls.Count > 0)
            {
                Control existingControl = formPanel.Controls[0];
                formPanel.Controls.Remove(existingControl);
                existingControl.Dispose();
            }
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            formPanel.Controls.Add(form);
            form.Show();
        }

        private void formPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
