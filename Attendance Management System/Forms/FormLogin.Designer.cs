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
            buttonLanguage = new Button();
            buttonSetTimerBackup = new Button();
            textBoxSetTimerBackup = new TextBox();
            pictureBoxSettings = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSettings).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxClose
            // 
            resources.ApplyResources(pictureBoxClose, "pictureBoxClose");
            pictureBoxClose.Cursor = Cursors.Hand;
            pictureBoxClose.Image = Properties.Resources.Delete_Red_X_Button_Transparent;
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
            label2.ForeColor = Color.Purple;
            label2.Name = "label2";
            toolTip.SetToolTip(label2, resources.GetString("label2.ToolTip"));
            // 
            // UserEmail
            // 
            resources.ApplyResources(UserEmail, "UserEmail");
            UserEmail.ForeColor = SystemColors.HotTrack;
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
            label1.ForeColor = SystemColors.HotTrack;
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
            buttonClear.BackColor = Color.Purple;
            buttonClear.ForeColor = Color.White;
            buttonClear.Name = "buttonClear";
            toolTip.SetToolTip(buttonClear, resources.GetString("buttonClear.ToolTip"));
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonLogin
            // 
            resources.ApplyResources(buttonLogin, "buttonLogin");
            buttonLogin.BackColor = Color.Green;
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
            // buttonLanguage
            // 
            resources.ApplyResources(buttonLanguage, "buttonLanguage");
            buttonLanguage.BackColor = Color.Green;
            buttonLanguage.Name = "buttonLanguage";
            toolTip.SetToolTip(buttonLanguage, resources.GetString("buttonLanguage.ToolTip"));
            buttonLanguage.UseVisualStyleBackColor = false;
            buttonLanguage.Click += buttonLanguage_Click;
            // 
            // buttonSetTimerBackup
            // 
            resources.ApplyResources(buttonSetTimerBackup, "buttonSetTimerBackup");
            buttonSetTimerBackup.BackColor = Color.Green;
            buttonSetTimerBackup.Name = "buttonSetTimerBackup";
            toolTip.SetToolTip(buttonSetTimerBackup, resources.GetString("buttonSetTimerBackup.ToolTip"));
            buttonSetTimerBackup.UseVisualStyleBackColor = false;
            buttonSetTimerBackup.Click += buttonSetTimerBackup_Click;
            // 
            // textBoxSetTimerBackup
            // 
            resources.ApplyResources(textBoxSetTimerBackup, "textBoxSetTimerBackup");
            textBoxSetTimerBackup.Name = "textBoxSetTimerBackup";
            toolTip.SetToolTip(textBoxSetTimerBackup, resources.GetString("textBoxSetTimerBackup.ToolTip"));
            // 
            // pictureBoxSettings
            // 
            resources.ApplyResources(pictureBoxSettings, "pictureBoxSettings");
            pictureBoxSettings.Cursor = Cursors.Hand;
            pictureBoxSettings.Image = Properties.Resources.OIP;
            pictureBoxSettings.Name = "pictureBoxSettings";
            pictureBoxSettings.TabStop = false;
            toolTip.SetToolTip(pictureBoxSettings, resources.GetString("pictureBoxSettings.ToolTip"));
            pictureBoxSettings.Click += pictureBoxSettings_Click;
            // 
            // FormLogin
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pictureBoxSettings);
            Controls.Add(textBoxSetTimerBackup);
            Controls.Add(buttonSetTimerBackup);
            Controls.Add(buttonLanguage);
            Controls.Add(pictureBoxError);
            Controls.Add(labelInvalidUserName);
            Controls.Add(pictureBoxHide);
            Controls.Add(pictureBoxShow);
            Controls.Add(buttonLogin);
            Controls.Add(buttonClear);
            Controls.Add(textBoxPassword);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBoxMinimize);
            Controls.Add(pictureBoxClose);
            Controls.Add(UserEmail);
            Controls.Add(label1);
            Controls.Add(textBoxEmail);
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
        private Button buttonLanguage;
        private Button buttonSetTimerBackup;
        private TextBox textBoxSetTimerBackup;
        private PictureBox pictureBoxSettings;
    }
}