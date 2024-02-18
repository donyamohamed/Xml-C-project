using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;
using Font = System.Drawing.Font;

namespace Attendance_Management_System.Forms
{
    partial class TeacherAdminForm
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
         // Declare a Button for the back arrow

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherAdminForm));
            teacherGrid = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            teacherFname = new DataGridViewTextBoxColumn();
            teacherLname = new DataGridViewTextBoxColumn();
            age = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            password = new DataGridViewTextBoxColumn();
            phone = new DataGridViewTextBoxColumn();
            address = new DataGridViewTextBoxColumn();
            teacherdata = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pictureBox1 = new PictureBox();
            pictureBoxMinimize = new PictureBox();
            pictureBoxClose = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)teacherGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            SuspendLayout();
            // 
            // teacherGrid
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.Padding = new Padding(5);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            teacherGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            teacherGrid.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Orchid;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 15F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            teacherGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            teacherGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            teacherGrid.Columns.AddRange(new DataGridViewColumn[] { id, teacherFname, teacherLname, age, email, password, phone, address });
            teacherGrid.Location = new Point(159, 335);
            teacherGrid.Margin = new Padding(5);
            teacherGrid.Name = "teacherGrid";
            teacherGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            teacherGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            teacherGrid.Size = new Size(1440, 820);
            teacherGrid.TabIndex = 0;
            teacherGrid.CellContentClick += TeacherGrid_CellContentClick;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.Width = 125;
            // 
            // teacherFname
            // 
            teacherFname.HeaderText = "Teacher Fname";
            teacherFname.MinimumWidth = 6;
            teacherFname.Name = "teacherFname";
            teacherFname.Width = 170;
            // 
            // teacherLname
            // 
            teacherLname.HeaderText = "Teacher Lname";
            teacherLname.MinimumWidth = 6;
            teacherLname.Name = "teacherLname";
            teacherLname.Width = 125;
            // 
            // age
            // 
            age.HeaderText = "Age";
            age.MinimumWidth = 6;
            age.Name = "age";
            age.Width = 125;
            // 
            // email
            // 
            email.HeaderText = "Email";
            email.MinimumWidth = 6;
            email.Name = "email";
            email.Width = 200;
            // 
            // password
            // 
            password.HeaderText = "Password";
            password.MinimumWidth = 6;
            password.Name = "password";
            password.Width = 125;
            // 
            // phone
            // 
            phone.HeaderText = "Phone";
            phone.MinimumWidth = 11;
            phone.Name = "phone";
            phone.Width = 125;
            // 
            // address
            // 
            address.HeaderText = "Address";
            address.MinimumWidth = 6;
            address.Name = "address";
            address.Width = 125;
            // 
            // teacherdata
            // 
            teacherdata.AutoSize = true;
            teacherdata.Location = new Point(238, 140);
            teacherdata.Margin = new Padding(5, 0, 5, 0);
            teacherdata.Name = "teacherdata";
            teacherdata.Size = new Size(159, 35);
            teacherdata.TabIndex = 1;
            teacherdata.Text = "Teacher Data";
            teacherdata.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBoxMinimize
            // 
            pictureBoxMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxMinimize.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxMinimize.Cursor = Cursors.Hand;
            pictureBoxMinimize.Image = (System.Drawing.Image)resources.GetObject("pictureBoxMinimize.Image");
            pictureBoxMinimize.Location = new Point(1169, 2);
            pictureBoxMinimize.Name = "pictureBoxMinimize";
            pictureBoxMinimize.Size = new Size(50, 50);
            pictureBoxMinimize.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMinimize.TabIndex = 4;
            pictureBoxMinimize.TabStop = false;
            pictureBoxMinimize.Click += pictureBoxMinimize_Click;
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxClose.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxClose.Cursor = Cursors.Hand;
            pictureBoxClose.Image = (System.Drawing.Image)resources.GetObject("pictureBoxClose.Image");
            pictureBoxClose.Location = new Point(1215, 2);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(50, 50);
            pictureBoxClose.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxClose.TabIndex = 5;
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += pictureBoxClose_Click;
            // 
            // TeacherAdminForm
            // 
            AutoScaleDimensions = new SizeF(14F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1265, 901);
            Controls.Add(pictureBoxClose);
            Controls.Add(pictureBoxMinimize);
            Controls.Add(pictureBox1);
            Controls.Add(teacherdata);
            Controls.Add(teacherGrid);
            Font = new Font("Segoe UI", 15F);
            Margin = new Padding(5);
            Name = "TeacherAdminForm";
            Text = "AdminTeacherForm";
            ((System.ComponentModel.ISupportInitialize)teacherGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView teacherGrid;

        //private Button backButton;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn teacherFname;
        private DataGridViewTextBoxColumn teacherLname;
        private DataGridViewTextBoxColumn age;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn password;
        private DataGridViewTextBoxColumn phone;
        private DataGridViewTextBoxColumn address;
        private Label teacherdata;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pictureBox1;
        private PictureBox pictureBoxMinimize;
        private PictureBox pictureBoxClose;
    }
}