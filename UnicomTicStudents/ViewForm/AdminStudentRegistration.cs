using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using UnicomTicStudents.Controllers;

namespace UnicomTicStudents.ViewForm
{
    public partial class AdminStudentRegistration : Form
    {
        private readonly UserController _controller;   
        public AdminStudentRegistration(UserController controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        private void AdminStudentRegistration_Load(object sender, EventArgs e)
        {

        }

        private void registerBtn_Click(object sender, EventArgs e)
        {

        }

        private void registerBtn_Click_1(object sender, EventArgs e)
        {
            string nic = nicnumberTXT.Text.Trim();
            string name = fullnameTXT.Text.Trim();
            string username = usernametxt.Text.Trim();
            string password = passwordtxt.Text.Trim();

            string result = _controller.SetUserCredentials(nic, name, username, password);
            MessageBox.Show(result);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            string nic = nicnumberTXT.Text.Trim();
            string name = fullnameTXT.Text.Trim();

            var user = _controller.GetByNICAndName(nic, name);
            if (user != null)
            {
                indexnumberTXT.Text = user.IndexNumber;
                label5.Text = "You are eligible to register.";
            }
            else
            {
                label5.Text = "You are not pre-registered.";
            }
        }
    }
}
