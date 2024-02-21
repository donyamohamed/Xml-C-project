using Attendance_Management_System.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_Management_System.classes
{
   public class Course
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
        public Course() { }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, \n Description: {Description}, #sessions: {Numberofsessions}";
        }
        public static Course getCourseByID(string CID)
        {
            Course course = new Course();
            foreach (var cour in Program.courses)
            {
                if (cour.Id == CID)
                {
                    return course;
                }
            }
            return course;
        }
        public static List<Course> getListofCourse(List<string> CIDs)
        {
            List<Course> courses = new List<Course>();
            foreach (var cour in Program.courses)
            {
                foreach (var CID in CIDs)
                {
                    if (CID == cour.Id)
                    {
                        courses.Add(cour);
                    }
                }
            }
            return courses;
        }
    }

}
