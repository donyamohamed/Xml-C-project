using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using static Attendance_Management_System.classes.Course;
using static Attendance_Management_System.classes.Class;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Attendance_Management_System.Forms;
using System.Windows.Forms;

namespace Attendance_Management_System.classes
{
    public class Teacher : User
    {

        public Teacher(string id, string firstName, string lastName, int age, string email, string password, string phone, string address)
            : base(id, firstName, lastName, age, email, password, phone, address, "teacher")
        {

        }

        public Teacher() : base() { }



        /*
        IEnumerable<string> teacherCourses = new List<string>();

        teacherCourses = from course in XDocument.Load("../../../../class.xml").Descendants("Classes")
                                             where course.Element("teacherId").Value == TID.ToString()
                                             select course.Element("courseId").Value;
        return teacherCourses.ToString();
        */


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
        public List<string> getCoursesIDbyTeacherID(string TID)
        {
            List<string> teacherCourses = new List<string>();
            /*
            foreach (XElement course in XDocument.Load("../../../../class.xml").Descendants("Classes"))
            {
                if (course.Element("teacherId").Value == TID)
                {
                    teacherCourses.Add(course.Element("courseId").Value);
                    MessageBox.Show(course.Element("courseId").Value);
                }
            }
            */
            foreach (Class claSS in Program.claSSes)
            {
                if (claSS.TeacherId == TID)
                {
                    teacherCourses.Add(claSS.CourseId);
                    MessageBox.Show(claSS.CourseId);
                }
            }
            
            return teacherCourses;
        }
        public List<string> getStudentsIDbyTeacherID(string TID, string CID)
        {
            List<string> teacherStudents = new List<string>();
            foreach (Class claSS in Program.claSSes)
            {
                if (claSS.TeacherId == TID && claSS.CourseId == CID)
                {
                    foreach (StudentSessions StuSess in claSS.StudentSessions)
                    {
                        teacherStudents.Add(StuSess.StudentId);
                        MessageBox.Show(StuSess.StudentId);
                    }
                    // teacherStudents.Add(claSS.StudentId);
                    // MessageBox.Show(claSS.StudentId);
                }
            }

            return teacherStudents;

        }
        public Boolean changeTeacherData(string firstName, string lastName, int age, string email, string password, string phone, string address)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Email = email;
            this.Password = password;
            this.Phone = phone;
            this.Address = address;
            return true;
        }

    }
}