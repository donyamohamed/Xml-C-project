// InsertCourseForm

using Attendance_Management_System.classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Attendance_Management_System.Forms
{
    public partial class InsertCourseForm : Form
    {
        private List<Course> coursesList = new List<Course>();
        private Course courseToUpdate;

        public InsertCourseForm(List<Course> listcourses, string action, Course courseToUpdate)
        {
            InitializeComponent();
            formGoal.Text = action;
            coursesList = listcourses;
            this.courseToUpdate = courseToUpdate;

            for (int i = 1; i <= 10; i++)
            {
                combosessionnumber.Items.Add(i.ToString());
            }

            if (courseToUpdate != null)
            {
                TexcourseID.Text = courseToUpdate.Id;
                texname.Text = courseToUpdate.Name;
                texdescription.Text = courseToUpdate.Description;
                combosessionnumber.SelectedItem = courseToUpdate.Numberofsessions.ToString();
            }
            else
            {
                TexcourseID.Text = GenerateCourseId();
            }
        }

        private string GenerateCourseId()
        {
            int nextCourseNumber = GetNextCourseNumber();
            return nextCourseNumber + "C";
        }

        private int GetNextCourseNumber()
        {
            if (coursesList.Count == 0)
            {
                return 1;
            }
            else
            {
                int maxId = coursesList.Max(u => int.Parse(u.Id.Substring(0, u.Id.Length - 1)));
                return (maxId + 1);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string courseName = texname.Text;
            string description = texdescription.Text;

            if (string.IsNullOrWhiteSpace(courseName))
            {
                MessageBox.Show("Please enter Course Name.");
                return;
            }

            if (!int.TryParse(combosessionnumber.SelectedItem?.ToString(), out int sessionsNumber))
            {
                MessageBox.Show("Invalid number of sessions. Please select a valid value.");
                return;
            }

            if (courseToUpdate != null)
            {
                courseToUpdate.Name = courseName;
                courseToUpdate.Description = description;
                courseToUpdate.Numberofsessions = sessionsNumber;

                CourseParser.SaveCoursesAsXml(coursesList, "../../../../courses.xml");

                MessageBox.Show("Course updated successfully.");
            }
            else
            {
                Course newCourse = new Course
                {
                    Id = GenerateCourseId(),
                    Name = courseName,
                    Description = description,
                    Numberofsessions = sessionsNumber
                };

                coursesList.Add(newCourse);
                CourseParser.SaveCoursesAsXml(coursesList, "../../../../courses.xml");

                MessageBox.Show("Course added successfully.");
            }

            this.Close();
        }
    }
}
