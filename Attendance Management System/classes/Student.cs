using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_Management_System.classes
{
    public class Student : User
    {
    
        public Student(string id, string firstName, string lastName, int age, string email, string password, string phone, string address)
            : base(id, firstName, lastName, age, email, password, phone, address, "student") 
        {
       
        }
        public override string ToString()
        {
            return $"Student - {base.ToString()}";
        }


    }
}
