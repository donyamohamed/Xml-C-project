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
            UserEmail = new Label();
            labelAppName = new Label();
            labelAppVersion = new Label();
            label4 = new Label();
            labelAppDescription = new Label();
            label5 = new Label();
            label3 = new Label();
            label6 = new Label();
            label8 = new Label();
            listBoxDevelopers = new ListBox();
            labelAppCreationDate = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimize).BeginInit();
            groupBox1.SuspendLayout();
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
            toolTip1.SetToolTip(pictureBoxClose, resources.GetString("pictureBoxClose.ToolTip"));
            pictureBoxClose.Click += pictureBoxClose_Click;
            // 
            // pictureBoxMinimize
            // 
            resources.ApplyResources(pictureBoxMinimize, "pictureBoxMinimize");
            pictureBoxMinimize.Cursor = Cursors.Hand;
            pictureBoxMinimize.Name = "pictureBoxMinimize";
            pictureBoxMinimize.TabStop = false;
            toolTip1.SetToolTip(pictureBoxMinimize, resources.GetString("pictureBoxMinimize.ToolTip"));
            pictureBoxMinimize.Click += pictureBoxMinimize_Click;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = Color.Purple;
            label2.Name = "label2";
            toolTip1.SetToolTip(label2, resources.GetString("label2.ToolTip"));
            // 
            // groupBox1
            // 
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Controls.Add(labelAppCreationDate);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(listBoxDevelopers);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(labelAppDescription);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(labelAppVersion);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(labelAppName);
            groupBox1.Controls.Add(UserEmail);
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            toolTip1.SetToolTip(groupBox1, resources.GetString("groupBox1.ToolTip"));
            // 
            // UserEmail
            // 
            resources.ApplyResources(UserEmail, "UserEmail");
            UserEmail.ForeColor = SystemColors.HotTrack;
            UserEmail.Name = "UserEmail";
            toolTip1.SetToolTip(UserEmail, resources.GetString("UserEmail.ToolTip"));
            // 
            // labelAppName
            // 
            resources.ApplyResources(labelAppName, "labelAppName");
            labelAppName.ForeColor = SystemColors.HotTrack;
            labelAppName.Name = "labelAppName";
            toolTip1.SetToolTip(labelAppName, resources.GetString("labelAppName.ToolTip"));
            // 
            // labelAppVersion
            // 
            resources.ApplyResources(labelAppVersion, "labelAppVersion");
            labelAppVersion.ForeColor = SystemColors.HotTrack;
            labelAppVersion.Name = "labelAppVersion";
            toolTip1.SetToolTip(labelAppVersion, resources.GetString("labelAppVersion.ToolTip"));
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.ForeColor = SystemColors.HotTrack;
            label4.Name = "label4";
            toolTip1.SetToolTip(label4, resources.GetString("label4.ToolTip"));
            // 
            // labelAppDescription
            // 
            resources.ApplyResources(labelAppDescription, "labelAppDescription");
            labelAppDescription.ForeColor = SystemColors.HotTrack;
            labelAppDescription.Name = "labelAppDescription";
            toolTip1.SetToolTip(labelAppDescription, resources.GetString("labelAppDescription.ToolTip"));
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.ForeColor = SystemColors.HotTrack;
            label5.Name = "label5";
            toolTip1.SetToolTip(label5, resources.GetString("label5.ToolTip"));
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.ForeColor = SystemColors.HotTrack;
            label3.Name = "label3";
            toolTip1.SetToolTip(label3, resources.GetString("label3.ToolTip"));
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.ForeColor = SystemColors.HotTrack;
            label6.Name = "label6";
            toolTip1.SetToolTip(label6, resources.GetString("label6.ToolTip"));
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.ForeColor = SystemColors.HotTrack;
            label8.Name = "label8";
            toolTip1.SetToolTip(label8, resources.GetString("label8.ToolTip"));
            // 
            // listBoxDevelopers
            // 
            resources.ApplyResources(listBoxDevelopers, "listBoxDevelopers");
            listBoxDevelopers.FormattingEnabled = true;
            listBoxDevelopers.Name = "listBoxDevelopers";
            toolTip1.SetToolTip(listBoxDevelopers, resources.GetString("listBoxDevelopers.ToolTip"));
            // 
            // labelAppCreationDate
            // 
            resources.ApplyResources(labelAppCreationDate, "labelAppCreationDate");
            labelAppCreationDate.ForeColor = SystemColors.HotTrack;
            labelAppCreationDate.Name = "labelAppCreationDate";
            toolTip1.SetToolTip(labelAppCreationDate, resources.GetString("labelAppCreationDate.ToolTip"));
            // 
            // label9
            // 
            resources.ApplyResources(label9, "label9");
            label9.ForeColor = SystemColors.HotTrack;
            label9.Name = "label9";
            toolTip1.SetToolTip(label9, resources.GetString("label9.ToolTip"));
            // 
            // FormSettings
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
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
        private Label label3;
        private Label label6;
        private Label label8;
        private ListBox listBoxDevelopers;
        private Label labelAppCreationDate;
        private Label label9;
    }
}