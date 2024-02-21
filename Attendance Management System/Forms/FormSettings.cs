using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// suing the classes namespace to access the AppConfig class
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
            labelAppName.Text = Program.appConfig.AppName;
            labelAppVersion.Text = Program.appConfig.AppVersion;
            labelAppCreationDate.Text = Program.appConfig.AppCreationDate.ToString();
            labelAppDescription.Text = Program.appConfig.AppDescription;
            //listBoxDevelopers.Text = string.Join(", ", Program.appConfig.Authors);
            foreach (string author in Program.appConfig.Authors)
            {
                listBoxDevelopers.Items.Add(author);
            }
            numericUpDownBackup.Value = AppConfig.AppSettings.BackupInterval;
            // numericUpDownBackup.Accelerations = new NumericUpDownAcceleration[] { new NumericUpDownAcceleration(60*Program.timeInterval, 5) };
            listBoxSysLang.Text = AppConfig.AppSettings.Languages;
            listBoxDateFormat.Text = AppConfig.AppSettings.DateFormats;


        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
