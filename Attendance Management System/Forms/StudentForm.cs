using Attendance_Management_System.classes;
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
using System.Xml;
using System.Threading;

namespace Attendance_Management_System.Forms
{
    public partial class StudentForm : Form
    {
        private string selectedLanguage;
        Student loggedUser;
        private List<(string date, string courseName, string teacherId, int sessionNumber, int status)> sessionData = new List<(string date, string courseName, string teacherId, int sessionNumber, int status)>();

        public StudentForm()
        {

            InitializeComponent();

            loggedUser = FormLogin.meStudent;
            LoadSessionDataForUser(loggedUser.Id);
            PopulateDataGridView();
            textSearch.TextChanged += txtSearch_TextChanged;

        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            if (loggedUser != null)
            {
                labelName.Text = $"{loggedUser.FirstName}  {loggedUser.LastName}   ^_^";
                labStdId.Text = loggedUser.Id;

            }
        }

        //get data for ---> this user id
        private void LoadSessionDataForUser(string userId)
        {
            XmlDocument classesDoc = new XmlDocument();
            classesDoc.Load("../../../../class.xml");

            //to get course name load course
            XmlDocument coursesDoc = new XmlDocument();
            coursesDoc.Load("../../../../courses.xml");


            //dynamic classesDoc = Program.claSSes;
            //  dynamic coursesDoc = Program.courses;

            XmlNodeList classNodes = classesDoc.SelectNodes($"//class[studentId/@id='{userId}']");

            foreach (XmlNode classNode in classNodes)
            {
                string courseId = classNode.SelectSingleNode("courseId").InnerText;
                string teacherId = classNode.SelectSingleNode("teacherId").InnerText;

                //get course name
                XmlNode courseNode = coursesDoc.SelectSingleNode($"//course[courseId='{courseId}']");
                string courseName = courseNode.SelectSingleNode("courseName").InnerText;

                XmlNodeList sessionNodes = classNode.SelectNodes($"studentId[@id='{userId}']/session");
                int sessionNumber = 1;
                foreach (XmlNode sessionNode in sessionNodes)
                {
                    string date = sessionNode.SelectSingleNode("date").InnerText;
                    int status = int.Parse(sessionNode.SelectSingleNode("status").InnerText);


                    sessionData.Add((date, courseName, teacherId, sessionNumber, status));


                    sessionNumber++;
                }
            }
        }

        private void PopulateDataGridView()
        {
            string attendanceStatus = "";
            foreach (var session in sessionData)
            {

                switch (session.status)
                {
                    case -1:
                        attendanceStatus = "Absent";
                        break;
                    case 0:
                        attendanceStatus = "Pending";
                        break;
                    case 1:
                        attendanceStatus = "Attend";
                        break;

                }
                studentGrid.Rows.Add(session.date, session.courseName, session.teacherId, session.sessionNumber, attendanceStatus);
            }
        }
        //end poplateData grid
        //start search section
        // but convert first status to string
        private string GetAttendanceStatusString(int status)
        {
            switch (status)
            {
                case -1:
                    return "Absent";
                case 0:
                    return "Pending";
                case 1:
                    return "Attend";
                default:
                    return "";
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = textSearch.Text.ToLower();


            studentGrid.Rows.Clear();


            var filteredSessions = sessionData.Where(session =>
                session.date.ToLower().Contains(searchText) ||
                session.courseName.ToLower().Contains(searchText) ||
                session.teacherId.ToLower().Contains(searchText) ||
                session.sessionNumber.ToString().Contains(searchText) ||
                GetAttendanceStatusString(session.status).ToLower().Contains(searchText)
            );

            //  filtered data
            foreach (var session in filteredSessions)
            {
                string attendanceStatus = GetAttendanceStatusString(session.status);
                studentGrid.Rows.Add(session.date, session.courseName, session.teacherId, session.sessionNumber, attendanceStatus);
            }
        }

       
      

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBoxMinm_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxLang_Click(object sender, EventArgs e)
        {
            string newCulture;

            if (lang.Text == "en")
            {
                lang.Text = "ar";
                newCulture = "en";
               
            }
            else
            {
                lang.Text = "en";
                newCulture = "ar";
            }

            // Change the current UI culture
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(newCulture);

       


            // Update the UI
            UpdateUI();
        }

        private void UpdateUI()
        {

            labelName.Text = $"{loggedUser.FirstName}  {loggedUser.LastName}   ^_^";
         labStdId.Text = loggedUser.Id;


            studentGrid.Rows.Clear();


            sessionData.Clear();
            LoadSessionDataForUser(loggedUser.Id);


            PopulateDataGridView();
        }
    }
}


