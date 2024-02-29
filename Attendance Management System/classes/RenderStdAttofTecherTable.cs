using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_Management_System.classes
{
    public static class RenderStduentAttendanceofTecherTable
    {
        public static DataTable RenderStdAttofTecherTable(List<Session> mySessionsObj, List<StudentSessions> myStdSessionsObj)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Stduent ID / Session Date", typeof(string));

            foreach (Session session in mySessionsObj)
            {
                string columnName = session.Date.ToString();

                // Check if the column already exists
                if (!dataTable.Columns.Contains(columnName))
                {
                    dataTable.Columns.Add(columnName, typeof(string));
                }
            }

            foreach (StudentSessions SS in myStdSessionsObj)
            {
                DataRow row = dataTable.NewRow();
                // make this row red 


                row["Stduent ID / Session Date"] = SS.StudentId;

                foreach (Session session in mySessionsObj)
                {
                    var matchingSession = SS.Sessions.FirstOrDefault(s => s.Date == session.Date);

                    if (matchingSession != null)
                    {
                        row[session.Date.ToString()] = matchingSession.Status == 1 ? "Attend" : "Absent";
                    }
                    else
                    {
                        // Handle the case where a matching session is not found
                        row[session.Date.ToString()] = "N/A";
                    }
                }

                dataTable.Rows.Add(row);
            }
            return dataTable;
        }

    }
}
