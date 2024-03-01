namespace Attendance_Management_System.Forms
{
    partial class UpdateUserForm
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
            btnAdd = new Button();
            label8 = new Label();
            texAddress = new TextBox();
            texPhone = new TextBox();
            texPass = new TextBox();
            texAge = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label1 = new Label();
            formGoal = new Label();
            TexUserID = new TextBox();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.IndianRed;
            btnAdd.ForeColor = Color.Cornsilk;
            btnAdd.Location = new Point(433, 441);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(153, 52);
            btnAdd.TabIndex = 39;
            btnAdd.Text = "Update";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(594, 283);
            label8.Name = "label8";
            label8.Size = new Size(62, 20);
            label8.TabIndex = 36;
            label8.Text = "Address";
            // 
            // texAddress
            // 
            texAddress.Location = new Point(677, 280);
            texAddress.Name = "texAddress";
            texAddress.Size = new Size(156, 27);
            texAddress.TabIndex = 35;
            // 
            // texPhone
            // 
            texPhone.Location = new Point(677, 217);
            texPhone.Name = "texPhone";
            texPhone.Size = new Size(156, 27);
            texPhone.TabIndex = 34;
            // 
            // texPass
            // 
            texPass.Location = new Point(205, 277);
            texPass.Name = "texPass";
            texPass.Size = new Size(156, 27);
            texPass.TabIndex = 33;
            // 
            // texAge
            // 
            texAge.Location = new Point(205, 342);
            texAge.Name = "texAge";
            texAge.Size = new Size(156, 27);
            texAge.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(594, 223);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 27;
            label7.Text = "Phone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(109, 280);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 26;
            label6.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(124, 342);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 24;
            label4.Text = "Age";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(124, 217);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 21;
            label1.Text = "User ID";
            // 
            // formGoal
            // 
            formGoal.AutoSize = true;
            formGoal.Font = new Font("Lucida Handwriting", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            formGoal.ForeColor = Color.Cornsilk;
            formGoal.Location = new Point(507, 63);
            formGoal.Name = "formGoal";
            formGoal.Size = new Size(204, 36);
            formGoal.TabIndex = 0;
            formGoal.Text = "Update User";
            formGoal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TexUserID
            // 
            TexUserID.Location = new Point(205, 214);
            TexUserID.Name = "TexUserID";
            TexUserID.Size = new Size(156, 27);
            TexUserID.TabIndex = 28;
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Controls.Add(formGoal);
            panel1.Location = new Point(-125, -15);
            panel1.Name = "panel1";
            panel1.Size = new Size(1102, 145);
            panel1.TabIndex = 20;
            // 
            // UpdateUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 543);
            Controls.Add(btnAdd);
            Controls.Add(label8);
            Controls.Add(texAddress);
            Controls.Add(texPhone);
            Controls.Add(texPass);
            Controls.Add(texAge);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(TexUserID);
            Controls.Add(panel1);
            Name = "UpdateUserForm";
            Text = "UpdateUserForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Label label8;
        private TextBox texAddress;
        private TextBox texPhone;
        private TextBox texPass;
        private TextBox texAge;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label1;
        private Label formGoal;
        private TextBox TexUserID;
        private Panel panel1;
    }
}