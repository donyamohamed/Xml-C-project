using Attendance_Management_System.classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Xsl;

namespace Attendance_Management_System.Forms
{
    public partial class StudentForm : Form
    {
        private Student loggedUser;
        private List<(string date, string courseName, string teacherName, int sessionNumber, string status)> sessionData = new List<(string date, string courseName, string teacherName, int sessionNumber, string status)>();

        public StudentForm()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(Program.newCulture);
            InitializeForm();
        }
        private void InitializeForm()
        {
            loggedUser = FormLogin.meStudent;
           
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(Program.newCulture);
            UpdateLanguage(); // Call the method to update the language
            InitializeFormComponents();
        }

        private void InitializeFormComponents()
        {
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

            XmlDocument usersDoc = new XmlDocument();
            usersDoc.Load("../../../../users.xml");

            XmlNodeList classNodes = classesDoc.SelectNodes($"//class[studentId/@id='{userId}']");

            foreach (XmlNode classNode in classNodes)
            {
                string courseId = classNode.SelectSingleNode("courseId").InnerText;
                string teacherId = classNode.SelectSingleNode("teacherId").InnerText;
              


                XmlNode courseNode = coursesDoc.SelectSingleNode($"//course[courseId='{courseId}']");
                string courseName = courseNode.SelectSingleNode("courseName").InnerText;

                // Retrieve teacher's name using teacher ID
               
             
                XmlNode teacherNode = usersDoc.SelectSingleNode($"//user[id='{teacherId}']");
              

                string teacherName = $"{teacherNode.SelectSingleNode("fname").InnerText} {teacherNode.SelectSingleNode("lname").InnerText}";


                XmlNodeList sessionNodes = classNode.SelectNodes($"studentId[@id='{userId}']/session");
                int sessionNumber = 1;

                foreach (XmlNode sessionNode in sessionNodes)
                {
                    string date = sessionNode.SelectSingleNode("date").InnerText;
                    string status = sessionNode.SelectSingleNode("status").InnerText;

                    sessionData.Add((date, courseName, teacherName, sessionNumber, status));
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
                studentGrid.Rows.Add(session.date, session.courseName, session.teacherName, session.sessionNumber, attendanceStatus);
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
                session.teacherName.ToLower().Contains(searchText) ||
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
            butReport.Tag = courseName;

        }

        private void UpdateDataGridView(List<(string date, string courseName, string teacherName, int sessionNumber, string status)> filteredSessions)
        {
            studentGrid.Rows.Clear();

            foreach (var session in filteredSessions)
            {
                string attendanceStatus = GetAttendanceStatusString(session.status);
                studentGrid.Rows.Add(session.date, session.courseName, session.teacherName, session.sessionNumber, attendanceStatus);
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
            if(Program.newCulture == "en")
            {
                Program.newCulture = "ar";
                InitializeComponent();
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(Program.newCulture);
                InitializeForm();
            } else if (Program.newCulture == "ar")
            {
                Program.newCulture = "en";
                InitializeComponent();
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(Program.newCulture);
                InitializeForm();
            }
            // lang.Text = (lang.Text == "en") ? "ar" : "en";
            // UpdateLanguage();
        }

        private void UpdateLanguage()
        {
            string newCulture = (lang.Text == "en") ? "ar" : "en";
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(newCulture);
            CultureInfo.CurrentCulture = new CultureInfo(newCulture);
            CultureInfo.CurrentUICulture = new CultureInfo(newCulture);
            // UpdateUserInfo();
            this.InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.gif)|*.jpg;*.jpeg;*.png;*.gif|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            openFileDialog.Title = "Select an image";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        // start handle report
        private string GenerateXSLTTemplate(string userName, string userId, string selectedCourseName, bool includeCourseFilter, List<(string date, string courseName, string teacherName, int sessionNumber, string status)> sessionData)
        {
            StringBuilder xsltBuilder = new StringBuilder();

            xsltBuilder.Append("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
            xsltBuilder.Append("<xsl:stylesheet version=\"1.0\" xmlns:xsl=\"http://www.w3.org/1999/XSL/Transform\">");

            xsltBuilder.Append($"<xsl:param name=\"userName\" select=\"'{userName}'\" />");
            xsltBuilder.Append($"<xsl:param name=\"userId\" select=\"'{userId}'\" />");
            xsltBuilder.Append($"<xsl:param name=\"selectedCourseName\" select=\"'{selectedCourseName}'\" />");

            xsltBuilder.Append("<xsl:template match=\"/\">");
            xsltBuilder.Append("<html>");
            xsltBuilder.Append("<head>");
            xsltBuilder.Append("<title>Attendance Report</title>");
            xsltBuilder.Append("<link rel=\"stylesheet\" type=\"text/css\" href=\"styles.css\"/>");
            xsltBuilder.Append("</head>");
            xsltBuilder.Append("<body>");
            xsltBuilder.Append("<h1>Attendance Report</h1>");
            xsltBuilder.Append("<p>Student Name: <xsl:value-of select=\"$userName\"/></p>");
            xsltBuilder.Append("<p>Student ID: <xsl:value-of select=\"$userId\"/></p>");

            // Check if selectedCourseName is not empty
            if (!string.IsNullOrEmpty(selectedCourseName))
            {
                xsltBuilder.Append("<p>Course Name: <xsl:value-of select=\"$selectedCourseName\"/></p>");
            }

            if (includeCourseFilter)
            {
                xsltBuilder.Append("<table>");
                xsltBuilder.Append("<tr><th>Date</th><th>Course Name</th><th>Teacher Name</th><th>Session Number</th><th>Status</th></tr>");
                foreach (var session in sessionData)
                {
                    if (string.IsNullOrEmpty(selectedCourseName) || session.courseName == selectedCourseName)
                    {
                        xsltBuilder.Append($"<tr><td>{session.date}</td><td>{session.courseName}</td><td>{session.teacherName}</td><td>{session.sessionNumber}</td><td>{GetAttendanceStatusString(session.status)}</td></tr>");
                    }
                }
                xsltBuilder.Append("</table>");
            }
            else
            {
                xsltBuilder.Append("<p>All Sessions:</p>");
                xsltBuilder.Append("<ul>");
                foreach (var session in sessionData)
                {
                    if (string.IsNullOrEmpty(selectedCourseName) || session.courseName == selectedCourseName)
                    {
                        xsltBuilder.Append($"<li>Date: {session.date}, Course Name: {session.courseName}, Teacher Name: {session.teacherName}, Session Number: {session.sessionNumber}, Status: {GetAttendanceStatusString(session.status)}</li>");
                    }
                }
                xsltBuilder.Append("</ul>");
            }

            xsltBuilder.Append("</body></html>");
            xsltBuilder.Append("</xsl:template>");

            xsltBuilder.Append("</xsl:stylesheet>");

            return xsltBuilder.ToString();
        }








        private void butReport_Click(object sender, EventArgs e)
        {
            string selectedCourseName = butReport.Tag as string;

            string userName = loggedUser.FirstName + " " + loggedUser.LastName;
            string userId = loggedUser.Id;

            try
            {
                bool includeCourseFilter = true;

                string xsltTemplate = GenerateXSLTTemplate(userName, userId, selectedCourseName, includeCourseFilter, sessionData);

                string xmlFilePath = "../../../../class.xml";
                string xmlFileDirectory = Path.GetDirectoryName(xmlFilePath);
                string folderPath = Path.Combine(xmlFileDirectory, "student Reports");
                Directory.CreateDirectory(folderPath);

                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(xmlFilePath);

                StringBuilder htmlReport = new StringBuilder();
                using (StringWriter sw = new StringWriter(htmlReport))
                {
                    XslCompiledTransform xsltTransform = new XslCompiledTransform();
                    xsltTransform.Load(new XmlTextReader(new StringReader(xsltTemplate)));
                    xsltTransform.Transform(xmlDoc, null, sw);
                }

                string currentDate = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
                string htmlFileName = $"report_{currentDate}.html";
                string savePath = Path.Combine(folderPath, htmlFileName);

                File.WriteAllText(savePath, htmlReport.ToString());

                MessageBox.Show("HTML report has been successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating or saving report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void StudentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
