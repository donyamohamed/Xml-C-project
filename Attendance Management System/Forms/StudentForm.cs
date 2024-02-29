using Attendance_Management_System.classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
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
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(Program.appLanguage);

            InitializeForm();
            timer1.Start();
        }

        private void InitializeForm()
        {
            loggedUser = FormLogin.meStudent;
            LoadSessionDataForUser(loggedUser.Id);
            PopulateDataGridView();
            CreateCourseButtons();
            UpdateUserInfo();

            // hide all btn and disaple generate btn if no courses
            if (studentGrid.Rows.Count == 0)
            {
                MessageBox.Show("You Didn't Join To Any Courses Yet!");
                Button allCourse = panelCourses.Controls["allCourses"] as Button;
                if (allCourse != null)
                {
                    allCourse.Visible = false;
                }

         
                butReport.Enabled = false;
            }
            else
            {
              
                butReport.Enabled = true;
            }
        }

        private string GetDateFormatFromConfig()
        {
            string xmlFilePath = "../../../appConfigurations/appConfigurations.xml";
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlFilePath);

            // Retrieve the date format from the configuration XML
            string dateFormat = xmlDoc.SelectSingleNode("//DateFormat")?.InnerText;
            return dateFormat;
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
                string courseId = classNode.SelectSingleNode("courseId")?.InnerText;
                string teacherId = classNode.SelectSingleNode("teacherId")?.InnerText;

                XmlNode courseNode = coursesDoc.SelectSingleNode($"//course[courseId='{courseId}']");
                string courseName = courseNode.SelectSingleNode("courseName").InnerText;

                XmlNode teacherNode = usersDoc?.SelectSingleNode($"//user[id='{teacherId}']");
                string teacherName = $"{teacherNode?.SelectSingleNode("fname").InnerText} {teacherNode.SelectSingleNode("lname")?.InnerText}";

                XmlNodeList sessionNodes = classNode.SelectNodes($"studentId[@id='{userId}']/session");
                int sessionNumber = 1;

                foreach (XmlNode sessionNode in sessionNodes)
                {
                    string date = sessionNode.SelectSingleNode("date")?.InnerText;
                    string status = sessionNode.SelectSingleNode("status")?.InnerText;

                    sessionData.Add((date, courseName, teacherName, sessionNumber, status));
                    sessionNumber++;
                }
            }
        }

        private void PopulateDataGridView()
        {
            string dateFormat = GetDateFormatFromConfig();
            studentGrid.Rows.Clear();

            foreach (var session in sessionData)
            {
                DateTime date = DateTime.ParseExact(session.date, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                string formattedDate = date.ToString(dateFormat);

                string attendanceStatus = GetAttendanceStatusString(session.status);
                studentGrid.Rows.Add(formattedDate, session.courseName, session.teacherName, session.sessionNumber, attendanceStatus);
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

        private void UpdateUserInfo()
        {
            if (loggedUser != null)
            {
                labelName.Text = $"{loggedUser.FirstName}  {loggedUser.LastName}  ";
                labStdId.Text = loggedUser.Id;
            }
        }

        private void CreateCourseButtons()
        {
            int buttonWidth = panelCourses.Width - 20;
            int buttonHeight = 40;
            int buttonSpacing = 5;
            int buttonTop = 330;

            Button allCourse = new Button
            {
                Name = "allCourses",
                Text = "All",
                AutoSize = false,
                Size = new Size(buttonWidth, buttonHeight),
                Location = new Point(5, 285),
                BackColor = Color.White
            };
            panelCourses.Controls.Add(allCourse);

            allCourse.Click += (sender, e) => { PopulateDataGridView(); butReport.Tag = null; };


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
        
       

        private void butReport_Click(object sender, EventArgs e)
        {
            string selectedCourseName = butReport.Tag as string;

            string userName = loggedUser.FirstName + " " + loggedUser.LastName;
            string userId = loggedUser.Id;

            try
            {
                bool includeCourseFilter = true;

              
                string xsltTemplate = XsltGenerator.GenerateXSLTTemplateForStudent(userName, userId, selectedCourseName, includeCourseFilter, sessionData);

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            labTimeDate.Text = DateTime.Now.ToString();
        }

        private void picLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin loginForm = new FormLogin();
            loginForm.Show();
        }
    }
}
