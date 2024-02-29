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
using static System.Collections.Specialized.BitVector32;

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
        /// <summary>
        /// Get a list of dates for the course or courses 
        /// if two courses have the same date, it will be added only once
        /// </summary>
        /// <param name="myCIDs"></param>
        /// <returns></returns>
        public static List<DateTime> getCDatesbyCIds(List<string> myCIDs)
        {
            List<DateTime> dates = new List<DateTime>();
            List<Session> sessions = new List<Session>();
            sessions = getListofSessions(myCIDs);
            
            foreach (Session sess in sessions)
            {
                if(!dates.Contains(sess.Date))
                {
                    dates.Add(sess.Date);
                }
            }
            return dates;

            /*
            foreach (string courseID in myCIDs)
            {
                List<string> cousres = new List<string>();
                cousres.Add(courseID);
                List<Session> sessions = Session.getSObjByCID(cousres);
                foreach (Session session in sessions)
                {
                    // Convert the DateTime to DateOnly
                    // session.Date - sessin.dateonly
                    if (!dates.Contains))
                    {
                        dates.Add(DateOnly.Parse(session.Date.ToString()));
                    }
                }
            }*/
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
       
        public static List<StudentSessions> getListofmyStudentSessions(string TID, List<string> CIDs)
        {
            List<StudentSessions> studentSessions = new List<StudentSessions>();
            foreach (string CID in CIDs)
            {
                foreach (Class claSS in Program.claSSes)
                {
                    if (claSS.CourseId == CID && claSS.TeacherId == TID)
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