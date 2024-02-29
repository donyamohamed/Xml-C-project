namespace Attendance_Management_System.controls
{
    partial class CourseAdminForm
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
            label1 = new Label();
            search = new TextBox();
            dataGridView1 = new DataGridView();
            addcourse = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addcourse).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(242, 93);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 8;
            label1.Text = "Search:";
            // 
            // search
            // 
            search.Location = new Point(347, 93);
            search.Name = "search";
            search.Size = new Size(184, 27);
            search.TabIndex = 7;
            search.TextChanged += search_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(120, 182);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(837, 503);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // addcourse
            // 
            addcourse.Image = Properties.Resources.add__1_;
            addcourse.ImeMode = ImeMode.NoControl;
            addcourse.Location = new Point(832, 73);
            addcourse.Name = "addcourse";
            addcourse.Size = new Size(68, 63);
            addcourse.SizeMode = PictureBoxSizeMode.Zoom;
            addcourse.TabIndex = 13;
            addcourse.TabStop = false;
            addcourse.Click += addcourse_Click;
            // 
            // CourseAdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(addcourse);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(search);
            Name = "CourseAdminForm";
            Size = new Size(1021, 809);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)addcourse).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox search;
        private DataGridView dataGridView1;
       // private PictureBox pictureBox1;
        private PictureBox addcourse;
    }
}
