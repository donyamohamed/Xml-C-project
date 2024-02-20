using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_Management_System.Forms
{
    public partial class testAdmin : Form
    {
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
            TeacherAdminForm teacherAdminForm = new TeacherAdminForm();
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

        }

        private void classes_data_Click(object sender, EventArgs e)
        {

        }

        private void course_data_Click(object sender, EventArgs e)
        {

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

        private void languagebutton_Click(object sender, EventArgs e)
        {
            lang.Text = (lang.Text == "en") ? "ar" : "en";
            UpdateLanguage();
        }
        private void UpdateLanguage()
        {
            string newCulture = (lang.Text == "en") ? "en" : "ar";
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(newCulture);
            CultureInfo.CurrentCulture = new CultureInfo(newCulture);
            CultureInfo.CurrentUICulture = new CultureInfo(newCulture);
            UpdateUI();

        }
        private void UpdateUI()
        {
            this.Controls.Clear();
            this.InitializeComponent();

        }



    }
}
