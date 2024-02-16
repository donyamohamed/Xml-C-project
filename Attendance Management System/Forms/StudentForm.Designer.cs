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
            studentGrid.Location = new Point(76, 339);
            studentGrid.Name = "studentGrid";
            studentGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            studentGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            studentGrid.Size = new Size(799, 315);
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
            label1.Location = new Point(427, 52);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 1;
            label1.Text = "Welcome ";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(508, 52);
            labelName.Name = "labelName";
            labelName.Size = new Size(46, 20);
            labelName.TabIndex = 2;
            labelName.Text = "name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Location = new Point(100, 45);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 3;
            label2.Text = "Your ID:";
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(166, 45);
            labelID.Name = "labelID";
            labelID.Size = new Size(22, 20);
            labelID.TabIndex = 4;
            labelID.Text = "id";
            // 
            // comStudentFilter
            // 
            comStudentFilter.FormattingEnabled = true;
            comStudentFilter.Items.AddRange(new object[] { "Date", "Course Name", "Teacher ID", "Attendance Status" });
            comStudentFilter.Location = new Point(724, 287);
            comStudentFilter.Name = "comStudentFilter";
            comStudentFilter.Size = new Size(151, 28);
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
            groupBox1.Location = new Point(76, 112);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(799, 125);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Profile Data";
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new Point(605, 89);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(35, 20);
            labelAddress.TabIndex = 10;
            labelAddress.Text = "add";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(534, 89);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 9;
            label4.Text = "Address:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(605, 45);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(38, 20);
            labelEmail.TabIndex = 8;
            labelEmail.Text = "ema";
            // 
            // labele
            // 
            labele.AutoSize = true;
            labele.Location = new Point(534, 45);
            labele.Name = "labele";
            labele.Size = new Size(49, 20);
            labele.TabIndex = 7;
            labele.Text = "Email:";
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.Location = new Point(166, 89);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(34, 20);
            labelAge.TabIndex = 6;
            labelAge.Text = "age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(121, 89);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 5;
            label3.Text = "Age:";
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(969, 684);
            Controls.Add(groupBox1);
            Controls.Add(comStudentFilter);
            Controls.Add(studentGrid);
            Controls.Add(label1);
            Controls.Add(labelName);
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