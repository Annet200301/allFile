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
using UnicomTicStudents.Services;
using UnicomTicStudents.Services.Iservices;

namespace UnicomTicStudents.ViewForm
{
    public partial class LecturerManagementSystem : Form
    {

        private readonly ILecturerServices _lecturerService;
        private readonly IsubjectServices _subjectService;
        private int selectedLecturerId = 0;
        public LecturerManagementSystem(ILecturerServices lecturerService, IsubjectServices subjectService)
        {
            InitializeComponent();
            _lecturerService = lecturerService;
            _subjectService = subjectService;
            LoadSubjects();
            LoadLecturers();
        }
        private void LoadSubjects()
        
        {
            var subjects = _subjectService.GetAllSubjects();
            lecturerCMB.DataSource = subjects;
            lecturerCMB.DisplayMember = "Name";
            lecturerCMB.ValueMember = "Id";
        }
        
        private void LoadLecturers()
        {
            var lecturers = _lecturerService.GetAllLecturers();
            LecturerDGV.DataSource = null;
            LecturerDGV.DataSource = lecturers;
        }

        private void nicTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void LecturerManagementSystem_Load(object sender, EventArgs e)
        {

        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            try
            {
                var dto = new LecturerDTO
                {
                    Name = nameTXT.Text.Trim(),
                    NIC = nicTXT.Text.Trim(),
                    IndexNumber = indexTXT.Text.Trim(),
                    SubjectId = Convert.ToInt32(lecturerCMB.SelectedValue)
                };

                _lecturerService.AddLecturer(dto);
                LoadLecturers();
                ClearForm();
                MessageBox.Show("Lecturer Added Successfully!");
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
                if (selectedLecturerId <= 0)
                {
                    MessageBox.Show("Please select a lecturer to update.");
                    return;
                }

                var dto = new LecturerDTO
                {
                    Id = selectedLecturerId,
                    Name = nameTXT.Text.Trim(),
                    NIC = nicTXT.Text.Trim(),
                    IndexNumber = indexTXT.Text.Trim(),
                    SubjectId = Convert.ToInt32(lecturerCMB.SelectedValue)
                };

                _lecturerService.UpdateLecturer(dto);
                LoadLecturers();
                ClearForm();
                MessageBox.Show("Lecturer Updated Successfully!");
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
                if (selectedLecturerId <= 0)
                {
                    MessageBox.Show("Please select a lecturer to delete.");
                    return;
                }

                _lecturerService.DeleteLecturer(selectedLecturerId);
                LoadLecturers();
                ClearForm();
                MessageBox.Show("Lecturer Deleted Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LecturerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = LecturerDGV.Rows[e.RowIndex];
                selectedLecturerId = Convert.ToInt32(row.Cells["Id"].Value);
                nameTXT.Text = row.Cells["Name"].Value.ToString();
                nicTXT.Text = row.Cells["NIC"].Value.ToString();
                indexTXT.Text = row.Cells["IndexNumber"].Value.ToString();
                lecturerCMB.SelectedValue = Convert.ToInt32(row.Cells["SubjectId"].Value);
            }
        }
        private void ClearForm()
        {
            nameTXT.Clear();
            nicTXT.Clear();
            indexTXT.Clear();
            lecturerCMB.SelectedIndex = 0;
            selectedLecturerId = 0;
        }
    }
}
