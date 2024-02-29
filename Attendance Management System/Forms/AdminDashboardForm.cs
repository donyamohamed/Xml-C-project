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
            InitializeComponent();
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
            courseAdminForm1.Visible = true;
            classAdminForm1.Visible = false;
        }

        private void classes_data_Click(object sender, EventArgs e)
        {
            classAdminForm1.Visible=true;
            courseAdminForm1.Visible = false;
        }
    }
}
