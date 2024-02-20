using Attendance_Management_System.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_Management_System.classes
{
    public class Admin : User
    {
       
        public Admin(string id, string firstName, string lastName, int age, string email, string password, string phone, string address)
            : base(id, firstName, lastName, age, email, password, phone, address, "admin") 
        {
          
        }
        public Admin() : base() { }
        public override string ToString()
        {
            return $"Admin - {base.ToString()}";
        }
       /* public void DisplayAdminForm()
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
        }*/
    }
}