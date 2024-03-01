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
    public partial class ClassAdminForm : Form
    {
        private List<Class> classesList;
        private string role;
        public ClassAdminForm()
        {
            InitializeComponent();
            LoadClassIds();
        }

        private void LoadClassIds()
        {
            classesList = ClassParser.ParseClasses("../../../../class.xml");

            foreach (Class cls in classesList)
            {
                comboclassId.Items.Add(cls.ClassId);
            }
            LoadCourseIds();
        }
        private void LoadCourseIds()
        {
            foreach (Class cls in classesList)
            {
                comboCourseId.Items.Add(cls.CourseId);
            }
        }
        private void comboclassId_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DisplayClassData();
        }

        private void comboCourseId_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            DisplayClassData();
        }

        private void DisplayClassData()
        {
            string selectedClassId = comboclassId.SelectedItem?.ToString();
            string selectedCourseId = comboCourseId.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(selectedClassId) || string.IsNullOrWhiteSpace(selectedCourseId))
            {
                return;
            }

            Class selectedClass = classesList.Find(cls => cls.ClassId == selectedClassId && cls.CourseId == selectedCourseId);

            if (selectedClass != null)
            {
                // Display teacher ID in the TextBox
                teacherIdbox.Text = selectedClass.TeacherId;

                dataGridView1.Rows.Clear();

                // Ensure columns are defined
                if (dataGridView1.Columns.Count == 0)
                {
                    dataGridView1.Columns.Add("Class ID", "Class ID");
                    dataGridView1.Columns.Add("Course ID", "Course ID");
                    // dataGridView1.Columns.Add("Teacher ID", "Teacher ID");
                    dataGridView1.Columns.Add("Student ID", "Student ID");
                    dataGridView1.Columns.Add("Date", "Date");
                    dataGridView1.Columns.Add("Status", "Status");
                }
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.RowTemplate.Height = 60;
                foreach (StudentSessions studentSessions in selectedClass.StudentSessions)
                {
                    foreach (Session session in studentSessions.Sessions)
                    {
                        string statusText = GetStatusText(session.Status);
                        dataGridView1.Rows.Add(selectedClass.ClassId, selectedClass.CourseId, studentSessions.StudentId, session.Date, statusText);
                    }
                }
            }
            else
            {
                MessageBox.Show("Class not found.");
            }
        }

        private string GetStatusText(int status)
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
                    return "Unknown";
            }
        }

        private void button4_Click(object sender, EventArgs e) //teacher
        {
            role = "teacher";
            UserAdminForm teacherAdminForm = new UserAdminForm(role);
            teacherAdminForm.Role = role;
            teacherAdminForm.Show();
            Hide();
        }

        private void button7_Click(object sender, EventArgs e) //student
        {
            role = "student";
            UserAdminForm studentAdminForm = new UserAdminForm(role);
            studentAdminForm.Role = role;
            studentAdminForm.Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e) //courses
        {

            CourseAdminForm courseAdminForm = new CourseAdminForm();
            courseAdminForm.Show();
            Hide();
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the user's response
            if (result == DialogResult.Yes)
            {
                FormLogin formLogin = new FormLogin();
                formLogin.Show();

                this.Hide();

            }
        }

        private void closebox_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the user's response
            if (result == DialogResult.Yes)
            {
                FormLogin formLogin = new FormLogin();
                formLogin.Show();

                this.Hide();

            }
        }

        private void minimizebox_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
