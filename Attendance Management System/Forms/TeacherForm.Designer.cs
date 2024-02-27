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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            toolTip1 = new ToolTip(components);
            pictureBoxMinimize = new PictureBox();
            pictureBoxClose = new PictureBox();
            labelWellcome = new Label();
            labelTeacher_Name = new Label();
            groupBoxProfileData = new GroupBox();
            listBoxCourses = new ListBox();
            labelYourCourses = new Label();
            buttonCancel = new Button();
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
            dataGridViewCourses = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numberofsessionsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            courseBindingSource = new BindingSource(components);
            dataGridViewAttendance = new DataGridView();
            courseBindingSource1 = new BindingSource(components);
            dataGridViewDateStatus = new DataGridView();
            dateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sessionsBindingSource = new BindingSource(components);
            studentSessionsBindingSource = new BindingSource(components);
            dataGridViewStudentStatus = new DataGridView();
            textBoxCouseID = new TextBox();
            textBoxCourseName = new TextBox();
            textBoxCourseDescription = new TextBox();
            textBoxCourseSessions = new TextBox();
            textBoxDate = new TextBox();
            buttonGenATTTAble = new Button();
            buttonAttend = new Button();
            buttonAbsent = new Button();
            sessionsBindingSource1 = new BindingSource(components);
            sessionsBindingSource2 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            groupBoxProfileData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCourses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)courseBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAttendance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)courseBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDateStatus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sessionsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentSessionsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudentStatus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sessionsBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sessionsBindingSource2).BeginInit();
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
            labelWellcome.Size = new Size(271, 62);
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
            labelTeacher_Name.Size = new Size(397, 62);
            labelTeacher_Name.TabIndex = 0;
            labelTeacher_Name.Text = "Teacher_Name";
            // 
            // groupBoxProfileData
            // 
            groupBoxProfileData.BackColor = Color.MediumOrchid;
            groupBoxProfileData.Controls.Add(listBoxCourses);
            groupBoxProfileData.Controls.Add(labelYourCourses);
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
            groupBoxProfileData.Size = new Size(1176, 148);
            groupBoxProfileData.TabIndex = 0;
            groupBoxProfileData.TabStop = false;
            groupBoxProfileData.Text = "Profile Data";
            // 
            // listBoxCourses
            // 
            listBoxCourses.FormattingEnabled = true;
            listBoxCourses.ItemHeight = 23;
            listBoxCourses.Location = new Point(830, 22);
            listBoxCourses.Name = "listBoxCourses";
            listBoxCourses.Size = new Size(120, 73);
            listBoxCourses.TabIndex = 5;
            // 
            // labelYourCourses
            // 
            labelYourCourses.AutoSize = true;
            labelYourCourses.ForeColor = Color.White;
            labelYourCourses.Location = new Point(690, 22);
            labelYourCourses.Name = "labelYourCourses";
            labelYourCourses.Size = new Size(147, 23);
            labelYourCourses.TabIndex = 8;
            labelYourCourses.Text = "Your Courses: ";
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
            labelPhone.Size = new Size(168, 23);
            labelPhone.TabIndex = 2;
            labelPhone.Text = "Phone Number :";
            // 
            // labelTID
            // 
            labelTID.AutoSize = true;
            labelTID.ForeColor = Color.White;
            labelTID.Location = new Point(6, 33);
            labelTID.Name = "labelTID";
            labelTID.Size = new Size(41, 23);
            labelTID.TabIndex = 1;
            labelTID.Text = "ID: ";
            // 
            // labelTAddress
            // 
            labelTAddress.AutoSize = true;
            labelTAddress.ForeColor = Color.White;
            labelTAddress.Location = new Point(6, 66);
            labelTAddress.Name = "labelTAddress";
            labelTAddress.Size = new Size(93, 23);
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
            labelTEmail.Size = new Size(67, 23);
            labelTEmail.TabIndex = 0;
            labelTEmail.Text = "Email:";
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.ForeColor = Color.White;
            labelAge.Location = new Point(457, 33);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(50, 23);
            labelAge.TabIndex = 0;
            labelAge.Text = "age";
            // 
            // labelTAge
            // 
            labelTAge.AutoSize = true;
            labelTAge.ForeColor = Color.White;
            labelTAge.Location = new Point(403, 33);
            labelTAge.Name = "labelTAge";
            labelTAge.Size = new Size(56, 23);
            labelTAge.TabIndex = 0;
            labelTAge.Text = "Age:";
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.ForeColor = Color.White;
            labelID.Location = new Point(47, 33);
            labelID.Name = "labelID";
            labelID.Size = new Size(27, 23);
            labelID.TabIndex = 0;
            labelID.Text = "id";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(781, 270);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(342, 350);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // buttonMyCourses
            // 
            buttonMyCourses.BackColor = Color.Green;
            buttonMyCourses.Location = new Point(702, 24);
            buttonMyCourses.Name = "buttonMyCourses";
            buttonMyCourses.Size = new Size(239, 78);
            buttonMyCourses.TabIndex = 4;
            buttonMyCourses.Text = "Get My Courses";
            buttonMyCourses.UseVisualStyleBackColor = false;
            buttonMyCourses.Click += buttonMyCourses_Click;
            // 
            // dataGridViewCourses
            // 
            dataGridViewCourses.AllowUserToOrderColumns = true;
            dataGridViewCourses.AutoGenerateColumns = false;
            dataGridViewCourses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.Orange;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewCourses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCourses.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, numberofsessionsDataGridViewTextBoxColumn });
            dataGridViewCourses.DataSource = courseBindingSource;
            dataGridViewCourses.Location = new Point(12, 270);
            dataGridViewCourses.Name = "dataGridViewCourses";
            dataGridViewCourses.RowHeadersWidth = 51;
            dataGridViewCourses.Size = new Size(628, 150);
            dataGridViewCourses.TabIndex = 5;
            dataGridViewCourses.CellClick += dataGridViewCourses_CellClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // numberofsessionsDataGridViewTextBoxColumn
            // 
            numberofsessionsDataGridViewTextBoxColumn.DataPropertyName = "Numberofsessions";
            numberofsessionsDataGridViewTextBoxColumn.HeaderText = "Numberofsessions";
            numberofsessionsDataGridViewTextBoxColumn.MinimumWidth = 6;
            numberofsessionsDataGridViewTextBoxColumn.Name = "numberofsessionsDataGridViewTextBoxColumn";
            // 
            // courseBindingSource
            // 
            courseBindingSource.DataSource = typeof(classes.Course);
            // 
            // dataGridViewAttendance
            // 
            dataGridViewAttendance.AllowUserToOrderColumns = true;
            dataGridViewAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAttendance.GridColor = SystemColors.WindowText;
            dataGridViewAttendance.Location = new Point(12, 426);
            dataGridViewAttendance.Name = "dataGridViewAttendance";
            dataGridViewAttendance.RowHeadersWidth = 51;
            dataGridViewAttendance.Size = new Size(628, 150);
            dataGridViewAttendance.TabIndex = 6;
            dataGridViewAttendance.CellFormatting += dataGridViewAttendance_CellFormatting;
            // 
            // courseBindingSource1
            // 
            courseBindingSource1.DataSource = typeof(classes.Course);
            // 
            // dataGridViewDateStatus
            // 
            dataGridViewDateStatus.AllowUserToOrderColumns = true;
            dataGridViewDateStatus.AutoGenerateColumns = false;
            dataGridViewDateStatus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDateStatus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDateStatus.Columns.AddRange(new DataGridViewColumn[] { dateDataGridViewTextBoxColumn });
            dataGridViewDateStatus.DataSource = sessionsBindingSource;
            dataGridViewDateStatus.GridColor = SystemColors.WindowText;
            dataGridViewDateStatus.Location = new Point(646, 270);
            dataGridViewDateStatus.Name = "dataGridViewDateStatus";
            dataGridViewDateStatus.RowHeadersWidth = 51;
            dataGridViewDateStatus.Size = new Size(242, 150);
            dataGridViewDateStatus.TabIndex = 7;
            dataGridViewDateStatus.CellContentClick += dataGridViewDateStatus_CellContentClick;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            dateDataGridViewTextBoxColumn.HeaderText = "Date";
            dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // sessionsBindingSource
            // 
            sessionsBindingSource.DataMember = "Sessions";
            sessionsBindingSource.DataSource = studentSessionsBindingSource;
            // 
            // studentSessionsBindingSource
            // 
            studentSessionsBindingSource.DataSource = typeof(classes.StudentSessions);
            // 
            // dataGridViewStudentStatus
            // 
            dataGridViewStudentStatus.AllowUserToOrderColumns = true;
            dataGridViewStudentStatus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStudentStatus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudentStatus.GridColor = SystemColors.WindowText;
            dataGridViewStudentStatus.Location = new Point(12, 582);
            dataGridViewStudentStatus.Name = "dataGridViewStudentStatus";
            dataGridViewStudentStatus.RowHeadersWidth = 51;
            dataGridViewStudentStatus.Size = new Size(542, 150);
            dataGridViewStudentStatus.TabIndex = 8;
            dataGridViewStudentStatus.CellClick += dataGridViewStudentStatus_CellClick;
            // 
            // textBoxCouseID
            // 
            textBoxCouseID.Location = new Point(656, 444);
            textBoxCouseID.Name = "textBoxCouseID";
            textBoxCouseID.Size = new Size(100, 32);
            textBoxCouseID.TabIndex = 9;
            textBoxCouseID.Text = "textBoxID";
            // 
            // textBoxCourseName
            // 
            textBoxCourseName.Location = new Point(656, 477);
            textBoxCourseName.Name = "textBoxCourseName";
            textBoxCourseName.Size = new Size(100, 32);
            textBoxCourseName.TabIndex = 10;
            textBoxCourseName.Text = "textBoxID";
            // 
            // textBoxCourseDescription
            // 
            textBoxCourseDescription.Location = new Point(656, 510);
            textBoxCourseDescription.Name = "textBoxCourseDescription";
            textBoxCourseDescription.Size = new Size(100, 32);
            textBoxCourseDescription.TabIndex = 11;
            textBoxCourseDescription.Text = "textBoxCourseDescription";
            // 
            // textBoxCourseSessions
            // 
            textBoxCourseSessions.Location = new Point(656, 543);
            textBoxCourseSessions.Name = "textBoxCourseSessions";
            textBoxCourseSessions.Size = new Size(100, 32);
            textBoxCourseSessions.TabIndex = 12;
            textBoxCourseSessions.Text = "textBoxCourseSessions";
            // 
            // textBoxDate
            // 
            textBoxDate.Location = new Point(656, 576);
            textBoxDate.Multiline = true;
            textBoxDate.Name = "textBoxDate";
            textBoxDate.Size = new Size(119, 27);
            textBoxDate.TabIndex = 13;
            textBoxDate.Text = "textBoxDate";
            // 
            // buttonGenATTTAble
            // 
            buttonGenATTTAble.BackColor = Color.Green;
            buttonGenATTTAble.ForeColor = Color.White;
            buttonGenATTTAble.Location = new Point(560, 680);
            buttonGenATTTAble.Name = "buttonGenATTTAble";
            buttonGenATTTAble.Size = new Size(269, 52);
            buttonGenATTTAble.TabIndex = 9;
            buttonGenATTTAble.Text = "Generate Attendance Table";
            buttonGenATTTAble.UseVisualStyleBackColor = false;
            buttonGenATTTAble.Click += buttonGenATTTAble_Click;
            // 
            // buttonAttend
            // 
            buttonAttend.BackColor = Color.Green;
            buttonAttend.ForeColor = Color.White;
            buttonAttend.Location = new Point(702, 622);
            buttonAttend.Name = "buttonAttend";
            buttonAttend.Size = new Size(126, 52);
            buttonAttend.TabIndex = 14;
            buttonAttend.Text = "Attend";
            buttonAttend.UseVisualStyleBackColor = false;
            buttonAttend.Visible = false;
            buttonAttend.Click += buttonAttend_Click;
            // 
            // buttonAbsent
            // 
            buttonAbsent.BackColor = Color.Red;
            buttonAbsent.ForeColor = Color.White;
            buttonAbsent.Location = new Point(560, 622);
            buttonAbsent.Name = "buttonAbsent";
            buttonAbsent.Size = new Size(126, 52);
            buttonAbsent.TabIndex = 15;
            buttonAbsent.Text = "Absent";
            buttonAbsent.UseVisualStyleBackColor = false;
            buttonAbsent.Visible = false;
            // 
            // sessionsBindingSource1
            // 
            sessionsBindingSource1.DataMember = "Sessions";
            sessionsBindingSource1.DataSource = studentSessionsBindingSource;
            // 
            // sessionsBindingSource2
            // 
            sessionsBindingSource2.DataMember = "Sessions";
            sessionsBindingSource2.DataSource = studentSessionsBindingSource;
            // 
            // TeacherForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 749);
            Controls.Add(buttonAbsent);
            Controls.Add(buttonAttend);
            Controls.Add(buttonGenATTTAble);
            Controls.Add(textBoxDate);
            Controls.Add(textBoxCourseSessions);
            Controls.Add(textBoxCourseDescription);
            Controls.Add(textBoxCourseName);
            Controls.Add(textBoxCouseID);
            Controls.Add(dataGridViewStudentStatus);
            Controls.Add(dataGridViewDateStatus);
            Controls.Add(dataGridViewAttendance);
            Controls.Add(dataGridViewCourses);
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
            ((System.ComponentModel.ISupportInitialize)dataGridViewCourses).EndInit();
            ((System.ComponentModel.ISupportInitialize)courseBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAttendance).EndInit();
            ((System.ComponentModel.ISupportInitialize)courseBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDateStatus).EndInit();
            ((System.ComponentModel.ISupportInitialize)sessionsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentSessionsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudentStatus).EndInit();
            ((System.ComponentModel.ISupportInitialize)sessionsBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)sessionsBindingSource2).EndInit();
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
        private Label labelYourCourses;
        private DataGridView dataGridViewCourses;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numberofsessionsDataGridViewTextBoxColumn;
        private BindingSource courseBindingSource;
        private DataGridView dataGridViewAttendance;
        private BindingSource courseBindingSource1;
        private BindingSource sessionsBindingSource;
        private BindingSource studentSessionsBindingSource;
        private DataGridView dataGridViewDateStatus;
        private DataGridView dataGridViewStudentStatus;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private TextBox textBoxCouseID;
        private TextBox textBoxCourseName;
        private TextBox textBoxCourseDescription;
        private TextBox textBoxCourseSessions;
        private TextBox textBoxDate;
        private Button buttonGenATTTAble;
        private Button buttonAttend;
        private Button buttonAbsent;
        private BindingSource sessionsBindingSource2;
        private BindingSource sessionsBindingSource1;
    }
}