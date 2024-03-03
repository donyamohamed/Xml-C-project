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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Attendance_Management_System.Forms
{
    public partial class UpdateUserForm : Form
    {

        private List<User> users;
        private string idToUpdate;
        public UpdateUserForm(List<User> users, string idToUpdate,string password,int age,string phone,string address)
        {
            InitializeComponent();
            this.users = users;
            this.idToUpdate = idToUpdate;
            TexUserID.Text = idToUpdate;
            TexUserID.Enabled = false;
            texPass.Text = password;
            texAge.Text = age.ToString();
            texPhone.Text = phone;
            texAddress.Text = address;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
              
                string newPassword = texPass.Text;
                int newAge = int.Parse(texAge.Text);
                string newPhone = texPhone.Text;
                string newAddress = texAddress.Text;

                // Validate 
                if (!UserValidator.ValidatePassword(newPassword))
                {
                    MessageBox.Show("Invalid password format. Password must have at least 3 characters and contain a special character and digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!UserValidator.ValidateAge(newAge))
                {
                    MessageBox.Show("Invalid age. Age must be at least 18 years old.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!UserValidator.ValidatePhone(newPhone))
                {
                    MessageBox.Show("Invalid phone number format. Please enter a valid Egyptian phone number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!UserValidator.ValidateAddress(newAddress))
                {
                    MessageBox.Show("Invalid address format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int indexToUpdate = users.FindIndex(u => u.Id == idToUpdate);
                if (indexToUpdate != -1)
                {
                    users[indexToUpdate].Password = newPassword;
                    users[indexToUpdate].Age = newAge;
                    users[indexToUpdate].Phone = newPhone;
                    users[indexToUpdate].Address = newAddress;

                  
                }

                // Save the updated 
                UserParser.SaveUsersAsXml(users, "../../../users.xml");

               
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
