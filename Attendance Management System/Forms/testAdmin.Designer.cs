
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
            languagebutton = new PictureBox();
            admin_profile = new Button();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            closebox = new PictureBox();
            minimizebox = new PictureBox();
            admin = new Label();
            lang = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picstudents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picclass).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)languagebutton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)closebox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minimizebox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
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
            panel1.Name = "panel1";
            // 
            // logout
            // 
            resources.ApplyResources(logout, "logout");
            logout.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            logout.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            logout.ForeColor = Color.Cornsilk;
            logout.Name = "logout";
            logout.UseVisualStyleBackColor = true;
            logout.Click += Logout_click;
            // 
            // pictureBox4
            // 
            resources.ApplyResources(pictureBox4, "pictureBox4");
            pictureBox4.Name = "pictureBox4";
            pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // teacher_data
            // 
            resources.ApplyResources(teacher_data, "teacher_data");
            teacher_data.Cursor = Cursors.Hand;
            teacher_data.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            teacher_data.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            teacher_data.ForeColor = Color.Cornsilk;
            teacher_data.Name = "teacher_data";
            teacher_data.UseVisualStyleBackColor = true;
            teacher_data.Click += Teacherbutton_Click;
            // 
            // pictureBox2
            // 
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            // 
            // picstudents
            // 
            resources.ApplyResources(picstudents, "picstudents");
            picstudents.BackColor = Color.FromArgb(255, 192, 192);
            picstudents.Name = "picstudents";
            picstudents.TabStop = false;
            // 
            // picclass
            // 
            resources.ApplyResources(picclass, "picclass");
            picclass.Name = "picclass";
            picclass.TabStop = false;
            // 
            // classes_data
            // 
            resources.ApplyResources(classes_data, "classes_data");
            classes_data.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            classes_data.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            classes_data.ForeColor = Color.Cornsilk;
            classes_data.Name = "classes_data";
            classes_data.UseVisualStyleBackColor = true;
            classes_data.Click += classes_data_Click;
            // 
            // course_data
            // 
            resources.ApplyResources(course_data, "course_data");
            course_data.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            course_data.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            course_data.ForeColor = Color.Cornsilk;
            course_data.Name = "course_data";
            course_data.UseVisualStyleBackColor = true;
            course_data.Click += course_data_Click;
            // 
            // student_data
            // 
            resources.ApplyResources(student_data, "student_data");
            student_data.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            student_data.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            student_data.ForeColor = Color.Cornsilk;
            student_data.Name = "student_data";
            student_data.UseVisualStyleBackColor = true;
            student_data.Click += student_data_Click;
            // 
            // panel3
            // 
            resources.ApplyResources(panel3, "panel3");
            panel3.Controls.Add(lang);
            panel3.Controls.Add(languagebutton);
            panel3.Controls.Add(admin_profile);
            panel3.Controls.Add(pictureBox3);
            panel3.Name = "panel3";
            // 
            // languagebutton
            // 
            resources.ApplyResources(languagebutton, "languagebutton");
            languagebutton.Name = "languagebutton";
            languagebutton.TabStop = false;
            languagebutton.Click += languagebutton_Click;
            // 
            // admin_profile
            // 
            resources.ApplyResources(admin_profile, "admin_profile");
            admin_profile.Cursor = Cursors.Hand;
            admin_profile.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            admin_profile.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            admin_profile.ForeColor = Color.Cornsilk;
            admin_profile.Name = "admin_profile";
            admin_profile.UseVisualStyleBackColor = true;
            admin_profile.Click += admin_profile_Click;
            // 
            // pictureBox3
            // 
            resources.ApplyResources(pictureBox3, "pictureBox3");
            pictureBox3.Name = "pictureBox3";
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // panel2
            // 
            resources.ApplyResources(panel2, "panel2");
            panel2.BackColor = Color.FromArgb(255, 192, 192);
            panel2.Controls.Add(closebox);
            panel2.Controls.Add(minimizebox);
            panel2.Controls.Add(admin);
            panel2.Name = "panel2";
            // 
            // closebox
            // 
            resources.ApplyResources(closebox, "closebox");
            closebox.Name = "closebox";
            closebox.TabStop = false;
            closebox.Click += closebox_Click;
            // 
            // minimizebox
            // 
            resources.ApplyResources(minimizebox, "minimizebox");
            minimizebox.Name = "minimizebox";
            minimizebox.TabStop = false;
            minimizebox.Click += minimizebox_Click;
            // 
            // admin
            // 
            resources.ApplyResources(admin, "admin");
            admin.ForeColor = Color.Transparent;
            admin.Name = "admin";
            // 
            // lang
            // 
            resources.ApplyResources(lang, "lang");
            lang.Name = "lang";
            // 
            // testAdmin
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "testAdmin";
            Load += testAdmin_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picstudents).EndInit();
            ((System.ComponentModel.ISupportInitialize)picclass).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)languagebutton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)closebox).EndInit();
            ((System.ComponentModel.ISupportInitialize)minimizebox).EndInit();
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
        private PictureBox languagebutton;
        private Label lang;
    }
}