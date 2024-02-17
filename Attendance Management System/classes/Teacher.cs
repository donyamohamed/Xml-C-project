using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using static Attendance_Management_System.classes.Course;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Attendance_Management_System.classes
{
    public class Teacher : User
    {
       
        public Teacher(string id, string firstName, string lastName, int age, string email, string password, string phone, string address)
            : base(id, firstName, lastName, age, email, password, phone, address, "teacher") 
        {
            Console.WriteLine(getCoursesIDbyTeacherID("2T").ToString());
        }

        public string getCoursesIDbyTeacherID(string TID)
        {
            IEnumerable<string> teacherCourses = new List<string>();

            teacherCourses = from course in XDocument.Load("../../../../class.xml").Descendants("Classes")
                                                 where course.Element("teacherId").Value == TID.ToString()
                                                 select course.Element("courseId").Value;
            return teacherCourses.ToString();
        }

        /*
        public List<Course> getTeacherCoursesById(string TId)
        {
            IEnumerable<Course> teacherCourses = from courseId in XDocument.Load("../../../../class.xml").Descendants("Classes")
                                                 where courseId.Element("teacherId").Value == TId.ToString()
                                                 select new Course
                                                 {
                                                     Id = courseId.Element("id").Value,
                                                     Name = courseId.Element("name").Value,
                                                     Description = courseId.Element("description").Value,
                                                     Numberofsessions = int.Parse(courseId.Element("numberofsessions").Value)
                                                 };
            return teacherCourses.ToList();
        }
        */

        // returns a list of courses that the teacher is teaching
        // this method will be called from the teacher's dashboard
        // the teacher's id will be passed as a parameter (TId)
        /*
         * There is no teacher ID in the XML file of Courses -_-
        public List<Course> getTeacherCoursesById(string TId)
        {
            IEnumerable<Course> teacherCourses = from course in XDocument.Load("../../../../courses.xml").Descendants("course")
                                                 where course.Element("teacherId").Value == TId.ToString()
                                                 select new Course
                                                 {
                                                     Id = course.Element("id").Value,
                                                     Name = course.Element("name").Value,
                                                     Description = course.Element("description").Value,
                                                     Numberofsessions = int.Parse(course.Element("numberofsessions").Value)
                                                 };
            return teacherCourses.ToList();
        }
        */

        

        public override string ToString()
        {
            return $"Teacher - {base.ToString()}";
        }
    }
}
