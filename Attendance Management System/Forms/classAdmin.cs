using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Attendance_Management_System.classes;

namespace Attendance_Management_System.Forms
{
    public partial class classAdmin : Form
    {
        private List<classes.Class> classesData;
        private List<Course> coursesData;
        private DataTable classDataTable;
        private DataTable courseDataTable;

        public classAdmin()
        {
            InitializeComponent();

            // Attach event handlers
            dataGridView1.RowsAdded += DataGridView1_RowsAdded;
            dataGridView1.RowsRemoved += DataGridView1_RowsRemoved;
            dataGridView1.CellValueChanged += DataGridView1_CellValueChanged;

            // Load data from XML
            LoadDataFromXML();
        }

        private void LoadDataFromXML()
        {
            try
            {
                // Load class data
                classesData = ClassParser.ParseClasses("../../../../class.xml");

                // Initialize class DataTable
                classDataTable = new DataTable();
                classDataTable.Columns.Add("Class ID", typeof(string));
                classDataTable.Columns.Add("Course ID", typeof(string));
                classDataTable.Columns.Add("Teacher ID", typeof(string));
                classDataTable.Columns.Add("Student ID", typeof(string));
                classDataTable.Columns.Add("Session Date", typeof(DateTime));
                classDataTable.Columns.Add("Session Status", typeof(int));
                classDataTable.Columns.Add("Delete", typeof(Image)); // Column for delete icon
                classDataTable.Columns.Add("Update", typeof(Image)); // Column for update icon

                // Populate class DataTable with data from classesData

                string previousClassId = null;

                foreach (Class classInfo in classesData)
                {
                    foreach (StudentSessions studentSessions in classInfo.StudentSessions)
                    {
                        foreach (Session session in studentSessions.Sessions)
                        {
                            // Scale the image to 50x50 (you can adjust the size as needed)
                            Image deleteImage = ScaleImage(Properties.Resources.DeleteIcon, 50, 50);
                            Image updateImage = ScaleImage(Properties.Resources.DeleteIcon, 50, 50);

                            // Create a new row for each session
                            DataRow row = classDataTable.Rows.Add(
                                classInfo.ClassId,
                                classInfo.CourseId,
                                classInfo.TeacherId,
                                studentSessions.StudentId,
                                session.Date,
                                session.Status
                            );

                            // Add buttons for "Delete" and "Update" only for the first row of each class
                            if (previousClassId != classInfo.ClassId)
                            {
                                DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
                                deleteButton.Name = "Delete";
                                deleteButton.Text = "Delete";
                                deleteButton.UseColumnTextForButtonValue = true;
                                dataGridView1.Columns.Insert(0, deleteButton);

                                DataGridViewButtonColumn updateButton = new DataGridViewButtonColumn();
                                updateButton.Name = "Update";
                                updateButton.Text = "Update";
                                updateButton.UseColumnTextForButtonValue = true;
                                dataGridView1.Columns.Insert(1, updateButton);

                                // Set the images for the first row
                                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["Delete"].Value = deleteImage;
                                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["Update"].Value = updateImage;

                                previousClassId = classInfo.ClassId;
                            }
                            else
                            {
                                // For subsequent sessions of the same class, add empty cells for "Delete" and "Update"
                                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["Delete"].Value = "";
                                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["Update"].Value = "";
                            }
                        }
                    }
                }

                // ... (existing code)

                // Check if there is at least one row in class DataTable
                if (classDataTable.Rows.Count > 0)
                {
                    // Bind class DataTable to the DataGridView
                    dataGridView1.DataSource = classDataTable;

                    // Set row height and column width
                    dataGridView1.RowTemplate.Height = 70; // Adjust the row height as needed
                    dataGridView1.Columns["Delete"].Width = 70; // Adjust the column width as needed
                    dataGridView1.Columns["Update"].Width = 70; // Adjust the column width as needed
                }
                else
                {
                    MessageBox.Show("No data found in the class XML file.");
                }

                // Load course data
                coursesData = CourseParser.ParseCourses("../../../../courses.xml");

                // Initialize course DataTable
                courseDataTable = new DataTable();
                courseDataTable.Columns.Add("Course ID", typeof(string));
                courseDataTable.Columns.Add("Course Name", typeof(string));
                courseDataTable.Columns.Add("Sessions Number", typeof(int));
                courseDataTable.Columns.Add("Description", typeof(string));

                // Populate course DataTable with data from coursesData
                foreach (Course course in coursesData)
                {
                    courseDataTable.Rows.Add(course.Id, course.Name, course.Numberofsessions, course.Description);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        // Helper method to scale the image
        private Image ScaleImage(Image image, int maxWidth, int maxHeight)
        {
            double ratioX = (double)maxWidth / image.Width;
            double ratioY = (double)maxHeight / image.Height;
            double ratio = Math.Min(ratioX, ratioY);

            int newWidth = (int)(image.Width * ratio);
            int newHeight = (int)(image.Height * ratio);

            Bitmap newImage = new Bitmap(newWidth, newHeight);
            using (Graphics g = Graphics.FromImage(newImage))
            {
                g.DrawImage(image, 0, 0, newWidth, newHeight);
            }

            return newImage;
        }

        private void DataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            // Handle rows added event
            // You can perform actions when rows are added here
            //MessageBox.Show("Rows Added: " + e.RowCount);
        }

        private void DataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            // Handle rows removed event
            // You can perform actions when rows are removed here
            // MessageBox.Show("Rows Removed: " + e.RowCount);
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell value changed event
            // You can perform actions when cell values are changed here
            // MessageBox.Show("Cell Value Changed: Row " + e.RowIndex + ", Column " + e.ColumnIndex);
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox1.Text.ToLower();

            try
            {
                DataTable currentTable = GetCurrentDataTable();

                if (currentTable != null)
                {
                    // Create a BindingSource and set its DataSource to the current DataTable
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = currentTable;

                    if (!string.IsNullOrEmpty(searchText))
                    {
                        // Apply a filter to the BindingSource using LINQ
                        bindingSource.Filter = GetFilterExpression(currentTable, searchText);
                    }
                    else
                    {
                        // Clear the filter
                        bindingSource.RemoveFilter();
                    }

                    // Bind the DataGridView to the filtered BindingSource
                    dataGridView1.DataSource = bindingSource;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during search: " + ex.Message);
            }
        }




        private DataTable ApplyFilter(DataTable table, string searchText)
        {
            // Create a new DataTable to store the filtered rows
            DataTable filteredTable = table.Clone();

            // Iterate through each row in the original DataTable
            foreach (DataRow row in table.Rows)
            {
                // Check if any column contains the search text
                if (row.ItemArray.Any(field => field.ToString().ToLower().Contains(searchText)))
                {
                    // Add the row to the filtered DataTable
                    filteredTable.ImportRow(row);
                }
            }

            return filteredTable;
        }


        private string GetFilterExpression(DataTable table, string searchText)
        {
            // Generate a filter expression for the given search text
            List<string> filterExpressions = new List<string>();

            foreach (DataColumn column in table.Columns)
            {
                filterExpressions.Add($"CONVERT([{column.ColumnName}], 'System.String') LIKE '%{searchText}%'");
            }

            return string.Join(" OR ", filterExpressions);
        }

        private DataTable GetCurrentDataTable()
        {
            // Determine which DataTable is currently being displayed
            if (dataGridView1.DataSource == classDataTable)
            {
                return classDataTable;
            }
            else if (dataGridView1.DataSource == courseDataTable)
            {
                return courseDataTable;
            }

            return null;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                // Display the class data in DataGridView
                dataGridView1.DataSource = classDataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading class data: " + ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                // Display the course data in DataGridView
                dataGridView1.DataSource = courseDataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading course data: " + ex.Message);
            }
        }

        private void classAdmin_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
