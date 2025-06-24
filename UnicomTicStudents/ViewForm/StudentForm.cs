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
using UnicomTicStudents.Services;

namespace UnicomTicStudents.ViewForm
{
    public partial class StudentForm : Form
    {
        private readonly StudentController _controller;
        private readonly ICourseService _courseService;
        private int _selectedStudentId = -1;

        public StudentForm(StudentController controller, ICourseService courseService)
        {
            InitializeComponent();
            _controller = controller;
            _courseService = courseService;
            LoadCourses();
        }
        private void LoadCourses()
        {
            var courses = _courseService.GetAllCourses();
            CourseCMB.DataSource = courses;
            CourseCMB.DisplayMember = "Name";
            CourseCMB.ValueMember = "Id";
        }

        private void StudentDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var name = nameTXT.Text;
            var nic = nicTXT.Text;
            var courseId = (int)CourseCMB.SelectedValue;

            _controller.AddStudent(name, nic, courseId);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var name = nameTXT.Text;
            var nic = nicTXT.Text;
            var courseId = (int)CourseCMB.SelectedValue;

            _controller.UpdateStudent(_selectedStudentId, name, nic,courseId);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _controller.DeleteStudent(_selectedStudentId);
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
