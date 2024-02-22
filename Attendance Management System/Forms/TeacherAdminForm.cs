using Attendance_Management_System.classes;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Xml.Linq;
using static Attendance_Management_System.classes.User;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Attendance_Management_System.Forms
{
    public partial class TeacherAdminForm : Form
    {
        public string Role { get; set; }

        private List<classes.User> users;
        private List<Teacher> teachers;
        private List<Student> students;

        public TeacherAdminForm(string role)
        {
            InitializeComponent();
            Role = role;
            InitializeDataGridView();
            //MessageBox.Show(Role);



            if (!string.IsNullOrEmpty(Role))
            {
                LoadUserData(Role);
            }

        }
        private void BackButton_Click_1(object sender, EventArgs e)
        {

            AdminForm adminForm = new AdminForm();
            adminForm.Show();
            Hide();
        }


        private void InitializeDataGridView()
        {
            // Set up DataGridView properties
            teacherGrid.AutoGenerateColumns = false;
            teacherGrid.AllowUserToAddRows = false;
            teacherGrid.RowTemplate.Height = 60;
            // Define DataGridView columns
            id.DataPropertyName = "ID";
            teacherFname.DataPropertyName = "Fname";
            teacherLname.DataPropertyName = "Lname";
            age.DataPropertyName = "Age";
            email.DataPropertyName = "Email";
            password.DataPropertyName = "Password";
            phone.DataPropertyName = "Phone";
            address.DataPropertyName = "Address";


        }

        /*  private void LoadTeacherData()
          {
              try
              {
                  // Assuming UserParser has a method to get a list of users
                 // users = UserParser.ParseUsers("../../../../users.xml");

                  // Filter users with role "teacher" and add them to the list of teachers
                  teachers = users.Where(u => u.Role == "teacher").Select(u => u as Teacher).ToList();

                  // Create a DataTable and add columns
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

                  // Populate DataTable with teacher data
                  foreach (var user in teachers)
                  {
                      if (user != null)
                      {
                          Image deleteImage = Image.FromFile("../../../../Assets/delete.png");
                          dataTable.Rows.Add(
                              user.Id,
                              user.FirstName,
                              user.LastName,
                              user.Age,
                              user.Email,
                              user.Password,
                              user.Phone,
                              user.Address,
                              deleteImage
                          );

                      }
                  }

                  // Bind the DataTable to the DataGridView
                  teacherGrid.DataSource = dataTable;
              }
              catch (Exception ex)
              {
                  MessageBox.Show("Error loading teacher data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
              }
          }*/

        private void LoadUserData(string role)
        {
            users = UserParser.ParseUsers("../../../../users.xml");

            try
            {
                if (role == "teacher")
                {
                    teachers = users.Where(u => u.Role == "teacher").Select(u => u as Teacher).ToList();
                    PopulateGrid(teachers);
                }
                else if (role == "student")
                {
                    students = users.Where(u => u.Role == "student").Select(u => u as Student).ToList();
                    PopulateGrid(students);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateGrid<T>(List<T> dataList)
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

            teacherGrid.DataSource = dataTable;
        }

        private object GetPropertyValue(object obj, string propertyName)
        {
            return obj.GetType().GetProperty(propertyName).GetValue(obj, null);
        }




        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
            Hide();
        }


        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            FormLogin Formlogin = new FormLogin();
            Formlogin.Show();
            Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void TeacherAdminForm_Load(object sender, EventArgs e)
        {

        }

        private void minimizebox_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void closebox_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string role = "student";
            LoadUserData(role);
            TeacherAdminForm studentAdminForm = new TeacherAdminForm(role);
            studentAdminForm.Role = role;
            studentAdminForm.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string role = "teacher";
            LoadUserData(role);
            TeacherAdminForm teacherAdminForm = new TeacherAdminForm(role);
            teacherAdminForm.Role = role;
            teacherAdminForm.Show();
            Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchText = textBox1.Text.ToLower(); // Convert search text to lowercase for case-insensitive search

                // Clear any previous filters
                ((DataTable)teacherGrid.DataSource).DefaultView.RowFilter = "";

                if (!string.IsNullOrEmpty(searchText))
                {
                    // Build a filter expression for each column
                    StringBuilder filterExpression = new StringBuilder();

                    foreach (DataColumn column in ((DataTable)teacherGrid.DataSource).Columns)
                    {
                        if (filterExpression.Length > 0)
                            filterExpression.Append(" OR ");

                        filterExpression.Append($"CONVERT({column.ColumnName}, 'System.String') LIKE '%{searchText}%'");
                    }

                    // Apply the filter
                    ((DataTable)teacherGrid.DataSource).DefaultView.RowFilter = filterExpression.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // handle delete btn
        }

        /* private void TeacherGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
         {
             if (e.ColumnIndex == teacherGrid.Columns["Delete"].Index && e.RowIndex != -1)
             {
                 DialogResult result = MessageBox.Show("Are you sure you want to delete this row?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                 if (result == DialogResult.Yes)
                 {
                     string idToDelete = teacherGrid.Rows[e.RowIndex].Cells["ID"].Value.ToString();

                     if (Role == "teacher")
                     {
                         Teacher teacherToRemove = teachers.FirstOrDefault(t => t.Id == idToDelete);
                         if (teacherToRemove != null)
                         {
                             teachers.Remove(teacherToRemove);
                             users.Remove(teacherToRemove);
                         }
                     }
                     else if (Role == "student")
                     {
                         Student studentToRemove = students.FirstOrDefault(s => s.Id == idToDelete);
                         if (studentToRemove != null)
                         {
                             students.Remove(studentToRemove);
                             users.Remove(studentToRemove);
                         }
                     }

                     teacherGrid.Rows.RemoveAt(e.RowIndex);

                     UserParser.UpdateUsers(users, "../../../../users.xml");

                     foreach (var user in users)
                     {
                         MessageBox.Show(user.ToString());
                     }
                 }
             }

         }*/

        private void TeacherGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == teacherGrid.Columns["Delete"].Index && e.RowIndex >= 0 && e.RowIndex < teacherGrid.Rows.Count)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this row?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string idToDelete = teacherGrid.Rows[e.RowIndex].Cells["ID"].Value.ToString();

                    if (Role == "teacher")
                    {
                        Teacher teacherToRemove = teachers.FirstOrDefault(t => t.Id == idToDelete);
                        if (teacherToRemove != null)
                        {
                            // Remove the teacher from the users list
                            users.Remove(teacherToRemove);

                            // Update the XML file
                            UserParser.UpdateUsers(users, "../../../../users.xml");

                            // Update the DataGridView
                            teachers.Remove(teacherToRemove);
                            PopulateGrid(teachers);
                        }
                    }
                    else if (Role == "student")
                    {
                        Student studentToRemove = students.FirstOrDefault(s => s.Id == idToDelete);
                        if (studentToRemove != null)
                        {
                            // Remove the student from the users list
                            users.Remove(studentToRemove);

                            // Update the XML file
                            UserParser.UpdateUsers(users, "../../../../users.xml");

                            // Update the DataGridView
                            students.Remove(studentToRemove);
                            PopulateGrid(students);
                        }
                    }

                    teacherGrid.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void btnInsertUser_Click(object sender, EventArgs e)
        {
            InsertUserForm insform = new InsertUserForm(users,Role);
            insform.ShowDialog();
        }
    }
}