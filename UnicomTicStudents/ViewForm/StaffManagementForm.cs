using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTicStudents.Models.DTOs;
using UnicomTicStudents.Services.Iservices;

namespace UnicomTicStudents.ViewForm
{
    public partial class StaffManagementForm : Form
    {
        private readonly IStaffService _staffService;
        private int _selectedStaffId = -1;

        public StaffManagementForm(IStaffService staffService)
        {
            InitializeComponent();
            _staffService = staffService;
            LoadStaff();
        }

        private void StaffManagementForm_Load(object sender, EventArgs e)
        {

        }
        private void LoadStaff()
        {
            var staffList = _staffService.GetAllStaff();
            StaffDGV.DataSource = staffList;
        }


        private void lecturerCMB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void indexTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void nicTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LecturerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = StaffDGV.Rows[e.RowIndex];
                _selectedStaffId = Convert.ToInt32(row.Cells["Id"].Value);
                nameTXT.Text = row.Cells["Name"].Value.ToString();
                nicTXT.Text = row.Cells["NIC"].Value.ToString();
                if (StaffDGV.SelectedRows.Count > 0)
                {
                    var selectedValue = StaffDGV.SelectedRows[0].Cells["ColumnName"].Value.ToString();
                }

            }
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            try
            {
                var staffDto = new StaffDTO
                {
                    Name = nameTXT.Text.Trim(),
                    NIC = nicTXT.Text.Trim(),
                    Work = workTXT.Text.Trim(),
                };

                _staffService.AddStaff(staffDto);
                MessageBox.Show("Staff added successfully.");
                LoadStaff();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnUpdateCourse_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedStaffId <= 0)
                {
                    MessageBox.Show("Please select a staff member to update.");
                    return;
                }

                var staffDto = new StaffDTO
                {
                    Id = _selectedStaffId,
                    Name = nameTXT.Text.Trim(),
                    NIC =nicTXT.Text.Trim(),
                    Work = workTXT.Text.Trim(),
                };

                _staffService.UpdateStaff(staffDto);
                MessageBox.Show("Staff updated successfully.");
                LoadStaff();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedStaffId <= 0)
                {
                    MessageBox.Show("Please select a staff member to delete.");
                    return;
                }

                _staffService.DeleteStaff(_selectedStaffId);
                MessageBox.Show("Staff deleted successfully.");
                LoadStaff();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
