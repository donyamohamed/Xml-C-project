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
            foreach (XmlNode classNode in classNodes)
            {
                string classId = classNode.SelectSingleNode("classId").InnerText;
                string courseId = classNode.SelectSingleNode("courseId").InnerText;
                string teacherId = classNode.SelectSingleNode("teacherId").InnerText;
                List<StudentSessions> SSlist = new List<StudentSessions>();
                XmlNodeList studentNodes = classNode.SelectNodes("studentId");
                foreach (XmlNode studentNode in studentNodes)
                {
                    List<Session> sessions = new List<Session>();
                    XmlNodeList sessionNodes = studentNode.SelectNodes("session");
                    foreach (XmlNode sessionNode in sessionNodes)
                    {
                        Session session = new Session(
                            DateTime.Parse(sessionNode.SelectSingleNode("date").InnerText),
                            int.Parse(sessionNode.SelectSingleNode("status").InnerText)
                        );
                        sessions.Add(session);
                    }
                    SSlist.Add(new StudentSessions(studentNode.Attributes["id"].Value, sessions));
                }
                classes.Add(new Class(classId, courseId, teacherId, SSlist));
            }

            return classes;
        }
        public static void SaveClassesAsXml(List<Class> classes, string filePath)
        {

            XmlDocument doc = new XmlDocument();

            // Create the XML Declaration, and append it to XML document
            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(xmlDeclaration);


            XmlElement root = doc.CreateElement("Classes");
            // set attributes
            root.SetAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            XmlAttribute att = doc.CreateAttribute("xsi", "noNamespaceSchemaLocation","http://www.w3.org/2001/XMLSchema-instance");
            att.Value = filePath;
            root.SetAttributeNode(att);


            foreach (Class claSS in classes)
            {
                XmlElement classNode = doc.CreateElement("class");
                // root.AppendChild(classNode);

                XmlElement classIdNode = doc.CreateElement("classId");
                classIdNode.InnerText = claSS.ClassId;
                classNode.AppendChild(classIdNode);

                XmlElement courseIdNode = doc.CreateElement("courseId");
                courseIdNode.InnerText = claSS.CourseId;
                classNode.AppendChild(courseIdNode);

                XmlElement teacherIdNode = doc.CreateElement("teacherId");
                teacherIdNode.InnerText = claSS.TeacherId;
                classNode.AppendChild(teacherIdNode);

                foreach (StudentSessions SS in claSS.StudentSessions)
                {
                    XmlElement studentNode = doc.CreateElement("studentId");
                    studentNode.SetAttribute("id", SS.StudentId);
                    // classNode.AppendChild(studentNode);

                    foreach (Session session in SS.Sessions)
                    {
                        XmlElement sessionNode = doc.CreateElement("session");
                        // studentNode.AppendChild(sessionNode);

                        XmlElement dateNode = doc.CreateElement("date");
                        dateNode.InnerText = session.Date.Year + "-" + session.Date.Month.ToString("D2") + "-" + session.Date.Day.ToString("D2");
                        sessionNode.AppendChild(dateNode);
                        XmlElement statusNode = doc.CreateElement("status");
                        statusNode.InnerText = session.Status.ToString();
                        sessionNode.AppendChild(statusNode);

                        studentNode.AppendChild(sessionNode);
                    }
                    classNode.AppendChild(studentNode);
                }
                root.AppendChild(classNode);
            }
            doc.AppendChild(root);
            doc.Save(filePath);
        }
      


    }
}
