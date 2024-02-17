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
using static Attendance_Management_System.classes.CourseParser;

namespace Attendance_Management_System.Forms
{
    public partial class TeacherForm : Form
    {
        public TeacherForm()
        {
            // get list of courses by CourseParser
            List<Course> Courses = ParseCourses("../../../../courses.xml");
            InitializeComponent();
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
