using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Attendance_Management_System.classes
{
    public class AppConfig
    {
        // public static User me;
        // public static string myId;
        public string AppName           {get; set;}
        public string AppVersion        {get; set;}
        public string AppDescription    {get; set;}
        public string UsersFilePath     {get; set;}
        public string CoursesFilePath   {get; set;}
        public string ClassesFilePath { get; set;}
        public string[] Authors         {get; set;}
        public static class AppSettings
        {
            public static int BackupInterval   {get; set;}
            public static string[] Languages   {get; set;}
            public static string[] DateFormats {get; set;}
}

        public AppConfig(
            string _AppName,
            string _AppVersion,
            string _AppDescription,
            string _UsersFilePath,
            string _CoursesFilePath,
            string _ClassesFilePath,
            string[] _Authors,
            int _BackupInterval,
            string[] _Languages,
            string[] _DateFormats
            ) 
        {
            AppName = _AppName;
            AppVersion = _AppVersion;
            AppDescription = _AppDescription;
            UsersFilePath = _UsersFilePath;
            CoursesFilePath = _CoursesFilePath;
            ClassesFilePath = _ClassesFilePath;
            Authors = _Authors;
            AppSettings.BackupInterval = _BackupInterval;
            AppSettings.Languages = _Languages;
            AppSettings.DateFormats = _DateFormats;
        }

        public AppConfig() { }

    }


    /*
<?xml version="1.0" encoding="UTF-8"?>
<appConfigurations>
    <appConfiguration>
        <name>Attendance Management System</name>
        <version>1.0</version>
        <description>Attendance Management System Description</description>
        <dataPathes>
            <Users>data/Users.xml</Users>
            <Courses>data/Courses.xml</Courses>
            <Sessions>data/Sessions.xml</Sessions>
        </dataPathes>
        <authors>
            <author>Author 1</author>
            <author>Author 2</author>
            <author>Author 3</author>
        </authors>
        <createdDate>2021-06-01</createdDate>
        <appSettings>
            <!-- updateInterval in minutes -->
            <updateInterval>5</updateInterval>
            <language>English</language>
            <language>Arabic</language>s
            <DateFormat>dd-MM-yyyy</DateFormat>
            <DateFormat>MM-dd-yyyy</DateFormat>
            <DateFormat>yyyy-MM-dd</DateFormat>
        </appSettings>
    </appConfiguration>
</appConfigurations>
    */
}
