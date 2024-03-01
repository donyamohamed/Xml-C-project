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
            pictureBox1 = new PictureBox();
            label2 = new Label();
            toolTip = new ToolTip(components);
            UserEmail = new Label();
            textBoxEmail = new TextBox();
            label1 = new Label();
            pictureBoxShow = new PictureBox();
            pictureBoxHide = new PictureBox();
            pictureBoxError = new PictureBox();
            labelInvalidUserName = new Label();
            buttonClear = new Button();
            buttonLogin = new Button();
            textBoxPassword = new TextBox();
            pictureBoxSettings = new PictureBox();
            labelOpenDateTime = new Label();
            label3 = new Label();
            labelBackupIn = new Label();
            label5 = new Label();
            buttonLanguage = new Button();
            groupBox1 = new GroupBox();
            timerBackup = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSettings).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxClose
            // 
            resources.ApplyResources(pictureBoxClose, "pictureBoxClose");
            pictureBoxClose.Cursor = Cursors.Hand;
            pictureBoxClose.Image = Properties.Resources.cross_mark2;
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.TabStop = false;
            toolTip.SetToolTip(pictureBoxClose, resources.GetString("pictureBoxClose.ToolTip"));
            pictureBoxClose.Click += pictureBoxClose_Click;
            pictureBoxClose.MouseHover += pictureBoxClose_MouseHover;
            // 
            // pictureBoxMinimize
            // 
            resources.ApplyResources(pictureBoxMinimize, "pictureBoxMinimize");
            pictureBoxMinimize.Cursor = Cursors.Hand;
            pictureBoxMinimize.InitialImage = Properties.Resources.OIP3;
            pictureBoxMinimize.Name = "pictureBoxMinimize";
            pictureBoxMinimize.TabStop = false;
            toolTip.SetToolTip(pictureBoxMinimize, resources.GetString("pictureBoxMinimize.ToolTip"));
            pictureBoxMinimize.Click += pictureBoxMinimize_Click;
            pictureBoxMinimize.MouseHover += pictureBoxMinimize_MouseHover;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            toolTip.SetToolTip(pictureBox1, resources.GetString("pictureBox1.ToolTip"));
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = Color.IndianRed;
            label2.Name = "label2";
            toolTip.SetToolTip(label2, resources.GetString("label2.ToolTip"));
            // 
            // UserEmail
            // 
            resources.ApplyResources(UserEmail, "UserEmail");
            UserEmail.ForeColor = Color.IndianRed;
            UserEmail.Name = "UserEmail";
            toolTip.SetToolTip(UserEmail, resources.GetString("UserEmail.ToolTip"));
            // 
            // textBoxEmail
            // 
            resources.ApplyResources(textBoxEmail, "textBoxEmail");
            textBoxEmail.Name = "textBoxEmail";
            toolTip.SetToolTip(textBoxEmail, resources.GetString("textBoxEmail.ToolTip"));
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.IndianRed;
            label1.Name = "label1";
            toolTip.SetToolTip(label1, resources.GetString("label1.ToolTip"));
            // 
            // pictureBoxShow
            // 
            resources.ApplyResources(pictureBoxShow, "pictureBoxShow");
            pictureBoxShow.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxShow.Cursor = Cursors.Hand;
            pictureBoxShow.Name = "pictureBoxShow";
            pictureBoxShow.TabStop = false;
            toolTip.SetToolTip(pictureBoxShow, resources.GetString("pictureBoxShow.ToolTip"));
            pictureBoxShow.Click += pictureBoxShow_Click;
            pictureBoxShow.MouseHover += pictureBoxHide_MouseHover;
            // 
            // pictureBoxHide
            // 
            resources.ApplyResources(pictureBoxHide, "pictureBoxHide");
            pictureBoxHide.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxHide.Cursor = Cursors.Hand;
            pictureBoxHide.Name = "pictureBoxHide";
            pictureBoxHide.TabStop = false;
            toolTip.SetToolTip(pictureBoxHide, resources.GetString("pictureBoxHide.ToolTip"));
            pictureBoxHide.Click += pictureBoxHide_Click;
            pictureBoxHide.MouseHover += pictureBoxHide_MouseHover_1;
            // 
            // pictureBoxError
            // 
            resources.ApplyResources(pictureBoxError, "pictureBoxError");
            pictureBoxError.Cursor = Cursors.Hand;
            pictureBoxError.Name = "pictureBoxError";
            pictureBoxError.TabStop = false;
            toolTip.SetToolTip(pictureBoxError, resources.GetString("pictureBoxError.ToolTip"));
            // 
            // labelInvalidUserName
            // 
            resources.ApplyResources(labelInvalidUserName, "labelInvalidUserName");
            labelInvalidUserName.ForeColor = Color.Red;
            labelInvalidUserName.Name = "labelInvalidUserName";
            toolTip.SetToolTip(labelInvalidUserName, resources.GetString("labelInvalidUserName.ToolTip"));
            // 
            // buttonClear
            // 
            resources.ApplyResources(buttonClear, "buttonClear");
            buttonClear.BackColor = Color.IndianRed;
            buttonClear.ForeColor = Color.White;
            buttonClear.Name = "buttonClear";
            toolTip.SetToolTip(buttonClear, resources.GetString("buttonClear.ToolTip"));
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonLogin
            // 
            resources.ApplyResources(buttonLogin, "buttonLogin");
            buttonLogin.BackColor = Color.LightSlateGray;
            buttonLogin.ForeColor = Color.White;
            buttonLogin.Name = "buttonLogin";
            toolTip.SetToolTip(buttonLogin, resources.GetString("buttonLogin.ToolTip"));
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // textBoxPassword
            // 
            resources.ApplyResources(textBoxPassword, "textBoxPassword");
            textBoxPassword.Name = "textBoxPassword";
            toolTip.SetToolTip(textBoxPassword, resources.GetString("textBoxPassword.ToolTip"));
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // pictureBoxSettings
            // 
            resources.ApplyResources(pictureBoxSettings, "pictureBoxSettings");
            pictureBoxSettings.Cursor = Cursors.Hand;
            pictureBoxSettings.Image = Properties.Resources.OIP2;
            pictureBoxSettings.Name = "pictureBoxSettings";
            pictureBoxSettings.TabStop = false;
            toolTip.SetToolTip(pictureBoxSettings, resources.GetString("pictureBoxSettings.ToolTip"));
            pictureBoxSettings.Click += pictureBoxSettings_Click;
            // 
            // labelOpenDateTime
            // 
            resources.ApplyResources(labelOpenDateTime, "labelOpenDateTime");
            labelOpenDateTime.ForeColor = Color.Black;
            labelOpenDateTime.Name = "labelOpenDateTime";
            toolTip.SetToolTip(labelOpenDateTime, resources.GetString("labelOpenDateTime.ToolTip"));
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.ForeColor = Color.IndianRed;
            label3.Name = "label3";
            toolTip.SetToolTip(label3, resources.GetString("label3.ToolTip"));
            // 
            // labelBackupIn
            // 
            resources.ApplyResources(labelBackupIn, "labelBackupIn");
            labelBackupIn.ForeColor = Color.Black;
            labelBackupIn.Name = "labelBackupIn";
            toolTip.SetToolTip(labelBackupIn, resources.GetString("labelBackupIn.ToolTip"));
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.ForeColor = Color.IndianRed;
            label5.Name = "label5";
            toolTip.SetToolTip(label5, resources.GetString("label5.ToolTip"));
            // 
            // buttonLanguage
            // 
            resources.ApplyResources(buttonLanguage, "buttonLanguage");
            buttonLanguage.BackColor = Color.IndianRed;
            buttonLanguage.ForeColor = Color.White;
            buttonLanguage.Name = "buttonLanguage";
            toolTip.SetToolTip(buttonLanguage, resources.GetString("buttonLanguage.ToolTip"));
            buttonLanguage.UseVisualStyleBackColor = false;
            buttonLanguage.Click += buttonLanguage_Click_1;
            // 
            // groupBox1
            // 
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Controls.Add(pictureBoxShow);
            groupBox1.Controls.Add(pictureBoxHide);
            groupBox1.Controls.Add(UserEmail);
            groupBox1.Controls.Add(textBoxEmail);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxPassword);
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            toolTip.SetToolTip(groupBox1, resources.GetString("groupBox1.ToolTip"));
            // 
            // timerBackup
            // 
            timerBackup.Tick += timerBackup_Tick;
            // 
            // FormLogin
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(groupBox1);
            Controls.Add(buttonLanguage);
            Controls.Add(labelBackupIn);
            Controls.Add(label5);
            Controls.Add(labelOpenDateTime);
            Controls.Add(label3);
            Controls.Add(pictureBoxSettings);
            Controls.Add(pictureBoxError);
            Controls.Add(labelInvalidUserName);
            Controls.Add(buttonLogin);
            Controls.Add(buttonClear);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBoxMinimize);
            Controls.Add(pictureBoxClose);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin";
            toolTip.SetToolTip(this, resources.GetString("$this.ToolTip"));
            WindowState = FormWindowState.Maximized;
            Load += FormLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShow).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHide).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxError).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSettings).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxClose;
        private PictureBox pictureBoxMinimize;
        private PictureBox pictureBox1;
        private Label label2;
        private ToolTip toolTip;
        private Label UserEmail;
        private TextBox textBoxEmail;
        private Label label1;
        private PictureBox pictureBoxShow;
        private PictureBox pictureBoxHide;
        private PictureBox pictureBoxError;
        private Label labelInvalidUserName;
        private Button buttonClear;
        private Button buttonLogin;
        private TextBox textBoxPassword;
        private PictureBox pictureBoxSettings;
        private Label labelOpenDateTime;
        private Label label3;
        private Label labelBackupIn;
        private Label label5;
        public System.Windows.Forms.Timer timerBackup;
        private Button buttonLanguage;
        private GroupBox groupBox1;
    }
}