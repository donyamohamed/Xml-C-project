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
        public DateOnly AppCreationDate {get; set;}
        public string UsersFilePath     {get; set;}
        public string CoursesFilePath   {get; set;}
        public string ClassesFilePath { get; set;}
        public string UsersBackupFilePath { get; set; }
        public string CoursesBackupFilePath { get; set; }
        public string ClassesBackupFilePath { get; set; }

        public string[] Authors         {get; set;}
        public static class AppSettings
        {
            public static int BackupInterval   {get; set;}
            public static string Language   {get; set;}
            public static string DateFormats {get; set;}
}

        public AppConfig(
            string _AppName,
            string _AppVersion,
            string _AppDescription,
            DateOnly _AppCreationDate,
            string _UsersFilePath,
            string _CoursesFilePath,
            string _ClassesFilePath,
            string _UsersBackupFilePath,
            string _CoursesBackupFilePath,
            string _ClassesBackupFilePath,
            string[] _Authors,
            int _BackupInterval,
            string _Language,
            string _DateFormats
            ) 
        {
            AppName = _AppName;
            AppVersion = _AppVersion;
            AppDescription = _AppDescription;
            AppCreationDate = _AppCreationDate;
            UsersFilePath = _UsersFilePath;
            CoursesFilePath = _CoursesFilePath;
            ClassesFilePath = _ClassesFilePath;
            UsersBackupFilePath = _UsersBackupFilePath;
            CoursesBackupFilePath = _CoursesBackupFilePath;
            ClassesBackupFilePath = _ClassesBackupFilePath;
            Authors = _Authors;
            AppSettings.BackupInterval = _BackupInterval;
            AppSettings.Language = _Language;
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
            <Users>../../../../users.xml</Users>
            <!-- <Users>G:\ITI\Xml-C-project\users.xml</Users> -->
            <Courses>../../../../courses.xml</Courses>
            <!-- <Courses>G:\ITI\Xml-C-project\courses.xml</Courses> -->
            <Classes>../../../../class.xml</Classes>
            <!-- <Classes>G:\ITI\Xml-C-project\class.xml</Classes> -->
        </dataPathes>
        <authors>
            <author>Author 1</author>
            <author>Author 2</author>
            <author>Author 3</author>
        </authors>
        <createdDate>2021-06-01</createdDate>
        <appSettings>
            <!-- updateInterval in minutes -->
            <backupInterval>5</backupInterval>
            <language>English</language>
            <DateFormat>yyyy-MM-dd</DateFormat>
        </appSettings>
    </appConfiguration>
</appConfigurations>
    */
}
