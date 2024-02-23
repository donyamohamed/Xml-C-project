
namespace Attendance_Management_System.Forms
{
    partial class testAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(testAdmin));
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
            panel2 = new Panel();
            closebox = new PictureBox();
            minimizebox = new PictureBox();
            admin = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picstudents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picclass).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)closebox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minimizebox).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 192);
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
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(339, 591);
            panel1.TabIndex = 3;
            // 
            // logout
            // 
            logout.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            logout.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            logout.FlatStyle = FlatStyle.Flat;
            logout.Font = new Font("Sitka Text", 13F, FontStyle.Bold);
            logout.ForeColor = Color.Cornsilk;
            logout.ImeMode = ImeMode.NoControl;
            logout.Location = new Point(122, 641);
            logout.Margin = new Padding(3, 2, 3, 2);
            logout.Name = "logout";
            logout.Size = new Size(195, 41);
            logout.TabIndex = 17;
            logout.Text = "Log Out";
            logout.UseVisualStyleBackColor = true;
            logout.Click += Logout_click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.ImeMode = ImeMode.NoControl;
            pictureBox4.InitialImage = null;
            pictureBox4.Location = new Point(30, 628);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(88, 65);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 16;
            pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.ImeMode = ImeMode.NoControl;
            pictureBox1.Location = new Point(20, 293);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(88, 65);
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
            teacher_data.Location = new Point(122, 214);
            teacher_data.Margin = new Padding(3, 2, 3, 2);
            teacher_data.Name = "teacher_data";
            teacher_data.Size = new Size(195, 41);
            teacher_data.TabIndex = 14;
            teacher_data.Text = "Teachers";
            teacher_data.UseVisualStyleBackColor = true;
            teacher_data.Click += Teacherbutton_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.ImeMode = ImeMode.NoControl;
            pictureBox2.Location = new Point(20, 202);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(88, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // picstudents
            // 
            picstudents.BackColor = Color.FromArgb(255, 192, 192);
            picstudents.Image = (Image)resources.GetObject("picstudents.Image");
            picstudents.ImeMode = ImeMode.NoControl;
            picstudents.Location = new Point(20, 396);
            picstudents.Margin = new Padding(3, 2, 3, 2);
            picstudents.Name = "picstudents";
            picstudents.Size = new Size(88, 65);
            picstudents.SizeMode = PictureBoxSizeMode.Zoom;
            picstudents.TabIndex = 7;
            picstudents.TabStop = false;
            // 
            // picclass
            // 
            picclass.Image = (Image)resources.GetObject("picclass.Image");
            picclass.ImeMode = ImeMode.NoControl;
            picclass.Location = new Point(30, 516);
            picclass.Margin = new Padding(3, 2, 3, 2);
            picclass.Name = "picclass";
            picclass.Size = new Size(88, 65);
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
            classes_data.Location = new Point(122, 530);
            classes_data.Margin = new Padding(3, 2, 3, 2);
            classes_data.Name = "classes_data";
            classes_data.Size = new Size(195, 41);
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
            course_data.Location = new Point(122, 411);
            course_data.Margin = new Padding(3, 2, 3, 2);
            course_data.Name = "course_data";
            course_data.Size = new Size(195, 41);
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
            student_data.Location = new Point(122, 308);
            student_data.Margin = new Padding(3, 2, 3, 2);
            student_data.Name = "student_data";
            student_data.Size = new Size(195, 41);
            student_data.TabIndex = 6;
            student_data.Text = "Students";
            student_data.UseVisualStyleBackColor = true;
            student_data.Click += student_data_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(admin_profile);
            panel3.Controls.Add(pictureBox3);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(339, 141);
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
            admin_profile.Location = new Point(62, 94);
            admin_profile.Margin = new Padding(3, 2, 3, 2);
            admin_profile.Name = "admin_profile";
            admin_profile.Size = new Size(195, 41);
            admin_profile.TabIndex = 15;
            admin_profile.Text = "Admin";
            admin_profile.UseVisualStyleBackColor = true;
            admin_profile.Click += admin_profile_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.ImeMode = ImeMode.NoControl;
            pictureBox3.Location = new Point(122, 26);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(88, 65);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 192);
            panel2.Controls.Add(closebox);
            panel2.Controls.Add(minimizebox);
            panel2.Controls.Add(admin);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(339, 0);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(874, 90);
            panel2.TabIndex = 4;
            // 
            // closebox
            // 
            closebox.Image = (Image)resources.GetObject("closebox.Image");
            closebox.ImeMode = ImeMode.NoControl;
            closebox.Location = new Point(872, 0);
            closebox.Margin = new Padding(3, 2, 3, 2);
            closebox.Name = "closebox";
            closebox.Size = new Size(38, 32);
            closebox.SizeMode = PictureBoxSizeMode.Zoom;
            closebox.TabIndex = 17;
            closebox.TabStop = false;
            closebox.Click += closebox_Click;
            // 
            // minimizebox
            // 
            minimizebox.Image = (Image)resources.GetObject("minimizebox.Image");
            minimizebox.ImeMode = ImeMode.NoControl;
            minimizebox.Location = new Point(830, 0);
            minimizebox.Margin = new Padding(3, 2, 3, 2);
            minimizebox.Name = "minimizebox";
            minimizebox.Size = new Size(46, 32);
            minimizebox.SizeMode = PictureBoxSizeMode.Zoom;
            minimizebox.TabIndex = 16;
            minimizebox.TabStop = false;
            minimizebox.Click += minimizebox_Click;
            // 
            // admin
            // 
            admin.AutoSize = true;
            admin.Font = new Font("Sitka Text", 13F, FontStyle.Bold);
            admin.ForeColor = Color.Transparent;
            admin.Location = new Point(144, 37);
            admin.Name = "admin";
            admin.Size = new Size(170, 26);
            admin.TabIndex = 0;
            admin.Text = "Admin Dashboard";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(468, 206);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(200, 100);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(192, 72);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(192, 72);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // testAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1213, 591);
            Controls.Add(tabControl1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "testAdmin";
            Text = "testAdmin";
            Load += testAdmin_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picstudents).EndInit();
            ((System.ComponentModel.ISupportInitialize)picclass).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)closebox).EndInit();
            ((System.ComponentModel.ISupportInitialize)minimizebox).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }



        #endregion

        private Panel panel1;
        private Button teacher_data;
        private PictureBox pictureBox2;
        private PictureBox picstudents;
        private PictureBox picclass;
        private Button classes_data;
        private Button course_data;
        private Button student_data;
        private Panel panel3;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Button admin_profile;
        private PictureBox pictureBox4;
        private Button logout;
        private Label admin;
        private PictureBox closebox;
        private PictureBox minimizebox;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
    }
}