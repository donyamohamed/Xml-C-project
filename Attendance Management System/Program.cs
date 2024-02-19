using Attendance_Management_System.classes;
using System.Xml;
using static Attendance_Management_System.classes.CourseParser;

namespace Attendance_Management_System.Forms
{
    internal static class Program
    {
        public static string usersPath = "../../../../users.xml";
        public static string coursesPath = "../../../../courses.xml";
        public static string claSSesPath = "../../../../class.xml";

        public static List<classes.User> users = UserParser.ParseUsers(usersPath);
        // Accessable from any form by Program.users
        public static List<classes.Course> courses = ParseCourses(coursesPath);
        // Accessable from any form by Program.courses
        public static List<classes.Class> claSSes = ClassParser.ParseClasses(claSSesPath);
        // Accessable from any form by Program.claSSes

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            ApplicationConfiguration.Initialize();
            Application.Run(new FormLogin());


            /*
            Course course1 = new Course("1C", "math", "any text", 5);
            Console.WriteLine(course1.Id);
            Console.WriteLine(course1.Name);
            Console.WriteLine(course1.Description);
            Console.WriteLine(course1.Numberofsessions);
            Console.WriteLine(course1.ToString());
            */



            /*
             * 
             
            // --------------->  just try get data of student :)
             
           
            XmlDocument usersDoc = new XmlDocument();
            usersDoc.Load("../../../../users.xml"); // default->  bin/depug folder

           
            List<Student> students = GetStudents(usersDoc);

           
            foreach (var student in students)
            {
                MessageBox.Show(student.ToString());
            }
            */

            // Try to get data of Coures >_< //
            // XmlDocument courseDoc = new XmlDocument();
            // courseDoc.Load("../../../../courses.xml");

            // List<Course> Courses = ParseCourses("../../../../courses.xml");
            // CourseList Courses = new CourseList();
            // List<Course> courses = GetCourses(courseDoc);
            // Console.WriteLine(Courses.ToString());


            /*
            XmlNodeList nodeList;
            XmlNode root = courseDoc.DocumentElement;

            nodeList = root.SelectNodes("descendant::course");
            */

        }

        /*
        static List<Student> GetStudents(XmlDocument usersDoc)
        {
            List<Student> students = new List<Student>();

            // Select all user nodes --> role attribute --> "student"
            XmlNodeList studentNodes = usersDoc.SelectNodes("//user[@role='student']");
            foreach (XmlNode studentNode in studentNodes)
            {
                //  student information

                string id = studentNode.SelectSingleNode("id").InnerText;
                string firstName = studentNode.SelectSingleNode("fname").InnerText;
                string lastName = studentNode.SelectSingleNode("lname").InnerText;
                int age = Convert.ToInt32(studentNode.SelectSingleNode("age").InnerText);
                string email = studentNode.SelectSingleNode("email").InnerText;
                string password = studentNode.SelectSingleNode("password").InnerText;
                string phone = studentNode.SelectSingleNode("phone").InnerText;
                string address = studentNode.SelectSingleNode("address").InnerText;

                // Create Student object and add to list
                Student student = new Student(id, firstName, lastName, age, email, password, phone, address);
                students.Add(student);
            }

            return students;
        }
        */
        


/*        public static class CourseList
        {
            public static List<Course> Courses { get; private set;}
            
            static CourseList()
            {
                XmlDocument courseDoc = new XmlDocument();
                courseDoc.Load("../../../../courses.xml");

                Courses = new List<Course>();
                XmlNodeList courseNodes = courseDoc.SelectNodes("//course");


                foreach (XmlNode courseNode in courseNodes)
                {
                    string courseId = courseNode.SelectSingleNode("courseId").InnerText;
                    string courseName = courseNode.SelectSingleNode("courseName").InnerText;
                    int sessionsNumber = Convert.ToInt32(courseNode.SelectSingleNode("sessionsNumber").InnerText);
                    string description = courseNode.SelectSingleNode("description").InnerText;

                    Course course = new Course(courseId, courseName, description, sessionsNumber);
                    Courses.Add(course);
                }


            }

        }
*/        
/*        
        static List<Course> GetCourses(XmlDocument courseDoc)
        {
            List<Course> courses = new List<Course>();

            // Select all courses nodes
            XmlNodeList courseNodes = courseDoc.SelectNodes("//course");
            // XmlNodeList studentNodes = usersDoc.SelectNodes("//user[@role='student']");
            // foreach (XmlNode studentNode in studentNodes)
            foreach (XmlNode courseNode in courseNodes)
            {
                //  Course information

                string courseId = courseNode.SelectSingleNode("courseId").InnerText;
                string courseName = courseNode.SelectSingleNode("courseName").InnerText;
                int sessionsNumber = Convert.ToInt32(courseNode.SelectSingleNode("sessionsNumber").InnerText);
                string description = courseNode.SelectSingleNode("description").InnerText;

                // Create Student object and add to list
                //Student student = new Student(id, firstName, lastName, age, email, password, phone, address);
                Course course = new Course(courseId, courseName, description, sessionsNumber);
                courses.Add(course);
                // Course.Add(student);
            }

            return courses;
        }
*/
    }
}