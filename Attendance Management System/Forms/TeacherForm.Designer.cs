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
            textBoxPhoneNumber = new TextBox();
            textBoxAddress = new TextBox();
            buttonEditYourData = new Button();
            labelPhone = new Label();
            labelTID = new Label();
            labelTAddress = new Label();
            labelEmail = new Label();
            labelTEmail = new Label();
            labelAge = new Label();
            labelTAge = new Label();
            labelID = new Label();
            pictureBox1 = new PictureBox();
            buttonMyCourses = new Button();
            listBoxCourses = new ListBox();
            buttonCancel = new Button();
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
            groupBoxProfileData.Controls.Add(buttonCancel);
            groupBoxProfileData.Controls.Add(textBoxPhoneNumber);
            groupBoxProfileData.Controls.Add(textBoxAddress);
            groupBoxProfileData.Controls.Add(buttonEditYourData);
            groupBoxProfileData.Controls.Add(labelPhone);
            groupBoxProfileData.Controls.Add(labelTID);
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
            groupBoxProfileData.Size = new Size(684, 148);
            groupBoxProfileData.TabIndex = 0;
            groupBoxProfileData.TabStop = false;
            groupBoxProfileData.Text = "Profile Data";
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.BackColor = Color.MediumOrchid;
            textBoxPhoneNumber.BorderStyle = BorderStyle.None;
            textBoxPhoneNumber.Location = new Point(456, 66);
            textBoxPhoneNumber.Multiline = true;
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.PlaceholderText = "Your Phone NUmber ...";
            textBoxPhoneNumber.ReadOnly = true;
            textBoxPhoneNumber.Size = new Size(218, 21);
            textBoxPhoneNumber.TabIndex = 7;
            // 
            // textBoxAddress
            // 
            textBoxAddress.BackColor = Color.MediumOrchid;
            textBoxAddress.BorderStyle = BorderStyle.None;
            textBoxAddress.Location = new Point(88, 66);
            textBoxAddress.Multiline = true;
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.PlaceholderText = "Your Address ...";
            textBoxAddress.ReadOnly = true;
            textBoxAddress.Size = new Size(218, 69);
            textBoxAddress.TabIndex = 6;
            // 
            // buttonEditYourData
            // 
            buttonEditYourData.BackColor = Color.Green;
            buttonEditYourData.ForeColor = Color.White;
            buttonEditYourData.Location = new Point(355, 99);
            buttonEditYourData.Name = "buttonEditYourData";
            buttonEditYourData.Size = new Size(171, 36);
            buttonEditYourData.TabIndex = 1;
            buttonEditYourData.Text = "Edit Your Data";
            buttonEditYourData.UseVisualStyleBackColor = false;
            buttonEditYourData.Click += buttonEditYourData_Click;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.ForeColor = Color.White;
            labelPhone.Location = new Point(317, 66);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(134, 21);
            labelPhone.TabIndex = 2;
            labelPhone.Text = "Phone Number :";
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
            // labelTAddress
            // 
            labelTAddress.AutoSize = true;
            labelTAddress.ForeColor = Color.White;
            labelTAddress.Location = new Point(6, 66);
            labelTAddress.Name = "labelTAddress";
            labelTAddress.Size = new Size(76, 21);
            labelTAddress.TabIndex = 0;
            labelTAddress.Text = "Address:";
            // 
            // labelEmail
            // 
            labelEmail.ForeColor = Color.White;
            labelEmail.Location = new Point(262, 33);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(198, 21);
            labelEmail.TabIndex = 0;
            labelEmail.Text = "ema";
            // 
            // labelTEmail
            // 
            labelTEmail.AutoSize = true;
            labelTEmail.ForeColor = Color.White;
            labelTEmail.Location = new Point(201, 33);
            labelTEmail.Name = "labelTEmail";
            labelTEmail.Size = new Size(55, 21);
            labelTEmail.TabIndex = 0;
            labelTEmail.Text = "Email:";
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.ForeColor = Color.White;
            labelAge.Location = new Point(457, 33);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(42, 21);
            labelAge.TabIndex = 0;
            labelAge.Text = "age";
            // 
            // labelTAge
            // 
            labelTAge.AutoSize = true;
            labelTAge.ForeColor = Color.White;
            labelTAge.Location = new Point(403, 33);
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
            // listBoxCourses
            // 
            listBoxCourses.FormattingEnabled = true;
            listBoxCourses.ItemHeight = 21;
            listBoxCourses.Location = new Point(468, 334);
            listBoxCourses.Name = "listBoxCourses";
            listBoxCourses.Size = new Size(120, 88);
            listBoxCourses.TabIndex = 5;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.Red;
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(532, 99);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(131, 36);
            buttonCancel.TabIndex = 2;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // TeacherForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 749);
            Controls.Add(listBoxCourses);
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
            Load += TeacherForm_Load;
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
        private Label labelTAddress;
        private Label labelEmail;
        private Label labelTEmail;
        private Label labelAge;
        private Label labelTAge;
        private Label labelTID;
        private PictureBox pictureBox1;
        private Button buttonMyCourses;
        private Label labelPhoneNmber;
        private Label labelPhone;
        private Button buttonEditYourData;
        private Label labelID;
        private ListBox listBoxCourses;
        private TextBox textBoxAddress;
        private TextBox textBoxPhoneNumber;
        private Button buttonCancel;
    }
}