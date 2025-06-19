using ADMIN.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ADMIN.Enums.UserRoles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ADMIN.viewform
{
    public partial class RegistrationMainForm : Form
    {
        public RegistrationMainForm()
        {
            InitializeComponent();
            memberCMB2.DataSource = Enum.GetValues(typeof(Role));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void registerMainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RegistrationMainForm_Load_1(object sender, EventArgs e)
        {
           
        }

        private void memberSelectionBtn2_Click(object sender, EventArgs e)
        {
            Role selectedForm = (Role)memberCMB2.SelectedItem;

            switch (selectedForm)
            {
                case Role.Student:
                    LoadFormIntoPanel(new StudentRegister());
                    break;
                case Role.Lecturer:
                    LoadFormIntoPanel(new LecturerRegister());                       
                    break;
                case Role.Staff:
                    LoadFormIntoPanel(new StaffRegister());
                    break;
                case Role.Admin:
                    LoadFormIntoPanel(new AdminRegistration());
                    break;
            }
        }
        private void LoadFormIntoPanel(Form form)
        {
            if (registerMainPanel.Controls.Count > 0)
            {
                Control existingControl = registerMainPanel.Controls[0];


                registerMainPanel.Controls.Remove(existingControl);
                existingControl.Dispose();
            }
    
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            registerMainPanel.Controls.Add(form);
            form.Show();
        }

        private void RegistrationMainForm_Load(object sender, EventArgs e)
        {
            memberCMB2.DataSource = Enum.GetValues(typeof(UserRoles.Role));
        }
    }
}
