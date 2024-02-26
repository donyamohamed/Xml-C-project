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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherAdminForm));
            teacherGrid = new DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel3 = new Panel();
            closebox = new PictureBox();
            minimizebox = new PictureBox();
            teacherData = new Button();
            panel1 = new Panel();
            button3 = new Button();
            pictureBox4 = new PictureBox();
            pictureBox1 = new PictureBox();
            teacherbutton = new Button();
            pictureBox2 = new PictureBox();
            picstudents = new PictureBox();
            picclass = new PictureBox();
            btnmanageclasses = new Button();
            btnmanagestudent = new Button();
            btnmangeteachers = new Button();
            panel2 = new Panel();
            button1 = new Button();
            pictureBox3 = new PictureBox();
            panel4 = new Panel();
            logout_button = new Button();
            button2 = new Button();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            button4 = new Button();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            btnInsertUser = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            id = new DataGridViewTextBoxColumn();
            teacherFname = new DataGridViewTextBoxColumn();
            teacherLname = new DataGridViewTextBoxColumn();
            age = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            password = new DataGridViewTextBoxColumn();
            phone = new DataGridViewTextBoxColumn();
            address = new DataGridViewTextBoxColumn();
            delete = new DataGridViewImageColumn();
            update = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)teacherGrid).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)closebox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minimizebox).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picstudents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picclass).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            SuspendLayout();
            // 
            // teacherGrid
            // 
            teacherGrid.AllowUserToAddRows = false;
            teacherGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.Padding = new Padding(5);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            teacherGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            teacherGrid.BackgroundColor = SystemColors.Control;
            teacherGrid.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Orchid;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            teacherGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            teacherGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            teacherGrid.Columns.AddRange(new DataGridViewColumn[] { id, teacherFname, teacherLname, age, email, password, phone, address, delete, update });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            teacherGrid.DefaultCellStyle = dataGridViewCellStyle3;
            teacherGrid.Location = new Point(472, 270);
            teacherGrid.Margin = new Padding(5);
            teacherGrid.Name = "teacherGrid";
            teacherGrid.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            teacherGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            teacherGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.Padding = new Padding(5, 10, 5, 10);
            teacherGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            teacherGrid.Size = new Size(1372, 467);
            teacherGrid.TabIndex = 0;
            teacherGrid.CellContentClick += TeacherGrid_CellContentClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 192, 192);
            panel3.Controls.Add(closebox);
            panel3.Controls.Add(minimizebox);
            panel3.Controls.Add(teacherData);
            panel3.Controls.Add(panel1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(5, 6, 5, 6);
            panel3.Name = "panel3";
            panel3.Size = new Size(1924, 188);
            panel3.TabIndex = 2;
            // 
            // closebox
            // 
            closebox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            closebox.Image = (System.Drawing.Image)resources.GetObject("closebox.Image");
            closebox.ImeMode = ImeMode.NoControl;
            closebox.Location = new Point(1881, 0);
            closebox.Name = "closebox";
            closebox.Size = new Size(43, 43);
            closebox.SizeMode = PictureBoxSizeMode.Zoom;
            closebox.TabIndex = 18;
            closebox.TabStop = false;
            closebox.Click += closebox_Click;
            // 
            // minimizebox
            // 
            minimizebox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            minimizebox.Image = (System.Drawing.Image)resources.GetObject("minimizebox.Image");
            minimizebox.ImeMode = ImeMode.NoControl;
            minimizebox.Location = new Point(1832, 0);
            minimizebox.Name = "minimizebox";
            minimizebox.Size = new Size(52, 43);
            minimizebox.SizeMode = PictureBoxSizeMode.Zoom;
            minimizebox.TabIndex = 17;
            minimizebox.TabStop = false;
            minimizebox.Click += minimizebox_Click;
            // 
            // teacherData
            // 
            teacherData.Cursor = Cursors.Hand;
            teacherData.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            teacherData.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            teacherData.FlatStyle = FlatStyle.Flat;
            teacherData.Font = new Font("Sitka Text", 13F, FontStyle.Bold);
            teacherData.ForeColor = Color.Cornsilk;
            teacherData.ImeMode = ImeMode.NoControl;
            teacherData.Location = new Point(630, 67);
            teacherData.Name = "teacherData";
            teacherData.Size = new Size(223, 55);
            teacherData.TabIndex = 15;
            teacherData.Text = "Teachers Data";
            teacherData.UseVisualStyleBackColor = true;
            teacherData.Click += button8_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 192);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(teacherbutton);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(picstudents);
            panel1.Controls.Add(picclass);
            panel1.Controls.Add(btnmanageclasses);
            panel1.Controls.Add(btnmanagestudent);
            panel1.Controls.Add(btnmangeteachers);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5, 6, 5, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(387, 188);
            panel1.TabIndex = 4;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 255);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Sitka Text", 13F, FontStyle.Bold);
            button3.ForeColor = Color.Cornsilk;
            button3.ImeMode = ImeMode.NoControl;
            button3.Location = new Point(140, 855);
            button3.Name = "button3";
            button3.Size = new Size(223, 55);
            button3.TabIndex = 17;
            button3.Text = "Log Out";
            button3.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (System.Drawing.Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.ImeMode = ImeMode.NoControl;
            pictureBox4.InitialImage = null;
            pictureBox4.Location = new Point(34, 838);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(100, 87);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 16;
            pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.ImeMode = ImeMode.NoControl;
            pictureBox1.Location = new Point(23, 391);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // teacherbutton
            // 
            teacherbutton.Cursor = Cursors.Hand;
            teacherbutton.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            teacherbutton.FlatAppearance.MouseOverBackColor = Color.FromArgb(18, 55, 42);
            teacherbutton.FlatStyle = FlatStyle.Flat;
            teacherbutton.Font = new Font("Sitka Text", 13F, FontStyle.Bold);
            teacherbutton.ForeColor = Color.Cornsilk;
            teacherbutton.ImeMode = ImeMode.NoControl;
            teacherbutton.Location = new Point(140, 285);
            teacherbutton.Name = "teacherbutton";
            teacherbutton.Size = new Size(223, 55);
            teacherbutton.TabIndex = 14;
            teacherbutton.Text = "Teachers";
            teacherbutton.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.ImeMode = ImeMode.NoControl;
            pictureBox2.Location = new Point(23, 270);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 86);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // picstudents
            // 
            picstudents.BackColor = Color.FromArgb(255, 192, 192);
            picstudents.Image = (System.Drawing.Image)resources.GetObject("picstudents.Image");
            picstudents.ImeMode = ImeMode.NoControl;
            picstudents.Location = new Point(23, 528);
            picstudents.Name = "picstudents";
            picstudents.Size = new Size(100, 87);
            picstudents.SizeMode = PictureBoxSizeMode.Zoom;
            picstudents.TabIndex = 7;
            picstudents.TabStop = false;
            // 
            // picclass
            // 
            picclass.Image = (System.Drawing.Image)resources.GetObject("picclass.Image");
            picclass.ImeMode = ImeMode.NoControl;
            picclass.Location = new Point(34, 688);
            picclass.Name = "picclass";
            picclass.Size = new Size(100, 87);
            picclass.SizeMode = PictureBoxSizeMode.Zoom;
            picclass.TabIndex = 9;
            picclass.TabStop = false;
            // 
            // btnmanageclasses
            // 
            btnmanageclasses.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            btnmanageclasses.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 255);
            btnmanageclasses.FlatStyle = FlatStyle.Flat;
            btnmanageclasses.Font = new Font("Sitka Text", 13F, FontStyle.Bold);
            btnmanageclasses.ForeColor = Color.Cornsilk;
            btnmanageclasses.ImeMode = ImeMode.NoControl;
            btnmanageclasses.Location = new Point(140, 707);
            btnmanageclasses.Name = "btnmanageclasses";
            btnmanageclasses.Size = new Size(223, 55);
            btnmanageclasses.TabIndex = 10;
            btnmanageclasses.Text = "Classes";
            btnmanageclasses.UseVisualStyleBackColor = true;
            // 
            // btnmanagestudent
            // 
            btnmanagestudent.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            btnmanagestudent.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 255);
            btnmanagestudent.FlatStyle = FlatStyle.Flat;
            btnmanagestudent.Font = new Font("Sitka Text", 13F, FontStyle.Bold);
            btnmanagestudent.ForeColor = Color.Cornsilk;
            btnmanagestudent.ImeMode = ImeMode.NoControl;
            btnmanagestudent.Location = new Point(140, 548);
            btnmanagestudent.Name = "btnmanagestudent";
            btnmanagestudent.Size = new Size(223, 55);
            btnmanagestudent.TabIndex = 8;
            btnmanagestudent.Text = "Courses";
            btnmanagestudent.UseVisualStyleBackColor = true;
            // 
            // btnmangeteachers
            // 
            btnmangeteachers.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            btnmangeteachers.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnmangeteachers.FlatStyle = FlatStyle.Flat;
            btnmangeteachers.Font = new Font("Sitka Text", 13F, FontStyle.Bold);
            btnmangeteachers.ForeColor = Color.Cornsilk;
            btnmangeteachers.ImeMode = ImeMode.NoControl;
            btnmangeteachers.Location = new Point(140, 411);
            btnmangeteachers.Name = "btnmangeteachers";
            btnmangeteachers.Size = new Size(223, 55);
            btnmangeteachers.TabIndex = 6;
            btnmangeteachers.Text = "Students";
            btnmangeteachers.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(pictureBox3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(5, 6, 5, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(387, 188);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Sitka Text", 13F, FontStyle.Bold);
            button1.ForeColor = Color.Cornsilk;
            button1.ImeMode = ImeMode.NoControl;
            button1.Location = new Point(71, 126);
            button1.Name = "button1";
            button1.Size = new Size(223, 55);
            button1.TabIndex = 15;
            button1.Text = "Admin";
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.ImeMode = ImeMode.NoControl;
            pictureBox3.Location = new Point(139, 34);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 87);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 192, 192);
            panel4.Controls.Add(logout_button);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(pictureBox5);
            panel4.Controls.Add(pictureBox6);
            panel4.Controls.Add(button4);
            panel4.Controls.Add(pictureBox7);
            panel4.Controls.Add(pictureBox8);
            panel4.Controls.Add(pictureBox9);
            panel4.Controls.Add(button5);
            panel4.Controls.Add(button6);
            panel4.Controls.Add(button7);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 188);
            panel4.Margin = new Padding(5, 6, 5, 6);
            panel4.Name = "panel4";
            panel4.Size = new Size(387, 867);
            panel4.TabIndex = 4;
            // 
            // logout_button
            // 
            logout_button.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            logout_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            logout_button.FlatStyle = FlatStyle.Flat;
            logout_button.Font = new Font("Sitka Text", 13F, FontStyle.Bold);
            logout_button.ForeColor = Color.Cornsilk;
            logout_button.ImeMode = ImeMode.NoControl;
            logout_button.Location = new Point(140, 682);
            logout_button.Name = "logout_button";
            logout_button.Size = new Size(223, 55);
            logout_button.TabIndex = 18;
            logout_button.Text = "Log Out";
            logout_button.UseVisualStyleBackColor = true;
            logout_button.Click += logoutButton_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 255);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Sitka Text", 13F, FontStyle.Bold);
            button2.ForeColor = Color.Cornsilk;
            button2.ImeMode = ImeMode.NoControl;
            button2.Location = new Point(140, 855);
            button2.Name = "button2";
            button2.Size = new Size(223, 55);
            button2.TabIndex = 17;
            button2.Text = "Log Out";
            button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (System.Drawing.Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.ImeMode = ImeMode.NoControl;
            pictureBox5.InitialImage = null;
            pictureBox5.Location = new Point(23, 681);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(100, 87);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 16;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (System.Drawing.Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.ImeMode = ImeMode.NoControl;
            pictureBox6.Location = new Point(23, 191);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(100, 87);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 15;
            pictureBox6.TabStop = false;
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Sitka Text", 13F, FontStyle.Bold);
            button4.ForeColor = Color.Cornsilk;
            button4.ImeMode = ImeMode.NoControl;
            button4.Location = new Point(139, 53);
            button4.Name = "button4";
            button4.Size = new Size(223, 55);
            button4.TabIndex = 14;
            button4.Text = "Teachers";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (System.Drawing.Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.ImeMode = ImeMode.NoControl;
            pictureBox7.Location = new Point(23, 33);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(100, 86);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 3;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.FromArgb(255, 192, 192);
            pictureBox8.Image = (System.Drawing.Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.ImeMode = ImeMode.NoControl;
            pictureBox8.Location = new Point(23, 360);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(100, 87);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 7;
            pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (System.Drawing.Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.ImeMode = ImeMode.NoControl;
            pictureBox9.Location = new Point(23, 519);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(100, 87);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 9;
            pictureBox9.TabStop = false;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Sitka Text", 13F, FontStyle.Bold);
            button5.ForeColor = Color.Cornsilk;
            button5.ImeMode = ImeMode.NoControl;
            button5.Location = new Point(140, 532);
            button5.Name = "button5";
            button5.Size = new Size(223, 55);
            button5.TabIndex = 10;
            button5.Text = "Classes";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Sitka Text", 13F, FontStyle.Bold);
            button6.ForeColor = Color.Cornsilk;
            button6.ImeMode = ImeMode.NoControl;
            button6.Location = new Point(140, 372);
            button6.Name = "button6";
            button6.Size = new Size(223, 55);
            button6.TabIndex = 8;
            button6.Text = "Courses";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            button7.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Sitka Text", 13F, FontStyle.Bold);
            button7.ForeColor = Color.Cornsilk;
            button7.ImeMode = ImeMode.NoControl;
            button7.Location = new Point(140, 203);
            button7.Name = "button7";
            button7.Size = new Size(223, 55);
            button7.TabIndex = 6;
            button7.Text = "Students";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // btnInsertUser
            // 
            btnInsertUser.Location = new Point(487, 825);
            btnInsertUser.Name = "btnInsertUser";
            btnInsertUser.Size = new Size(154, 52);
            btnInsertUser.TabIndex = 5;
            btnInsertUser.Text = "Add User";
            btnInsertUser.UseVisualStyleBackColor = true;
            btnInsertUser.Click += btnInsertUser_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(664, 220);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(184, 41);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(564, 220);
            label1.Name = "label1";
            label1.Size = new Size(94, 35);
            label1.TabIndex = 6;
            label1.Text = "Search:";
            // 
            // id
            // 
            id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            id.HeaderText = "ID";
            id.MinimumWidth = 10;
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // teacherFname
            // 
            teacherFname.HeaderText = "Fname";
            teacherFname.MinimumWidth = 6;
            teacherFname.Name = "teacherFname";
            teacherFname.ReadOnly = true;
            teacherFname.Width = 170;
            // 
            // teacherLname
            // 
            teacherLname.HeaderText = "Lname";
            teacherLname.MinimumWidth = 6;
            teacherLname.Name = "teacherLname";
            teacherLname.ReadOnly = true;
            teacherLname.Width = 125;
            // 
            // age
            // 
            age.HeaderText = "Age";
            age.MinimumWidth = 6;
            age.Name = "age";
            age.ReadOnly = true;
            age.Width = 125;
            // 
            // email
            // 
            email.HeaderText = "Email";
            email.MinimumWidth = 6;
            email.Name = "email";
            email.ReadOnly = true;
            email.Width = 200;
            // 
            // password
            // 
            password.HeaderText = "Password";
            password.MinimumWidth = 6;
            password.Name = "password";
            password.ReadOnly = true;
            password.Width = 125;
            // 
            // phone
            // 
            phone.HeaderText = "Phone";
            phone.MinimumWidth = 11;
            phone.Name = "phone";
            phone.ReadOnly = true;
            phone.Width = 125;
            // 
            // address
            // 
            address.HeaderText = "Address";
            address.MinimumWidth = 6;
            address.Name = "address";
            address.ReadOnly = true;
            address.Width = 125;
            // 
            // delete
            // 
            delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            delete.HeaderText = "Delete";
            delete.Image = (System.Drawing.Image)resources.GetObject("delete.Image");
            delete.ImageLayout = DataGridViewImageCellLayout.Zoom;
            delete.MinimumWidth = 6;
            delete.Name = "delete";
            delete.ReadOnly = true;
            // 
            // update
            // 
            update.HeaderText = "Update";
            update.Image = (System.Drawing.Image)resources.GetObject("update.Image");
            update.ImageLayout = DataGridViewImageCellLayout.Zoom;
            update.MinimumWidth = 6;
            update.Name = "update";
            update.ReadOnly = true;
            update.Width = 125;
            // 
            // TeacherAdminForm
            // 
            AutoScaleDimensions = new SizeF(14F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1924, 1055);
            Controls.Add(btnInsertUser);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(teacherGrid);
            Font = new Font("Segoe UI", 15F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "TeacherAdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminTeacherForm";
            WindowState = FormWindowState.Maximized;
            Load += TeacherAdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)teacherGrid).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)closebox).EndInit();
            ((System.ComponentModel.ISupportInitialize)minimizebox).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picstudents).EndInit();
            ((System.ComponentModel.ISupportInitialize)picclass).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView teacherGrid;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel3;
        private Panel panel1;
        private Button button3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox1;
        private Button teacherbutton;
        private PictureBox pictureBox2;
        private PictureBox picstudents;
        private PictureBox picclass;
        private Button btnmanageclasses;
        private Button btnmanagestudent;
        private Button btnmangeteachers;
        private Panel panel2;
        private Button button1;
        private PictureBox pictureBox3;
        private Panel panel4;
        private Button button2;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Button button4;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button logout_button;
        private Button teacherData;
        private PictureBox minimizebox;
        private PictureBox closebox;
        private Button btnInsertUser;
        private TextBox textBox1;
        private Label label1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn teacherFname;
        private DataGridViewTextBoxColumn teacherLname;
        private DataGridViewTextBoxColumn age;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn password;
        private DataGridViewTextBoxColumn phone;
        private DataGridViewTextBoxColumn address;
        private DataGridViewImageColumn delete;
        private DataGridViewImageColumn update;
    }
}