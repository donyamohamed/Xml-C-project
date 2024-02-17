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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            comStudentFilter = new ComboBox();
            groupBox1 = new GroupBox();
            labelAddress = new Label();
            label4 = new Label();
            labelEmail = new Label();
            labele = new Label();
            labelAge = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)studentGrid).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // studentGrid
            // 
            studentGrid.AllowUserToAddRows = false;
            studentGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.Padding = new Padding(5);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            studentGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            studentGrid.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Orchid;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            studentGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            studentGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentGrid.Columns.AddRange(new DataGridViewColumn[] { date, courseName, teacherId, sessionNo, status });
            studentGrid.Location = new Point(66, 254);
            studentGrid.Margin = new Padding(3, 2, 3, 2);
            studentGrid.Name = "studentGrid";
            studentGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            studentGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            studentGrid.Size = new Size(699, 236);
            studentGrid.TabIndex = 0;
            // 
            // date
            // 
            date.HeaderText = "Date";
            date.MinimumWidth = 6;
            date.Name = "date";
            date.Width = 125;
            // 
            // courseName
            // 
            courseName.HeaderText = "Course Name";
            courseName.MinimumWidth = 6;
            courseName.Name = "courseName";
            courseName.Width = 170;
            // 
            // teacherId
            // 
            teacherId.HeaderText = "Teacher ID";
            teacherId.MinimumWidth = 6;
            teacherId.Name = "teacherId";
            teacherId.Width = 125;
            // 
            // sessionNo
            // 
            sessionNo.HeaderText = "Session No";
            sessionNo.MinimumWidth = 6;
            sessionNo.Name = "sessionNo";
            sessionNo.Width = 125;
            // 
            // status
            // 
            status.HeaderText = "Attendance Status";
            status.MinimumWidth = 6;
            status.Name = "status";
            status.Width = 200;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(374, 39);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 1;
            label1.Text = "Welcome ";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(444, 39);
            labelName.Name = "labelName";
            labelName.Size = new Size(37, 15);
            labelName.TabIndex = 2;
            labelName.Text = "name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Location = new Point(88, 34);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 3;
            label2.Text = "Your ID:";
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(145, 34);
            labelID.Name = "labelID";
            labelID.Size = new Size(17, 15);
            labelID.TabIndex = 4;
            labelID.Text = "id";
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
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(848, 513);
            Controls.Add(groupBox1);
            Controls.Add(comStudentFilter);
            Controls.Add(studentGrid);
            Controls.Add(label1);
            Controls.Add(labelName);
            Margin = new Padding(3, 2, 3, 2);
            Name = "StudentForm";
            Text = "StudentForm";
            Load += StudentForm_Load;
            ((System.ComponentModel.ISupportInitialize)studentGrid).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView studentGrid;
        private Label label1;
        private Label labelName;
        private Label label2;
        private Label labelID;
        private ComboBox comStudentFilter;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn courseName;
        private DataGridViewTextBoxColumn teacherId;
        private DataGridViewTextBoxColumn sessionNo;
        private DataGridViewTextBoxColumn status;
        private GroupBox groupBox1;
        private Label labele;
        private Label labelAge;
        private Label label3;
        private Label labelAddress;
        private Label label4;
        private Label labelEmail;
    }
}