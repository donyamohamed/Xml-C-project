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
using static Attendance_Management_System.classes.Class;
using Microsoft.VisualBasic.Logging;
using System.Reflection.Emit;


namespace Attendance_Management_System.Forms
{
    public partial class TeacherForm : Form
    {
        public static List<string> myCourses = getCoursesIDbyTeacherID(FormLogin.meTeacher.Id);
        public static List<Course> myCoursesObj = getListofCourse(myCourses);
        public static List<StudentSessions> myStdSessionsObj = getListofStudentSessions(myCourses);
        public static List<Session> mySessionsObj = getListofSessions(myCourses);
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
            //Console.WriteLine(Program.claSSes);
            dataGridViewCourses.DataSource = RenderDateTable(myCoursesObj);
            // dataGridViewAttendance.DataSource = RenderDateTable(mySessionsObj);
            dataGridViewDateStatus.DataSource = RenderDateTable(mySessionsObj);


            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Stduent ID / Session Date", typeof(string));

            foreach (Session session in mySessionsObj)
            {
                string columnName = session.Date.ToString();

                // Check if the column already exists
                if (!dataTable.Columns.Contains(columnName))
                {
                    dataTable.Columns.Add(columnName, typeof(string));
                }
            }

            foreach (StudentSessions SS in myStdSessionsObj)
            {
                DataRow row = dataTable.NewRow();
                // make this row red 


                row["Stduent ID / Session Date"] = SS.StudentId;

                foreach (Session session in mySessionsObj)
                {
                    var matchingSession = SS.Sessions.FirstOrDefault(s => s.Date == session.Date);

                    if (matchingSession != null)
                    {
                        row[session.Date.ToString()] = matchingSession.Status == 1 ? "Attend" : "Absent";
                    }
                    else
                    {
                        // Handle the case where a matching session is not found
                        row[session.Date.ToString()] = "N/A";
                    }
                }

                dataTable.Rows.Add(row);
            }

            dataGridViewAttendance.DataSource = dataTable;



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
            DataGridViewRow row = dataGridViewCourses.Rows[indexRow];
            textBoxCouseID.Text = row.Cells[0].Value.ToString();
            textBoxCourseName.Text = row.Cells[1].Value.ToString();
            textBoxCourseDescription.Text = row.Cells[2].Value.ToString();
            textBoxCourseSessions.Text = row.Cells[3].Value.ToString();



            // textBoxID.Text = row.Cells[0].Value.ToString();
            // textBoxName.Text = row.Cells[1].Value.ToString();
            // textBoxDescription.Text = row.Cells[2].Value.ToString();

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
            dataGridViewStudentStatus.DataSource = RenderAttTable(textBoxDate.Text, myStdSessionsObj);

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
