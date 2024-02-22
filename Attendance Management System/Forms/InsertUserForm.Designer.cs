namespace Attendance_Management_System.Forms
{
    partial class InsertUserForm
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
            panel1 = new Panel();
            formGoal = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            TexUserID = new TextBox();
            texFname = new TextBox();
            texLname = new TextBox();
            texAge = new TextBox();
            texEmail = new TextBox();
            texPass = new TextBox();
            texPhone = new TextBox();
            texAddress = new TextBox();
            label8 = new Label();
            label9 = new Label();
            btnAdd = new Button();
            comboBoxRole = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 192);
            panel1.Controls.Add(formGoal);
            panel1.Location = new Point(-2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1050, 145);
            panel1.TabIndex = 0;
            // 
            // formGoal
            // 
            formGoal.AutoSize = true;
            formGoal.Font = new Font("Lucida Handwriting", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            formGoal.Location = new Point(398, 55);
            formGoal.Name = "formGoal";
            formGoal.Size = new Size(255, 36);
            formGoal.TabIndex = 0;
            formGoal.Text = "Insert New User";
            formGoal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 235);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 1;
            label1.Text = "User ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 288);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 2;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 349);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 3;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(435, 292);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 4;
            label4.Text = "Age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(435, 351);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 5;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(738, 231);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 6;
            label6.Text = "Password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(751, 292);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 7;
            label7.Text = "Phone";
            // 
            // TexUserID
            // 
            TexUserID.Location = new Point(188, 232);
            TexUserID.Name = "TexUserID";
            TexUserID.ReadOnly = true;
            TexUserID.Size = new Size(156, 27);
            TexUserID.TabIndex = 8;
            // 
            // texFname
            // 
            texFname.Location = new Point(188, 288);
            texFname.Name = "texFname";
            texFname.Size = new Size(156, 27);
            texFname.TabIndex = 9;
            // 
            // texLname
            // 
            texLname.Location = new Point(188, 349);
            texLname.Name = "texLname";
            texLname.Size = new Size(156, 27);
            texLname.TabIndex = 10;
            // 
            // texAge
            // 
            texAge.Location = new Point(516, 292);
            texAge.Name = "texAge";
            texAge.Size = new Size(156, 27);
            texAge.TabIndex = 11;
            // 
            // texEmail
            // 
            texEmail.Location = new Point(516, 348);
            texEmail.Name = "texEmail";
            texEmail.Size = new Size(156, 27);
            texEmail.TabIndex = 12;
            // 
            // texPass
            // 
            texPass.Location = new Point(834, 228);
            texPass.Name = "texPass";
            texPass.Size = new Size(156, 27);
            texPass.TabIndex = 13;
            // 
            // texPhone
            // 
            texPhone.Location = new Point(834, 286);
            texPhone.Name = "texPhone";
            texPhone.Size = new Size(156, 27);
            texPhone.TabIndex = 14;
            // 
            // texAddress
            // 
            texAddress.Location = new Point(834, 342);
            texAddress.Name = "texAddress";
            texAddress.Size = new Size(156, 27);
            texAddress.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(751, 345);
            label8.Name = "label8";
            label8.Size = new Size(62, 20);
            label8.TabIndex = 16;
            label8.Text = "Address";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(432, 238);
            label9.Name = "label9";
            label9.Size = new Size(39, 20);
            label9.TabIndex = 17;
            label9.Text = "Role";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(255, 192, 192);
            btnAdd.Location = new Point(86, 427);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(153, 52);
            btnAdd.TabIndex = 19;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // comboBoxRole
            // 
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Items.AddRange(new object[] { "Student", "Teacher" });
            comboBoxRole.Location = new Point(516, 232);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(156, 28);
            comboBoxRole.TabIndex = 20;
            // 
            // InsertUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1047, 506);
            Controls.Add(comboBoxRole);
            Controls.Add(btnAdd);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(texAddress);
            Controls.Add(texPhone);
            Controls.Add(texPass);
            Controls.Add(texEmail);
            Controls.Add(texAge);
            Controls.Add(texLname);
            Controls.Add(texFname);
            Controls.Add(TexUserID);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "InsertUserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InsertUserForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label formGoal;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox TexUserID;
        private TextBox texFname;
        private TextBox texLname;
        private TextBox texAge;
        private TextBox texEmail;
        private TextBox texPass;
        private TextBox texPhone;
        private TextBox texAddress;
        private Label label8;
        private Label label9;
        private Button btnAdd;
        private ComboBox comboBoxRole;
    }
}