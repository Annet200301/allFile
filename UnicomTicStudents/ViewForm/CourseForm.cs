using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using UnicomTicStudents.Course;
using UnicomTicStudents.Datas;
using UnicomTicStudents.ViewForm;
using static UnicomTicStudents.Course.CourseEnum;

namespace UnicomTicStudents
{
   
   
    public partial class CourseForm : Form
    {
        private CourseController _controller;
        private int _selectedCourseId = -1;

        public CourseForm()
        {
            InitializeComponent();

            var repository = new CourseRepository();
            var service = new CourseService(repository);
            _controller = new CourseController(service);
            

            LoadCourses();

        }
        private void LoadCourses()
        {
            try
            {
                var courses = _controller.GetAll();
                courseDataGridView.DataSource = null; 
                courseDataGridView.DataSource = courses;
                courseDataGridView.ClearSelection();
                _selectedCourseId = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading courses: " + ex.Message);
            }
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {
            
        }
        private void LoadGrid()
        {
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            try
            {
                var name = NameCtextBox.Text.Trim();
                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Course name cannot be empty.");
                    return;
                }

                var existingCourse = _controller.GetAll().FirstOrDefault(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
                if (existingCourse != null)
                {
                    MessageBox.Show("Course with the same name already exists.");
                    return;
                }

                _controller.Add(name);
                NameCtextBox.Clear();
                LoadCourses();
                MessageBox.Show("Course added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add failed: " + ex.Message);
            }
        }

        private void btnUpdateCourse_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedCourseId <= 0)
                {
                    MessageBox.Show("Please select a course to update.");
                    return;
                }

                var name =NameCtextBox.Text.Trim();
                _controller.Update(_selectedCourseId, name);
                NameCtextBox.Clear();
                LoadCourses(); 
                MessageBox.Show("Course updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update failed: " + ex.Message);
            }
        }

        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            if (courseDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a course to delete.");
                return;
            }
            
            int id = Convert.ToInt32(courseDataGridView.SelectedRows[0].Cells["Id"].Value);

            using (var connection = DataConfig.GetConnection())
            {          
                var query = "DELETE FROM Courses WHERE Id = @Id";
                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }                 
                var resetQuery = "DELETE FROM sqlite_sequence WHERE name='Courses'";
                using (var resetCmd = new SQLiteCommand(resetQuery, connection))
                {
                    resetCmd.ExecuteNonQuery();
                }
            }
            NameCtextBox.Clear();
            LoadCourses();
        }

        private void courseDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = courseDataGridView.Rows[e.RowIndex];
                _selectedCourseId = Convert.ToInt32(row.Cells["Id"].Value);
                NameCtextBox.Text = row.Cells["Name"].Value.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void NameCtextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void levelCMBcourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to exit?", "Exit Application",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            SubjectForm subjectForm = new SubjectForm();
            subjectForm.ShowDialog();
        }
    }
}
