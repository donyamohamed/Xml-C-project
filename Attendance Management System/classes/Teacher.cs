using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using static Attendance_Management_System.classes.Course;
using static Attendance_Management_System.classes.Class;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Attendance_Management_System.Forms;
using System.Windows.Forms;

namespace Attendance_Management_System.classes
{
    public class Teacher : User
    {

        public Teacher(string id, string firstName, string lastName, int age, string email, string password, string phone, string address)
            : base(id, firstName, lastName, age, email, password, phone, address, "teacher")
        {

        }

        public Teacher() : base() { }

        public override string ToString()
        {
            return $"Teacher - {base.ToString()}";
        }

        public static Teacher getTeacherByTeacherID(string TID)
        {
            Teacher teacher = new Teacher();
            foreach (Teacher teach in Program.users)
            {
                if (teach.Id == TID)
                {
                    teacher = teach;
                }
            }
            return teacher;
        }
        public static List<string> getCoursesIDbyTeacherID(string TID)
        {
            List<string> teacherCourses = new List<string>();
            foreach (Class claSS in Program.claSSes)
            {
                if (claSS.TeacherId == TID)
                {
                    teacherCourses.Add(claSS.CourseId);
                    // MessageBox.Show(claSS.CourseId);
                }
            }
            
            return teacherCourses;
        }
        public List<string> getStudentsIDbyTeacherID(string TID, string CID)
        {
            List<string> teacherStudents = new List<string>();
            foreach (Class claSS in Program.claSSes)
            {
                if (claSS.TeacherId == TID && claSS.CourseId == CID)
                {
                    foreach (StudentSessions StuSess in claSS.StudentSessions)
                    {
                        teacherStudents.Add(StuSess.StudentId);
                        MessageBox.Show(StuSess.StudentId);
                    }
                    // teacherStudents.Add(claSS.StudentId);
                    // MessageBox.Show(claSS.StudentId);
                }
            }

            return teacherStudents;

        }
        public Boolean changeTeacherData(string firstName, string lastName, int age, string email, string password, string phone, string address)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Email = email;
            this.Password = password;
            this.Phone = phone;
            this.Address = address;
            return true;
        }

        public static List<Session> getListofSessions(List<string> CIDs)
        {
            List<Session> sessions = new List<Session>();
            foreach (string CID in CIDs)
            {
                foreach (Class claSS in Program.claSSes)
                {
                    if (claSS.CourseId == CID)
                    {
                        foreach (StudentSessions SS in claSS.StudentSessions)
                        {
                            foreach (Session S in SS.Sessions)
                            {
                                sessions.Add(S);
                            }
                        }
                    }
                }
            }
            return sessions;
        }
        public class Student_Status
        {
            public string studentID { get; set; }
            public int status { get; set; }
        }

        // get list student, status in specific course and specific date
        
        public static List<Student_Status> getListofStudentStatus (string CIDs, DateTime date)
        {
            List<Student_Status> stdst = new List<Student_Status>();
            foreach (Class claSS in Program.claSSes)
            {
                if (claSS.CourseId == CIDs)
                {
                    foreach (StudentSessions SS in claSS.StudentSessions)
                    {
                        foreach (Session S in SS.Sessions)
                        {
                            if (S.Date == date)
                            {
                                Student_Status std = new Student_Status();
                                std.studentID = SS.StudentId;
                                std.status = S.Status;
                                stdst.Add(std);
                            }
                        }
                    }
                }
            }
            return stdst;
        }
       
        public static List<StudentSessions> getListofStudentSessions(List<string> CIDs)
        {
            List<StudentSessions> studentSessions = new List<StudentSessions>();
            foreach (string CID in CIDs)
            {
                foreach (Class claSS in Program.claSSes)
                {
                    if (claSS.CourseId == CID)
                    {
                        foreach (StudentSessions SS in claSS.StudentSessions)
                        {
                            studentSessions.Add(SS);
                        }
                    }
                }
            }
            return studentSessions;
        }

        public static void changeStudentAttendance(string TID, string CID, string SID, DateTime date, int status)
        {
            foreach (Class claSS in Program.claSSes)
            {
                if (claSS.TeacherId == TID && claSS.CourseId == CID)
                {
                    foreach (StudentSessions SS in claSS.StudentSessions)
                    {
                        if (SS.StudentId == SID)
                        {
                            foreach (Session S in SS.Sessions)
                            {
                                if(S.Date == date)
                                {
                                    S.Status = status;
                                    MessageBox.Show(TID + " " + CID + " " + SID + " " + date + " " + status);
                                    // break;
                                }
                            }
                        }
                    }
                }
            }
        }

    }
}