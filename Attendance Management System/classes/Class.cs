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

        public Class(string classId, string courseId, string teacherId, List<StudentSessions> SSlist = null)
        {
            ClassId = classId;
            CourseId = courseId;
            TeacherId = teacherId;
            StudentSessions = SSlist;
        }
        Class() { }

        // get class by Class ID
        public static Class getClassByID(string CID)
        {
            Class _class = new Class();
            foreach (var clas in Forms.Program.claSSes)
            {
                if (clas.ClassId == CID)
                {
                    return _class;
                }
            }
            return _class;
        }

        // get list of stdudents IDs by Teacher ID, Course ID
        public static List<string> getStudentsIDbyTID_CID(string TID, string CID)
        {
            List<string> teacherStudents = new List<string>();
            foreach (Class claSS in Forms.Program.claSSes)
            {
                if (claSS.TeacherId == TID && claSS.CourseId == CID)
                {
                    foreach (var SS in claSS.StudentSessions)
                    {
                        teacherStudents.Add(SS.StudentId);
                    }
                }
            }
            return teacherStudents;
        }


    }
    
}
