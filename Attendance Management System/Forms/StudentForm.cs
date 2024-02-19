using Attendance_Management_System.classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace Attendance_Management_System.Forms
{
    public partial class StudentForm : Form
    {
        private Student loggedUser;
        private List<(string date, string courseName, string teacherId, int sessionNumber, string status)> sessionData = new List<(string date, string courseName, string teacherId, int sessionNumber, string status)>();

        public StudentForm()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            loggedUser = FormLogin.meStudent;
            LoadSessionDataForUser(loggedUser.Id);
            PopulateDataGridView();
            textSearch.TextChanged += TxtSearch_TextChanged;
            CreateCourseButtons();
            UpdateUserInfo();
        }

        private void LoadSessionDataForUser(string userId)
        {
            XmlDocument classesDoc = new XmlDocument();
            classesDoc.Load("../../../../class.xml");

            XmlDocument coursesDoc = new XmlDocument();
            coursesDoc.Load("../../../../courses.xml");

            XmlNodeList classNodes = classesDoc.SelectNodes($"//class[studentId/@id='{userId}']");

            foreach (XmlNode classNode in classNodes)
            {
                string courseId = classNode.SelectSingleNode("courseId").InnerText;
                string teacherId = classNode.SelectSingleNode("teacherId").InnerText;

                XmlNode courseNode = coursesDoc.SelectSingleNode($"//course[courseId='{courseId}']");
                string courseName = courseNode.SelectSingleNode("courseName").InnerText;

                XmlNodeList sessionNodes = classNode.SelectNodes($"studentId[@id='{userId}']/session");
                int sessionNumber = 1;

                foreach (XmlNode sessionNode in sessionNodes)
                {
                    string date = sessionNode.SelectSingleNode("date").InnerText;
                    string status = sessionNode.SelectSingleNode("status").InnerText;

                    sessionData.Add((date, courseName, teacherId, sessionNumber, status));
                    sessionNumber++;
                }
            }
        }

        private void PopulateDataGridView()
        {
            studentGrid.Rows.Clear();

            foreach (var session in sessionData)
            {
                string attendanceStatus = GetAttendanceStatusString(session.status);
                studentGrid.Rows.Add(session.date, session.courseName, session.teacherId, session.sessionNumber, attendanceStatus);
            }
        }

        private string GetAttendanceStatusString(string status)
        {
            switch (status)
            {
                case "-1":
                    return "Absent";
                case "0":
                    return "Pending";
                case "1":
                    return "Attend";
                default:
                    return status;
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = textSearch.Text.ToLower();
            var filteredSessions = sessionData.Where(session =>
                session.date.ToLower().Contains(searchText) ||
                session.courseName.ToLower().Contains(searchText) ||
                session.teacherId.ToLower().Contains(searchText) ||
                session.sessionNumber.ToString().Contains(searchText) ||
                GetAttendanceStatusString(session.status).ToLower().Contains(searchText)
            );

            UpdateDataGridView(filteredSessions.ToList());
        }

        private void UpdateUserInfo()
        {
            if (loggedUser != null)
            {
                labelName.Text = $"{loggedUser.FirstName}  {loggedUser.LastName}   ^_^";
                labStdId.Text = loggedUser.Id;
            }
        }

        private void CreateCourseButtons()
        {
            int buttonWidth = panelCourses.Width - 20;
            int buttonHeight = 40;
            int buttonSpacing = 5;
            int buttonTop = 280;

            foreach (var session in sessionData)
            {
                string courseName = session.courseName;

                if (!panelCourses.Controls.ContainsKey(courseName))
                {
                    Button btnCourse = new Button
                    {
                        Name = courseName,
                        Text = courseName,
                        AutoSize = false,
                        Size = new Size(buttonWidth, buttonHeight),
                        Location = new Point(5, buttonTop),
                        BackColor = Color.White
                    };

                    btnCourse.Click += (sender, e) => { CourseButton_Click(sender, e, courseName); };
                    panelCourses.Controls.Add(btnCourse);
                    buttonTop += buttonHeight + buttonSpacing;
                }
            }
        }

        private void CourseButton_Click(object sender, EventArgs e, string courseName)
        {
            var filteredSessions = sessionData.Where(session => session.courseName == courseName);
            UpdateDataGridView(filteredSessions.ToList());
        }

        private void UpdateDataGridView(List<(string date, string courseName, string teacherId, int sessionNumber, string status)> filteredSessions)
        {
            studentGrid.Rows.Clear();

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
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxLang_Click(object sender, EventArgs e)
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
            UpdateUserInfo();
            PopulateDataGridView();
        }
    }
}
