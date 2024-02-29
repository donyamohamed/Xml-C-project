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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            pictureBoxMinimize = new System.Windows.Forms.PictureBox();
            pictureBoxClose = new System.Windows.Forms.PictureBox();
            labelWellcome = new System.Windows.Forms.Label();
            labelTeacher_Name = new System.Windows.Forms.Label();
            groupBoxProfileData = new System.Windows.Forms.GroupBox();
            listBoxCDates = new System.Windows.Forms.ListBox();
            label1 = new System.Windows.Forms.Label();
            listBoxCourses = new System.Windows.Forms.ListBox();
            labelYourCourses = new System.Windows.Forms.Label();
            buttonCancel = new System.Windows.Forms.Button();
            textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            textBoxAddress = new System.Windows.Forms.TextBox();
            buttonEditYourData = new System.Windows.Forms.Button();
            labelPhone = new System.Windows.Forms.Label();
            labelTID = new System.Windows.Forms.Label();
            labelTAddress = new System.Windows.Forms.Label();
            labelEmail = new System.Windows.Forms.Label();
            labelTEmail = new System.Windows.Forms.Label();
            labelAge = new System.Windows.Forms.Label();
            labelTAge = new System.Windows.Forms.Label();
            labelID = new System.Windows.Forms.Label();
            comboBoxCourseDates = new System.Windows.Forms.ComboBox();
            dataGridViewCourses = new System.Windows.Forms.DataGridView();
            idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            numberofsessionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            courseBindingSource = new System.Windows.Forms.BindingSource(components);
            dataGridViewAttendance = new System.Windows.Forms.DataGridView();
            courseBindingSource1 = new System.Windows.Forms.BindingSource(components);
            sessionsBindingSource = new System.Windows.Forms.BindingSource(components);
            studentSessionsBindingSource = new System.Windows.Forms.BindingSource(components);
            dataGridViewStudentStatus = new System.Windows.Forms.DataGridView();
            textBoxCouseID = new System.Windows.Forms.TextBox();
            textBoxCourseName = new System.Windows.Forms.TextBox();
            textBoxCourseDescription = new System.Windows.Forms.TextBox();
            textBoxCourseSessions = new System.Windows.Forms.TextBox();
            textBoxDate = new System.Windows.Forms.TextBox();
            buttonAttend = new System.Windows.Forms.Button();
            buttonAbsent = new System.Windows.Forms.Button();
            sessionsBindingSource1 = new System.Windows.Forms.BindingSource(components);
            sessionsBindingSource2 = new System.Windows.Forms.BindingSource(components);
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            groupBoxProfileData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCourses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)courseBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAttendance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)courseBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sessionsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentSessionsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudentStatus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sessionsBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sessionsBindingSource2).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMinimize
            // 
            pictureBoxMinimize.Anchor = System.Windows.Forms.AnchorStyles.Top;
            pictureBoxMinimize.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            pictureBoxMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            pictureBoxMinimize.Image = (System.Drawing.Image)resources.GetObject("pictureBoxMinimize.Image");
            pictureBoxMinimize.Location = new System.Drawing.Point(1062, 9);
            pictureBoxMinimize.Name = "pictureBoxMinimize";
            pictureBoxMinimize.Size = new System.Drawing.Size(50, 50);
            pictureBoxMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBoxMinimize.TabIndex = 1;
            pictureBoxMinimize.TabStop = false;
            pictureBoxMinimize.Click += this.pictureBoxMinimize_Click;
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            pictureBoxClose.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            pictureBoxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            pictureBoxClose.Image = (System.Drawing.Image)resources.GetObject("pictureBoxClose.Image");
            pictureBoxClose.Location = new System.Drawing.Point(1138, 9);
            pictureBoxClose.Margin = new System.Windows.Forms.Padding(0);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new System.Drawing.Size(50, 50);
            pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBoxClose.TabIndex = 2;
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += this.pictureBoxClose_Click;
            // 
            // labelWellcome
            // 
            labelWellcome.AutoSize = true;
            labelWellcome.Font = new System.Drawing.Font("Century Gothic", 30F, (System.Drawing.FontStyle)System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            labelWellcome.ForeColor = System.Drawing.Color.Purple;
            labelWellcome.Location = new System.Drawing.Point(12, 9);
            labelWellcome.Name = "labelWellcome";
            labelWellcome.Size = new System.Drawing.Size(220, 50);
            labelWellcome.TabIndex = 0;
            labelWellcome.Text = "Wellcome";
            // 
            // labelTeacher_Name
            // 
            labelTeacher_Name.AutoSize = true;
            labelTeacher_Name.Font = new System.Drawing.Font("Century Gothic", 30F, (System.Drawing.FontStyle)System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            labelTeacher_Name.ForeColor = System.Drawing.Color.Purple;
            labelTeacher_Name.Location = new System.Drawing.Point(238, 9);
            labelTeacher_Name.Name = "labelTeacher_Name";
            labelTeacher_Name.Size = new System.Drawing.Size(320, 50);
            labelTeacher_Name.TabIndex = 0;
            labelTeacher_Name.Text = "Teacher_Name";
            // 
            // groupBoxProfileData
            // 
            groupBoxProfileData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            groupBoxProfileData.BackColor = System.Drawing.Color.MediumOrchid;
            groupBoxProfileData.Controls.Add(listBoxCDates);
            groupBoxProfileData.Controls.Add(label1);
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
            groupBoxProfileData.ForeColor = System.Drawing.SystemColors.HotTrack;
            groupBoxProfileData.Location = new System.Drawing.Point(12, 67);
            groupBoxProfileData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBoxProfileData.Name = "groupBoxProfileData";
            groupBoxProfileData.Padding = new System.Windows.Forms.Padding(0);
            groupBoxProfileData.Size = new System.Drawing.Size(1176, 148);
            groupBoxProfileData.TabIndex = 0;
            groupBoxProfileData.TabStop = false;
            groupBoxProfileData.Text = "Profile Data";
            // 
            // listBoxCDates
            // 
            listBoxCDates.FormattingEnabled = true;
            listBoxCDates.ItemHeight = 21;
            listBoxCDates.Location = new System.Drawing.Point(1050, 22);
            listBoxCDates.Name = "listBoxCDates";
            listBoxCDates.Size = new System.Drawing.Size(120, 88);
            listBoxCDates.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(914, 20);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(127, 21);
            label1.TabIndex = 10;
            label1.Text = "Your Calender:";
            // 
            // listBoxCourses
            // 
            listBoxCourses.FormattingEnabled = true;
            listBoxCourses.ItemHeight = 21;
            listBoxCourses.Location = new System.Drawing.Point(791, 22);
            listBoxCourses.Name = "listBoxCourses";
            listBoxCourses.Size = new System.Drawing.Size(120, 88);
            listBoxCourses.TabIndex = 5;
            // 
            // labelYourCourses
            // 
            labelYourCourses.AutoSize = true;
            labelYourCourses.ForeColor = System.Drawing.Color.White;
            labelYourCourses.Location = new System.Drawing.Point(633, 20);
            labelYourCourses.Name = "labelYourCourses";
            labelYourCourses.Size = new System.Drawing.Size(149, 21);
            labelYourCourses.TabIndex = 8;
            labelYourCourses.Text = "Your Courses List:  ";
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = System.Drawing.Color.Red;
            buttonCancel.ForeColor = System.Drawing.Color.White;
            buttonCancel.Location = new System.Drawing.Point(312, 99);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new System.Drawing.Size(131, 36);
            buttonCancel.TabIndex = 2;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += this.buttonCancel_Click;
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.BackColor = System.Drawing.Color.MediumOrchid;
            textBoxPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBoxPhoneNumber.Location = new System.Drawing.Point(456, 66);
            textBoxPhoneNumber.Multiline = true;
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.PlaceholderText = "Your Phone NUmber ...";
            textBoxPhoneNumber.ReadOnly = true;
            textBoxPhoneNumber.Size = new System.Drawing.Size(218, 21);
            textBoxPhoneNumber.TabIndex = 7;
            // 
            // textBoxAddress
            // 
            textBoxAddress.BackColor = System.Drawing.Color.MediumOrchid;
            textBoxAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBoxAddress.Location = new System.Drawing.Point(88, 66);
            textBoxAddress.Multiline = true;
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.PlaceholderText = "Your Address ...";
            textBoxAddress.ReadOnly = true;
            textBoxAddress.Size = new System.Drawing.Size(218, 69);
            textBoxAddress.TabIndex = 6;
            // 
            // buttonEditYourData
            // 
            buttonEditYourData.BackColor = System.Drawing.Color.Green;
            buttonEditYourData.ForeColor = System.Drawing.Color.White;
            buttonEditYourData.Location = new System.Drawing.Point(457, 99);
            buttonEditYourData.Name = "buttonEditYourData";
            buttonEditYourData.Size = new System.Drawing.Size(171, 36);
            buttonEditYourData.TabIndex = 1;
            buttonEditYourData.Text = "Edit Your Data";
            buttonEditYourData.UseVisualStyleBackColor = false;
            buttonEditYourData.Click += this.buttonEditYourData_Click;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.ForeColor = System.Drawing.Color.White;
            labelPhone.Location = new System.Drawing.Point(314, 64);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new System.Drawing.Size(134, 21);
            labelPhone.TabIndex = 2;
            labelPhone.Text = "Phone Number :";
            // 
            // labelTID
            // 
            labelTID.AutoSize = true;
            labelTID.ForeColor = System.Drawing.Color.White;
            labelTID.Location = new System.Drawing.Point(3, 31);
            labelTID.Name = "labelTID";
            labelTID.Size = new System.Drawing.Size(35, 21);
            labelTID.TabIndex = 1;
            labelTID.Text = "ID: ";
            // 
            // labelTAddress
            // 
            labelTAddress.AutoSize = true;
            labelTAddress.ForeColor = System.Drawing.Color.White;
            labelTAddress.Location = new System.Drawing.Point(3, 64);
            labelTAddress.Name = "labelTAddress";
            labelTAddress.Size = new System.Drawing.Size(76, 21);
            labelTAddress.TabIndex = 0;
            labelTAddress.Text = "Address:";
            // 
            // labelEmail
            // 
            labelEmail.ForeColor = System.Drawing.Color.White;
            labelEmail.Location = new System.Drawing.Point(262, 33);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new System.Drawing.Size(198, 21);
            labelEmail.TabIndex = 0;
            labelEmail.Text = "ema";
            // 
            // labelTEmail
            // 
            labelTEmail.AutoSize = true;
            labelTEmail.ForeColor = System.Drawing.Color.White;
            labelTEmail.Location = new System.Drawing.Point(198, 31);
            labelTEmail.Name = "labelTEmail";
            labelTEmail.Size = new System.Drawing.Size(55, 21);
            labelTEmail.TabIndex = 0;
            labelTEmail.Text = "Email:";
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.ForeColor = System.Drawing.Color.White;
            labelAge.Location = new System.Drawing.Point(454, 31);
            labelAge.Name = "labelAge";
            labelAge.Size = new System.Drawing.Size(42, 21);
            labelAge.TabIndex = 0;
            labelAge.Text = "age";
            // 
            // labelTAge
            // 
            labelTAge.AutoSize = true;
            labelTAge.ForeColor = System.Drawing.Color.White;
            labelTAge.Location = new System.Drawing.Point(400, 31);
            labelTAge.Name = "labelTAge";
            labelTAge.Size = new System.Drawing.Size(48, 21);
            labelTAge.TabIndex = 0;
            labelTAge.Text = "Age:";
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.ForeColor = System.Drawing.Color.White;
            labelID.Location = new System.Drawing.Point(44, 31);
            labelID.Name = "labelID";
            labelID.Size = new System.Drawing.Size(24, 21);
            labelID.TabIndex = 0;
            labelID.Text = "id";
            // 
            // comboBoxCourseDates
            // 
            comboBoxCourseDates.FormattingEnabled = true;
            comboBoxCourseDates.Location = new System.Drawing.Point(12, 304);
            comboBoxCourseDates.Name = "comboBoxCourseDates";
            comboBoxCourseDates.Size = new System.Drawing.Size(186, 29);
            comboBoxCourseDates.TabIndex = 9;
            comboBoxCourseDates.SelectedIndexChanged += this.comboBox1_SelectedIndexChanged;
            // 
            // dataGridViewCourses
            // 
            dataGridViewCourses.AllowUserToAddRows = false;
            dataGridViewCourses.AllowUserToDeleteRows = false;
            dataGridViewCourses.AllowUserToOrderColumns = true;
            dataGridViewCourses.AutoGenerateColumns = false;
            dataGridViewCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCourses.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCourses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridViewCourses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, numberofsessionsDataGridViewTextBoxColumn });
            dataGridViewCourses.DataSource = courseBindingSource;
            dataGridViewCourses.Location = new System.Drawing.Point(219, 227);
            dataGridViewCourses.Name = "dataGridViewCourses";
            dataGridViewCourses.ReadOnly = true;
            dataGridViewCourses.Size = new System.Drawing.Size(546, 182);
            dataGridViewCourses.TabIndex = 5;
            dataGridViewCourses.CellClick += this.dataGridViewCourses_CellClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberofsessionsDataGridViewTextBoxColumn
            // 
            numberofsessionsDataGridViewTextBoxColumn.DataPropertyName = "Numberofsessions";
            numberofsessionsDataGridViewTextBoxColumn.HeaderText = "Numberofsessions";
            numberofsessionsDataGridViewTextBoxColumn.MinimumWidth = 6;
            numberofsessionsDataGridViewTextBoxColumn.Name = "numberofsessionsDataGridViewTextBoxColumn";
            numberofsessionsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseBindingSource
            // 
            courseBindingSource.DataSource = typeof(Attendance_Management_System.classes.Course);
            // 
            // dataGridViewAttendance
            // 
            dataGridViewAttendance.AllowUserToOrderColumns = true;
            dataGridViewAttendance.Anchor = System.Windows.Forms.AnchorStyles.Top;
            dataGridViewAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAttendance.BackgroundColor = System.Drawing.Color.White;
            dataGridViewAttendance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAttendance.GridColor = System.Drawing.SystemColors.WindowText;
            dataGridViewAttendance.Location = new System.Drawing.Point(771, 227);
            dataGridViewAttendance.Name = "dataGridViewAttendance";
            dataGridViewAttendance.Size = new System.Drawing.Size(417, 510);
            dataGridViewAttendance.TabIndex = 6;
            dataGridViewAttendance.CellFormatting += this.dataGridViewAttendance_CellFormatting;
            // 
            // courseBindingSource1
            // 
            courseBindingSource1.DataSource = typeof(Attendance_Management_System.classes.Course);
            // 
            // sessionsBindingSource
            // 
            sessionsBindingSource.DataMember = "Sessions";
            sessionsBindingSource.DataSource = studentSessionsBindingSource;
            // 
            // studentSessionsBindingSource
            // 
            studentSessionsBindingSource.DataSource = typeof(Attendance_Management_System.classes.StudentSessions);
            // 
            // dataGridViewStudentStatus
            // 
            dataGridViewStudentStatus.AllowUserToAddRows = false;
            dataGridViewStudentStatus.AllowUserToDeleteRows = false;
            dataGridViewStudentStatus.AllowUserToOrderColumns = true;
            dataGridViewStudentStatus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStudentStatus.BackgroundColor = System.Drawing.Color.White;
            dataGridViewStudentStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewStudentStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudentStatus.GridColor = System.Drawing.SystemColors.WindowText;
            dataGridViewStudentStatus.Location = new System.Drawing.Point(137, 415);
            dataGridViewStudentStatus.Name = "dataGridViewStudentStatus";
            dataGridViewStudentStatus.ReadOnly = true;
            dataGridViewStudentStatus.Size = new System.Drawing.Size(628, 322);
            dataGridViewStudentStatus.TabIndex = 8;
            dataGridViewStudentStatus.CellClick += this.dataGridViewStudentStatus_CellClick;
            dataGridViewStudentStatus.CellFormatting += this.dataGridViewStudentStatus_CellFormatting;
            // 
            // textBoxCouseID
            // 
            textBoxCouseID.Location = new System.Drawing.Point(12, 415);
            textBoxCouseID.Name = "textBoxCouseID";
            textBoxCouseID.Size = new System.Drawing.Size(119, 27);
            textBoxCouseID.TabIndex = 9;
            textBoxCouseID.Text = "textBoxID";
            // 
            // textBoxCourseName
            // 
            textBoxCourseName.Location = new System.Drawing.Point(12, 459);
            textBoxCourseName.Name = "textBoxCourseName";
            textBoxCourseName.Size = new System.Drawing.Size(119, 27);
            textBoxCourseName.TabIndex = 10;
            textBoxCourseName.Text = "textBoxID";
            // 
            // textBoxCourseDescription
            // 
            textBoxCourseDescription.Location = new System.Drawing.Point(12, 503);
            textBoxCourseDescription.Name = "textBoxCourseDescription";
            textBoxCourseDescription.Size = new System.Drawing.Size(119, 27);
            textBoxCourseDescription.TabIndex = 11;
            textBoxCourseDescription.Text = "textBoxCourseDescription";
            // 
            // textBoxCourseSessions
            // 
            textBoxCourseSessions.Location = new System.Drawing.Point(12, 547);
            textBoxCourseSessions.Name = "textBoxCourseSessions";
            textBoxCourseSessions.Size = new System.Drawing.Size(119, 27);
            textBoxCourseSessions.TabIndex = 12;
            textBoxCourseSessions.Text = "textBoxCourseSessions";
            // 
            // textBoxDate
            // 
            textBoxDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBoxDate.Font = new System.Drawing.Font("Century Gothic", 20F);
            textBoxDate.Location = new System.Drawing.Point(12, 356);
            textBoxDate.Name = "textBoxDate";
            textBoxDate.Size = new System.Drawing.Size(186, 33);
            textBoxDate.TabIndex = 13;
            textBoxDate.Text = "Date ...";
            textBoxDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            textBoxDate.WordWrap = false;
            // 
            // buttonAttend
            // 
            buttonAttend.BackColor = System.Drawing.Color.Green;
            buttonAttend.ForeColor = System.Drawing.Color.White;
            buttonAttend.Location = new System.Drawing.Point(12, 653);
            buttonAttend.Name = "buttonAttend";
            buttonAttend.Size = new System.Drawing.Size(119, 39);
            buttonAttend.TabIndex = 14;
            buttonAttend.Text = "Attend";
            buttonAttend.UseVisualStyleBackColor = false;
            buttonAttend.Visible = false;
            buttonAttend.Click += this.buttonAttend_Click;
            // 
            // buttonAbsent
            // 
            buttonAbsent.BackColor = System.Drawing.Color.Red;
            buttonAbsent.ForeColor = System.Drawing.Color.White;
            buttonAbsent.Location = new System.Drawing.Point(12, 698);
            buttonAbsent.Name = "buttonAbsent";
            buttonAbsent.Size = new System.Drawing.Size(119, 39);
            buttonAbsent.TabIndex = 15;
            buttonAbsent.Text = "Absent";
            buttonAbsent.UseVisualStyleBackColor = false;
            buttonAbsent.Visible = false;
            buttonAbsent.Click += this.buttonAbsent_Click;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century Gothic", 20F, (System.Drawing.FontStyle)System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            label2.ForeColor = System.Drawing.Color.Purple;
            label2.Location = new System.Drawing.Point(12, 227);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(201, 33);
            label2.TabIndex = 16;
            label2.Text = "Select Course:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Century Gothic", 20F, (System.Drawing.FontStyle)System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            label3.ForeColor = System.Drawing.Color.Purple;
            label3.Location = new System.Drawing.Point(12, 268);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(172, 33);
            label3.TabIndex = 17;
            label3.Text = "Select Date:";
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 749);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(buttonAbsent);
            this.Controls.Add(buttonAttend);
            this.Controls.Add(comboBoxCourseDates);
            this.Controls.Add(textBoxDate);
            this.Controls.Add(textBoxCourseSessions);
            this.Controls.Add(textBoxCourseDescription);
            this.Controls.Add(textBoxCourseName);
            this.Controls.Add(textBoxCouseID);
            this.Controls.Add(dataGridViewStudentStatus);
            this.Controls.Add(dataGridViewAttendance);
            this.Controls.Add(dataGridViewCourses);
            this.Controls.Add(groupBoxProfileData);
            this.Controls.Add(labelTeacher_Name);
            this.Controls.Add(labelWellcome);
            this.Controls.Add(pictureBoxMinimize);
            this.Controls.Add(pictureBoxClose);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TeacherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeacherForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += this.TeacherForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            groupBoxProfileData.ResumeLayout(false);
            groupBoxProfileData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCourses).EndInit();
            ((System.ComponentModel.ISupportInitialize)courseBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAttendance).EndInit();
            ((System.ComponentModel.ISupportInitialize)courseBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)sessionsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentSessionsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudentStatus).EndInit();
            ((System.ComponentModel.ISupportInitialize)sessionsBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)sessionsBindingSource2).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
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
        private DataGridView dataGridViewStudentStatus;
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
        private ComboBox comboBoxCourseDates;
        private Label label1;
        private ListBox listBoxCDates;
        private Label label2;
        private Label label3;
    }
}