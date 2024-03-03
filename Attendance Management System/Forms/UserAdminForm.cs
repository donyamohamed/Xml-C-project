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
    public partial class UserAdminForm : Form
    {
        public string Role { get; set; }

        private List<classes.User> users;
        private List<Teacher> teachers;
        private List<Student> students;

        public UserAdminForm(string role)
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

            StartAdmin adminForm = new StartAdmin();
            adminForm.Show();
            Hide();
        }


        private void InitializeDataGridView()
        {
            // Set up DataGridView properties
            teacherGrid.AutoGenerateColumns = false;
            teacherGrid.AllowUserToAddRows = false;
            teacherGrid.RowTemplate.Height = 60;
            teacherGrid.DefaultCellStyle.Font = new Font("Arial", 12); // Set the default font

         
            foreach (DataGridViewColumn column in teacherGrid.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                column.FillWeight = 1; 
            }
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
            users = UserParser.ParseUsers("../../../users.xml");

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
            StartAdmin adminForm = new StartAdmin();
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

        private void UserAdminForm_Load(object sender, EventArgs e)
        {

        }

        private void minimizebox_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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

        private void button7_Click(object sender, EventArgs e)
        {
            string role = "student";
            LoadUserData(role);
            UserAdminForm studentAdminForm = new UserAdminForm(role);
            studentAdminForm.Role = role;
            studentAdminForm.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string role = "teacher";
            LoadUserData(role);
            UserAdminForm teacherAdminForm = new UserAdminForm(role);
            teacherAdminForm.Role = role;
            teacherAdminForm.Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)//courses
        {

            CourseAdminForm courseAdminForm = new CourseAdminForm();
            courseAdminForm.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e) //class
        {
            ClassAdminForm classAdminForm = new ClassAdminForm();
            classAdminForm.Show();
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

        }

        // handle delete btn

        private void TeacherGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == teacherGrid.Columns["Delete"].Index && e.RowIndex >= 0 && e.RowIndex < teacherGrid.Rows.Count)
            {

                string idToDelete = teacherGrid.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                string roleToDelete = Role.ToLower();

                Console.WriteLine($"Attempting to delete row at index {e.RowIndex}");
                DialogResult result = MessageBox.Show($"Are you sure you want to delete the {roleToDelete} with ID '{idToDelete}'?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (Role == "teacher")
                    {
                        Teacher teacherToRemove = teachers.FirstOrDefault(t => t.Id == idToDelete);
                        if (teacherToRemove != null)
                        {

                            users.Remove(teacherToRemove);

                            // -> update xml
                            UserParser.RemoveUserById(users, "../../users.xml", "../../class.xml", idToDelete);

                            teachers.Remove(teacherToRemove); //->update grid
                            PopulateGrid(teachers);

                            Console.WriteLine($"Row deleted successfully. Remaining rows: {teacherGrid.Rows.Count}");
                        }
                    }
                    else if (Role == "student")
                    {
                        Student studentToRemove = students.FirstOrDefault(s => s.Id == idToDelete);
                        if (studentToRemove != null)
                        {

                            users.Remove(studentToRemove);


                            UserParser.RemoveUserById(users, "../../users.xml", "../../class.xml", idToDelete);


                            students.Remove(studentToRemove);
                            PopulateGrid(students);

                            Console.WriteLine($"Row deleted successfully. Remaining rows: {teacherGrid.Rows.Count}");
                        }
                    }

                    // --------  > Remove the row from the DataGridView
                    try
                    {
                        teacherGrid.Rows.RemoveAt(e.RowIndex);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error removing row from DataGridView: " + ex.Message);

                    }

                    Console.WriteLine($"Row removed successfully. Remaining rows: {teacherGrid.Rows.Count}");
                }
            }

            else if (e.ColumnIndex == teacherGrid.Columns["Update"].Index && e.RowIndex >= 0 && e.RowIndex < teacherGrid.Rows.Count)
            {
                // Extract data of the corresponding user row
                DataGridViewRow selectedRow = teacherGrid.Rows[e.RowIndex];
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

        //update 



        private void btnInsertUser_Click(object sender, EventArgs e)
        {
            InsertUserForm insform = new InsertUserForm(users, Role);
            insform.ShowDialog();
        }

        private void buInsert_Click(object sender, EventArgs e)
        {
            InsertUserForm insform = new InsertUserForm(users, Role);
            insform.ShowDialog();
        }

       
    }
}