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
        public AdminDashboard()
        {
            InitializeComponent();
            
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

        private void CourseManagement_Click(object sender, EventArgs e)
        {
            CourseForm courseForm = new CourseForm();
            LoadFormIntoPanel(courseForm);
            
        }
        private void LoadFormIntoPanel(Form form)
        {
            if (adminFormPanel.Controls.Count > 0)
            {
                Control existingControl = adminFormPanel.Controls[0];


                adminFormPanel.Controls.Remove(existingControl);
                existingControl.Dispose();
            }
    
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            adminFormPanel.Controls.Add(form);
            form.Show();
        }

        private void adminFormPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
