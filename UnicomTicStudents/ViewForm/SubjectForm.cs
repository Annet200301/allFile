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
using UnicomTicStudents.Course;

namespace UnicomTicStudents.ViewForm
{
    public partial class SubjectForm : Form
    {
        private SubjectController _subjectController;
        private CourseController _courseController;
        public SubjectForm()
        {
            InitializeComponent();
            
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

    }
}
