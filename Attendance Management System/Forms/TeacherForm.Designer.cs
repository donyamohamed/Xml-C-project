namespace Attendance_Management_System.Forms
{
    partial class TeacherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherForm));
            toolTip1 = new ToolTip(components);
            pictureBoxMinimize = new PictureBox();
            pictureBoxClose = new PictureBox();
            labelWellcome = new Label();
            labelTeacher_Name = new Label();
            groupBoxProfileData = new GroupBox();
            labelTID = new Label();
            labelAddress = new Label();
            labelTAddress = new Label();
            labelEmail = new Label();
            labelTEmail = new Label();
            labelAge = new Label();
            labelTAge = new Label();
            labelID = new Label();
            pictureBox1 = new PictureBox();
            buttonMyCourses = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            groupBoxProfileData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxMinimize
            // 
            pictureBoxMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxMinimize.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxMinimize.Cursor = Cursors.Hand;
            pictureBoxMinimize.Image = (Image)resources.GetObject("pictureBoxMinimize.Image");
            pictureBoxMinimize.Location = new Point(1073, 12);
            pictureBoxMinimize.Name = "pictureBoxMinimize";
            pictureBoxMinimize.Size = new Size(50, 50);
            pictureBoxMinimize.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMinimize.TabIndex = 1;
            pictureBoxMinimize.TabStop = false;
            pictureBoxMinimize.Click += pictureBoxMinimize_Click;
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxClose.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxClose.Cursor = Cursors.Hand;
            pictureBoxClose.Image = (Image)resources.GetObject("pictureBoxClose.Image");
            pictureBoxClose.Location = new Point(1138, 12);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(50, 50);
            pictureBoxClose.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxClose.TabIndex = 2;
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += pictureBoxClose_Click;
            // 
            // labelWellcome
            // 
            labelWellcome.AutoSize = true;
            labelWellcome.Font = new Font("Century Gothic", 30F, FontStyle.Bold | FontStyle.Italic);
            labelWellcome.ForeColor = Color.Purple;
            labelWellcome.Location = new Point(48, 39);
            labelWellcome.Name = "labelWellcome";
            labelWellcome.Size = new Size(220, 50);
            labelWellcome.TabIndex = 0;
            labelWellcome.Text = "Wellcome";
            // 
            // labelTeacher_Name
            // 
            labelTeacher_Name.AutoSize = true;
            labelTeacher_Name.Font = new Font("Century Gothic", 30F, FontStyle.Bold | FontStyle.Italic);
            labelTeacher_Name.ForeColor = Color.Purple;
            labelTeacher_Name.Location = new Point(274, 39);
            labelTeacher_Name.Name = "labelTeacher_Name";
            labelTeacher_Name.Size = new Size(320, 50);
            labelTeacher_Name.TabIndex = 0;
            labelTeacher_Name.Text = "Teacher_Name";
            // 
            // groupBoxProfileData
            // 
            groupBoxProfileData.BackColor = Color.MediumOrchid;
            groupBoxProfileData.Controls.Add(labelTID);
            groupBoxProfileData.Controls.Add(labelAddress);
            groupBoxProfileData.Controls.Add(labelTAddress);
            groupBoxProfileData.Controls.Add(labelEmail);
            groupBoxProfileData.Controls.Add(labelTEmail);
            groupBoxProfileData.Controls.Add(labelAge);
            groupBoxProfileData.Controls.Add(labelTAge);
            groupBoxProfileData.Controls.Add(labelID);
            groupBoxProfileData.ForeColor = SystemColors.HotTrack;
            groupBoxProfileData.Location = new Point(12, 107);
            groupBoxProfileData.Margin = new Padding(3, 2, 3, 2);
            groupBoxProfileData.Name = "groupBoxProfileData";
            groupBoxProfileData.Padding = new Padding(3, 2, 3, 2);
            groupBoxProfileData.Size = new Size(582, 122);
            groupBoxProfileData.TabIndex = 0;
            groupBoxProfileData.TabStop = false;
            groupBoxProfileData.Text = "Profile Data";
            // 
            // labelTID
            // 
            labelTID.AutoSize = true;
            labelTID.ForeColor = Color.White;
            labelTID.Location = new Point(6, 33);
            labelTID.Name = "labelTID";
            labelTID.Size = new Size(35, 21);
            labelTID.TabIndex = 1;
            labelTID.Text = "ID: ";
            // 
            // labelAddress
            // 
            labelAddress.ForeColor = Color.White;
            labelAddress.Location = new Point(399, 66);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(183, 21);
            labelAddress.TabIndex = 0;
            labelAddress.Text = "add";
            // 
            // labelTAddress
            // 
            labelTAddress.AutoSize = true;
            labelTAddress.ForeColor = Color.White;
            labelTAddress.Location = new Point(317, 66);
            labelTAddress.Name = "labelTAddress";
            labelTAddress.Size = new Size(76, 21);
            labelTAddress.TabIndex = 0;
            labelTAddress.Text = "Address:";
            // 
            // labelEmail
            // 
            labelEmail.ForeColor = Color.White;
            labelEmail.Location = new Point(378, 33);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(198, 21);
            labelEmail.TabIndex = 0;
            labelEmail.Text = "ema";
            // 
            // labelTEmail
            // 
            labelTEmail.AutoSize = true;
            labelTEmail.ForeColor = Color.White;
            labelTEmail.Location = new Point(317, 33);
            labelTEmail.Name = "labelTEmail";
            labelTEmail.Size = new Size(55, 21);
            labelTEmail.TabIndex = 0;
            labelTEmail.Text = "Email:";
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.ForeColor = Color.White;
            labelAge.Location = new Point(60, 66);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(42, 21);
            labelAge.TabIndex = 0;
            labelAge.Text = "age";
            // 
            // labelTAge
            // 
            labelTAge.AutoSize = true;
            labelTAge.ForeColor = Color.White;
            labelTAge.Location = new Point(6, 66);
            labelTAge.Name = "labelTAge";
            labelTAge.Size = new Size(48, 21);
            labelTAge.TabIndex = 0;
            labelTAge.Text = "Age:";
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.ForeColor = Color.White;
            labelID.Location = new Point(47, 33);
            labelID.Name = "labelID";
            labelID.Size = new Size(24, 21);
            labelID.TabIndex = 0;
            labelID.Text = "id";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(781, 173);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(342, 350);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // buttonMyCourses
            // 
            buttonMyCourses.BackColor = Color.Green;
            buttonMyCourses.Location = new Point(126, 308);
            buttonMyCourses.Name = "buttonMyCourses";
            buttonMyCourses.Size = new Size(239, 78);
            buttonMyCourses.TabIndex = 4;
            buttonMyCourses.Text = "Get My Courses";
            buttonMyCourses.UseVisualStyleBackColor = false;
            buttonMyCourses.Click += buttonMyCourses_Click;
            // 
            // TeacherForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 749);
            Controls.Add(buttonMyCourses);
            Controls.Add(pictureBox1);
            Controls.Add(groupBoxProfileData);
            Controls.Add(labelTeacher_Name);
            Controls.Add(labelWellcome);
            Controls.Add(pictureBoxMinimize);
            Controls.Add(pictureBoxClose);
            Font = new Font("Century Gothic", 12F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "TeacherForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TeacherForm";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            groupBoxProfileData.ResumeLayout(false);
            groupBoxProfileData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolTip toolTip1;
        private PictureBox pictureBoxMinimize;
        private PictureBox pictureBoxClose;
        private Label labelWellcome;
        private Label labelTeacher_Name;
        private GroupBox groupBoxProfileData;
        private Label labelAddress;
        private Label labelTAddress;
        private Label labelEmail;
        private Label labelTEmail;
        private Label labelAge;
        private Label labelTAge;
        private Label labelID;
        private Label labelTID;
        private PictureBox pictureBox1;
        private Button buttonMyCourses;
    }
}