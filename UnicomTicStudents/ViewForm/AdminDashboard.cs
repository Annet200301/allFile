using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTicStudents;

namespace ADMIN.viewform
{
    public partial class AdminDashboard : Form
    {
        private Form2 _form2;
        public AdminDashboard(Form2 _form)
        {
            InitializeComponent();
            _form2=_form;
           

        }

        private void MainDashBoard_Load(object sender, EventArgs e)
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
        private void LoadFormIntoPanel(Form form)
        {
            if (AdminPanel.Controls.Count > 0)
            {
                Control existingControl = AdminPanel.Controls[0];


                AdminPanel.Controls.Remove(existingControl);
                existingControl.Dispose();
            }
    
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            AdminPanel.Controls.Add(form);
            form.Show();
        }

        private void adminFormPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void adminRegisterBtn_Click(object sender, EventArgs e)
        {

        }

        private void adminStudentBtn_Click(object sender, EventArgs e)
        {

        }

        private void adminlectureBtn_Click(object sender, EventArgs e)
        {

        }

        private void adminStaffBtn_Click(object sender, EventArgs e)
        {

        }

        private void adminAdminBtn_Click(object sender, EventArgs e)
        {

        }

        private void adminTimetblBtn_Click(object sender, EventArgs e)
        {

        }

        private void adminAttendenceBtn_Click(object sender, EventArgs e)
        {

        }

        private void adminCourseBtn_Click(object sender, EventArgs e)
        {
            CourseForm courseForm = new CourseForm();
            LoadFormIntoPanel(courseForm);

        }

        private void adminExamBtn_Click(object sender, EventArgs e)
        {

        }

        private void adminMarksBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
