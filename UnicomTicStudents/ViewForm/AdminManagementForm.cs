using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTicStudents.Controllers;
using UnicomTicStudents.Repositories;
using UnicomTicStudents.Services;
using UnicomTicStudents.Services.Iservices;

namespace UnicomTicStudents.ViewForm
{
    public partial class AdminManagementForm : Form
    {
        private readonly AdminController _controller;
        private int _selectedAdminId = -1;
        private readonly IAdminService _adminService;



        public AdminManagementForm(IAdminService adminService)
        {
            InitializeComponent();
            _adminService = adminService;
            _controller = new AdminController(_adminService);

            LoadAdmins();

        }
        private void LoadAdmins()
        {
            try
            {
                var admins = _controller.GetAll();
                AdminDGV.DataSource = null;
                AdminDGV.DataSource = admins;
                AdminDGV.ClearSelection();
                _selectedAdminId = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading admins: " + ex.Message);
            }
        }
        private void ClearForm()
        {
            nameTXT.Clear();
            nicTXT.Clear();
            _selectedAdminId = -1;
        }


        private void indexTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && AdminDGV.Rows[e.RowIndex].Cells["Id"].Value != null)
            {
                var row = AdminDGV.Rows[e.RowIndex];
                _selectedAdminId = Convert.ToInt32(row.Cells["Id"].Value);
                nameTXT.Text = row.Cells["Name"].Value.ToString();
                nicTXT.Text = row.Cells["NIC"].Value.ToString();
                
            }
        }

        private void AdminManagementForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string name = nameTXT.Text.Trim();
                string nic = nicTXT.Text.Trim();
               

                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(nic))
                {
                    MessageBox.Show("Name and nic are required.");
                    return;
                }

                _controller.Add(name, nic);
                LoadAdmins();
                ClearForm();
                MessageBox.Show("Admin added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add failed: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedAdminId <= 0)
                {
                    MessageBox.Show("Please select an admin to update.");
                    return;
                }

                string name = nameTXT.Text.Trim();
                string nic = nicTXT.Text.Trim();
                

                _controller.Update(_selectedAdminId, name, nic);
                LoadAdmins();
                ClearForm();
                MessageBox.Show("Admin updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update failed: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedAdminId <= 0)
                {
                    MessageBox.Show("Please select an admin to delete.");
                    return;
                }

                _controller.Delete(_selectedAdminId);
                LoadAdmins();
                ClearForm();
                MessageBox.Show("Admin deleted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete failed: " + ex.Message);
            }
        }
    }
}
