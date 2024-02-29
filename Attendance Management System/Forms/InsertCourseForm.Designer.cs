namespace Attendance_Management_System.Forms
{
    partial class InsertCourseForm
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
            texname = new TextBox();
            TexcourseID = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            formGoal = new Label();
            label5 = new Label();
            texdescription = new TextBox();
            label9 = new Label();
            combosessionnumber = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(255, 192, 192);
            btnAdd.ImeMode = ImeMode.NoControl;
            btnAdd.Location = new Point(20, 462);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(153, 52);
            btnAdd.TabIndex = 39;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // texname
            // 
            texname.Location = new Point(122, 323);
            texname.Name = "texname";
            texname.Size = new Size(156, 27);
            texname.TabIndex = 30;
           // texname.TextChanged += texname_TextChanged;
            // 
            // TexcourseID
            // 
            TexcourseID.Location = new Point(122, 267);
            TexcourseID.Name = "TexcourseID";
            TexcourseID.ReadOnly = true;
            TexcourseID.Size = new Size(156, 27);
            TexcourseID.TabIndex = 29;
           // TexcourseID.TextChanged += TexCourseID_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(29, 323);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 23;
            label2.Text = " Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(19, 274);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 22;
            label1.Text = "Course ID";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 192);
            panel1.Controls.Add(formGoal);
            panel1.Location = new Point(-68, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(1050, 145);
            panel1.TabIndex = 21;
            // 
            // formGoal
            // 
            formGoal.AutoSize = true;
            formGoal.Font = new Font("Lucida Handwriting", 16.2F);
            formGoal.ImeMode = ImeMode.NoControl;
            formGoal.Location = new Point(398, 55);
            formGoal.Name = "formGoal";
            formGoal.Size = new Size(292, 36);
            formGoal.TabIndex = 0;
            formGoal.Text = "Insert New Course";
            formGoal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(343, 330);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 26;
            label5.Text = "Description";
            // 
            // texdescription
            // 
            texdescription.Location = new Point(452, 330);
            texdescription.Multiline = true;
            texdescription.Name = "texdescription";
            texdescription.Size = new Size(221, 109);
            texdescription.TabIndex = 33;
           // texdescription.TextChanged += texCourse_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ImeMode = ImeMode.NoControl;
            label9.Location = new Point(330, 270);
            label9.Name = "label9";
            label9.Size = new Size(116, 20);
            label9.TabIndex = 38;
            label9.Text = "Session Number";
            // 
            // combosessionnumber
            // 
            combosessionnumber.FormattingEnabled = true;
            combosessionnumber.Location = new Point(476, 267);
            combosessionnumber.Name = "combosessionnumber";
            combosessionnumber.Size = new Size(156, 28);
            combosessionnumber.TabIndex = 40;
            combosessionnumber.Text = "Session Number";
            //combosessionnumber.SelectedIndexChanged += comboBoxRole_SelectedIndexChanged;
            // 
            // InsertCourseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 551);
            Controls.Add(combosessionnumber);
            Controls.Add(btnAdd);
            Controls.Add(label9);
            Controls.Add(texdescription);
            Controls.Add(texname);
            Controls.Add(TexcourseID);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "InsertCourseForm";
            Text = "InsertCourseForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private TextBox texname;
        private TextBox TexcourseID;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Label formGoal;
        private Label label5;
        private TextBox texdescription;
        private Label label9;
        private ComboBox combosessionnumber;
    }
}