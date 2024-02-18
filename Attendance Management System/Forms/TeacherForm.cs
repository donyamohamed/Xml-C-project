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
// using static Attendance_Management_System.classes.CourseParser;
using static Attendance_Management_System.classes.User;
using static Attendance_Management_System.classes.Teacher;
using static Attendance_Management_System.classes.Course;
using static Attendance_Management_System.classes.RenderTable;
using Microsoft.VisualBasic.Logging;
using System.Reflection.Emit;


namespace Attendance_Management_System.Forms
{
    public partial class TeacherForm : Form
    {
        public static List<string> myCourses = getCoursesIDbyTeacherID(FormLogin.meTeacher.Id);
        public static List<Course> myCoursesObj = getListofCourse(myCourses);
        // public static List<Course> myCoursesObj = getCourseByID()
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

            getCoursesIDbyTeacherID(FormLogin.meTeacher.Id);
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            dataGridViewCourses.DataSource = RenderDateTable(myCoursesObj);
            //dataGridViewCourses.DataSource = RenderDateTable(Program.courses);
            // DataTable table = new DataTable();
            // table.Columns.Add("ID", typeof(string));
            // table.Columns.Add("Name", typeof(string));
            // table.Columns.Add("Description", typeof(string));
            // table.Columns.Add("Number of Sessions", typeof(int));
            // foreach (var course in myCoursesObj)
            // {
            //     table.Rows.Add(course.Id, course.Name, course.Description, course.Numberofsessions);
            // }
            // dataGridViewCourses.DataSource = table;

            // get list of courses by CourseParser
            // List<Course> Courses = ParseCourses("../../../../courses.xml");
            // FormLogin.meTeacher;
            labelID.Text = FormLogin.meTeacher.Id.ToString();
            labelAge.Text = FormLogin.meTeacher.Age.ToString();
            labelEmail.Text = FormLogin.meTeacher.Email.ToString();
            // labelPhoneNmber.Text = FormLogin.meTeacher.Phone.ToString();
            textBoxPhoneNumber.Text = FormLogin.meTeacher.Phone.ToString();
            textBoxAddress.Text = FormLogin.meTeacher.Address.ToString();
            textBoxAddress.ReadOnly = true;
            labelTeacher_Name.Text = FormLogin.meTeacher.FirstName.ToString() + " " + FormLogin.meTeacher.LastName.ToString();

            // listBoxCourses.DataSource = FormLogin.meTeacher.getCoursesIDbyTeacherID(FormLogin.meTeacher.Id).ToString();
            listBoxCourses.DataSource = myCourses;

        }

        private void buttonEditYourData_Click(object sender, EventArgs e)
        {
            if (buttonEditYourData.Text == "Edit Your Data")
            {
                buttonEditYourData.Text = "Save Your Data";
                textBoxAddress.ReadOnly = false;
                textBoxAddress.BorderStyle = BorderStyle.FixedSingle;
                textBoxPhoneNumber.ReadOnly = false;
                textBoxPhoneNumber.BorderStyle = BorderStyle.FixedSingle;

                labelID.Visible = false;
            }
            else if (buttonEditYourData.Text == "Save Your Data")
            {
                buttonEditYourData.Text = "Edit Your Data";
                textBoxAddress.ReadOnly = true;
                textBoxAddress.BorderStyle = BorderStyle.None;
                textBoxPhoneNumber.ReadOnly = false;
                textBoxPhoneNumber.BorderStyle = BorderStyle.None;
                labelID.Visible = true;

                FormLogin.meTeacher.changeTeacherData(
                    FormLogin.meTeacher.FirstName,
                    FormLogin.meTeacher.LastName,
                    FormLogin.meTeacher.Age,
                    FormLogin.meTeacher.Email,
                    FormLogin.meTeacher.Password,
                    textBoxPhoneNumber.Text,
                    textBoxAddress.Text
                    );
            }


        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            textBoxPhoneNumber.Text = FormLogin.meTeacher.Phone.ToString();
            textBoxAddress.Text = FormLogin.meTeacher.Address.ToString();
            textBoxAddress.ReadOnly = true;

            buttonEditYourData.Text = "Edit Your Data";
            textBoxAddress.ReadOnly = true;
            textBoxAddress.BorderStyle = BorderStyle.None;
            textBoxPhoneNumber.ReadOnly = false;
            textBoxPhoneNumber.BorderStyle = BorderStyle.None;
            labelID.Visible = true;


        }

    }
}
