namespace Attendance_Management_System.controls
{
    partial class ClassAdminForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboclassId = new ComboBox();
            comboCourseId = new ComboBox();
            teacherIdbox = new TextBox();
            classId = new Label();
            courseId = new Label();
            teacherId = new Label();
            dataGridView1 = new DataGridView();
            delete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboclassId
            // 
            comboclassId.FormattingEnabled = true;
            comboclassId.Location = new Point(152, 144);
            comboclassId.Name = "comboclassId";
            comboclassId.Size = new Size(151, 28);
            comboclassId.TabIndex = 0;
            comboclassId.SelectedIndexChanged += comboClassId_SelectedIndexChanged;
            // 
            // comboCourseId
            // 
            comboCourseId.FormattingEnabled = true;
            comboCourseId.Location = new Point(458, 144);
            comboCourseId.Name = "comboCourseId";
            comboCourseId.Size = new Size(151, 28);
            comboCourseId.TabIndex = 1;
            comboCourseId.SelectedIndexChanged += comboCourseId_SelectedIndexChanged;
            // 
            // teacherIdbox
            // 
            teacherIdbox.Location = new Point(786, 148);
            teacherIdbox.Name = "teacherIdbox";
            teacherIdbox.Size = new Size(125, 27);
            teacherIdbox.TabIndex = 2;
            teacherIdbox.TextChanged += teacherIdbox_TextChanged;
            // 
            // classId
            // 
            classId.AutoSize = true;
            classId.Location = new Point(57, 151);
            classId.Name = "classId";
            classId.Size = new Size(62, 20);
            classId.TabIndex = 3;
            classId.Text = "Class Id:";
            // 
            // courseId
            // 
            courseId.AutoSize = true;
            courseId.Location = new Point(364, 151);
            courseId.Name = "courseId";
            courseId.Size = new Size(74, 20);
            courseId.TabIndex = 4;
            courseId.Text = "Course Id:";
            // 
            // teacherId
            // 
            teacherId.AutoSize = true;
            teacherId.Location = new Point(693, 152);
            teacherId.Name = "teacherId";
            teacherId.Size = new Size(80, 20);
            teacherId.TabIndex = 5;
            teacherId.Text = "Teacher Id:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(57, 253);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(881, 457);
            dataGridView1.TabIndex = 6;
            // 
            // delete
            // 
            delete.Location = new Point(78, 681);
            delete.Name = "delete";
            delete.Size = new Size(94, 29);
            delete.TabIndex = 7;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = true;
            // 
            // ClassAdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(delete);
            Controls.Add(dataGridView1);
            Controls.Add(teacherId);
            Controls.Add(courseId);
            Controls.Add(classId);
            Controls.Add(teacherIdbox);
            Controls.Add(comboCourseId);
            Controls.Add(comboclassId);
            Name = "ClassAdminForm";
            Size = new Size(1020, 767);
          //  Load += ClassAdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboclassId;
        private ComboBox comboCourseId;
        private TextBox teacherIdbox;
        private Label classId;
        private Label courseId;
        private Label teacherId;
        private DataGridView dataGridView1;
        private Button delete;
    }
}
