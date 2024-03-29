﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Attendance_Management_System.classes;

namespace Attendance_Management_System.Forms
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labelDteTimeNow.Text = DateTime.Now.ToString(Program.appConfig.DateFormats);
            labelAppName.Text = Program.appConfig.AppName;
            labelAppVersion.Text = Program.appConfig.AppVersion;
            labelAppCreationDate.Text = Program.appConfig.AppCreationDate.ToString();
            labelAppDescription.Text = Program.appConfig.AppDescription;
            //listBoxDevelopers.Text = string.Join(", ", Program.appConfig.Authors);
            foreach (string author in Program.appConfig.Authors)
            {
                listBoxDevelopers.Items.Add(author);
            }
            numericUpDownBackup.Value = Program.appConfig.BackupInterval;
            // numericUpDownBackup.Accelerations = new NumericUpDownAcceleration[] { new NumericUpDownAcceleration(60*Program.timeInterval, 5) };
            listBoxSysLang.Text = Program.appConfig.Language;
            listBoxDateFormat.Text = Program.appConfig.DateFormats;
            listBoxBackupFileLocations.DataSource = new string[] { Program.appConfig.UsersBackupFilePath, Program.appConfig.CoursesBackupFilePath, Program.appConfig.ClassesBackupFilePath };
            
            // Change the languare of the form after loading the form to the Program.appConfig.Language loaded from the xml file
            // Change the languare
            foreach (Control c in this.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(FormSettings));
                resources.ApplyResources(c, c.Name, new System.Globalization.CultureInfo(Program.appConfig.Language));
            }

        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void buttonLoginSaveSettings_Click(object sender, EventArgs e)
        {


            // validate the backup interval value > 5 & < 60 // < 1 just for testing purposes
            if (numericUpDownBackup.Value < 1 && numericUpDownBackup.Value > 60)
            {
                MessageBox.Show("Backup interval must be between 5 and 60 minutes", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // numericUpDownBackup.Value = AppConfig.AppSettings.BackupInterval;
            Program.appConfig.BackupInterval = (int)numericUpDownBackup.Value;
            Program.appConfig.Language = listBoxSysLang.Text;
            Program.appConfig.DateFormats = listBoxDateFormat.Text;
            //         public static void SaveAppConfigAsXml(AppConfig appConfig, string filePath)
            AppConfigParser.SaveAppConfigAsXml(Program.appConfig, Program.appConfigPath);
            Program.GetDataFromXml(Program.backupUsersPath, Program.backupCoursesPath, Program.backupClaSSesPath);
            labelshowdate.Text = DateTime.Now.ToString(Program.appConfig.DateFormats);
            MessageBox.Show("Settings saved successfully", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // set the open date and time to the current date and time
            Program.appOpenDateandTime = DateTime.Now;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDteTimeNow.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
            timer1.Start();


            // labelDteTimeNow.Text = DateTime.Now.ToString(AppConfig.AppSettings.DateFormats);
            //labelDteTimeNow.Enabled = true;
            // labelDteTimeNow.Text = DateTime.Now.ToString(AppConfig.AppSettings.DateFormats);
            //labelDteTimeNow.Text = DateTime.Now.ToShortDateString(AppConfig.AppSettings.DateFormats);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            // Change the languare 

            FormLogin Formlogin = new FormLogin();
            Formlogin.Show();
            Hide();

        }
    }
}
