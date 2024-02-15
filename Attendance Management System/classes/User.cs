using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_Management_System.classes
{
    public abstract class User
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public string Role { get; set; }

    
        protected User(string _id, string _firstName, string _lastName, int _age, string _email, string _password, string _phone, string _address, string _role)
        {
            Id = _id;
            FirstName = _firstName;
            LastName = _lastName;
            Age = _age;
            Email = _email;
            Password = _password;
            Phone = _phone;
            Address = _address;
            Role = _role;
        }

       
        public override string ToString()
        {
            return $"ID: {Id}, Name: {FirstName +" "+ LastName}";
        }
    }
}