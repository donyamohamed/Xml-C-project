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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
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
            butReport = new Button();
            panelCourses = new Panel();
            picLogOut = new PictureBox();
            labStdId = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            labTimeDate = new Label();
            pictureBoxMinm = new PictureBox();
            pictureBoxClose = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)studentGrid).BeginInit();
            panelCourses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogOut).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            SuspendLayout();
            // 
            // studentGrid
            // 
            resources.ApplyResources(studentGrid, "studentGrid");
            studentGrid.AllowUserToAddRows = false;
            studentGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.Padding = new Padding(5);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            studentGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            studentGrid.BackgroundColor = Color.White;
            studentGrid.BorderStyle = BorderStyle.None;
            studentGrid.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Snow;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Snow;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            studentGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            studentGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentGrid.Columns.AddRange(new DataGridViewColumn[] { date, courseName, teacherId, sessionNo, status });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.LightSlateGray;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Snow;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            studentGrid.DefaultCellStyle = dataGridViewCellStyle3;
            studentGrid.GridColor = Color.Snow;
            studentGrid.Name = "studentGrid";
            studentGrid.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Snow;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.Snow;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            studentGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            studentGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            studentGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            studentGrid.CellContentClick += studentGrid_CellContentClick;
            // 
            // date
            // 
            date.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(date, "date");
            date.Name = "date";
            date.ReadOnly = true;
            // 
            // courseName
            // 
            courseName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(courseName, "courseName");
            courseName.Name = "courseName";
            courseName.ReadOnly = true;
            // 
            // teacherId
            // 
            teacherId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(teacherId, "teacherId");
            teacherId.Name = "teacherId";
            teacherId.ReadOnly = true;
            // 
            // sessionNo
            // 
            sessionNo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(sessionNo, "sessionNo");
            sessionNo.Name = "sessionNo";
            sessionNo.ReadOnly = true;
            // 
            // status
            // 
            status.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(status, "status");
            status.Name = "status";
            status.ReadOnly = true;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.ForeColor = Color.IndianRed;
            label1.Name = "label1";
            // 
            // labelName
            // 
            resources.ApplyResources(labelName, "labelName");
            labelName.ForeColor = Color.IndianRed;
            labelName.Name = "labelName";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Name = "label2";
            // 
            // labelID
            // 
            resources.ApplyResources(labelID, "labelID");
            labelID.Name = "labelID";
            // 
            // butReport
            // 
            resources.ApplyResources(butReport, "butReport");
            butReport.BackColor = Color.LightSlateGray;
            butReport.ForeColor = SystemColors.ButtonHighlight;
            butReport.Name = "butReport";
            butReport.UseVisualStyleBackColor = false;
            butReport.Click += butReport_Click;
            // 
            // panelCourses
            // 
            resources.ApplyResources(panelCourses, "panelCourses");
            panelCourses.BackColor = Color.IndianRed;
            panelCourses.Controls.Add(picLogOut);
            panelCourses.Controls.Add(labStdId);
            panelCourses.Controls.Add(label3);
            panelCourses.Controls.Add(pictureBox1);
            panelCourses.Name = "panelCourses";
            // 
            // picLogOut
            // 
            resources.ApplyResources(picLogOut, "picLogOut");
            picLogOut.Name = "picLogOut";
            picLogOut.TabStop = false;
            picLogOut.Click += picLogOut_Click;
            // 
            // labStdId
            // 
            resources.ApplyResources(labStdId, "labStdId");
            labStdId.ForeColor = Color.Cornsilk;
            labStdId.Name = "labStdId";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.ForeColor = Color.Cornsilk;
            label3.Name = "label3";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Image = Properties.Resources.Webalys_Kameleon_pics_Student_3_512;
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            resources.ApplyResources(panel2, "panel2");
            panel2.BackColor = Color.IndianRed;
            panel2.Controls.Add(labTimeDate);
            panel2.Controls.Add(pictureBoxMinm);
            panel2.Controls.Add(pictureBoxClose);
            panel2.Name = "panel2";
            // 
            // labTimeDate
            // 
            resources.ApplyResources(labTimeDate, "labTimeDate");
            labTimeDate.ForeColor = Color.Cornsilk;
            labTimeDate.Name = "labTimeDate";
            // 
            // pictureBoxMinm
            // 
            resources.ApplyResources(pictureBoxMinm, "pictureBoxMinm");
            pictureBoxMinm.Image = Properties.Resources.minus_button;
            pictureBoxMinm.Name = "pictureBoxMinm";
            pictureBoxMinm.TabStop = false;
            pictureBoxMinm.Click += pictureBoxMinm_Click;
            // 
            // pictureBoxClose
            // 
            resources.ApplyResources(pictureBoxClose, "pictureBoxClose");
            pictureBoxClose.Image = Properties.Resources.cross_mark;
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += pictureBoxClose_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // StudentForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panelCourses);
            Controls.Add(butReport);
            Controls.Add(studentGrid);
            Controls.Add(label1);
            Controls.Add(labelName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentForm";
            WindowState = FormWindowState.Maximized;
            Load += StudentForm_Load;
            ((System.ComponentModel.ISupportInitialize)studentGrid).EndInit();
            panelCourses.ResumeLayout(false);
            panelCourses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogOut).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinm).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView studentGrid;
        private Label label1;
        private Label labelName;
        private Label label2;
        private Label labelID;
        private Button butReport;
    
        private Panel panelCourses;
        private Label labStdId;
        private Label label3;
        private PictureBox pictureBox1;
        private Panel panel2;
        private PictureBox pictureBoxClose;
        private PictureBox pictureBoxMinm;
        private System.Windows.Forms.Timer timer1;
        private Label labTimeDate;
        private PictureBox picLogOut;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn courseName;
        private DataGridViewTextBoxColumn teacherId;
        private DataGridViewTextBoxColumn sessionNo;
        private DataGridViewTextBoxColumn status;
        //     private TextBox textSearch;
    }
}