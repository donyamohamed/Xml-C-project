using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_Management_System.classes
{
    public class Course
    {
        public string CourseId { get; set; }
        public string CourseName { get; set; }
        public int SessionsNumber { get; set; }
        public string Description { get; set; }

        public Course(string courseId, string courseName, int sessionsNumber, string description)
        {
            CourseId = courseId;
            CourseName = courseName;
            SessionsNumber = sessionsNumber;
            Description = description;
        }
    }
}
