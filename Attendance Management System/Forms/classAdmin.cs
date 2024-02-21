using System;
using System.Data;
using System.Windows.Forms;
using Attendance_Management_System.classes;

namespace Attendance_Management_System.Forms
{
    public partial class classAdmin : Form
    {
        public classAdmin()
        {
            InitializeComponent();

            // Call a method to load data from XML to DataGridView
            LoadDataFromXML();
        }

        private void LoadDataFromXML()
        {
            // Create a DataSet to hold the data
            DataSet dataSet = new DataSet();

            try
            {
                // Use the ClassParser to retrieve data from XML
                List<Class> classes = ClassParser.ParseClasses("../../../../class.xml");

                // Convert the list of Class objects to a DataTable
                DataTable classDataTable = ConvertToDataTable(classes);

                // Check if there is at least one row in the DataTable
                if (classDataTable.Rows.Count > 0)
                {
                    // Set up a DataRelation between Classes and StudentId
                    DataRelation relation = new DataRelation("Classes_StudentId",
                        classDataTable.Columns["classId"],
                        classDataTable.Columns["studentId"]);
                    dataSet.Relations.Add(relation);

                    // Bind the root table (Classes) to the DataGridView
                    dataGridView1.DataSource = classDataTable;
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

        private DataTable ConvertToDataTable(List<Class> classes)
        {
            DataTable dataTable = new DataTable();

            // Add columns to the DataTable
            dataTable.Columns.Add("classId", typeof(string));
            dataTable.Columns.Add("courseId", typeof(string));
            dataTable.Columns.Add("teacherId", typeof(string));
            dataTable.Columns.Add("studentId", typeof(string));
            dataTable.Columns.Add("sessionDate", typeof(DateTime));
            dataTable.Columns.Add("sessionStatus", typeof(int));

            // Populate the DataTable with data from the List of Class objects
            foreach (Class classInfo in classes)
            {
                foreach (StudentSessions studentSessions in classInfo.StudentSessions)
                {
                    foreach (Session session in studentSessions.Sessions)
                    {
                        dataTable.Rows.Add(classInfo.ClassId, classInfo.CourseId, classInfo.TeacherId, studentSessions.StudentId, session.Date, session.Status);
                    }
                }
            }

            return dataTable;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell content click event if needed
        }
    }
}
