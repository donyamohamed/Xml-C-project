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
            label1 = new Label();
            textBoxName = new TextBox();
            UserName = new Label();
            pictureBoxHide = new PictureBox();
            pictureBoxShow = new PictureBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            toolTip = new ToolTip(components);
            pictureBoxShowPassWord = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimize).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShowPassWord).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxClose
            // 
            resources.ApplyResources(pictureBoxClose, "pictureBoxClose");
            pictureBoxClose.BorderStyle = BorderStyle.Fixed3D;
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
            pictureBoxMinimize.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxMinimize.Cursor = Cursors.Hand;
            pictureBoxMinimize.Name = "pictureBoxMinimize";
            pictureBoxMinimize.TabStop = false;
            toolTip.SetToolTip(pictureBoxMinimize, resources.GetString("pictureBoxMinimize.ToolTip"));
            pictureBoxMinimize.Click += pictureBoxMinimize_Click;
            pictureBoxMinimize.MouseHover += pictureBoxMinimize_MouseHover;
            // 
            // groupBox1
            // 
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Controls.Add(pictureBoxShowPassWord);
            groupBox1.Controls.Add(textBoxPassword);
            groupBox1.Controls.Add(buttonLogin);
            groupBox1.Controls.Add(buttonClear);
            groupBox1.Controls.Add(labelInvalidUserName);
            groupBox1.Controls.Add(pictureBoxError);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(UserName);
            groupBox1.ForeColor = Color.Blue;
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            toolTip.SetToolTip(groupBox1, resources.GetString("groupBox1.ToolTip"));
            // 
            // textBoxPassword
            // 
            resources.ApplyResources(textBoxPassword, "textBoxPassword");
            textBoxPassword.Name = "textBoxPassword";
            toolTip.SetToolTip(textBoxPassword, resources.GetString("textBoxPassword.ToolTip"));
            textBoxPassword.UseSystemPasswordChar = true;
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
            // labelInvalidUserName
            // 
            resources.ApplyResources(labelInvalidUserName, "labelInvalidUserName");
            labelInvalidUserName.ForeColor = Color.Red;
            labelInvalidUserName.Name = "labelInvalidUserName";
            toolTip.SetToolTip(labelInvalidUserName, resources.GetString("labelInvalidUserName.ToolTip"));
            // 
            // pictureBoxError
            // 
            resources.ApplyResources(pictureBoxError, "pictureBoxError");
            pictureBoxError.Cursor = Cursors.Hand;
            pictureBoxError.Name = "pictureBoxError";
            pictureBoxError.TabStop = false;
            toolTip.SetToolTip(pictureBoxError, resources.GetString("pictureBoxError.ToolTip"));
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = SystemColors.HotTrack;
            label1.Name = "label1";
            toolTip.SetToolTip(label1, resources.GetString("label1.ToolTip"));
            // 
            // textBoxName
            // 
            resources.ApplyResources(textBoxName, "textBoxName");
            textBoxName.Name = "textBoxName";
            toolTip.SetToolTip(textBoxName, resources.GetString("textBoxName.ToolTip"));
            // 
            // UserName
            // 
            resources.ApplyResources(UserName, "UserName");
            UserName.ForeColor = SystemColors.HotTrack;
            UserName.Name = "UserName";
            toolTip.SetToolTip(UserName, resources.GetString("UserName.ToolTip"));
            // 
            // pictureBoxHide
            // 
            resources.ApplyResources(pictureBoxHide, "pictureBoxHide");
            pictureBoxHide.Cursor = Cursors.Hand;
            pictureBoxHide.Name = "pictureBoxHide";
            pictureBoxHide.TabStop = false;
            toolTip.SetToolTip(pictureBoxHide, resources.GetString("pictureBoxHide.ToolTip"));
            pictureBoxHide.Click += pictureBoxHide_Click;
            pictureBoxHide.MouseHover += pictureBoxHide_MouseHover_1;
            // 
            // pictureBoxShow
            // 
            resources.ApplyResources(pictureBoxShow, "pictureBoxShow");
            pictureBoxShow.Cursor = Cursors.Hand;
            pictureBoxShow.Name = "pictureBoxShow";
            pictureBoxShow.TabStop = false;
            toolTip.SetToolTip(pictureBoxShow, resources.GetString("pictureBoxShow.ToolTip"));
            pictureBoxShow.Click += pictureBoxShow_Click;
            pictureBoxShow.MouseHover += pictureBoxHide_MouseHover;
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
            // pictureBoxShowPassWord
            // 
            resources.ApplyResources(pictureBoxShowPassWord, "pictureBoxShowPassWord");
            pictureBoxShowPassWord.Cursor = Cursors.Hand;
            pictureBoxShowPassWord.Name = "pictureBoxShowPassWord";
            pictureBoxShowPassWord.TabStop = false;
            toolTip.SetToolTip(pictureBoxShowPassWord, resources.GetString("pictureBoxShowPassWord.ToolTip"));
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            toolTip.SetToolTip(button1, resources.GetString("button1.ToolTip"));
            button1.UseVisualStyleBackColor = true;
            // 
            // FormLogin
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(pictureBoxMinimize);
            Controls.Add(pictureBoxHide);
            Controls.Add(pictureBoxShow);
            Controls.Add(pictureBoxClose);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin";
            toolTip.SetToolTip(this, resources.GetString("$this.ToolTip"));
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
            ((System.ComponentModel.ISupportInitialize)pictureBoxShowPassWord).EndInit();
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
        private PictureBox pictureBox1;
        private Label label2;
        private ToolTip toolTip;
        private PictureBox pictureBoxShowPassWord;
        private Button button1;
    }
}