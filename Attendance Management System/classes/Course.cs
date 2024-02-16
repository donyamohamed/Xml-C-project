using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_Management_System.classes
{
    internal class Course
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Numberofsessions { get; set; }


        public Course(string _id, string _Name, string _Description, int _Numberofsessions)
        {
            Id = _id;
            Name = _Name;
            Description = _Description;
            Numberofsessions = _Numberofsessions;

        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, \n Description: {Description}, #sessions: {Numberofsessions}";
        }

    }

}
