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
using System.Xml;

namespace Attendance_Management_System.Forms
{
    public partial class StudentForm : Form
    {
        List<User> users;
        List<Student> students;
        Student loggedUser;
        private List<(string date, string courseName, string teacherId,int sessionNumber, int status)> sessionData = new List<(string date, string courseName, string teacherId,int sessionNumber, int status)>();

        public StudentForm()
        {
            InitializeComponent();
            users = UserParser.ParseUsers("../../../../users.xml");
            students = users.Where(u => u.Role == "student").Select(u => u as Student).ToList();
            if (students.Any())
            {
                loggedUser = students.First();
                LoadSessionDataForUser(loggedUser.Id);
                PopulateDataGridView();
            }

        
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            if (loggedUser != null)
            {
                labelName.Text = loggedUser.FirstName+" "+loggedUser.LastName;
                labelID.Text = loggedUser.Id;
                labelAge.Text =   loggedUser.Age.ToString();
                labelEmail.Text = loggedUser.Email;
                labelAddress.Text = loggedUser.Address;

            }
        }

        //get data for this user id
        private void LoadSessionDataForUser(string userId)
        {
        
            XmlDocument classesDoc = new XmlDocument();
            classesDoc.Load("../../../../class.xml"); 

            XmlNodeList classNodes = classesDoc.SelectNodes($"//class[studentId/@id='{userId}']");

         
            foreach (XmlNode classNode in classNodes)
            {
                string courseId = classNode.SelectSingleNode("courseId").InnerText;
                string teacherId = classNode.SelectSingleNode("teacherId").InnerText;

              
                XmlNodeList sessionNodes = classNode.SelectNodes($"studentId[@id='{userId}']/session");
                int sessionNumber = 1; 
                foreach (XmlNode sessionNode in sessionNodes)
                {
                    string date = sessionNode.SelectSingleNode("date").InnerText;
                    int status = int.Parse(sessionNode.SelectSingleNode("status").InnerText);

                
                    sessionData.Add((date, courseId, teacherId, sessionNumber, status));

                   
                    sessionNumber++;
                }
            }
        }

        private void PopulateDataGridView()
        {
            string attendanceStatus="";
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
                studentGrid.Rows.Add(session.date, session.courseName, session.teacherId,session.sessionNumber, attendanceStatus);
            }
        }
    }

}
