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
using UnicomTicStudents.Repositories;
using UnicomTicStudents.Services;
using UnicomTicStudents.Services.Iservices;
using UnicomTicStudents.Services.IServices;

namespace UnicomTicStudents.ViewForm
{
    public partial class SubjectForm : Form
    {
        private readonly IsubjectServices _subjectService;
        private readonly ICourseService _courseService;
        private SubjectController  _controller;
        private int selectedSubjectId = 0;
        public SubjectForm(IsubjectServices subjectService, ICourseService courseService)
        {
            InitializeComponent();

            _subjectService = subjectService;
            _courseService = courseService;   

            _controller = new SubjectController(subjectService);

            LoadCourses();
        }
        private void LoadCourses()
        {
            var courses = _courseService.GetAllCourses();  
            courseNameLoad.DataSource = courses;  
            courseNameLoad.DisplayMember = "Name"; 
            courseNameLoad.ValueMember = "Id"; 
        }
        private void LoadSubjects()
        {
            if (courseNameLoad.SelectedValue is int courseId)
            {
                var subjects = _subjectService.GetSubjectsByCourseId(courseId);
                subjectDGV.DataSource = subjects;

                if (!subjectDGV.Columns.Contains("CourseName"))
                {
                    subjectDGV.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        HeaderText = "Course Name",
                        DataPropertyName = "CourseName",
                        Name = "CourseName"
                    });
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubjectForm_Load(object sender, EventArgs e)
        {
           
        }
        private void LoadCoursesIntoComboBox()
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {

            try
            {
                var dto = new SubjectDTO
                {
                    Name = subjectNameTXT.Text.Trim(),
                    CourseId = (int)courseNameLoad.SelectedValue 
                };

                _subjectService.AddSubject(dto);
                LoadSubjects(); 
                ClearForm();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateCourse_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedSubjectId <= 0)
                {
                    MessageBox.Show("Please select a subject to update.");
                    return;
                }

                var dto = new SubjectDTO
                {
                    Id = selectedSubjectId,
                    Name = subjectNameTXT.Text.Trim(),
                    CourseId = (int)courseNameLoad.SelectedValue
                };

                _subjectService.UpdateSubject(dto);
                LoadSubjects();  
                ClearForm();
                MessageBox.Show("Subject updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update failed: " + ex.Message);
            }
        }

        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedSubjectId <= 0)
                {
                    MessageBox.Show("Please select a subject to delete.");
                    return;
                }

                _subjectService.DeleteSubject(selectedSubjectId);
                LoadSubjects();
                ClearForm();
                MessageBox.Show("Subject deleted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete failed: " + ex.Message);
            }
        }

        private void subjectDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                var row = subjectDGV.Rows[e.RowIndex];
                selectedSubjectId = (int)row.Cells["Id"].Value;
                subjectNameTXT.Text = row.Cells["Name"].Value.ToString();
            }
        }

        private void courseNameLoad_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSubjects();
        }
        private void ClearForm()
        {
            subjectNameTXT.Clear(); 
            selectedSubjectId = 0;  
        }
    }
}
