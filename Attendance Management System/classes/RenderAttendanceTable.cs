using Attendance_Management_System.classes;
using Attendance_Management_System.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Attendance_Management_System.classes.Student;

namespace Attendance_Management_System.classes
{
    internal class RenderAttendanceTable
    {
        public static DataTable RenderAttTable (string Date, List<StudentSessions> myStduentsSessions)
        {
            DataTable dataTable = new DataTable();
            // dataTable.Columns.Add(Date, typeof(string));
            dataTable.Columns.Add("StudentId", typeof(string));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Status", typeof(string));
            foreach (var student in myStduentsSessions)
            {
                // add the student status to the table
                // add rows of the student ids and their status
                DataRow row = dataTable.NewRow();
                row["StudentId"] = student.StudentId;
                foreach (var session in student.Sessions)
                {
                    if (session.Date == DateTime.Parse(Date))
                    {
                        Student std = getStudentByStudentID(student.StudentId, Program.users);
                        string fullName = std.FirstName + " " + std.LastName;
                        row["Name"] = fullName;
                        row["Status"] = session.Status;
                    }
                }
                dataTable.Rows.Add(row);
            }
            return dataTable;



                /*
                DataRow row = dataTable.NewRow();
                row[Date] = student.StudentId;
                dataTable.Rows.Add(row);
                }
            return dataTable;
                */

        }
    }
}
