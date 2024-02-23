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
using static Attendance_Management_System.classes.User;
using static Attendance_Management_System.classes.Teacher;
using static Attendance_Management_System.classes.Course;
using static Attendance_Management_System.classes.RenderTable;
using static Attendance_Management_System.classes.RenderAttendanceTable;
using static Attendance_Management_System.classes.RenderStduentAttendanceofTecherTable;
using static Attendance_Management_System.classes.Class;
using Microsoft.VisualBasic.Logging;
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Attendance_Management_System.Forms
{
    public partial class TeacherForm : Form
    {
        public static List<string> myCIDs = getCoursesIDbyTeacherID(FormLogin.meTeacher.Id);
        public static List<Course> myCoursesObj = getListofCourse(myCIDs);
        public static List<StudentSessions> myStdSessionsObj = getListofStudentSessions(myCIDs);
        public static List<Session> mySessionsObj = getListofSessions(myCIDs);
        public static List<DateTime> courseDates = getCDatesbyCIds(myCIDs);

        // public static List<Course> myCoursesObj = getCourseByID()

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
            getCoursesIDbyTeacherID(FormLogin.meTeacher.Id);
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            dataGridViewCourses.DataSource = RenderDateTable(myCoursesObj);
            //Console.WriteLine(Program.claSSes);
            // dataGridViewAttendance.DataSource = RenderDateTable(mySessionsObj);
            dataGridViewDateStatus.DataSource = RenderDateTable(mySessionsObj);



            dataGridViewAttendance.DataSource = RenderStdAttofTecherTable(mySessionsObj, myStdSessionsObj);



            labelID.Text = FormLogin.meTeacher.Id.ToString();
            labelAge.Text = FormLogin.meTeacher.Age.ToString();
            labelEmail.Text = FormLogin.meTeacher.Email.ToString();
            // labelPhoneNmber.Text = FormLogin.meTeacher.Phone.ToString();
            textBoxPhoneNumber.Text = FormLogin.meTeacher.Phone.ToString();
            textBoxAddress.Text = FormLogin.meTeacher.Address.ToString();
            textBoxAddress.ReadOnly = true;
            labelTeacher_Name.Text = FormLogin.meTeacher.FirstName.ToString() + " " + FormLogin.meTeacher.LastName.ToString();

            // listBoxCourses.DataSource = FormLogin.meTeacher.getCoursesIDbyTeacherID(FormLogin.meTeacher.Id).ToString();
            listBoxCourses.DataSource = myCIDs;
            listBoxCDates.DataSource = courseDates;

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

        private void dataGridViewAttendance_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Chagne the Color of the row
            if (e.RowIndex % 2 == 0)
            {
                dataGridViewAttendance.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray;
            }
            else
            {
                dataGridViewAttendance.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
            // if cell contains "Absent" then change the color to red 
            // else if cell contains "Attend" then change the color to green
            if (e.Value != null && e.Value.ToString() == "Absent")
            {
                e.CellStyle.BackColor = Color.Red;
            }
            else if (e.Value != null && e.Value.ToString() == "Attend")
            {
                e.CellStyle.BackColor = Color.Green;
            }
            else
            {
                e.CellStyle.BackColor = Color.Orange;
            }
        }

        private void dataGridViewCourses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            // prevent se
            if (indexRow < 0)
            {
                return;
            }
            selectedStudents = new List<Obj>(); ;

            DataGridViewRow row = dataGridViewCourses.Rows[indexRow];
            textBoxCouseID.Text = row.Cells[0].Value.ToString();
            textBoxCourseName.Text = row.Cells[1].Value.ToString();
            textBoxCourseDescription.Text = row.Cells[2].Value.ToString();
            textBoxCourseSessions.Text = row.Cells[3].Value.ToString();

            List<string> selectedCourse = new List<string>();
            selectedCourse.Add(row.Cells[0].Value.ToString());
            List<DateTime> courseDates = getCDatesbyCIds(selectedCourse);
            comboBoxCourseDates.DataSource = courseDates;


            /*
            if (selectedCourse.Contains(row.Cells[0].Value.ToString()))
                selectedCourse.Add(row.Cells[0].Value.ToString());
            else
                selectedCourse.Remove(row.Cells[0].Value.ToString());
            */




            // textBoxID.Text = row.Cells[0].Value.ToString();
            // textBoxName.Text = row.Cells[1].Value.ToString();
            // textBoxDescription.Text = row.Cells[2].Value.ToString();
            //dataGridViewAttendance.DataSource = 
            dataGridViewStudentStatus.DataSource = RenderAttTable(textBoxDate.Text, myStdSessionsObj);
            dataGridViewAttendance.DataSource = RenderStdAttofTecherTable(mySessionsObj, myStdSessionsObj);


        }

        private void dataGridViewDateStatus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            if (indexRow < 0)
            {
                return;
            }
            DataGridViewRow row = dataGridViewDateStatus.Rows[indexRow];
            textBoxDate.Text = row.Cells[0].Value.ToString();
        }

        private void buttonGenATTTAble_Click(object sender, EventArgs e)
        {

        }

        class Obj
        {
            public string StudentID { get; set; }
            public string Status { get; set; }
            public string Name { get; set; }
            // constructor
            public Obj(string studentId, string status, string name)
            {
                StudentID = studentId;
                Status = status;
                Name = name;
            }

        }

        List<Obj> selectedStudents = new List<Obj>();

        private void dataGridViewStudentStatus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            if (indexRow < 0)
            {
                return;
            }
            DataGridViewRow row = dataGridViewStudentStatus.Rows[indexRow];


            Obj selectedStudent = new Obj(
                row.Cells[0].Value.ToString(),
                row.Cells[1].Value.ToString(),
                row.Cells[2].Value.ToString()
                );

            if (selectedStudents.Contains(selectedStudent))
            {
                // If the student is already in the list, remove them (deselect)
                selectedStudents.Remove(selectedStudent);
            }
            else
            {
                // If the student is not in the list, add them (select)
                selectedStudents.Add(selectedStudent);
            }
            // check if the selectedStudents contains the student or not 
            if (selectedStudents.Count > 0)
            {
                buttonAttend.Visible = true;
                buttonAbsent.Visible = true;
            }
            else
            {
                buttonAttend.Visible = false;
                buttonAbsent.Visible = false;
            }
        }

        private void buttonAttend_Click(object sender, EventArgs e)
        {
            // make the selected students present 
            foreach (var student in selectedStudents)
            {
                student.Status = "Attend";
                changeStudentAttendance(FormLogin.meTeacher.Id, textBoxCouseID.Text, student.StudentID, Convert.ToDateTime(textBoxDate.Text), 1);
            }
            dataGridViewStudentStatus.DataSource = RenderAttTable(textBoxDate.Text, myStdSessionsObj);
            dataGridViewAttendance.DataSource = RenderStdAttofTecherTable(mySessionsObj, myStdSessionsObj);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedStudents = new List<Obj>();
            textBoxDate.Text = comboBoxCourseDates.Text;
            dataGridViewStudentStatus.DataSource = RenderAttTable(textBoxDate.Text, myStdSessionsObj);

        }


        /*
        private void dataGridViewStudentStatus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // get list with selected Rows in the dataGridViewStudentStatus 
            // to change the status of the selected students
            int indexRow = e.RowIndex;

            if (indexRow < 0)
            {
                return;
            }

            // get the selected row data in a list 
            // when the user select on the row add to the list
            // when the user deselect the row remove from the list

            List<Obj> thisStd = new List<Obj>();

            Data


            DataGridViewRow row = dataGridViewStudentStatus.Rows[indexRow];
            textBoxStudentID.Text = row.Cells[0].Value.ToString();
            textBoxStatus.Text = row.Cells[1].Value.ToString();
            textBoxName.Text = row.Cells[2].Value.ToString();


        }
        */
    }
}
