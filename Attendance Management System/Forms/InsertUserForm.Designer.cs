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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertUserForm));
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
            resources.ApplyResources(panel1, "panel1");
            panel1.BackColor = Color.IndianRed;
            panel1.Controls.Add(formGoal);
            panel1.Name = "panel1";
            // 
            // formGoal
            // 
            resources.ApplyResources(formGoal, "formGoal");
            formGoal.ForeColor = Color.Cornsilk;
            formGoal.Name = "formGoal";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.Name = "label7";
            // 
            // TexUserID
            // 
            resources.ApplyResources(TexUserID, "TexUserID");
            TexUserID.Name = "TexUserID";
            TexUserID.ReadOnly = true;
            // 
            // texFname
            // 
            resources.ApplyResources(texFname, "texFname");
            texFname.Name = "texFname";
            // 
            // texLname
            // 
            resources.ApplyResources(texLname, "texLname");
            texLname.Name = "texLname";
            // 
            // texAge
            // 
            resources.ApplyResources(texAge, "texAge");
            texAge.Name = "texAge";
            // 
            // texEmail
            // 
            resources.ApplyResources(texEmail, "texEmail");
            texEmail.Name = "texEmail";
            // 
            // texPass
            // 
            resources.ApplyResources(texPass, "texPass");
            texPass.Name = "texPass";
            // 
            // texPhone
            // 
            resources.ApplyResources(texPhone, "texPhone");
            texPhone.Name = "texPhone";
            // 
            // texAddress
            // 
            resources.ApplyResources(texAddress, "texAddress");
            texAddress.Name = "texAddress";
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(label9, "label9");
            label9.Name = "label9";
            // 
            // btnAdd
            // 
            resources.ApplyResources(btnAdd, "btnAdd");
            btnAdd.BackColor = Color.IndianRed;
            btnAdd.ForeColor = Color.Cornsilk;
            btnAdd.Name = "btnAdd";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // comboBoxRole
            // 
            resources.ApplyResources(comboBoxRole, "comboBoxRole");
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Items.AddRange(new object[] { resources.GetString("comboBoxRole.Items"), resources.GetString("comboBoxRole.Items1") });
            comboBoxRole.Name = "comboBoxRole";
            // 
            // InsertUserForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
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