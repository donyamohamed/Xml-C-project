using Attendance_Management_System.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Attendance_Management_System.classes.CourseParser;
using Microsoft.VisualBasic.Logging;

namespace Attendance_Management_System.Forms
{
    public partial class TeacherForm : Form
    {

        /*IEnumerable<string> meTeacher = from user in XDocument.Load("../../../../users.xml").Descendants("Users")
                                         where user.Element("id").Value == FormLogin.meTeacher.Id
                                        select user.Element("id").Value;
                                          /*
                                         select new Teacher // ("1", "fname", "lname", 20, "anymail", "123", "010", "address");
                                          {
                                              Id = user.Element("id").Value,
                                              FirstName = user.Element("firstName").Value,
                                              LastName = user.Element("lastName").Value,
                                              Age = int.Parse(user.Element("age").Value),
                                              Email = user.Element("email").Value,
                                              Password = user.Element("password").Value,
                                              Phone = user.Element("phone").Value,
                                              Address = user.Element("address").Value
                                          };
                                          */

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

        private void buttonMyCourses_Click(object sender, EventArgs e)
        {
            // get list of meTeacher's courses by Teacher.getCoursesIDbyTeacherID
            MessageBox.Show("You are teaching the following courses: ");

            FormLogin.meTeacher.getCoursesIDbyTeacherID(FormLogin.meTeacher.Id);
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {

        }
    }
}
