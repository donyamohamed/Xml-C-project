using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Attendance_Management_System.classes;
using static Attendance_Management_System.classes.Course;


namespace Attendance_Management_System.classes
{
    public class Session
    {
        public DateTime Date { get; set; }
        public int Status { get; set; }

        public Session(DateTime date, int status)
        {
            Date = date;
            Status = status;
        }


        /// <summary>
        /// Get all sessions for a list of courses IDs
        /// returns a list of sessions
        /// </summary>
        /// <param name="courseID"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        /*internal static List<StudentSessions> getSObjByCID(List<string> CIDs)
        {
            List<Session> sessions = new List<Session>();
            List<Class> classes = new List<Class>();
            foreach (string CID in CIDs)
            {
                foreach (Class clas in Forms.Program.claSSes)
                {
                    if (clas.CourseId == CID)
                    {
                        if(!classes.Contains(clas))
                        {
                            classes.Add(clas);
                        }
                    }

                }
            }
            foreach (Class clas in classes)
            {
                foreach (StudentSessions sess in clas.StudentSessions)
                {
                    if()
                }
            }


            Course thisCourse = getCObjByCID(courseID);
            foreach (Course course in Course.getCObjByCID(courseID))
            {
                sessions.AddRange(course.Sessions);
            }

            return sessions;
        }
        */
    }
    
}
