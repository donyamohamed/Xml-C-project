namespace Attendance_Management_System.Forms
{
    partial class AdminForm
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            password = new TextBox();
            labelAddress = new Label();
            label4 = new Label();
            labelEmail = new Label();
            labele = new Label();
            labelAge = new Label();
            label3 = new Label();
            labelID = new Label();
            label2 = new Label();
            Teachers_Data = new Button();
            Students_Data = new Button();
            Courses_Data = new Button();
            Classes_Data = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(password);
            groupBox1.Controls.Add(labelAddress);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(labelEmail);
            groupBox1.Controls.Add(labele);
            groupBox1.Controls.Add(labelAge);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(labelID);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(252, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(799, 166);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Profile Data";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 131);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 12;
            label1.Text = "Password:";
            // 
            // password
            // 
            password.Location = new Point(189, 127);
            password.Name = "password";
            password.Size = new Size(125, 27);
            password.TabIndex = 11;
            password.TextChanged += password_TextChanged;
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
            label3.Location = new Point(100, 89);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 5;
            label3.Text = "Age:";
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
            // Teachers_Data
            // 
            Teachers_Data.Location = new Point(252, 257);
            Teachers_Data.Name = "Teachers_Data";
            Teachers_Data.Size = new Size(123, 29);
            Teachers_Data.TabIndex = 11;
            Teachers_Data.Text = "Teachers Data";
            Teachers_Data.UseVisualStyleBackColor = true;
            Teachers_Data.UseWaitCursor = true;
            Teachers_Data.Click += Teachers_Data_Click;
            // 
            // Students_Data
            // 
            Students_Data.Location = new Point(521, 257);
            Students_Data.Name = "Students_Data";
            Students_Data.Size = new Size(114, 29);
            Students_Data.TabIndex = 8;
            Students_Data.Text = "Students Data";
            Students_Data.UseVisualStyleBackColor = true;
            // 
            // Courses_Data
            // 
            Courses_Data.Location = new Point(723, 257);
            Courses_Data.Name = "Courses_Data";
            Courses_Data.Size = new Size(112, 29);
            Courses_Data.TabIndex = 12;
            Courses_Data.Text = "Courses Data";
            Courses_Data.UseVisualStyleBackColor = true;
            // 
            // Classes_Data
            // 
            Classes_Data.Location = new Point(926, 257);
            Classes_Data.Name = "Classes_Data";
            Classes_Data.Size = new Size(112, 29);
            Classes_Data.TabIndex = 13;
            Classes_Data.Text = "Classes Data";
            Classes_Data.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1680, 826);
            Controls.Add(Classes_Data);
            Controls.Add(Courses_Data);
            Controls.Add(Teachers_Data);
            Controls.Add(Students_Data);
            Controls.Add(groupBox1);
            Name = "AdminForm";
            Text = "AdminForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label labelAddress;
        private Label label4;
        private Label labelEmail;
        private Label labele;
        private Label labelAge;
        private Label label3;
        private Label labelID;
        private Label label2;
        private Button Teachers_Data;
        private Button Students_Data;
        private Button Courses_Data;
        private Button Classes_Data;
        private Label label1;
        private TextBox password;
    }
}