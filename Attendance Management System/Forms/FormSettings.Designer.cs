namespace Attendance_Management_System.Forms
{
    partial class FormSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            pictureBoxClose = new PictureBox();
            pictureBoxMinimize = new PictureBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            labelAppCreationDate = new Label();
            label9 = new Label();
            listBoxDevelopers = new ListBox();
            label8 = new Label();
            labelAppDescription = new Label();
            label5 = new Label();
            labelAppVersion = new Label();
            label4 = new Label();
            labelAppName = new Label();
            UserEmail = new Label();
            groupBox2 = new GroupBox();
            labelshowdate = new Label();
            buttonLoginSaveSettings = new Button();
            label12 = new Label();
            numericUpDownBackup = new NumericUpDown();
            listBoxSysLang = new ListBox();
            listBoxDateFormat = new ListBox();
            label11 = new Label();
            label7 = new Label();
            label10 = new Label();
            label3 = new Label();
            labelDteTimeNow = new Label();
            button1 = new Button();
            groupBox3 = new GroupBox();
            listBoxBackupFileLocations = new ListBox();
            label13 = new Label();
            pictureBoxBack = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimize).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBackup).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBack).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            toolTip1.SetToolTip(label1, resources.GetString("label1.ToolTip"));
            // 
            // pictureBoxClose
            // 
            resources.ApplyResources(pictureBoxClose, "pictureBoxClose");
            pictureBoxClose.Cursor = Cursors.Hand;
            pictureBoxClose.Image = Properties.Resources.Delete_Red_X_Button_Transparent;
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Tag = "x";
            toolTip1.SetToolTip(pictureBoxClose, resources.GetString("pictureBoxClose.ToolTip"));
            pictureBoxClose.Click += pictureBoxClose_Click;
            // 
            // pictureBoxMinimize
            // 
            resources.ApplyResources(pictureBoxMinimize, "pictureBoxMinimize");
            pictureBoxMinimize.Cursor = Cursors.Hand;
            pictureBoxMinimize.Image = Properties.Resources._3403551_2001;
            pictureBoxMinimize.Name = "pictureBoxMinimize";
            pictureBoxMinimize.TabStop = false;
            pictureBoxMinimize.Tag = "-";
            toolTip1.SetToolTip(pictureBoxMinimize, resources.GetString("pictureBoxMinimize.ToolTip"));
            pictureBoxMinimize.Click += pictureBoxMinimize_Click;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = Color.IndianRed;
            label2.Name = "label2";
            label2.Tag = "العنوان نظام الحضور والإنصراف";
            toolTip1.SetToolTip(label2, resources.GetString("label2.ToolTip"));
            // 
            // groupBox1
            // 
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Controls.Add(labelAppCreationDate);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(listBoxDevelopers);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(labelAppDescription);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(labelAppVersion);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(labelAppName);
            groupBox1.Controls.Add(UserEmail);
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            groupBox1.Tag = "معلمومات عن الناظام";
            toolTip1.SetToolTip(groupBox1, resources.GetString("groupBox1.ToolTip"));
            // 
            // labelAppCreationDate
            // 
            resources.ApplyResources(labelAppCreationDate, "labelAppCreationDate");
            labelAppCreationDate.ForeColor = Color.Black;
            labelAppCreationDate.Name = "labelAppCreationDate";
            labelAppCreationDate.Tag = "App Description";
            toolTip1.SetToolTip(labelAppCreationDate, resources.GetString("labelAppCreationDate.ToolTip"));
            // 
            // label9
            // 
            resources.ApplyResources(label9, "label9");
            label9.ForeColor = Color.IndianRed;
            label9.Name = "label9";
            label9.Tag = "وقت تصميم البرنامج";
            toolTip1.SetToolTip(label9, resources.GetString("label9.ToolTip"));
            // 
            // listBoxDevelopers
            // 
            resources.ApplyResources(listBoxDevelopers, "listBoxDevelopers");
            listBoxDevelopers.FormattingEnabled = true;
            listBoxDevelopers.Name = "listBoxDevelopers";
            listBoxDevelopers.Tag = "...";
            toolTip1.SetToolTip(listBoxDevelopers, resources.GetString("listBoxDevelopers.ToolTip"));
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.ForeColor = Color.IndianRed;
            label8.Name = "label8";
            label8.Tag = "المصممون";
            toolTip1.SetToolTip(label8, resources.GetString("label8.ToolTip"));
            // 
            // labelAppDescription
            // 
            resources.ApplyResources(labelAppDescription, "labelAppDescription");
            labelAppDescription.ForeColor = Color.Black;
            labelAppDescription.Name = "labelAppDescription";
            labelAppDescription.Tag = "App Description";
            toolTip1.SetToolTip(labelAppDescription, resources.GetString("labelAppDescription.ToolTip"));
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.ForeColor = Color.IndianRed;
            label5.Name = "label5";
            label5.Tag = "وصف البرنامحج";
            toolTip1.SetToolTip(label5, resources.GetString("label5.ToolTip"));
            // 
            // labelAppVersion
            // 
            resources.ApplyResources(labelAppVersion, "labelAppVersion");
            labelAppVersion.ForeColor = Color.Black;
            labelAppVersion.Name = "labelAppVersion";
            labelAppVersion.Tag = "App Version";
            toolTip1.SetToolTip(labelAppVersion, resources.GetString("labelAppVersion.ToolTip"));
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.ForeColor = Color.IndianRed;
            label4.Name = "label4";
            label4.Tag = "نسخة البرنامج";
            toolTip1.SetToolTip(label4, resources.GetString("label4.ToolTip"));
            // 
            // labelAppName
            // 
            resources.ApplyResources(labelAppName, "labelAppName");
            labelAppName.ForeColor = Color.Black;
            labelAppName.Name = "labelAppName";
            labelAppName.Tag = "App Name";
            toolTip1.SetToolTip(labelAppName, resources.GetString("labelAppName.ToolTip"));
            // 
            // UserEmail
            // 
            resources.ApplyResources(UserEmail, "UserEmail");
            UserEmail.ForeColor = Color.IndianRed;
            UserEmail.Name = "UserEmail";
            UserEmail.Tag = "";
            toolTip1.SetToolTip(UserEmail, resources.GetString("UserEmail.ToolTip"));
            // 
            // groupBox2
            // 
            resources.ApplyResources(groupBox2, "groupBox2");
            groupBox2.Controls.Add(labelshowdate);
            groupBox2.Controls.Add(buttonLoginSaveSettings);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(numericUpDownBackup);
            groupBox2.Controls.Add(listBoxSysLang);
            groupBox2.Controls.Add(listBoxDateFormat);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label10);
            groupBox2.Name = "groupBox2";
            groupBox2.TabStop = false;
            toolTip1.SetToolTip(groupBox2, resources.GetString("groupBox2.ToolTip"));
            // 
            // labelshowdate
            // 
            resources.ApplyResources(labelshowdate, "labelshowdate");
            labelshowdate.ForeColor = Color.Black;
            labelshowdate.Name = "labelshowdate";
            labelshowdate.Tag = "save your changes";
            toolTip1.SetToolTip(labelshowdate, resources.GetString("labelshowdate.ToolTip"));
            // 
            // buttonLoginSaveSettings
            // 
            resources.ApplyResources(buttonLoginSaveSettings, "buttonLoginSaveSettings");
            buttonLoginSaveSettings.BackColor = Color.IndianRed;
            buttonLoginSaveSettings.ForeColor = Color.White;
            buttonLoginSaveSettings.Name = "buttonLoginSaveSettings";
            buttonLoginSaveSettings.Tag = "Save Settings";
            toolTip1.SetToolTip(buttonLoginSaveSettings, resources.GetString("buttonLoginSaveSettings.ToolTip"));
            buttonLoginSaveSettings.UseVisualStyleBackColor = false;
            buttonLoginSaveSettings.Click += buttonLoginSaveSettings_Click;
            // 
            // label12
            // 
            resources.ApplyResources(label12, "label12");
            label12.ForeColor = Color.IndianRed;
            label12.Name = "label12";
            label12.Tag = "Settings Changed at: ";
            toolTip1.SetToolTip(label12, resources.GetString("label12.ToolTip"));
            // 
            // numericUpDownBackup
            // 
            resources.ApplyResources(numericUpDownBackup, "numericUpDownBackup");
            numericUpDownBackup.Name = "numericUpDownBackup";
            toolTip1.SetToolTip(numericUpDownBackup, resources.GetString("numericUpDownBackup.ToolTip"));
            // 
            // listBoxSysLang
            // 
            resources.ApplyResources(listBoxSysLang, "listBoxSysLang");
            listBoxSysLang.FormattingEnabled = true;
            listBoxSysLang.Items.AddRange(new object[] { resources.GetString("listBoxSysLang.Items"), resources.GetString("listBoxSysLang.Items1") });
            listBoxSysLang.Name = "listBoxSysLang";
            toolTip1.SetToolTip(listBoxSysLang, resources.GetString("listBoxSysLang.ToolTip"));
            // 
            // listBoxDateFormat
            // 
            resources.ApplyResources(listBoxDateFormat, "listBoxDateFormat");
            listBoxDateFormat.FormattingEnabled = true;
            listBoxDateFormat.Items.AddRange(new object[] { resources.GetString("listBoxDateFormat.Items"), resources.GetString("listBoxDateFormat.Items1") });
            listBoxDateFormat.Name = "listBoxDateFormat";
            toolTip1.SetToolTip(listBoxDateFormat, resources.GetString("listBoxDateFormat.ToolTip"));
            // 
            // label11
            // 
            resources.ApplyResources(label11, "label11");
            label11.ForeColor = Color.IndianRed;
            label11.Name = "label11";
            label11.Tag = "System Date Format";
            toolTip1.SetToolTip(label11, resources.GetString("label11.ToolTip"));
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.ForeColor = Color.IndianRed;
            label7.Name = "label7";
            label7.Tag = "لغة البرنامج";
            toolTip1.SetToolTip(label7, resources.GetString("label7.ToolTip"));
            // 
            // label10
            // 
            resources.ApplyResources(label10, "label10");
            label10.ForeColor = Color.IndianRed;
            label10.Name = "label10";
            label10.Tag = "Backup Interval (in minutes)";
            toolTip1.SetToolTip(label10, resources.GetString("label10.ToolTip"));
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.ForeColor = Color.IndianRed;
            label3.Name = "label3";
            label3.Tag = "الوقت الحالى";
            toolTip1.SetToolTip(label3, resources.GetString("label3.ToolTip"));
            // 
            // labelDteTimeNow
            // 
            resources.ApplyResources(labelDteTimeNow, "labelDteTimeNow");
            labelDteTimeNow.ForeColor = Color.Black;
            labelDteTimeNow.Name = "labelDteTimeNow";
            labelDteTimeNow.Tag = "الوقت الحالى ...";
            toolTip1.SetToolTip(labelDteTimeNow, resources.GetString("labelDteTimeNow.ToolTip"));
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.BackColor = Color.LightSlateGray;
            button1.ForeColor = Color.White;
            button1.Name = "button1";
            toolTip1.SetToolTip(button1, resources.GetString("button1.ToolTip"));
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox3
            // 
            resources.ApplyResources(groupBox3, "groupBox3");
            groupBox3.Controls.Add(listBoxBackupFileLocations);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(button1);
            groupBox3.Name = "groupBox3";
            groupBox3.TabStop = false;
            toolTip1.SetToolTip(groupBox3, resources.GetString("groupBox3.ToolTip"));
            // 
            // listBoxBackupFileLocations
            // 
            resources.ApplyResources(listBoxBackupFileLocations, "listBoxBackupFileLocations");
            listBoxBackupFileLocations.FormattingEnabled = true;
            listBoxBackupFileLocations.Items.AddRange(new object[] { resources.GetString("listBoxBackupFileLocations.Items"), resources.GetString("listBoxBackupFileLocations.Items1"), resources.GetString("listBoxBackupFileLocations.Items2") });
            listBoxBackupFileLocations.Name = "listBoxBackupFileLocations";
            toolTip1.SetToolTip(listBoxBackupFileLocations, resources.GetString("listBoxBackupFileLocations.ToolTip"));
            // 
            // label13
            // 
            resources.ApplyResources(label13, "label13");
            label13.ForeColor = Color.IndianRed;
            label13.Name = "label13";
            label13.Tag = "Backup File Location";
            toolTip1.SetToolTip(label13, resources.GetString("label13.ToolTip"));
            // 
            // pictureBoxBack
            // 
            resources.ApplyResources(pictureBoxBack, "pictureBoxBack");
            pictureBoxBack.Cursor = Cursors.Hand;
            pictureBoxBack.Image = Properties.Resources.backarrow;
            pictureBoxBack.Name = "pictureBoxBack";
            pictureBoxBack.TabStop = false;
            pictureBoxBack.Tag = "-";
            toolTip1.SetToolTip(pictureBoxBack, resources.GetString("pictureBoxBack.ToolTip"));
            pictureBoxBack.Click += pictureBoxBack_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // FormSettings
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pictureBoxBack);
            Controls.Add(groupBox3);
            Controls.Add(labelDteTimeNow);
            Controls.Add(label3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(pictureBoxMinimize);
            Controls.Add(pictureBoxClose);
            Controls.Add(label1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSettings";
            toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            WindowState = FormWindowState.Maximized;
            Load += FormSettings_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimize).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDownBackup).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxBack).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ToolTip toolTip1;
        private PictureBox pictureBoxClose;
        private PictureBox pictureBoxMinimize;
        private Label label2;
        private GroupBox groupBox1;
        private Label labelAppVersion;
        private Label label4;
        private Label labelAppName;
        private Label UserEmail;
        private Label labelAppDescription;
        private Label label5;
        private Label label8;
        private ListBox listBoxDevelopers;
        private Label labelAppCreationDate;
        private Label label9;
        private GroupBox groupBox2;
        private ListBox listBoxDateFormat;
        private Label label11;
        private Label label7;
        private Label label10;
        private ListBox listBoxSysLang;
        private NumericUpDown numericUpDownBackup;
        private Button buttonLoginSaveSettings;
        private Label label3;
        private Label labelDteTimeNow;
        private System.Windows.Forms.Timer timer1;
        private Label label6;
        private Label label12;
        private Label labelshowdate;
        private Button button1;
        private GroupBox groupBox3;
        private ListBox listBoxBackupFileLocations;
        private Label label13;
        private PictureBox pictureBox1;
        private PictureBox pictureBoxBack;
    }
}