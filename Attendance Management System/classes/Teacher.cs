using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_Management_System.classes
{
    public class Teacher : User
    {
       
        public Teacher(string id, string firstName, string lastName, int age, string email, string password, string phone, string address)
            : base(id, firstName, lastName, age, email, password, phone, address, "teacher") 
        {
          
        }
        public override string ToString()
        {
            return $"Teacher - {base.ToString()}";
        }
    }
}
