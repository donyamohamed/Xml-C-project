namespace Attendance_Management_System.Forms
{
    partial class StudentForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            studentGrid = new DataGridView();
            date = new DataGridViewTextBoxColumn();
            courseName = new DataGridViewTextBoxColumn();
            teacherId = new DataGridViewTextBoxColumn();
            sessionNo = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            label1 = new Label();
            labelName = new Label();
            label2 = new Label();
            labelID = new Label();
            textSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)studentGrid).BeginInit();
            SuspendLayout();
            // 
            // studentGrid
            // 
            studentGrid.AllowUserToAddRows = false;
            studentGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.Padding = new Padding(5);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            studentGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            studentGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            studentGrid.BackgroundColor = Color.White;
            studentGrid.BorderStyle = BorderStyle.None;
            studentGrid.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Orchid;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Orchid;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            studentGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            studentGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentGrid.Columns.AddRange(new DataGridViewColumn[] { date, courseName, teacherId, sessionNo, status });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.SkyBlue;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Orchid;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            studentGrid.DefaultCellStyle = dataGridViewCellStyle3;
            studentGrid.GridColor = SystemColors.ActiveCaption;
            studentGrid.Location = new Point(104, 258);
            studentGrid.Margin = new Padding(4, 3, 4, 3);
            studentGrid.Name = "studentGrid";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Lavender;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            studentGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            studentGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            studentGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            studentGrid.Size = new Size(1003, 334);
            studentGrid.TabIndex = 0;
            // 
            // date
            // 
            date.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            date.HeaderText = "Date";
            date.MinimumWidth = 6;
            date.Name = "date";
            // 
            // courseName
            // 
            courseName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            courseName.HeaderText = "Course Name";
            courseName.MinimumWidth = 6;
            courseName.Name = "courseName";
            // 
            // teacherId
            // 
            teacherId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            teacherId.HeaderText = "Teacher ID";
            teacherId.MinimumWidth = 6;
            teacherId.Name = "teacherId";
            // 
            // sessionNo
            // 
            sessionNo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            sessionNo.HeaderText = "Session No";
            sessionNo.MinimumWidth = 6;
            sessionNo.Name = "sessionNo";
            // 
            // status
            // 
            status.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            status.HeaderText = "Attendance Status";
            status.MinimumWidth = 6;
            status.Name = "status";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Lucida Calligraphy", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Purple;
            label1.Location = new Point(104, 105);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(251, 36);
            label1.TabIndex = 1;
            label1.Text = "Welcome Back:";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelName
            // 
            labelName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            labelName.AutoSize = true;
            labelName.Font = new Font("Lucida Calligraphy", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelName.ForeColor = Color.DarkMagenta;
            labelName.Location = new Point(354, 105);
            labelName.Margin = new Padding(4, 0, 4, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(102, 36);
            labelName.TabIndex = 2;
            labelName.Text = "name";
            labelName.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Font = new Font("Lucida Calligraphy", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Purple;
            label2.Location = new Point(915, 110);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(128, 29);
            label2.TabIndex = 3;
            label2.Text = "Your ID:";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelID
            // 
            labelID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            labelID.AutoSize = true;
            labelID.Font = new Font("Lucida Calligraphy", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelID.ForeColor = Color.DarkMagenta;
            labelID.Location = new Point(1041, 110);
            labelID.Margin = new Padding(4, 0, 4, 0);
            labelID.Name = "labelID";
            labelID.Size = new Size(39, 29);
            labelID.TabIndex = 4;
            labelID.Text = "id";
            labelID.TextAlign = ContentAlignment.TopCenter;
            // 
            // textSearch
            // 
            textSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textSearch.Cursor = Cursors.IBeam;
            textSearch.Location = new Point(924, 201);
            textSearch.Name = "textSearch";
            textSearch.Size = new Size(183, 30);
            textSearch.TabIndex = 6;
            textSearch.Text = "Search";
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1211, 787);
            Controls.Add(textSearch);
            Controls.Add(studentGrid);
            Controls.Add(label1);
            Controls.Add(labelName);
            Controls.Add(label2);
            Controls.Add(labelID);
            Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "StudentForm";
            Padding = new Padding(0, 5, 60, 20);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentForm";
            WindowState = FormWindowState.Maximized;
            Load += StudentForm_Load;
            ((System.ComponentModel.ISupportInitialize)studentGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView studentGrid;
        private Label label1;
        private Label labelName;
        private Label label2;
        private Label labelID;
        private TextBox textSearch;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn courseName;
        private DataGridViewTextBoxColumn teacherId;
        private DataGridViewTextBoxColumn sessionNo;
        private DataGridViewTextBoxColumn status;
    }
}