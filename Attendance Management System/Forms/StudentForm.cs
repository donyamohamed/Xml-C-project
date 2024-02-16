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

namespace Attendance_Management_System.Forms
{
    public partial class StudentForm : Form
    {
        List<User> users;
        List<Student> students;
        Student loggedUser;
        public StudentForm()
        {
            InitializeComponent();
            users = UserParser.ParseUsers("../../../../users.xml");
            students = users.Where(u => u.Role == "student").Select(u => u as Student).ToList();
            if (students.Any())
            {
                loggedUser = students.First();
            }
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            if (loggedUser != null)
            {
                labelName.Text = loggedUser.FirstName+" "+loggedUser.LastName;
                labelID.Text = loggedUser.Id;
            }
        }
    }
}
