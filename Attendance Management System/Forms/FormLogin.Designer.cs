namespace Attendance_Management_System.Forms
{
    partial class FormLogin
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            pictureBoxClose = new PictureBox();
            pictureBoxMinimize = new PictureBox();
            groupBox1 = new GroupBox();
            textBoxPassword = new TextBox();
            buttonLogin = new Button();
            buttonClear = new Button();
            labelInvalidUserName = new Label();
            pictureBoxError = new PictureBox();
            pictureBoxHide = new PictureBox();
            pictureBoxShow = new PictureBox();
            label1 = new Label();
            textBoxName = new TextBox();
            UserName = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            toolTip = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimize).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxClose.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxClose.Cursor = Cursors.Hand;
            pictureBoxClose.Image = Properties.Resources.Delete_Red_X_Button_Transparent;
            pictureBoxClose.Location = new Point(1138, 12);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(50, 50);
            pictureBoxClose.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxClose.TabIndex = 0;
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += pictureBoxClose_Click;
            pictureBoxClose.MouseHover += pictureBoxClose_MouseHover;
            // 
            // pictureBoxMinimize
            // 
            pictureBoxMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxMinimize.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxMinimize.Cursor = Cursors.Hand;
            pictureBoxMinimize.Image = (Image)resources.GetObject("pictureBoxMinimize.Image");
            pictureBoxMinimize.Location = new Point(1073, 12);
            pictureBoxMinimize.Name = "pictureBoxMinimize";
            pictureBoxMinimize.Size = new Size(50, 50);
            pictureBoxMinimize.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMinimize.TabIndex = 1;
            pictureBoxMinimize.TabStop = false;
            pictureBoxMinimize.Click += pictureBoxMinimize_Click;
            pictureBoxMinimize.MouseHover += pictureBoxMinimize_MouseHover;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(textBoxPassword);
            groupBox1.Controls.Add(buttonLogin);
            groupBox1.Controls.Add(buttonClear);
            groupBox1.Controls.Add(labelInvalidUserName);
            groupBox1.Controls.Add(pictureBoxError);
            groupBox1.Controls.Add(pictureBoxHide);
            groupBox1.Controls.Add(pictureBoxShow);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(UserName);
            groupBox1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Blue;
            groupBox1.Location = new Point(100, 200);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(500, 350);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Log in";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(46, 204);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(398, 27);
            textBoxPassword.TabIndex = 2;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.Green;
            buttonLogin.ForeColor = Color.White;
            buttonLogin.Location = new Point(269, 301);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(185, 29);
            buttonLogin.TabIndex = 7;
            buttonLogin.Text = "Log in";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.Purple;
            buttonClear.ForeColor = Color.White;
            buttonClear.Location = new Point(73, 301);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(178, 29);
            buttonClear.TabIndex = 6;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // labelInvalidUserName
            // 
            labelInvalidUserName.AutoSize = true;
            labelInvalidUserName.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelInvalidUserName.ForeColor = Color.Red;
            labelInvalidUserName.Location = new Point(118, 250);
            labelInvalidUserName.Name = "labelInvalidUserName";
            labelInvalidUserName.Size = new Size(152, 21);
            labelInvalidUserName.TabIndex = 5;
            labelInvalidUserName.Text = "Invalid User Name";
            labelInvalidUserName.Visible = false;
            // 
            // pictureBoxError
            // 
            pictureBoxError.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxError.Cursor = Cursors.Hand;
            pictureBoxError.Image = (Image)resources.GetObject("pictureBoxError.Image");
            pictureBoxError.Location = new Point(66, 247);
            pictureBoxError.Name = "pictureBoxError";
            pictureBoxError.Size = new Size(27, 27);
            pictureBoxError.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxError.TabIndex = 4;
            pictureBoxError.TabStop = false;
            pictureBoxError.Visible = false;
            // 
            // pictureBoxHide
            // 
            pictureBoxHide.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxHide.Cursor = Cursors.Hand;
            pictureBoxHide.Image = (Image)resources.GetObject("pictureBoxHide.Image");
            pictureBoxHide.Location = new Point(444, 244);
            pictureBoxHide.Name = "pictureBoxHide";
            pictureBoxHide.Size = new Size(27, 27);
            pictureBoxHide.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxHide.TabIndex = 3;
            pictureBoxHide.TabStop = false;
            pictureBoxHide.Click += pictureBoxHide_Click;
            pictureBoxHide.MouseHover += pictureBoxHide_MouseHover_1;
            // 
            // pictureBoxShow
            // 
            pictureBoxShow.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxShow.Cursor = Cursors.Hand;
            pictureBoxShow.Image = (Image)resources.GetObject("pictureBoxShow.Image");
            pictureBoxShow.Location = new Point(444, 204);
            pictureBoxShow.Name = "pictureBoxShow";
            pictureBoxShow.Size = new Size(27, 27);
            pictureBoxShow.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxShow.TabIndex = 2;
            pictureBoxShow.TabStop = false;
            pictureBoxShow.Visible = false;
            pictureBoxShow.Click += pictureBoxShow_Click;
            pictureBoxShow.MouseHover += pictureBoxHide_MouseHover;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(46, 166);
            label1.Name = "label1";
            label1.Size = new Size(127, 21);
            label1.TabIndex = 0;
            label1.Text = "User Password: ";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(46, 107);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(425, 27);
            textBoxName.TabIndex = 1;
            textBoxName.Text = "Your Name ...";
            // 
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            UserName.ForeColor = SystemColors.HotTrack;
            UserName.Location = new Point(46, 69);
            UserName.Name = "UserName";
            UserName.Size = new Size(103, 21);
            UserName.TabIndex = 0;
            UserName.Text = "User Name: ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Purple;
            panel1.ForeColor = Color.Purple;
            panel1.Location = new Point(674, 166);
            panel1.Name = "panel1";
            panel1.Size = new Size(11, 457);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(781, 200);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(342, 350);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 30F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = Color.Purple;
            label2.Location = new Point(299, 101);
            label2.Name = "label2";
            label2.Size = new Size(678, 50);
            label2.TabIndex = 0;
            label2.Text = "Attendance Management System";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 749);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(pictureBoxMinimize);
            Controls.Add(pictureBoxClose);
            Font = new Font("Century Gothic", 12F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6, 5, 6, 5);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            WindowState = FormWindowState.Maximized;
            Load += FormLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimize).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxError).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHide).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShow).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxClose;
        private PictureBox pictureBoxMinimize;
        private GroupBox groupBox1;
        private Label UserName;
        private TextBox textBoxName;
        private PictureBox pictureBoxShow;
        private TextBox textBoxPassword;
        private Label label1;
        private Label labelInvalidUserName;
        private PictureBox pictureBoxError;
        private PictureBox pictureBoxHide;
        private Button buttonLogin;
        private Button buttonClear;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private ToolTip toolTip;
    }
}