using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

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
        public static void SaveCoursesAsXml(List<Course> courses, string filePath)
        {
            XmlDocument doc = new XmlDocument();

            // Create the XML Declaration, and append it to XML document
            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(xmlDeclaration);

            XmlElement root = doc.CreateElement("Courses");
            // set attributes
            root.SetAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            XmlAttribute att = doc.CreateAttribute("xsi", "noNamespaceSchemaLocation", "http://www.w3.org/2001/XMLSchema-instance");
            att.Value = filePath;
            root.Attributes.Append(att);

            // foearch course in the list
            foreach (Course course in courses)
            {
                XmlElement courseElement = doc.CreateElement("course");

                XmlElement courseId = doc.CreateElement("courseId");
                courseId.InnerText = course.Id;
                courseElement.AppendChild(courseId);

                XmlElement courseName = doc.CreateElement("courseName");
                courseName.InnerText = course.Name;
                courseElement.AppendChild(courseName);

                XmlElement sessionsNumber = doc.CreateElement("sessionsNumber");
                sessionsNumber.InnerText = course.Numberofsessions.ToString();
                courseElement.AppendChild(sessionsNumber);

                XmlElement description = doc.CreateElement("description");
                description.InnerText = course.Description;
                courseElement.AppendChild(description);

                root.AppendChild(courseElement);
            }
            doc.AppendChild(root);
            doc.Save(filePath);
        }
    }
}
/*
<?xml version="1.0" encoding="UTF-8"?>
<appConfigurations>
<appConfiguration>
<name>Attendance Management System</name>
<version>1.0</version>
<description>Attendance Management System Description</description>
<dataPathes>
    <Users>data/Users.xml</Users>
    <Courses>data/Courses.xml</Courses>
    <Sessions>data/Sessions.xml</Sessions>
</dataPathes>
<authors>
    <author>Author 1</author>
    <author>Author 2</author>
    <author>Author 3</author>
</authors>
<createdDate>2021-06-01</createdDate>
<appSettings>
    <!-- updateInterval in minutes -->
    <updateInterval>5</updateInterval>
    <language>English</language>
    <language>Arabic</language>s
    <DateFormat>dd-MM-yyyy</DateFormat>
    <DateFormat>MM-dd-yyyy</DateFormat>
    <DateFormat>yyyy-MM-dd</DateFormat>
</appSettings>
</appConfiguration>
</appConfigurations>
*/

