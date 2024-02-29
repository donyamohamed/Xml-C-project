using Attendance_Management_System.controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_Management_System.Forms
{
    public partial class AdminDashboardForm : Form
    {
        public AdminDashboardForm()
        {

            //teacherAdminForm1.Visible = false;
            // studentsAdminForm1.Visible = false;
            InitializeComponent();

            courseAdminForm2.Visible = false;
            classAdminForm2.Visible = false;
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            //  teacherAdminForm1.Visible = false;
            // studentsAdminForm1.Visible = false;
            // courseAdminForm1.Visible = false;
        }

        private void teacher_data_Click(object sender, EventArgs e)
        {
            //teacherAdminForm1.Visible = true;
            //studentsAdminForm1.Visible = false;
        }

        private void student_data_Click(object sender, EventArgs e)
        {
            //studentsAdminForm1.Visible = true;
            //teacherAdminForm1.Visible = false;
        }

        private void course_data_Click(object sender, EventArgs e)
        {
            courseAdminForm2.Visible = true;
            classAdminForm2.Visible = false;
        }

        private void classes_data_Click(object sender, EventArgs e)
        {
            classAdminForm2.Visible = true;
            courseAdminForm2.Visible = false;
        }

        private void logout_Click(object sender, EventArgs e)
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
    }
}
