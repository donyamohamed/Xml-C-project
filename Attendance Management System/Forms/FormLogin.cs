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
    /*
    public struct Person
    {
        public string Name;
        public string Password;
        public string Email;

        public Person(string name, string password, string email)
        {
            Name = name;
            Password = password;
            Email = email;
        }
    }
    */
    public partial class FormLogin : Form
    {
        public static Admin adminUser = new Admin();
        //meAdmin is Accessable from any form by FormLogin.meAdmin
        public static Teacher meTeacher = new Teacher();
        // meTeacher is Accessable from any form by FormLogin.meTeacher
        public static Student meStudent = new Student();
        // meStudent is Accessable from any form by formLogin.meStudent


        public FormLogin()
        {
            // when the form is created, get the users from the xml file and store them in the users list
            // List<classes.User> users = UserParser.ParseUsers("../../../../users.xml");
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxHide_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxShow, "Show Password");
        }

        private void pictureBoxHide_MouseHover_1(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxHide, "Hide Password");
        }

        private void pictureBoxShow_Click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = false;
            pictureBoxShow.Hide();
            pictureBoxHide.Show();
        }

        private void pictureBoxHide_Click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = true;
            pictureBoxHide.Hide();
            pictureBoxShow.Show();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            pictureBoxHide.Hide();
            pictureBoxError.Hide();
            labelInvalidUserName.Hide();

        }

        private void pictureBoxClose_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxClose, "Exit");

        }

        private void pictureBoxMinimize_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxMinimize, "Minimize");
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxEmail.Text = string.Empty;
            textBoxPassword.Text = string.Empty;
            pictureBoxError.Hide();
            labelInvalidUserName.Hide();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // if (p1.Email == textBoxEmail.Text.ToLower().Trim() && p1.Password == textBoxPassword.Text)
            if (ValidateUser(textBoxEmail.Text.ToLower().Trim(), textBoxPassword.Text) == true)
            {
                // open StudentForm
                StudentForm studentForm = new StudentForm();

                // open TeacherForm
                TeacherForm teacherForm = new TeacherForm();

                // open AdminForm
                AdminForm adminForm = new AdminForm();

                // open the form according to the role of the user
                foreach (var user in Program.users)
                {
                    if (user.Email == textBoxEmail.Text.ToLower().Trim() && user.Password == textBoxPassword.Text)
                    {
                        if (user.Role == "admin")
                        {
                            adminForm.Show(); // Assuming you have a method to display admin buttons
                            Hide();
                        }
                        else if (user.Role == "teacher")
                        {
                            teacherForm.Show();
                            Hide();
                        }
                        else if (user.Role == "student")
                        {
                            studentForm.Show();
                            Hide();
                        }
                    }
                }

                // Configure message box
                string message = "This password is Correct";
                string caption = "Wellcome";
                // Show message box
                MessageBox.Show(message, caption);
            }
            else
            {
                pictureBoxError.Show();
                labelInvalidUserName.Show();
            }
        }

        private static Boolean ValidateUser(string email, string password)
        {
            foreach (var user in Program.users)
            {
                if (user.Email == email && user.Password == password)
                {
                    if (user.Role == "admin")
                    {
                        Admin adminUser = (Admin)user;
                        return true;
                    }
                    else if (user.Role == "teacher")
                    {
                        meTeacher = (Teacher)user;
                        return true;
                    }
                    else if (user.Role == "student")
                    {
                        meStudent = (Student)user;
                        return true;
                    }
                }
            }
            return false;
        }

        private void buttonLanguage_Click(object sender, EventArgs e)
        {
            string newCulture;

            if (buttonLanguage.Text == "Language: Arabic")
            {
                buttonLanguage.Text = "Language: English";
                newCulture = "en";
            }
            else
            {
                buttonLanguage.Text = "Language: Arabic";
                newCulture = "ar";
            }

            // Change the current UI culture
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(newCulture);


            // Update the UI
            UpdateUI();
        }
        private void UpdateUI()
        {
            this.Controls.Clear();
            this.InitializeComponent();

        }

        
    }
}
