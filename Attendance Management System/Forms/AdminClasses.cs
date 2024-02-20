using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_Management_System.Forms
{
    public partial class AdminClasses : Form
    {
        public AdminClasses()
        {
            InitializeComponent();
            InitializeSidebar();
        }

            private void InitializeSidebar()
            {
                // Add icons and titles to the sidebar
               // AddSidebarItem(Properties.Resources.Icon1, "Section 1");
                //AddSidebarItem(Properties.Resources.Icon2, "Section 2");
                //AddSidebarItem(Properties.Resources.Icon3, "Section 3");
                // Add more items as needed
            }

            private void AddSidebarItem(Image icon, string title)
            {
                // Create a Panel for each item
                Panel itemPanel = new Panel
                {
                    Size = new Size(sidebarPanel.Width, 60),
                    Dock = DockStyle.Top,
                    Cursor = Cursors.Hand
                };

                // Create a PictureBox for the icon
                PictureBox iconPictureBox = new PictureBox
                {
                    Image = icon,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Size = new Size(40, 40),
                    Location = new Point(10, (itemPanel.Height - 40) / 2)
                };

                // Create a Label for the title
                Label titleLabel = new Label
                {
                    Text = title,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    Location = new Point(iconPictureBox.Right + 10, (itemPanel.Height - 20) / 2),
                    AutoSize = true
                };

                // Add controls to the itemPanel
                itemPanel.Controls.Add(iconPictureBox);
                itemPanel.Controls.Add(titleLabel);

                // Add a Click event handler for the item
                itemPanel.Click += (sender, e) =>
                {
                    // Handle the click event for the sidebar item
                    // You can navigate to the corresponding section or perform any other action
                    MessageBox.Show("Clicked: " + title);
                };

                // Add the itemPanel to the sidebarPanel
                sidebarPanel.Controls.Add(itemPanel);
            }
            private void AdminClasses_Load(object sender, EventArgs e)
        {

        }
    }
}
