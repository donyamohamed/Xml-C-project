namespace Attendance_Management_System.Forms
{
    partial class AdminClasses
    {
        private System.ComponentModel.IContainer components = null;
        private Panel sidebarPanel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            SuspendLayout();

            // SidebarPanel
            sidebarPanel = new Panel
            {
                Dock = DockStyle.Left,
                Width = 150,
                BackColor = Color.Gray
            };

            // Add the sidebarPanel to the form
            Controls.Add(sidebarPanel);

            // Initialize the sidebar items
            InitializeSidebar();

            // AdminClasses
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "AdminClasses";
            Text = "AdminClasses";
            Load += AdminClasses_Load;
            ResumeLayout(false);

            ResumeLayout(false);
        }

        #endregion
    }
}
