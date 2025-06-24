using ADMIN.Enums;
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
using UnicomTicStudents.Course;
using UnicomTicStudents.Models.DTOs;
using static ADMIN.Enums.UserRoles;

namespace UnicomTicStudents
{
    public partial class UserForm : Form
    {
        private readonly UserController _controller;
        public UserForm(UserController controller)
        {
            InitializeComponent();
            _controller = controller;
            LoadRoles();
            LoadFilterRoles();
            LoadUserData();
            passwordTXT.UseSystemPasswordChar = true;
        }
        private void LoadRoles()
        {
        
            var roles = Enum.GetValues(typeof(UserRoles.Role)).Cast<UserRoles.Role>().ToList();
            roleCMB.DataSource = roles;
        }
        private void LoadFilterRoles()
        {
            var roles = Enum.GetValues(typeof(UserRoles.Role)).Cast<UserRoles.Role>().ToList();
            comboBox1.DataSource = roles;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            var dto = new UserDTO
            {
                NIC = nicTXT.Text.Trim(),
                Name = nameTXT.Text.Trim(),
                IndexNumber = indexTXT.Text.Trim(),
                Username = userTXT.Text.Trim(),
                Password = passwordTXT.Text.Trim(),
                Role = (UserRoles)roleCMB.SelectedItem
            };

            try
            {
                var existing = _controller.GetByNICAndName(dto.NIC, dto.Name);
                if (existing != null)
                {
                    MessageBox.Show("User already exists.");
                    return;
                }

                _controller.AddPreRegisteredUser(dto);
                MessageBox.Show("User added successfully.");
                LoadUserData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnUpdateCourse_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs() || string.IsNullOrWhiteSpace(idTXT.Text)) return;

            var dto = new UserDTO
            {
                Id = int.Parse(idTXT.Text),
                NIC = nicTXT.Text.Trim(),
                Name = nameTXT.Text.Trim(),
                IndexNumber = indexTXT.Text.Trim(),
                Username = userTXT.Text.Trim(),
                Password = passwordTXT.Text.Trim(),
                Role = (UserRoles)roleCMB.SelectedItem
            };

            try
            {
                _controller.UpdateUser(dto);
                MessageBox.Show("User updated successfully.");
                LoadUserData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update error: " + ex.Message);
            }
        }
        private void LoadUserData()
        {
            dataGridView1.DataSource = _controller.GetAllUsers();
        }

        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(idTXT.Text))
            {
                MessageBox.Show("Please select a user to delete.");
                return;
            }

            int id = int.Parse(idTXT.Text);
            _controller.DeleteUser(id);
            MessageBox.Show("User deleted.");
            LoadUserData();
            ClearFields();
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                if (e.RowIndex >= 0)
                {
                    var row = dataGridView1.Rows[e.RowIndex]; 

                    idTXT.Text = row.Cells["Id"].Value.ToString();
                    nicTXT.Text = row.Cells["NIC"].Value.ToString();
                    nameTXT.Text = row.Cells["Name"].Value.ToString();
                    indexTXT.Text = row.Cells["IndexNumber"].Value.ToString();
                    userTXT.Text = row.Cells["Username"].Value.ToString();
                    passwordTXT.Text = row.Cells["Password"].Value.ToString();
                    roleCMB.SelectedItem = (UserRoles.Role)Enum.Parse(typeof(UserRoles.Role), row.Cells["Role"].Value.ToString()); // ✅ fixed cast
                }
        }

        private void roleCMB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void idTXT_TextChanged(object sender, EventArgs e)
        {

        }
        private void ClearFields()
        {
            idTXT.Clear();
            nicTXT.Clear();
            nameTXT.Clear();
            indexTXT.Clear();
            userTXT.Clear();
            passwordTXT.Clear();
            passwordTXT.UseSystemPasswordChar = true;
            chkShowPassword.Checked = false;
            roleCMB.SelectedIndex = 0;
        }
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(nicTXT.Text))
            {
                MessageBox.Show("NIC is required.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(nameTXT.Text))
            {
                MessageBox.Show("Name is required.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(indexTXT.Text))
            {
                MessageBox.Show("Index Number is required.");
                return false;
            }
            return true;
        }

        private void nameTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void indexTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chkShowPassword_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
