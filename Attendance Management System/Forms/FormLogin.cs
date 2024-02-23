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
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(Program.appLanguage);
            InitializeComponent();
            // Get the current UI culture from the configuration file
            // Update the UI
            // UpdateUI();

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
            // Change the current UI culture to the new culture from the configuration file
            // Thread.CurrentThread.CurrentUICulture = new CultureInfo(Program.appLanguage);
            // Thread.CurrentThread.CurrentUICulture = new CultureInfo(Program.appLanguage);
            // this.Controls.Clear();
            // Thread.CurrentThread.CurrentUICulture = new CultureInfo(Program.appLanguage);
            // this.InitializeComponent();


            //Thread.CurrentThread.CurrentUICulture = 
            // new CultureInfo(Program.appLanguage);
            // new CultureInfo(Program.newCulture);
            // UpdateUI();

            timerBackup.Start();
            labelOpenDateTime.Text = Program.appOpenDateandTime.ToString(Program.appConfig.DateFormats) + " " + Program.appOpenDateandTime.ToShortTimeString();
            pictureBoxHide.Hide();
            pictureBoxError.Hide();
            labelInvalidUserName.Hide();

            // test the backup method
            //Program.SaveDataAsXml(Program.appConfig.UsersBackupFilePath, Program.appConfig.CoursesBackupFilePath, Program.appConfig.ClassesBackupFilePath);


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
            // foreach (var user in Program.users)
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
            if (buttonLanguage.Text == "Language: Arabic")
            {
                buttonLanguage.Text = "Language: English";
                Program.appLanguage = "en";
            }
            else
            {
                buttonLanguage.Text = "Language: Arabic";
                Program.appLanguage = "ar";
            }

            // Change the current UI culture
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(Program.appLanguage);

            // Update the UI
            UpdateUI();
        }
        private void UpdateUI()
        {
            this.Controls.Clear();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(Program.appLanguage);
            this.InitializeComponent();


        }

        private void pictureBoxSettings_Click(object sender, EventArgs e)
        {
            // AdminForm adminFormSettings = new AdminForm();
            // FormLogin formLogin = new FormLogin();
            // formLogin.Show();
            // this.Hide();

            // show th form login and hide the settings form
            FormSettings formSettings = new FormSettings();
            formSettings.Show();
            Hide();
        }
        /// <summary>
        /// The timerBackup_Tick method to backup the data (users, courses, classes)
        /// every time interval (user can set it from 5 to 60 min) to the xml files
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerBackup_Tick(object sender, EventArgs e)
        {

            TimeSpan timeSpan = DateTime.Now - Program.appOpenDateandTime;
            // labelOpenDateTime.Text = timeSpan.ToString(@"dd\.hh\:mm\:ss");
            labelBackupIn.Text =
                timeSpan.ToString(@"dd\.hh\:mm\:ss");
            // DateTime.Now.ToString();
            if (timeSpan.TotalMinutes >= Program.appConfig.BackupInterval)
            {
                Program.SaveDataAsXml(Program.appConfig.UsersBackupFilePath, Program.appConfig.CoursesBackupFilePath, Program.appConfig.ClassesBackupFilePath);
                Program.appOpenDateandTime = DateTime.Now;

                labelOpenDateTime.Text = Program.appOpenDateandTime.ToString(Program.appConfig.DateFormats)
                 + " " + Program.appOpenDateandTime.ToShortTimeString();

            }


        }

        private void buttonLanguage_Click_1(object sender, EventArgs e)
        {
            // Get the current UI culture from the configuration file
            // change the current UI culture to the new culture
            if (Program.appLanguage == "ar")
            {
                buttonLanguage.Text = "Language: English";
                Program.appLanguage = "en";
            }
            else if (Program.appLanguage == "en")
            {
                buttonLanguage.Text = "تغيير اللغة إلى العربية";
                Program.appLanguage = "ar";
            }
            // Change the current UI culture to the new culture from the configuration file
            // Thread.CurrentThread.CurrentUICulture = new CultureInfo(Program.appLanguage);
            // this.Controls.Clear();
            // Thread.CurrentThread.CurrentUICulture = new CultureInfo(Program.appLanguage);
            // this.InitializeComponent();

            // Update the UI
            UpdateUI();


        }

    }
}
