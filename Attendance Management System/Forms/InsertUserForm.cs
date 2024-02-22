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
    public partial class InsertUserForm : Form
    {
        private string NextUserId;
        private List<User> users;
        public InsertUserForm(List<User> existingUsers, string role)
        {
            InitializeComponent();
            users = existingUsers;
            TexUserID.Text = GetNextUserId(role);

        }
        private string GetNextUserId(string role)
        {
            // If there are no existing users, return "1U" as the first user ID
            if (users.Count == 0)
            {
                return "1" + role[0].ToString().ToUpper(); // Initialize with '1' and the first character of the role in uppercase
            }

            // Extract numerical part from the existing user IDs based on the role, convert to integers, and find the maximum
            int maxId = users.Where(u => u.Id.EndsWith(role[0].ToString().ToUpper())).Max(u => int.Parse(u.Id.Substring(0, u.Id.Length - 1)));

            // Increment the maximum ID by one to get the next ID
            return (maxId + 1).ToString() + role[0].ToString().ToUpper();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Get user input from the form
            string id = TexUserID.Text;
            string fname = texFname.Text;
            string lname = texLname.Text;
            int age = int.Parse(texAge.Text);
            string email = texEmail.Text;
            string password = texPass.Text;
            string phone = texPhone.Text;
            string address = texAddress.Text;
            string role = comboBoxRole.SelectedItem.ToString();

            // Validate user input (you can implement validation logic here)

            // Create a new User object
            User newUser = null;
            switch (role.ToLower())
            {
                case "student":
                    newUser = new Student(id, fname, lname, age, email, password, phone, address);
                    break;
                case "teacher":
                    newUser = new Teacher(id, fname, lname, age, email, password, phone, address);
                    break;

                default:
                    MessageBox.Show("Invalid role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            // Add the new user to the list of users
            users.Add(newUser);

            // Update the XML file with the new user data
            UserParser.InsertUsers(users, "../../../../users.xml");

            // Close the form
            this.Close();
        }
    }
}