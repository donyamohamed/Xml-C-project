using Attendance_Management_System.classes;
using System.Xml;
// using static Attendance_Management_System.classes.CourseParser;

namespace Attendance_Management_System.Forms
{
    internal static class Program
    {
        public static string newCulture = "en";
        public static string appConfigPath = "G:\\ITI\\Xml-C-project\\Attendance Management System\\appConfigurations\\appConfigurations.xml";
        public static AppConfig appConfig = AppConfigParser.ParseAppConfig(appConfigPath);
        
        public static string usersPath = appConfig.UsersFilePath;
        // public static string usersPath = "../../../../users.xml";
        public static string coursesPath = appConfig.CoursesFilePath;
        public static string claSSesPath = appConfig.ClassesFilePath;

        public static List<classes.User> users = UserParser.ParseUsers(usersPath);
        // Accessable from any form by Program.users
        public static List<classes.Course> courses = CourseParser.ParseCourses(coursesPath);
        // Accessable from any form by Program.courses
        public static List<classes.Class> claSSes = ClassParser.ParseClasses(claSSesPath);
        // Accessable from any form by Program.claSSes

        // set time interval for the timer every 5 minutes
        public static int timeInterval = 300000; // 5 minutes

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            // testing conveting claSS to XML file
            // ClassParser.SaveClassesAsXml(claSSes, "claSSesPath");
            // CourseParser.SaveCoursesAsXml(courses, "coursesPath");
            // UserParser.SaveUsersAsXml(users, "usersPath");

            ApplicationConfiguration.Initialize();
            Application.Run(new FormLogin());
        }
    }
}