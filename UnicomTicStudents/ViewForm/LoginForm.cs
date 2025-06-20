using ADMIN.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTicStudents;
using UnicomTicStudents.Controllers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ADMIN.viewform
{
    public partial class LoginForm : Form
    {
        private readonly UserController _controller;
        public LoginForm()
        {
            InitializeComponent(UserController controller);
            _controller = controller;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
           

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to exit?", "Exit Application",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void memberCMB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void memberSelectionBtn_Click(object sender, EventArgs e)
        {

        }    
        private void loginMainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LoadFormIntoPanel(Form form)
        {
            if (loginMainPanel.Controls.Count > 0)
            {
                Control existingControl = loginMainPanel.Controls[0];
                loginMainPanel.Controls.Remove(existingControl);
                existingControl.Dispose();
            }
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            loginMainPanel.Controls.Add(form);
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = usernametxt.Text.Trim();
            string password = passwordtxt.Text.Trim();

            var user = _controller.Login(username, password);

            if (user != null)
            {
                MessageBox.Show($"Welcome {user.Name}! Role: {user.Role}");
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
            Form2 form = new Form2();
            AdminDashboard dashboard = new AdminDashboard(form); 
            form .Hide();
            dashboard.Show();





        }
    }
}