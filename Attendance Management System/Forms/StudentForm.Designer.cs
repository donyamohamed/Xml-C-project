namespace Attendance_Management_System.Forms
{
    partial class StudentForm
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            studentGrid = new DataGridView();
            date = new DataGridViewTextBoxColumn();
            courseName = new DataGridViewTextBoxColumn();
            teacherId = new DataGridViewTextBoxColumn();
            sessionNo = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            label1 = new Label();
            labelName = new Label();
            label2 = new Label();
            labelID = new Label();
            textSearch = new TextBox();
            butReport = new Button();
            ((System.ComponentModel.ISupportInitialize)studentGrid).BeginInit();
            SuspendLayout();
            // 
            // studentGrid
            // 
            studentGrid.AllowUserToAddRows = false;
            studentGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.Padding = new Padding(5);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            studentGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            studentGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            studentGrid.BackgroundColor = Color.White;
            studentGrid.BorderStyle = BorderStyle.None;
            studentGrid.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.Orchid;
            dataGridViewCellStyle7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = Color.Orchid;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            studentGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            studentGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentGrid.Columns.AddRange(new DataGridViewColumn[] { date, courseName, teacherId, sessionNo, status });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.SkyBlue;
            dataGridViewCellStyle8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = Color.Orchid;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            studentGrid.DefaultCellStyle = dataGridViewCellStyle8;
            studentGrid.GridColor = SystemColors.ActiveCaption;
            studentGrid.Location = new Point(104, 258);
            studentGrid.Margin = new Padding(4, 3, 4, 3);
            studentGrid.Name = "studentGrid";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.Lavender;
            dataGridViewCellStyle9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            studentGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            studentGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            studentGrid.RowsDefaultCellStyle = dataGridViewCellStyle10;
            studentGrid.Size = new Size(1003, 334);
            studentGrid.TabIndex = 0;
            // 
            // date
            // 
            date.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            date.HeaderText = "Date";
            date.MinimumWidth = 6;
            date.Name = "date";
            // 
            // courseName
            // 
            courseName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            courseName.HeaderText = "Course Name";
            courseName.MinimumWidth = 6;
            courseName.Name = "courseName";
            // 
            // teacherId
            // 
            teacherId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            teacherId.HeaderText = "Teacher ID";
            teacherId.MinimumWidth = 6;
            teacherId.Name = "teacherId";
            // 
            // sessionNo
            // 
            sessionNo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            sessionNo.HeaderText = "Session No";
            sessionNo.MinimumWidth = 6;
            sessionNo.Name = "sessionNo";
            // 
            // status
            // 
            status.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            status.HeaderText = "Attendance Status";
            status.MinimumWidth = 6;
            status.Name = "status";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;

            label1.Location = new Point(374, 39);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);

            label1.TabIndex = 1;
            label1.Text = "Welcome Back:";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelName
            // 
            labelName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            labelName.AutoSize = true;

            labelName.Location = new Point(444, 39);
            labelName.Name = "labelName";
            labelName.Size = new Size(37, 15);

            labelName.TabIndex = 2;
            labelName.Text = "name";
            labelName.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;

            label2.Location = new Point(88, 34);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);

            label2.TabIndex = 3;
            label2.Text = "Your ID:";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelID
            // 
            labelID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            labelID.AutoSize = true;

            labelID.Location = new Point(145, 34);
            labelID.Name = "labelID";
            labelID.Size = new Size(17, 15);

            labelID.TabIndex = 4;
            labelID.Text = "id";
            labelID.TextAlign = ContentAlignment.TopCenter;
            // 
            // comStudentFilter
            // 
            comStudentFilter.FormattingEnabled = true;
            comStudentFilter.Items.AddRange(new object[] { "Date", "Course Name", "Teacher ID", "Attendance Status" });
            comStudentFilter.Location = new Point(634, 215);
            comStudentFilter.Margin = new Padding(3, 2, 3, 2);
            comStudentFilter.Name = "comStudentFilter";
            comStudentFilter.Size = new Size(133, 23);
            comStudentFilter.TabIndex = 5;
            comStudentFilter.Text = "Filter Data";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelAddress);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(labelEmail);
            groupBox1.Controls.Add(labele);
            groupBox1.Controls.Add(labelAge);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(labelID);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(66, 84);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(699, 94);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Profile Data";
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new Point(529, 67);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(27, 15);
            labelAddress.TabIndex = 10;
            labelAddress.Text = "add";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(467, 67);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 9;
            label4.Text = "Address:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(529, 34);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(30, 15);
            labelEmail.TabIndex = 8;
            labelEmail.Text = "ema";
            // 
            // labele
            // 
            labele.AutoSize = true;
            labele.Location = new Point(467, 34);
            labele.Name = "labele";
            labele.Size = new Size(39, 15);
            labele.TabIndex = 7;
            labele.Text = "Email:";
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.Location = new Point(145, 67);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(26, 15);
            labelAge.TabIndex = 6;
            labelAge.Text = "age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(106, 67);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 5;
            label3.Text = "Age:";
            // 
            // butReport
            // 
            butReport.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            butReport.BackColor = Color.Purple;
            butReport.ForeColor = SystemColors.ButtonHighlight;
            butReport.Location = new Point(953, 695);
            butReport.Name = "butReport";
            butReport.Size = new Size(154, 51);
            butReport.TabIndex = 7;
            butReport.Text = "Generate Report";
            butReport.UseVisualStyleBackColor = false;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1211, 787);
            Controls.Add(butReport);
            Controls.Add(textSearch);
            Controls.Add(studentGrid);
            Controls.Add(label1);
            Controls.Add(labelName);
            Margin = new Padding(3, 2, 3, 2);

            Name = "StudentForm";
            Padding = new Padding(0, 5, 60, 20);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentForm";
            WindowState = FormWindowState.Maximized;
            Load += StudentForm_Load;
            ((System.ComponentModel.ISupportInitialize)studentGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView studentGrid;
        private Label label1;
        private Label labelName;
        private Label label2;
        private Label labelID;
        private TextBox textSearch;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn courseName;
        private DataGridViewTextBoxColumn teacherId;
        private DataGridViewTextBoxColumn sessionNo;
        private DataGridViewTextBoxColumn status;
        private Button butReport;
    }
}