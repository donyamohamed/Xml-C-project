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
    public partial class testAdmin : Form
    {
        private string role;
        public testAdmin()
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
          
            TeacherAdminForm teacherAdminForm = new TeacherAdminForm(role);
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
            TeacherAdminForm studentAdminForm = new TeacherAdminForm(role);
            studentAdminForm.Role = role;
            studentAdminForm.Show();
            Hide();
        }

        private void classes_data_Click(object sender, EventArgs e)
        {

        }

        private void course_data_Click(object sender, EventArgs e)
        {
            role = "course";
            TeacherAdminForm courseAdminForm = new TeacherAdminForm(role);
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
            Close();
        }

        // test student 
   
    }
}
