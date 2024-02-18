using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
/*
namespace Attendance_Management_System.classes
{
    public static class CourseParser
    {
        public static List<Course> ParseCourses(string filePath)
        {
            List<Course> courses = new List<Course>();

            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);

            XmlNodeList courseNodes = doc.SelectNodes("//course");
            foreach (XmlNode node in courseNodes)
            {
                string courseId = node.SelectSingleNode("courseId").InnerText;
                string courseName = node.SelectSingleNode("courseName").InnerText;
                int sessionsNumber = int.Parse(node.SelectSingleNode("sessionsNumber").InnerText);
                string description = node.SelectSingleNode("description").InnerText;

                courses.Add(new Course(courseId, courseName, description, sessionsNumber));
            }

            return courses;
        }
    }
}
*/