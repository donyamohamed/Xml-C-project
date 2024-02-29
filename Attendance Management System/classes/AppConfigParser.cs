using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Attendance_Management_System.classes.AppConfig;
using System.Xml;
using System.Data.SqlTypes;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.LinkLabel;

namespace Attendance_Management_System.classes
{
    public static class AppConfigParser
    {
        public static AppConfig ParseAppConfig(string xmlFilePath)
        {
            AppConfig appConfig = new AppConfig();

            try
            {

                XmlDocument doc = new();
                doc.Load(xmlFilePath);
                XmlNodeList appConfigNodes = doc.SelectNodes("//appConfiguration");

                foreach (XmlNode appConfigNode in appConfigNodes)
                {
                    appConfig.AppName = appConfigNode.SelectSingleNode("name").InnerText;
                    appConfig.AppVersion = appConfigNode.SelectSingleNode("version").InnerText;
                    appConfig.AppDescription = appConfigNode.SelectSingleNode("description").InnerText;
                    appConfig.AppCreationDate = DateOnly.Parse(appConfigNode.SelectSingleNode("createdDate").InnerText);
                    appConfig.UsersFilePath = appConfigNode.SelectSingleNode("dataPathes/Users").InnerText;
                    appConfig.CoursesFilePath = appConfigNode.SelectSingleNode("dataPathes/Courses").InnerText;
                    appConfig.ClassesFilePath = appConfigNode.SelectSingleNode("dataPathes/Sessions").InnerText;
                    appConfig.UsersBackupFilePath = appConfigNode.SelectSingleNode("backupPathes/Users").InnerText;
                    appConfig.CoursesBackupFilePath = appConfigNode.SelectSingleNode("backupPathes/Courses").InnerText;
                    appConfig.ClassesBackupFilePath = appConfigNode.SelectSingleNode("backupPathes/Sessions").InnerText;
                    XmlNodeList authorsNodes = appConfigNode.SelectNodes("authors/author");
                    appConfig.Authors = new string[authorsNodes.Count];
                    for (int i = 0; i < authorsNodes.Count; i++)
                    {
                        appConfig.Authors[i] = authorsNodes[i].InnerText;
                    }
                    appConfig.BackupInterval = int.Parse(appConfigNode.SelectSingleNode("appSettings/updateInterval").InnerText);
                    appConfig.Language = appConfigNode.SelectSingleNode("appSettings/language").InnerText;
                    appConfig.DateFormats = appConfigNode.SelectSingleNode("appSettings/DateFormat").InnerText;
                    // appConfig.AppSettings = appSettings;
                }
            }
            catch (Exception ex)
            {
                // Handle the exception or log the error message
                Console.WriteLine("Error loading XML file: " + ex.Message);
            }

            return appConfig;
        }
        public static void SaveAppConfigAsXml(AppConfig appConfig, string filePath)
        {
            XmlDocument doc = new XmlDocument();

            // Create the XML Declaration, and append it to XML document
            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(xmlDeclaration);

            XmlElement root = doc.CreateElement("appConfigurations");

            XmlElement appConfiguration = doc.CreateElement("appConfiguration");
            root.AppendChild(appConfiguration);

            XmlElement name = doc.CreateElement("name");
            name.InnerText = appConfig.AppName;
            appConfiguration.AppendChild(name);

            XmlElement version = doc.CreateElement("version");
            version.InnerText = appConfig.AppVersion;
            appConfiguration.AppendChild(version);

            XmlElement description = doc.CreateElement("description");
            description.InnerText = appConfig.AppDescription;
            appConfiguration.AppendChild(description);

            XmlElement createdDate = doc.CreateElement("createdDate");
            createdDate.InnerText = appConfig.AppCreationDate.ToString();
            appConfiguration.AppendChild(createdDate);

            XmlElement dataPathes = doc.CreateElement("dataPathes");
            appConfiguration.AppendChild(dataPathes);

            XmlElement Users = doc.CreateElement("Users");
            Users.InnerText = appConfig.UsersFilePath;
            dataPathes.AppendChild(Users);

            XmlElement Courses = doc.CreateElement("Courses");
            Courses.InnerText = appConfig.CoursesFilePath;
            dataPathes.AppendChild(Courses);

            XmlElement Sessions = doc.CreateElement("Sessions");
            Sessions.InnerText = appConfig.ClassesFilePath;
            dataPathes.AppendChild(Sessions);

            XmlElement backup = doc.CreateElement("backupPathes");
            appConfiguration.AppendChild(backup);

            XmlElement UsersBackup = doc.CreateElement("Users");
            UsersBackup.InnerText = appConfig.UsersBackupFilePath;
            backup.AppendChild(UsersBackup);

            XmlElement CoursesBackup = doc.CreateElement("Courses");
            CoursesBackup.InnerText = appConfig.CoursesBackupFilePath;
            backup.AppendChild(CoursesBackup);

            XmlElement SessionsBackup = doc.CreateElement("Sessions");
            SessionsBackup.InnerText = appConfig.ClassesBackupFilePath;
            backup.AppendChild(SessionsBackup);

            XmlElement authors = doc.CreateElement("authors");
            appConfiguration.AppendChild(authors);

            foreach (string author in appConfig.Authors)
            {
                XmlElement authorElement = doc.CreateElement("author");
                authorElement.InnerText = author;
                authors.AppendChild(authorElement);
            }

            XmlElement appSettings = doc.CreateElement("appSettings");
            appConfiguration.AppendChild(appSettings);

            XmlElement updateInterval = doc.CreateElement("updateInterval");
            updateInterval.InnerText = appConfig.BackupInterval.ToString();
            appSettings.AppendChild(updateInterval);

            XmlElement language = doc.CreateElement("language");
            language.InnerText = appConfig.Language;
            appSettings.AppendChild(language);

            XmlElement DateFormat = doc.CreateElement("DateFormat");
            DateFormat.InnerText = appConfig.DateFormats;
            appSettings.AppendChild(DateFormat);

            root.AppendChild(appConfiguration);
            doc.AppendChild(root);
            doc.Save(filePath);
        }


    }
    /*
<?xml version="1.0" encoding="UTF-8"?>
<appConfigurations>
    <appConfiguration>
        <name>Attendance Management System</name>
        <version>1.0</version>
        <description>Attendance Management System Description</description>
        <createdDate>6/1/2021</createdDate>
        <dataPathes>
            <Users>../../../../users.xml</Users>
            <Courses>../../../../courses.xml</Courses>
            <Sessions>../../../../class.xml</Sessions>
        </dataPathes>
        <backupPathes>
            <Users>../../../backup/usersBackup.xml</Users>
            <Courses>../../../backup/coursesBackup.xml</Courses>
            <Sessions>../../../backup/classBackup.xml</Sessions>
        </backupPathes>
        <authors>
            <author>Author 1</author>
            <author>Author 2</author>
            <author>Author 3</author>
        </authors>
        <appSettings>
            <updateInterval>50</updateInterval>
            <language>en</language>
            <DateFormat>yyyy-MM-dd</DateFormat>
        </appSettings>
    </appConfiguration>
</appConfigurations>
    */
}
