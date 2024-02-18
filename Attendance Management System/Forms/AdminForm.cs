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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }
        private void password_TextChanged(object sender, EventArgs e)
        {

        }
        private void Teachers_Data_Click(object sender, EventArgs e)
        {
            TeacherAdminForm teacherAdminForm = new TeacherAdminForm();
            teacherAdminForm.Show();
            Hide();

        }

        private void Students_Data_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Display All Students button clicked.", "Admin Action", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Courses_Data_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Display All Courses button clicked.", "Admin Action", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Classes_Data_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Display All Classes button clicked.", "Admin Action", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}
