using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTicStudents.Repositories;
using UnicomTicStudents.Repositories.Interfaces;
using UnicomTicStudents.Repositories.Irepository;
using UnicomTicStudents.Services;
using UnicomTicStudents.Services.Interfaces;
using UnicomTicStudents.Services.Iservices;

namespace UnicomTicStudents.ViewForm
{
    public partial class TimeTableManagement : Form
    {
        public TimeTableManagement()
        {
            InitializeComponent();
        }

        private void TimeTableManagement_Load(object sender, EventArgs e)
        {
             
        }

        private void label2_Click(object sender, EventArgs e)
        {// If RoomManagementForm does not need any parameters:
            var roomForm = new RoomForm();
            roomForm.TopLevel = false;
            roomForm.FormBorderStyle = FormBorderStyle.None;
            roomForm.Dock = DockStyle.Fill;

            // Assuming you have a Panel named panelRoom on your main form
            Panelroom.Controls.Clear();
            Panelroom.Controls.Add(roomForm);
            roomForm.Show();

        }

        private void Panelroom_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
