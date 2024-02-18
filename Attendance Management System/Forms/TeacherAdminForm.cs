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
        private List<classes.User> users;
        private List<Teacher> teachers;

        public TeacherAdminForm()
        {
            InitializeComponent();
            InitializeDataGridView();
            LoadTeacherData();

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

            // Define DataGridView columns
            id.DataPropertyName = "ID";
            teacherFname.DataPropertyName = "Teacher Fname";
            teacherLname.DataPropertyName = "Teacher Lname";
            age.DataPropertyName = "Age";
            email.DataPropertyName = "Email";
            password.DataPropertyName = "Password";
            phone.DataPropertyName = "Phone";
            address.DataPropertyName = "Address";
        }

        private void LoadTeacherData()
        {
            try
            {
                // Assuming UserParser has a method to get a list of users
                users = UserParser.ParseUsers("../../../../users.xml");

                // Filter users with role "teacher" and add them to the list of teachers
                teachers = users.Where(u => u.Role == "teacher").Select(u => u as Teacher).ToList();

                // Create a DataTable and add columns
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("ID");
                dataTable.Columns.Add("Teacher Fname");
                dataTable.Columns.Add("Teacher Lname");
                dataTable.Columns.Add("Age");
                dataTable.Columns.Add("Email");
                dataTable.Columns.Add("Password");
                dataTable.Columns.Add("Phone");
                dataTable.Columns.Add("Address");

                // Populate DataTable with teacher data
                foreach (var user in teachers)
                {
                    if (user != null)
                    {
                        dataTable.Rows.Add(
                            user.Id,
                            user.FirstName,
                            user.LastName,
                            user.Age,
                            user.Email,
                            user.Password,
                            user.Phone,
                            user.Address
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
        }

        private void TeacherGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // This event is typically used for handling user interactions with the cells.
            // If you don't have specific actions to perform on cell click, you can leave this empty.
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
            Hide();
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}