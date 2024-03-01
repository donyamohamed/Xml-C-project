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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            toolTip1 = new ToolTip(components);
            pictureBoxMinimize = new PictureBox();
            pictureBoxClose = new PictureBox();
            labelWellcome = new Label();
            labelTeacher_Name = new Label();
            groupBoxProfileData = new GroupBox();
            listBoxCDates = new ListBox();
            label1 = new Label();
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
            comboBoxCourseDates = new ComboBox();
            dataGridViewCourses = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numberofsessionsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            courseBindingSource = new BindingSource(components);
            dataGridViewAttendance = new DataGridView();
            courseBindingSource1 = new BindingSource(components);
            sessionsBindingSource = new BindingSource(components);
            studentSessionsBindingSource = new BindingSource(components);
            dataGridViewStudentStatus = new DataGridView();
            textBoxCouseID = new TextBox();
            textBoxCourseName = new TextBox();
            textBoxCourseDescription = new TextBox();
            textBoxCourseSessions = new TextBox();
            textBoxDate = new TextBox();
            buttonAttend = new Button();
            buttonAbsent = new Button();
            sessionsBindingSource1 = new BindingSource(components);
            sessionsBindingSource2 = new BindingSource(components);
            label2 = new Label();
            label3 = new Label();
            buttonExpPDF = new Button();
            buttonToExcel = new Button();
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
            SuspendLayout();
            // 
            // pictureBoxMinimize
            // 
            pictureBoxMinimize.Anchor = AnchorStyles.Top;
            pictureBoxMinimize.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxMinimize.Cursor = Cursors.Hand;
            pictureBoxMinimize.Image = Properties.Resources.minus_button1;
            pictureBoxMinimize.Location = new Point(1085, 9);
            pictureBoxMinimize.Name = "pictureBoxMinimize";
            pictureBoxMinimize.Size = new Size(50, 50);
            pictureBoxMinimize.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMinimize.TabIndex = 1;
            pictureBoxMinimize.TabStop = false;
            pictureBoxMinimize.Click += pictureBoxMinimize_Click;
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Anchor = AnchorStyles.Top;
            pictureBoxClose.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxClose.Cursor = Cursors.Hand;
            pictureBoxClose.Image = Properties.Resources.cross_mark1;
            pictureBoxClose.Location = new Point(1138, 9);
            pictureBoxClose.Margin = new Padding(0);
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
            labelWellcome.ForeColor = Color.Firebrick;
            labelWellcome.Location = new Point(12, 9);
            labelWellcome.Name = "labelWellcome";
            labelWellcome.Size = new Size(271, 62);
            labelWellcome.TabIndex = 0;
            labelWellcome.Text = "Wellcome";
            // 
            // labelTeacher_Name
            // 
            labelTeacher_Name.AutoSize = true;
            labelTeacher_Name.Font = new Font("Century Gothic", 30F, FontStyle.Bold | FontStyle.Italic);
            labelTeacher_Name.ForeColor = Color.Firebrick;
            labelTeacher_Name.Location = new Point(238, 9);
            labelTeacher_Name.Name = "labelTeacher_Name";
            labelTeacher_Name.Size = new Size(397, 62);
            labelTeacher_Name.TabIndex = 0;
            labelTeacher_Name.Text = "Teacher_Name";
            // 
            // groupBoxProfileData
            // 
            groupBoxProfileData.Anchor = AnchorStyles.Top;
            groupBoxProfileData.BackColor = Color.IndianRed;
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
            groupBoxProfileData.ForeColor = Color.Black;
            groupBoxProfileData.Location = new Point(12, 67);
            groupBoxProfileData.Margin = new Padding(3, 2, 3, 2);
            groupBoxProfileData.Name = "groupBoxProfileData";
            groupBoxProfileData.Padding = new Padding(0);
            groupBoxProfileData.Size = new Size(1176, 148);
            groupBoxProfileData.TabIndex = 0;
            groupBoxProfileData.TabStop = false;
            groupBoxProfileData.Text = "Profile Data";
            // 
            // listBoxCDates
            // 
            listBoxCDates.FormattingEnabled = true;
            listBoxCDates.ItemHeight = 23;
            listBoxCDates.Location = new Point(1050, 22);
            listBoxCDates.Name = "listBoxCDates";
            listBoxCDates.Size = new Size(120, 73);
            listBoxCDates.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(914, 20);
            label1.Name = "label1";
            label1.Size = new Size(158, 23);
            label1.TabIndex = 10;
            label1.Text = "Your Calender:";
            // 
            // listBoxCourses
            // 
            listBoxCourses.FormattingEnabled = true;
            listBoxCourses.ItemHeight = 23;
            listBoxCourses.Location = new Point(791, 22);
            listBoxCourses.Name = "listBoxCourses";
            listBoxCourses.Size = new Size(120, 73);
            listBoxCourses.TabIndex = 5;
            // 
            // labelYourCourses
            // 
            labelYourCourses.AutoSize = true;
            labelYourCourses.ForeColor = Color.White;
            labelYourCourses.Location = new Point(633, 20);
            labelYourCourses.Name = "labelYourCourses";
            labelYourCourses.Size = new Size(186, 23);
            labelYourCourses.TabIndex = 8;
            labelYourCourses.Text = "Your Courses List:  ";
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.DarkRed;
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(312, 99);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(131, 36);
            buttonCancel.TabIndex = 2;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.BackColor = Color.IndianRed;
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
            textBoxAddress.BackColor = Color.IndianRed;
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
            buttonEditYourData.Location = new Point(457, 99);
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
            labelPhone.Location = new Point(314, 64);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(168, 23);
            labelPhone.TabIndex = 2;
            labelPhone.Text = "Phone Number :";
            // 
            // labelTID
            // 
            labelTID.AutoSize = true;
            labelTID.ForeColor = Color.White;
            labelTID.Location = new Point(3, 31);
            labelTID.Name = "labelTID";
            labelTID.Size = new Size(41, 23);
            labelTID.TabIndex = 1;
            labelTID.Text = "ID: ";
            // 
            // labelTAddress
            // 
            labelTAddress.AutoSize = true;
            labelTAddress.ForeColor = Color.White;
            labelTAddress.Location = new Point(3, 64);
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
            labelTEmail.Location = new Point(198, 31);
            labelTEmail.Name = "labelTEmail";
            labelTEmail.Size = new Size(67, 23);
            labelTEmail.TabIndex = 0;
            labelTEmail.Text = "Email:";
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.ForeColor = Color.White;
            labelAge.Location = new Point(454, 31);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(50, 23);
            labelAge.TabIndex = 0;
            labelAge.Text = "age";
            // 
            // labelTAge
            // 
            labelTAge.AutoSize = true;
            labelTAge.ForeColor = Color.White;
            labelTAge.Location = new Point(400, 31);
            labelTAge.Name = "labelTAge";
            labelTAge.Size = new Size(56, 23);
            labelTAge.TabIndex = 0;
            labelTAge.Text = "Age:";
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.ForeColor = Color.White;
            labelID.Location = new Point(44, 31);
            labelID.Name = "labelID";
            labelID.Size = new Size(27, 23);
            labelID.TabIndex = 0;
            labelID.Text = "id";
            // 
            // comboBoxCourseDates
            // 
            comboBoxCourseDates.FormattingEnabled = true;
            comboBoxCourseDates.Location = new Point(12, 304);
            comboBoxCourseDates.Name = "comboBoxCourseDates";
            comboBoxCourseDates.Size = new Size(186, 31);
            comboBoxCourseDates.TabIndex = 9;
            comboBoxCourseDates.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dataGridViewCourses
            // 
            dataGridViewCourses.AllowUserToAddRows = false;
            dataGridViewCourses.AllowUserToDeleteRows = false;
            dataGridViewCourses.AllowUserToOrderColumns = true;
            dataGridViewCourses.AutoGenerateColumns = false;
            dataGridViewCourses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCourses.BackgroundColor = Color.White;
            dataGridViewCourses.BorderStyle = BorderStyle.None;
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
            dataGridViewCourses.Location = new Point(219, 227);
            dataGridViewCourses.Name = "dataGridViewCourses";
            dataGridViewCourses.ReadOnly = true;
            dataGridViewCourses.RowHeadersWidth = 51;
            dataGridViewCourses.Size = new Size(546, 182);
            dataGridViewCourses.TabIndex = 5;
            dataGridViewCourses.CellClick += dataGridViewCourses_CellClick;
            dataGridViewCourses.CellFormatting += dataGridViewCourses_CellFormatting;
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
            courseBindingSource.DataSource = typeof(classes.Course);
            // 
            // dataGridViewAttendance
            // 
            dataGridViewAttendance.AllowUserToOrderColumns = true;
            dataGridViewAttendance.Anchor = AnchorStyles.Top;
            dataGridViewAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAttendance.BackgroundColor = Color.White;
            dataGridViewAttendance.BorderStyle = BorderStyle.None;
            dataGridViewAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAttendance.GridColor = SystemColors.WindowText;
            dataGridViewAttendance.Location = new Point(771, 227);
            dataGridViewAttendance.Name = "dataGridViewAttendance";
            dataGridViewAttendance.RowHeadersWidth = 51;
            dataGridViewAttendance.Size = new Size(417, 510);
            dataGridViewAttendance.TabIndex = 6;
            dataGridViewAttendance.CellFormatting += dataGridViewAttendance_CellFormatting;
            // 
            // courseBindingSource1
            // 
            courseBindingSource1.DataSource = typeof(classes.Course);
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
            dataGridViewStudentStatus.AllowUserToAddRows = false;
            dataGridViewStudentStatus.AllowUserToDeleteRows = false;
            dataGridViewStudentStatus.AllowUserToOrderColumns = true;
            dataGridViewStudentStatus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStudentStatus.BackgroundColor = Color.White;
            dataGridViewStudentStatus.BorderStyle = BorderStyle.None;
            dataGridViewStudentStatus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudentStatus.GridColor = SystemColors.WindowText;
            dataGridViewStudentStatus.Location = new Point(137, 415);
            dataGridViewStudentStatus.Name = "dataGridViewStudentStatus";
            dataGridViewStudentStatus.ReadOnly = true;
            dataGridViewStudentStatus.RowHeadersWidth = 51;
            dataGridViewStudentStatus.Size = new Size(628, 238);
            dataGridViewStudentStatus.TabIndex = 8;
            dataGridViewStudentStatus.CellClick += dataGridViewStudentStatus_CellClick;
            dataGridViewStudentStatus.CellFormatting += dataGridViewStudentStatus_CellFormatting;
            // 
            // textBoxCouseID
            // 
            textBoxCouseID.Location = new Point(12, 395);
            textBoxCouseID.Name = "textBoxCouseID";
            textBoxCouseID.Size = new Size(119, 32);
            textBoxCouseID.TabIndex = 9;
            textBoxCouseID.Text = "textBoxID";
            // 
            // textBoxCourseName
            // 
            textBoxCourseName.Location = new Point(12, 433);
            textBoxCourseName.Name = "textBoxCourseName";
            textBoxCourseName.Size = new Size(119, 32);
            textBoxCourseName.TabIndex = 10;
            textBoxCourseName.Text = "textBoxID";
            // 
            // textBoxCourseDescription
            // 
            textBoxCourseDescription.Location = new Point(12, 471);
            textBoxCourseDescription.Name = "textBoxCourseDescription";
            textBoxCourseDescription.Size = new Size(119, 32);
            textBoxCourseDescription.TabIndex = 11;
            textBoxCourseDescription.Text = "textBoxCourseDescription";
            // 
            // textBoxCourseSessions
            // 
            textBoxCourseSessions.Location = new Point(12, 509);
            textBoxCourseSessions.Name = "textBoxCourseSessions";
            textBoxCourseSessions.Size = new Size(119, 32);
            textBoxCourseSessions.TabIndex = 12;
            textBoxCourseSessions.Text = "textBoxCourseSessions";
            // 
            // textBoxDate
            // 
            textBoxDate.BorderStyle = BorderStyle.None;
            textBoxDate.Font = new Font("Century Gothic", 20F);
            textBoxDate.Location = new Point(12, 356);
            textBoxDate.Name = "textBoxDate";
            textBoxDate.Size = new Size(186, 41);
            textBoxDate.TabIndex = 13;
            textBoxDate.Text = "Date ...";
            textBoxDate.TextAlign = HorizontalAlignment.Center;
            textBoxDate.WordWrap = false;
            // 
            // buttonAttend
            // 
            buttonAttend.BackColor = Color.Green;
            buttonAttend.ForeColor = Color.White;
            buttonAttend.Location = new Point(12, 647);
            buttonAttend.Name = "buttonAttend";
            buttonAttend.Size = new Size(119, 39);
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
            buttonAbsent.Location = new Point(12, 697);
            buttonAbsent.Name = "buttonAbsent";
            buttonAbsent.Size = new Size(119, 39);
            buttonAbsent.TabIndex = 15;
            buttonAbsent.Text = "Absent";
            buttonAbsent.UseVisualStyleBackColor = false;
            buttonAbsent.Visible = false;
            buttonAbsent.Click += buttonAbsent_Click;
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
            label2.Font = new Font("Century Gothic", 20F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = Color.Firebrick;
            label2.Location = new Point(12, 227);
            label2.Name = "label2";
            label2.Size = new Size(256, 40);
            label2.TabIndex = 16;
            label2.Text = "Select Course:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 20F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = Color.Firebrick;
            label3.Location = new Point(12, 268);
            label3.Name = "label3";
            label3.Size = new Size(217, 40);
            label3.TabIndex = 17;
            label3.Text = "Select Date:";
            // 
            // buttonExpPDF
            // 
            buttonExpPDF.BackColor = Color.IndianRed;
            buttonExpPDF.ForeColor = Color.White;
            buttonExpPDF.Location = new Point(12, 547);
            buttonExpPDF.Name = "buttonExpPDF";
            buttonExpPDF.Size = new Size(119, 39);
            buttonExpPDF.TabIndex = 18;
            buttonExpPDF.Text = "to .. PDF";
            buttonExpPDF.UseVisualStyleBackColor = false;
            buttonExpPDF.Click += buttonExpPDF_Click;
            // 
            // buttonToExcel
            // 
            buttonToExcel.BackColor = Color.RebeccaPurple;
            buttonToExcel.ForeColor = Color.White;
            buttonToExcel.Location = new Point(12, 597);
            buttonToExcel.Name = "buttonToExcel";
            buttonToExcel.Size = new Size(119, 39);
            buttonToExcel.TabIndex = 19;
            buttonToExcel.Text = "to .. EXCEL";
            buttonToExcel.UseVisualStyleBackColor = false;
            buttonToExcel.Click += buttonToExcel_Click;
            // 
            // TeacherForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 749);
            Controls.Add(buttonToExcel);
            Controls.Add(buttonExpPDF);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonAbsent);
            Controls.Add(buttonAttend);
            Controls.Add(comboBoxCourseDates);
            Controls.Add(textBoxDate);
            Controls.Add(textBoxCourseSessions);
            Controls.Add(textBoxCourseDescription);
            Controls.Add(textBoxCourseName);
            Controls.Add(textBoxCouseID);
            Controls.Add(dataGridViewStudentStatus);
            Controls.Add(dataGridViewAttendance);
            Controls.Add(dataGridViewCourses);
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
            ((System.ComponentModel.ISupportInitialize)dataGridViewCourses).EndInit();
            ((System.ComponentModel.ISupportInitialize)courseBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAttendance).EndInit();
            ((System.ComponentModel.ISupportInitialize)courseBindingSource1).EndInit();
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
        private Button buttonExpPDF;
        private Button buttonToExcel;
    }
}