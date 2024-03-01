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
    public partial class CourseAdminForm : Form
    {
        private DataTable originalDataTable;
        private string role;
        private List<Course> coursesData = CourseParser.ParseCourses("../../../../courses.xml");

        public CourseAdminForm()
        {
            InitializeComponent();
            LoadAndDisplayCourseData();
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        }
        private void LoadAndDisplayCourseData()
        {
            try
            {
                originalDataTable = new DataTable();
                originalDataTable.Columns.Add("Course ID", typeof(string));
                originalDataTable.Columns.Add("Course Name", typeof(string));
                originalDataTable.Columns.Add("Sessions Number", typeof(int));
                originalDataTable.Columns.Add("Description", typeof(string));
                originalDataTable.Columns.Add("Update", typeof(Image));

                Image updateImage = Properties.Resources.update;
                int imageSize = 21;
                Image smallUpdateImage = new Bitmap(updateImage, new Size(imageSize, imageSize));

                foreach (Course course in coursesData)
                {
                    originalDataTable.Rows.Add(course.Id, course.Name, course.Numberofsessions, course.Description, smallUpdateImage);
                }

                dataGridView1.DataSource = originalDataTable;

                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; 
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                dataGridView1.RowTemplate.Height = 60;
                dataGridView1.ReadOnly = true;
                FilterOutEmptyRows();

                ((DataGridViewImageColumn)dataGridView1.Columns["Update"]).ImageLayout = DataGridViewImageCellLayout.Zoom;

                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                dataGridView1.ReadOnly = true;
                FilterOutEmptyRows();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading and displaying course data: " + ex.Message);
            }
        }

        private void FilterOutEmptyRows()
        {
            for (int i = dataGridView1.Rows.Count - 1; i >= 0; i--)
            {
                DataGridViewRow row = dataGridView1.Rows[i];
                bool isEmpty = true;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && !string.IsNullOrEmpty(cell.Value.ToString()))
                    {
                        isEmpty = false;
                        break;
                    }
                }

                if (isEmpty)
                {
                    dataGridView1.Rows.RemoveAt(i);
                }
            }
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            string searchText = search.Text.ToLower();

            if (!string.IsNullOrEmpty(searchText))
            {
                DataTable filteredDataTable = originalDataTable.Clone();

                foreach (DataRow row in originalDataTable.Rows)
                {
                    if (row.ItemArray.Any(columnValue => columnValue.ToString().ToLower().Contains(searchText)))
                    {
                        if (row.ItemArray.Any(value => !string.IsNullOrEmpty(value.ToString())))
                        {
                            filteredDataTable.Rows.Add(row.ItemArray);
                        }
                    }
                }

                dataGridView1.DataSource = filteredDataTable;
            }
            else
            {
                dataGridView1.DataSource = originalDataTable;
            }
        }

        private void addcourse_Click(object sender, EventArgs e)
        {
            InsertOrUpdateCourse(null, "insert");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is the "Update" cell
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Update"].Index)
            {
                string courseId = dataGridView1.Rows[e.RowIndex].Cells["Course ID"].Value.ToString();
                Course courseToUpdate = coursesData.Find(c => c.Id == courseId);

                if (courseToUpdate != null)
                {
                    InsertCourseForm updateCourseForm = new InsertCourseForm(coursesData, "update", courseToUpdate);
                    updateCourseForm.FormClosed += (s, ev) => LoadAndDisplayCourseData(); // Reload data after update
                    updateCourseForm.ShowDialog();
                }
            }
        }

        private void InsertOrUpdateCourse(Course courseToUpdate, string action)
        {
            InsertCourseForm insertCourseForm = new InsertCourseForm(coursesData, action, courseToUpdate);
            insertCourseForm.ShowDialog();
            LoadAndDisplayCourseData();
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

        private void button4_Click(object sender, EventArgs e) //teacher btn
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

        private void button5_Click(object sender, EventArgs e) //class
        {
           
            ClassAdminForm classAdminForm = new ClassAdminForm();
            classAdminForm.Show();
            Hide();
        }
    }
}
