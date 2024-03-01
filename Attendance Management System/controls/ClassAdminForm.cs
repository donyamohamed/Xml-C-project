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

namespace Attendance_Management_System.controls
{
    public partial class ClassAdminForm : UserControl
    {
        private List<Class> classesList;
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
        private void comboCourseId_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayClassData();
        }

        private void comboClassId_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayClassData();
        }



        private void teacherIdbox_TextChanged(object sender, EventArgs e)
        {

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


    }
}