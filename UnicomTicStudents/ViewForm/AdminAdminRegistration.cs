using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTicStudents.Models;
using UnicomTicStudents.Repositories;
using UnicomTicStudents.Repositories.Irepository;

namespace UnicomTicStudents.ViewForm
{
    public partial class AdminAdminRegistration : Form
    {
        private readonly IAdminRepository _adminRepository;
        public AdminAdminRegistration()
        {
            InitializeComponent();
            _adminRepository = new AdminRepository();
        }

        private void AdminAdminRegistration_Load(object sender, EventArgs e)
        {

        }

        private void fullnameTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            string fullName = fullnameTXT.Text;
            string nic = nicnumberTXT.Text;
            string indexNumber = usernameTXT.Text;
            string username = textBox1.Text;
            string password = textBox2.Text;
            if (_adminRepository.IsUserExist(nic, fullName))
            {
                AdminEntity newAdmin = new AdminEntity
                {
                    Name = fullName,
                    NIC = nic,
                    Username = username,
                    Password = password
                };

                _adminRepository.RegisterAdmin(newAdmin);
                MessageBox.Show("Registration successful!");
            }
            else
            {
                MessageBox.Show("You can't create an account because your details are not saved by the admin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void AdminAdminRegistration_Load(object sender, EventArgs e)
        {

        }
    }
}
