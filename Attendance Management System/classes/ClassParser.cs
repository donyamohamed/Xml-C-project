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
    }
}
