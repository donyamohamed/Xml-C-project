using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq; // Add this namespace for LINQ
using System.Windows.Forms;
using Attendance_Management_System.classes;

namespace Attendance_Management_System.Forms
{
    public partial class classAdmin : Form
    {
        private List<classes.Class> classes1;
        private DataTable dataTable; // Move the DataTable to a class level variable

        public classAdmin()
        {
            InitializeComponent();

            // Call a method to load data from XML to DataGridView
            LoadDataFromXML();

            // Attach event handlers
            dataGridView1.RowsAdded += DataGridView1_RowsAdded;
            dataGridView1.RowsRemoved += DataGridView1_RowsRemoved;
            dataGridView1.CellValueChanged += DataGridView1_CellValueChanged;
        }

        private void LoadDataFromXML()
        {
            try
            {
                // Use the ClassParser to retrieve data from XML
                classes1 = ClassParser.ParseClasses("../../../../class.xml");

                // Initialize the DataTable
                dataTable = new DataTable();

                // Add columns to the DataTable
                dataTable.Columns.Add("Class ID", typeof(string));
                dataTable.Columns.Add("Course ID", typeof(string));
                dataTable.Columns.Add("Teacher ID", typeof(string));
                dataTable.Columns.Add("Student ID", typeof(string));
                dataTable.Columns.Add("Session Date", typeof(DateTime));
                dataTable.Columns.Add("Session Status", typeof(int));
                dataTable.Columns.Add("Delete", typeof(Image)); // Column for delete icon
                dataTable.Columns.Add("Update", typeof(Image)); // Column for update icon

                // Populate the DataTable with data from the List of Class objects
                foreach (Class classInfo in classes1)
                {
                    foreach (StudentSessions studentSessions in classInfo.StudentSessions)
                    {
                        foreach (Session session in studentSessions.Sessions)
                        {
                            // Scale the image to 50x50 (you can adjust the size as needed)
                            Image scaledImage = ScaleImage(Properties.Resources.DeleteIcon, 50, 50);

                            dataTable.Rows.Add(classInfo.ClassId, classInfo.CourseId, classInfo.TeacherId, studentSessions.StudentId, session.Date, session.Status, scaledImage, scaledImage);
                        }
                    }
                }

                // Check if there is at least one row in the DataTable
                if (dataTable.Rows.Count > 0)
                {
                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dataTable;

                    // Set row height and column width
                    dataGridView1.RowTemplate.Height = 70; // Adjust the row height as needed
                    dataGridView1.Columns["Delete"].Width = 70; // Adjust the column width as needed
                    dataGridView1.Columns["Update"].Width = 70; // Adjust the column width as needed
                }
                else
                {
                    MessageBox.Show("No data found in the XML file.");
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
            // Implement the case-insensitive search functionality
            string searchText = textBox1.Text.ToLower(); // Convert search text to lowercase

            try
            {
                if (!string.IsNullOrEmpty(searchText))
                {
                    // Use LINQ to filter rows based on the case-insensitive search text
                    var filteredRows = dataTable.AsEnumerable()
                        .Where(row => row.ItemArray.Any(field => field.ToString().ToLower().Contains(searchText)))
                        .CopyToDataTable();

                    dataGridView1.DataSource = filteredRows;
                }
                else
                {
                    // If the search text is empty, display all rows
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (InvalidOperationException ex)
            {
                // Handle the exception when CopyToDataTable has no matching rows
                dataGridView1.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during search: " + ex.Message);
            }
        }


        private void classAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}