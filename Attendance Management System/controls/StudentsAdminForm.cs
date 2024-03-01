using Attendance_Management_System.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Attendance_Management_System.Forms;

namespace Attendance_Management_System.controls
{
    public partial class StudentsAdminForm : UserControl
    {
        private List<User> users;
        private List<Student> students;
        public StudentsAdminForm()
        {
            InitializeComponent();
            InitializeDataGridView();
            LoadStudentData();
        }
        private void InitializeDataGridView()
        {
            // Set up DataGridView properties
            studentGrid.AutoGenerateColumns = false;
            studentGrid.AllowUserToAddRows = false;
            studentGrid.RowTemplate.Height = 60;

            // Define DataGridView columns
            id.DataPropertyName = "ID";
            Fname.DataPropertyName = "Fname";
            Lname.DataPropertyName = "Lname";
            age.DataPropertyName = "Age";
            email.DataPropertyName = "Email";
            password.DataPropertyName = "Password";
            phone.DataPropertyName = "Phone";
            address.DataPropertyName = "Address";
            delete.DataPropertyName = "Delete";
        }
        private void LoadStudentData()
        {
            users = UserParser.ParseUsers("../../../../users.xml");
            students = users.OfType<Student>().ToList();
            PopulateGrid(students);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void PopulateGrid(List<Student> dataList)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Fname");
            dataTable.Columns.Add("Lname");
            dataTable.Columns.Add("Age");
            dataTable.Columns.Add("Email");
            dataTable.Columns.Add("Password");
            dataTable.Columns.Add("Phone");
            dataTable.Columns.Add("Address");
            dataTable.Columns.Add("Delete", typeof(Image));

            foreach (var item in dataList)
            {
                if (item != null)
                {
                    Image deleteImage = Image.FromFile("../../../../Assets/delete.png");

                    dataTable.Rows.Add(
                        GetPropertyValue(item, "Id"),
                        GetPropertyValue(item, "FirstName"),
                        GetPropertyValue(item, "LastName"),
                        GetPropertyValue(item, "Age"),
                        GetPropertyValue(item, "Email"),
                        GetPropertyValue(item, "Password"),
                        GetPropertyValue(item, "Phone"),
                        GetPropertyValue(item, "Address"),
                        deleteImage
                    );
                }
            }

            studentGrid.DataSource = dataTable;
        }
        private object GetPropertyValue(object obj, string propertyName)
        {
            return obj.GetType().GetProperty(propertyName).GetValue(obj, null);
        }

        private void studentGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
                if (e.ColumnIndex == studentGrid.Columns["Delete"].Index && e.RowIndex >= 0 && e.RowIndex < studentGrid.Rows.Count)
                {
                    string idToDelete = studentGrid.Rows[e.RowIndex].Cells["ID"].Value.ToString();

                    DialogResult result = MessageBox.Show($"Are you sure you want to delete the student with ID '{idToDelete}'?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        Student studentToRemove = students.FirstOrDefault(s => s.Id == idToDelete);
                        if (studentToRemove != null)
                        {
                            users.Remove(studentToRemove);
                            UserParser.RemoveUserById(users, "../../../../users.xml", "../../../../class.xml", idToDelete);
                            students.Remove(studentToRemove);
                            PopulateGrid(students);
                        }

                        // Remove the row from the DataGridView
                        try
                        {
                            studentGrid.Rows.RemoveAt(e.RowIndex);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error removing row from DataGridView: " + ex.Message);
                        }
                    }
                }
                else if (e.ColumnIndex == studentGrid.Columns["Update"].Index && e.RowIndex >= 0 && e.RowIndex < studentGrid.Rows.Count)
                {
                    // Extract data of the corresponding user row
                    DataGridViewRow selectedRow = studentGrid.Rows[e.RowIndex];
                    string idToUpdate = selectedRow.Cells["ID"].Value.ToString();
                    int age = Convert.ToInt32(selectedRow.Cells["Age"].Value);
                    string password = selectedRow.Cells["Password"].Value.ToString();
                    string phone = selectedRow.Cells["Phone"].Value.ToString();
                    string address = selectedRow.Cells["Address"].Value.ToString();

                    // Pass the user data to the update form
                    UpdateUserForm updateForm = new UpdateUserForm(users, idToUpdate, password, age, phone, address);

                    // Display the update form
                    DialogResult result = updateForm.ShowDialog();
                }
            

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchText = textBox1.Text.ToLower(); // Convert search text to lowercase for case-insensitive search

                // Clear any previous filters
                ((DataTable)studentGrid.DataSource).DefaultView.RowFilter = "";

                if (!string.IsNullOrEmpty(searchText))
                {
                    // Build a filter expression for each column
                    StringBuilder filterExpression = new StringBuilder();

                    foreach (DataColumn column in ((DataTable)studentGrid.DataSource).Columns)
                    {
                        if (filterExpression.Length > 0)
                            filterExpression.Append(" OR ");

                        filterExpression.Append($"CONVERT({column.ColumnName}, 'System.String') LIKE '%{searchText}%'");
                    }

                    // Apply the filter
                    ((DataTable)studentGrid.DataSource).DefaultView.RowFilter = filterExpression.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void teacherGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == studentGrid.Columns["Delete"].Index && e.RowIndex >= 0 && e.RowIndex < studentGrid.Rows.Count)
            {
                string idToDelete = studentGrid.Rows[e.RowIndex].Cells["ID"].Value.ToString();

                DialogResult result = MessageBox.Show($"Are you sure you want to delete the student with ID '{idToDelete}'?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Student studentToRemove = students.FirstOrDefault(s => s.Id == idToDelete);
                    if (studentToRemove != null)
                    {
                        users.Remove(studentToRemove);
                        UserParser.RemoveUserById(users, "../../../../users.xml", "../../../../class.xml", idToDelete);
                        students.Remove(studentToRemove);
                        PopulateGrid(students);
                    }

                    // Remove the row from the DataGridView
                    try
                    {
                        studentGrid.Rows.RemoveAt(e.RowIndex);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error removing row from DataGridView: " + ex.Message);
                    }
                }
            }
            else if (e.ColumnIndex == studentGrid.Columns["Update"].Index && e.RowIndex >= 0 && e.RowIndex < studentGrid.Rows.Count)
            {
                // Extract data of the corresponding user row
                DataGridViewRow selectedRow = studentGrid.Rows[e.RowIndex];
                string idToUpdate = selectedRow.Cells["ID"].Value.ToString();
                int age = Convert.ToInt32(selectedRow.Cells["Age"].Value);
                string password = selectedRow.Cells["Password"].Value.ToString();
                string phone = selectedRow.Cells["Phone"].Value.ToString();
                string address = selectedRow.Cells["Address"].Value.ToString();

                // Pass the user data to the update form
                UpdateUserForm updateForm = new UpdateUserForm(users, idToUpdate, password, age, phone, address);

                // Display the update form
                DialogResult result = updateForm.ShowDialog();
            }
        }

        private void btnInsertUser_Click(object sender, EventArgs e)
        {
            InsertUserForm insform = new InsertUserForm(users, "student");
            insform.ShowDialog();
        }

        private void StudentsAdminForm_Load(object sender, EventArgs e)
        {

        }
    }
}

