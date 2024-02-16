using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_Management_System.classes
{
    public class Class
    {
        public string ClassId { get; set; }
        public string CourseId { get; set; }
        public string TeacherId { get; set; }
        public List<StudentSessions> StudentSessions { get; set; }

        public Class(string classId, string courseId, string teacherId)
        {
            ClassId = classId;
            CourseId = courseId;
            TeacherId = teacherId;
            StudentSessions = new List<StudentSessions>();
        }
    }
}
