using Attendance_Management_System.classes;
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
using System.Xml;

namespace Attendance_Management_System.Forms
{
    public partial class StartAdmin : Form
    {
        private string role;
        public StartAdmin()
        {
            InitializeComponent();
        }

        private void testAdmin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Teacherbutton_Click(object sender, EventArgs e)
        {
            role = "teacher";
          
            UserAdminForm teacherAdminForm = new UserAdminForm(role);
            teacherAdminForm.Role = role;
            teacherAdminForm.Show();
            Hide();
        }

        private void Logout_click(object sender, EventArgs e)
        {
            FormLogin Formlogin = new FormLogin();
            Formlogin.Show();
            Hide();
        }

        private void student_data_Click(object sender, EventArgs e)
        {
            role = "student";
            UserAdminForm studentAdminForm = new UserAdminForm(role);
            studentAdminForm.Role = role;
            studentAdminForm.Show();
            Hide();
        }

        private void classes_data_Click(object sender, EventArgs e)
        {
            StartAdmin classAdmin1 = new StartAdmin();

            classAdmin1.Show();
            Hide();
        }

        private void course_data_Click(object sender, EventArgs e)
        {
            role = "course";
            UserAdminForm courseAdminForm = new UserAdminForm(role);
            courseAdminForm.Role = role;
            courseAdminForm.Show();
            Hide();
        }

        private void admin_profile_Click(object sender, EventArgs e)
        {

        }

        private void minimizebox_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void closebox_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the user's response
            if (result == DialogResult.Yes)
            {
                FormLogin formLogin = new FormLogin();
                formLogin.Show();

                this.Hide();

            }
        }

        // test student 
   
    }
}
