using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Attendance_Management_System.classes
{
    public static class ClassParser
    {
        public static List<Class> ParseClasses(string filePath)
        {
            List<Class> classes = new List<Class>();

            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);

            XmlNodeList classNodes = doc.SelectNodes("//class");
            foreach (XmlNode node in classNodes)
            {
                string classId = node.SelectSingleNode("classId").InnerText;
                string courseId = node.SelectSingleNode("courseId").InnerText;
                string teacherId = node.SelectSingleNode("teacherId").InnerText;

                classes.Add(new Class(classId, courseId, teacherId));
            }

            return classes;
        }
    }
}
