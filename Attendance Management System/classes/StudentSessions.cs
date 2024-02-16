using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Attendance_Management_System.classes
{
    public class StudentSessions
    {
        public string StudentId { get; set; }
        public List<Session> Sessions { get; set; }

        public StudentSessions(string studentId)
        {
            StudentId = studentId;
            Sessions = new List<Session>();
        }
    }
}
