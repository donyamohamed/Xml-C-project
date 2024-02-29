using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Xsl;
using System.Xml;

namespace Attendance_Management_System.classes
{
    public static class XsltGenerator
    {
        public static string GenerateXSLTTemplateForStudent(string userName, string userId, string selectedCourseName, bool includeCourseFilter, List<(string date, string courseName, string teacherName, int sessionNumber, string status)> sessionData)
        {
            StringBuilder xsltBuilder = new StringBuilder();

            xsltBuilder.Append("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
            xsltBuilder.Append("<xsl:stylesheet version=\"1.0\" xmlns:xsl=\"http://www.w3.org/1999/XSL/Transform\">");

            xsltBuilder.Append($"<xsl:param name=\"userName\" select=\"'{userName}'\" />");
            xsltBuilder.Append($"<xsl:param name=\"userId\" select=\"'{userId}'\" />");
            xsltBuilder.Append($"<xsl:param name=\"selectedCourseName\" select=\"'{selectedCourseName}'\" />");

            xsltBuilder.Append("<xsl:template match=\"/\">");
            xsltBuilder.Append("<html>");
            xsltBuilder.Append("<head>");
            xsltBuilder.Append("<title>Attendance Report</title>");
            xsltBuilder.Append("<link rel=\"stylesheet\" type=\"text/css\" href=\"styles.css\"/>");
            xsltBuilder.Append("</head>");
            xsltBuilder.Append("<body>");
            xsltBuilder.Append("<h1>Attendance Report</h1>");
            xsltBuilder.Append("<p>Student Name: <xsl:value-of select=\"$userName\"/></p>");
            xsltBuilder.Append("<p>Student ID: <xsl:value-of select=\"$userId\"/></p>");

            // -> selectedCourseName is not empty
            if (!string.IsNullOrEmpty(selectedCourseName))
            {
                xsltBuilder.Append("<p>Course Name: <xsl:value-of select=\"$selectedCourseName\"/></p>");
            }

            if (includeCourseFilter)
            {
                xsltBuilder.Append("<table>");
                xsltBuilder.Append("<tr><th>Date</th><th>Course Name</th><th>Teacher Name</th><th>Session Number</th><th>Status</th></tr>");
                foreach (var session in sessionData)
                {
                    if (string.IsNullOrEmpty(selectedCourseName) || session.courseName == selectedCourseName)
                    {
                        xsltBuilder.Append($"<tr><td>{session.date}</td><td>{session.courseName}</td><td>{session.teacherName}</td><td>{session.sessionNumber}</td><td>{GetAttendanceStatusString(session.status)}</td></tr>");
                    }
                }
                xsltBuilder.Append("</table>");
            }
            else
            {
                xsltBuilder.Append("<p>All Sessions:</p>");
                xsltBuilder.Append("<ul>");



                foreach (var session in sessionData)
                {
                    if (string.IsNullOrEmpty(selectedCourseName) || session.courseName == selectedCourseName)
                    {
                        xsltBuilder.Append($"<li>Date: {session.date}, Course Name: {session.courseName}, Teacher Name: {session.teacherName}, Session Number: {session.sessionNumber}, Status: {GetAttendanceStatusString(session.status)}</li>");
                    }
                }
                xsltBuilder.Append("</ul>");
            }

         

            xsltBuilder.Append("</body></html>");
            xsltBuilder.Append("</xsl:template>");

            xsltBuilder.Append("</xsl:stylesheet>");

            return xsltBuilder.ToString();
        }

        private static string GetAttendanceStatusString(string status)
        {
            switch (status)
            {
                case "-1":
                    return "Absent";
                case "0":
                    return "Pending";
                case "1":
                    return "Attend";
                default:
                    return status;
            }
        }
    }
}

