namespace Attendance_Management_System.Forms
{
    partial class AdminDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboardForm));
            panel2 = new Panel();
            closebox = new PictureBox();
            minimizebox = new PictureBox();
            admin = new Label();
            panel1 = new Panel();
            logout = new Button();
            pictureBox4 = new PictureBox();
            pictureBox1 = new PictureBox();
            teacher_data = new Button();
            pictureBox2 = new PictureBox();
            picstudents = new PictureBox();
            picclass = new PictureBox();
            classes_data = new Button();
            course_data = new Button();
            student_data = new Button();
            panel3 = new Panel();
            admin_profile = new Button();
            pictureBox3 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)closebox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minimizebox).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picstudents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picclass).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.IndianRed;
            panel2.Controls.Add(closebox);
            panel2.Controls.Add(minimizebox);
            panel2.Controls.Add(admin);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(387, 0);
            panel2.Margin = new Padding(5, 6, 5, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(1202, 120);
            panel2.TabIndex = 6;
            // 
            // closebox
            // 
            closebox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            closebox.Image = (Image)resources.GetObject("closebox.Image");
            closebox.ImeMode = ImeMode.NoControl;
            closebox.Location = new Point(1159, 0);
            closebox.Name = "closebox";
            closebox.Size = new Size(43, 43);
            closebox.SizeMode = PictureBoxSizeMode.Zoom;
            closebox.TabIndex = 17;
            closebox.TabStop = false;
            closebox.Click += closebox_Click;
            // 
            // minimizebox
            // 
            minimizebox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            minimizebox.Image = (Image)resources.GetObject("minimizebox.Image");
            minimizebox.ImeMode = ImeMode.NoControl;
            minimizebox.Location = new Point(1933, 3);
            minimizebox.Name = "minimizebox";
            minimizebox.Size = new Size(52, 43);
            minimizebox.SizeMode = PictureBoxSizeMode.Zoom;
            minimizebox.TabIndex = 16;
            minimizebox.TabStop = false;
            // 
            // admin
            // 
            admin.AutoSize = true;
            admin.Font = new Font("Sitka Text", 13F, FontStyle.Bold);
            admin.ForeColor = Color.Transparent;
            admin.Location = new Point(186, 43);
            admin.Name = "admin";
            admin.Size = new Size(210, 32);
            admin.TabIndex = 0;
            admin.Text = "Admin Dashboard";
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Controls.Add(logout);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(teacher_data);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(picstudents);
            panel1.Controls.Add(picclass);
            panel1.Controls.Add(classes_data);
            panel1.Controls.Add(course_data);
            panel1.Controls.Add(student_data);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5, 6, 5, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(387, 1030);
            panel1.TabIndex = 5;
            // 
            // logout
            // 
            logout.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            logout.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            logout.FlatStyle = FlatStyle.Flat;
            logout.Font = new Font("Sitka Text", 13F, FontStyle.Bold);
            logout.ForeColor = Color.Cornsilk;
            logout.ImeMode = ImeMode.NoControl;
            logout.Location = new Point(140, 855);
            logout.Name = "logout";
            logout.Size = new Size(223, 55);
            logout.TabIndex = 17;
            logout.Text = "Log Out";
            logout.UseVisualStyleBackColor = true;
            logout.Click += logout_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
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
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.ImeMode = ImeMode.NoControl;
            pictureBox1.Location = new Point(23, 391);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // teacher_data
            // 
            teacher_data.Cursor = Cursors.Hand;
            teacher_data.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            teacher_data.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            teacher_data.FlatStyle = FlatStyle.Flat;
            teacher_data.Font = new Font("Sitka Text", 13F, FontStyle.Bold);
            teacher_data.ForeColor = Color.Cornsilk;
            teacher_data.ImeMode = ImeMode.NoControl;
            teacher_data.Location = new Point(140, 285);
            teacher_data.Name = "teacher_data";
            teacher_data.Size = new Size(223, 55);
            teacher_data.TabIndex = 14;
            teacher_data.Text = "Teachers";
            teacher_data.UseVisualStyleBackColor = true;
            teacher_data.Click += teacher_data_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
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
            picstudents.Image = (Image)resources.GetObject("picstudents.Image");
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
            picclass.Image = (Image)resources.GetObject("picclass.Image");
            picclass.ImeMode = ImeMode.NoControl;
            picclass.Location = new Point(34, 688);
            picclass.Name = "picclass";
            picclass.Size = new Size(100, 87);
            picclass.SizeMode = PictureBoxSizeMode.Zoom;
            picclass.TabIndex = 9;
            picclass.TabStop = false;
            // 
            // classes_data
            // 
            classes_data.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            classes_data.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            classes_data.FlatStyle = FlatStyle.Flat;
            classes_data.Font = new Font("Sitka Text", 13F, FontStyle.Bold);
            classes_data.ForeColor = Color.Cornsilk;
            classes_data.ImeMode = ImeMode.NoControl;
            classes_data.Location = new Point(140, 707);
            classes_data.Name = "classes_data";
            classes_data.Size = new Size(223, 55);
            classes_data.TabIndex = 10;
            classes_data.Text = "Classes";
            classes_data.UseVisualStyleBackColor = true;
            classes_data.Click += classes_data_Click;
            // 
            // course_data
            // 
            course_data.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            course_data.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            course_data.FlatStyle = FlatStyle.Flat;
            course_data.Font = new Font("Sitka Text", 13F, FontStyle.Bold);
            course_data.ForeColor = Color.Cornsilk;
            course_data.ImeMode = ImeMode.NoControl;
            course_data.Location = new Point(140, 548);
            course_data.Name = "course_data";
            course_data.Size = new Size(223, 55);
            course_data.TabIndex = 8;
            course_data.Text = "Courses";
            course_data.UseVisualStyleBackColor = true;
            course_data.Click += course_data_Click;
            // 
            // student_data
            // 
            student_data.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            student_data.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            student_data.FlatStyle = FlatStyle.Flat;
            student_data.Font = new Font("Sitka Text", 13F, FontStyle.Bold);
            student_data.ForeColor = Color.Cornsilk;
            student_data.ImeMode = ImeMode.NoControl;
            student_data.Location = new Point(140, 411);
            student_data.Name = "student_data";
            student_data.Size = new Size(223, 55);
            student_data.TabIndex = 6;
            student_data.Text = "Students";
            student_data.UseVisualStyleBackColor = true;
            student_data.Click += student_data_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.IndianRed;
            panel3.Controls.Add(admin_profile);
            panel3.Controls.Add(pictureBox3);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(5, 6, 5, 6);
            panel3.Name = "panel3";
            panel3.Size = new Size(387, 188);
            panel3.TabIndex = 1;
            // 
            // admin_profile
            // 
            admin_profile.Cursor = Cursors.Hand;
            admin_profile.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            admin_profile.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            admin_profile.FlatStyle = FlatStyle.Flat;
            admin_profile.Font = new Font("Sitka Text", 13F, FontStyle.Bold);
            admin_profile.ForeColor = Color.Cornsilk;
            admin_profile.ImeMode = ImeMode.NoControl;
            admin_profile.Location = new Point(71, 126);
            admin_profile.Name = "admin_profile";
            admin_profile.Size = new Size(223, 55);
            admin_profile.TabIndex = 15;
            admin_profile.Text = "Admin";
            admin_profile.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.ImeMode = ImeMode.NoControl;
            pictureBox3.Location = new Point(139, 34);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 87);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1589, 1030);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminDashboardForm";
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminDashboardForm";
            WindowState = FormWindowState.Maximized;
            Load += AdminDashboardForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)closebox).EndInit();
            ((System.ComponentModel.ISupportInitialize)minimizebox).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picstudents).EndInit();
            ((System.ComponentModel.ISupportInitialize)picclass).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private PictureBox closebox;
        private PictureBox minimizebox;
        private Label admin;
        private Panel panel1;
        private Button logout;
        private PictureBox pictureBox4;
        private PictureBox pictureBox1;
        private Button teacher_data;
        private PictureBox pictureBox2;
        private PictureBox picstudents;
        private PictureBox picclass;
        private Button classes_data;
        private Button course_data;
        private Button student_data;
        private Panel panel3;
        private Button admin_profile;
        private PictureBox pictureBox3;
        private controls.CourseAdminForm courseAdminForm1;
        private controls.ClassAdminForm classAdminForm1;
        private controls.StudentsAdminForm studentsAdminForm1;
        private controls.ClassAdminForm classAdminForm2;
        private controls.CourseAdminForm courseAdminForm2;
        // private Attendance_Management_System.TeacherAdminForm teacherAdminForm1;
        //private StudentsAdminForm studentsAdminForm1;
    }
}