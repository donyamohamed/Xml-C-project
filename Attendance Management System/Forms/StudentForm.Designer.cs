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
            studentGrid = new DataGridView();
            label1 = new Label();
            labelName = new Label();
            label2 = new Label();
            labelID = new Label();
            comStudentFilter = new ComboBox();
            date = new DataGridViewTextBoxColumn();
            courseName = new DataGridViewTextBoxColumn();
            teacherId = new DataGridViewTextBoxColumn();
            sessionNo = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)studentGrid).BeginInit();
            SuspendLayout();
            // 
            // studentGrid
            // 
            studentGrid.AllowUserToAddRows = false;
            studentGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.Padding = new Padding(5);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            studentGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            studentGrid.BackgroundColor = Color.Purple;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            studentGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            studentGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentGrid.Columns.AddRange(new DataGridViewColumn[] { date, courseName, teacherId, sessionNo, status });
            studentGrid.Location = new Point(76, 184);
            studentGrid.Name = "studentGrid";
            studentGrid.RowHeadersWidth = 51;
            studentGrid.Size = new Size(799, 105);
            studentGrid.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(326, 43);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 1;
            label1.Text = "Welcome ";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(419, 43);
            labelName.Name = "labelName";
            labelName.Size = new Size(0, 20);
            labelName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Location = new Point(546, 43);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 3;
            label2.Text = "Your ID:";
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(639, 43);
            labelID.Name = "labelID";
            labelID.Size = new Size(0, 20);
            labelID.TabIndex = 4;
            // 
            // comStudentFilter
            // 
            comStudentFilter.FormattingEnabled = true;
            comStudentFilter.Items.AddRange(new object[] { "Date", "Course Name", "Teacher ID", "Attendance Status" });
            comStudentFilter.Location = new Point(724, 128);
            comStudentFilter.Name = "comStudentFilter";
            comStudentFilter.Size = new Size(151, 28);
            comStudentFilter.TabIndex = 5;
            comStudentFilter.Text = "Filter Data";
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
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(969, 543);
            Controls.Add(comStudentFilter);
            Controls.Add(labelID);
            Controls.Add(label2);
            Controls.Add(labelName);
            Controls.Add(label1);
            Controls.Add(studentGrid);
            Name = "StudentForm";
            Text = "StudentForm";
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
        private ComboBox comStudentFilter;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn courseName;
        private DataGridViewTextBoxColumn teacherId;
        private DataGridViewTextBoxColumn sessionNo;
        private DataGridViewTextBoxColumn status;
    }
}