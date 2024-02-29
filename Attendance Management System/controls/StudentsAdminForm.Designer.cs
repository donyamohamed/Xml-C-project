namespace Attendance_Management_System.controls
{
    partial class StudentsAdminForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentsAdminForm));
            label1 = new Label();
            textBox1 = new TextBox();
            studentGrid = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            Fname = new DataGridViewTextBoxColumn();
            Lname = new DataGridViewTextBoxColumn();
            age = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            password = new DataGridViewTextBoxColumn();
            phone = new DataGridViewTextBoxColumn();
            address = new DataGridViewTextBoxColumn();
            delete = new DataGridViewImageColumn();
            update = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)studentGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(172, 175);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 9;
            label1.Text = "Search:";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(341, 168);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(159, 27);
            textBox1.TabIndex = 8;
            // 
            // studentGrid
            // 
            studentGrid.AllowUserToAddRows = false;
            studentGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.Padding = new Padding(5);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            studentGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            studentGrid.BackgroundColor = SystemColors.Control;
            studentGrid.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Orchid;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            studentGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            studentGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentGrid.Columns.AddRange(new DataGridViewColumn[] { id, Fname, Lname, age, email, password, phone, address, delete, update });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            studentGrid.DefaultCellStyle = dataGridViewCellStyle4;
            studentGrid.Location = new Point(23, 267);
            studentGrid.Margin = new Padding(5);
            studentGrid.Name = "studentGrid";
            studentGrid.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            studentGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            studentGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.Padding = new Padding(5, 10, 5, 10);
            studentGrid.RowsDefaultCellStyle = dataGridViewCellStyle6;
            studentGrid.Size = new Size(1333, 467);
            studentGrid.TabIndex = 7;
            // 
            // id
            // 
            id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            id.DefaultCellStyle = dataGridViewCellStyle3;
            id.HeaderText = "ID";
            id.MinimumWidth = 10;
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // Fname
            // 
            Fname.HeaderText = "Fname";
            Fname.MinimumWidth = 6;
            Fname.Name = "Fname";
            Fname.ReadOnly = true;
            Fname.Width = 170;
            // 
            // Lname
            // 
            Lname.HeaderText = "Lname";
            Lname.MinimumWidth = 6;
            Lname.Name = "Lname";
            Lname.ReadOnly = true;
            Lname.Width = 125;
            // 
            // age
            // 
            age.HeaderText = "Age";
            age.MinimumWidth = 6;
            age.Name = "age";
            age.ReadOnly = true;
            age.Width = 125;
            // 
            // email
            // 
            email.HeaderText = "Email";
            email.MinimumWidth = 6;
            email.Name = "email";
            email.ReadOnly = true;
            email.Width = 200;
            // 
            // password
            // 
            password.HeaderText = "Password";
            password.MinimumWidth = 6;
            password.Name = "password";
            password.ReadOnly = true;
            password.Width = 125;
            // 
            // phone
            // 
            phone.HeaderText = "Phone";
            phone.MinimumWidth = 11;
            phone.Name = "phone";
            phone.ReadOnly = true;
            phone.Width = 125;
            // 
            // address
            // 
            address.HeaderText = "Address";
            address.MinimumWidth = 6;
            address.Name = "address";
            address.ReadOnly = true;
            address.Width = 125;
            // 
            // delete
            // 
            delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            delete.HeaderText = "Delete";
            delete.Image = (Image)resources.GetObject("delete.Image");
            delete.ImageLayout = DataGridViewImageCellLayout.Zoom;
            delete.MinimumWidth = 6;
            delete.Name = "delete";
            delete.ReadOnly = true;
            // 
            // update
            // 
            update.HeaderText = "Update";
            update.Image = (Image)resources.GetObject("update.Image");
            update.ImageLayout = DataGridViewImageCellLayout.Zoom;
            update.MinimumWidth = 6;
            update.Name = "update";
            update.ReadOnly = true;
            update.Width = 125;
            // 
            // StudentsAdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(studentGrid);
            Name = "StudentsAdminForm";
            Size = new Size(1366, 788);
            Load += StudentsAdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)studentGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private DataGridView studentGrid;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Fname;
        private DataGridViewTextBoxColumn Lname;
        private DataGridViewTextBoxColumn age;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn password;
        private DataGridViewTextBoxColumn phone;
        private DataGridViewTextBoxColumn address;
        private DataGridViewImageColumn delete;
        private DataGridViewImageColumn update;
    }
}
