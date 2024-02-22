using Attendance_Management_System.classes;
using System.Xml;
// using static Attendance_Management_System.classes.CourseParser;

namespace Attendance_Management_System.Forms
{
    internal static class Program
    {
        public static DateTime appOpenDateandTime = DateTime.Now;
        public static DateTime backupDateandTime = DateTime.Now.AddMinutes(AppConfig.AppSettings.BackupInterval);
        

        public static string newCulture = "en";
        public static string appLanguage = AppConfig.AppSettings.Language;
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

        // Test the backup method 
        

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
            // Application.Run(new FormSettings());
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
    }
}