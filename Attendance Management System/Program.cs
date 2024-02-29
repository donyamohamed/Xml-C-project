using Attendance_Management_System.classes;
using System.Globalization;
using System.Xml;
using System.Windows.Forms;
// using static Attendance_Management_System.classes.CourseParser;

namespace Attendance_Management_System.Forms
{
    internal static class Program
    {

        public static string newCulture = "en";
        public static int timeInterval = 300000; // 5 minutes
        public static DateTime appOpenDateandTime = DateTime.Now;
        

        public static string appConfigPath = "../../../appConfigurations/appConfigurations.xml";
        public static AppConfig appConfig = AppConfigParser.ParseAppConfig(appConfigPath);
        
        public static DateTime backupDateandTime = DateTime.Now.AddMinutes(appConfig.BackupInterval);
        public static string appLanguage = appConfig.Language;
        public static string usersPath = appConfig.UsersFilePath;
        // public static string usersPath = "../../../../users.xml";
        public static string coursesPath = appConfig.CoursesFilePath;
        public static string claSSesPath = appConfig.ClassesFilePath;
        public static string backupUsersPath = appConfig.UsersBackupFilePath;
        public static string backupCoursesPath = appConfig.CoursesBackupFilePath;
        public static string backupClaSSesPath = appConfig.ClassesBackupFilePath;

        public static List<classes.User> users = UserParser.ParseUsers(usersPath);
        // Accessable from any form by Program.users
        public static List<classes.Course> courses = CourseParser.ParseCourses(coursesPath);
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
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(Program.appLanguage);
            ApplicationConfiguration.Initialize();
            //Application.Run(new TeacherForm());
             Application.Run(new AdminDashboardForm());
            // Application.Run(new testAdmin());
            //Application.Run(new FormSettings());

            // Application.Run(new testAdmin());
            //Application.Run(new FormLogin());



        }

        
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
        
        ///
        ///<summary>
        /// The AppSettings method to set the application settings (language, date format, backup interval)
        /// </summary>
        /// in progress ...

        ///
        ///<summary>
            /// The Backup method to backup the data (users, courses, classes) 
            /// every time interval (user can set it from 5 to 60 min) to the xml files
        ///</summary>
            public static void SaveDataAsXml(string usersPath, string coursesPath, string claSSesPath)
        {
            UserParser.SaveUsersAsXml(users, usersPath);
            CourseParser.SaveCoursesAsXml(courses, coursesPath);
            ClassParser.SaveClassesAsXml(claSSes, claSSesPath);
        }

        /// <summary>
        /// The GetDataFromXml method to get the data (users, courses, classes) from the xml files
        /// calling 
        /// GetDataFromXml(usersPath, coursesPath, claSSesPath);
        /// Program.GetDataFromXml(Program.backupUsersPath, Program.backupCoursesPath, Program.backupClaSSesPath);
        /// </summary>
        /// <param name="usersPath"></param>
        /// <param name="coursesPath"></param>
        /// <param name="claSSesPath"></param>
        public static void GetDataFromXml(string usersPath, string coursesPath, string claSSesPath)
        {
            users = UserParser.ParseUsers(usersPath);
            courses = CourseParser.ParseCourses(coursesPath);
            claSSes = ClassParser.ParseClasses(claSSesPath);
        }
        
    }
}