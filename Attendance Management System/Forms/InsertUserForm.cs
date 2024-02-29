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

            if (users.Count == 0)
            {
                return "1" + role[0].ToString().ToUpper();
            }

            
            var usersWithRole = users.Where(u => u.Id.EndsWith(role[0].ToString().ToUpper()));
            if (!usersWithRole.Any())
            {
                return "1" + role[0].ToString().ToUpper(); 
            }


            int maxId = usersWithRole.Max(u => int.Parse(u.Id.Substring(0, u.Id.Length - 1)));

            return (maxId + 1).ToString() + role[0].ToString().ToUpper();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Get user input from the form
            string id = TexUserID.Text;
            string fname = texFname.Text;
            string lname = texLname.Text;
            int age;
            string email = texEmail.Text;
            string password = texPass.Text;
            string phone = texPhone.Text;
            string address = texAddress.Text;
            string role = comboBoxRole.SelectedItem?.ToString(); 

           
            if (string.IsNullOrEmpty(id) || !UserValidator.ValidateId(id))
            {
                MessageBox.Show("Invalid ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(fname) || !UserValidator.ValidateName(fname))
            {
                MessageBox.Show("Invalid first name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(lname) || !UserValidator.ValidateName(lname))
            {
                MessageBox.Show("Invalid last name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(texAge.Text, out age) || !UserValidator.ValidateAge(age))
            {
                MessageBox.Show("Invalid age.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(email) || !UserValidator.ValidateEmail(email))
            {
                MessageBox.Show("Invalid email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(password) || !UserValidator.ValidatePassword(password))
            {
                MessageBox.Show("Invalid password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(phone) || !UserValidator.ValidatePhone(phone))
            {
                MessageBox.Show("Invalid phone number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(role) || !UserValidator.ValidateRole(role))
            {
                MessageBox.Show("Invalid role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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

           
            users.Add(newUser);

           
            UserParser.InsertUsers(users, "../../../../users.xml");

       
            this.Close();
        }

    }
}