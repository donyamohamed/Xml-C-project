using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Attendance_Management_System.classes.AppConfig;
using System.Xml;

namespace Attendance_Management_System.classes
{
    public static class AppConfigParser
    {
        public static string AppName { get; private set; }

        public static AppConfig ParseAppConfig(string xmlFilePath)
        {
            AppConfig appConfig = new AppConfig();

            // parse the xml file and fill the appConfig object
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlFilePath);

            XmlNodeList appConfigNodes = doc.SelectNodes("//appConfiguration");
            foreach (XmlNode appConfigNode in appConfigNodes)
            {
                appConfig.AppName = appConfigNode.SelectSingleNode("name").InnerText;
                appConfig.AppVersion = appConfigNode.SelectSingleNode("version").InnerText;
                appConfig.AppDescription = appConfigNode.SelectSingleNode("description").InnerText;
                appConfig.UsersFilePath = appConfigNode.SelectSingleNode("dataPathes/Users").InnerText;
                appConfig.CoursesFilePath = appConfigNode.SelectSingleNode("dataPathes/Courses").InnerText;
                appConfig.ClassesFilePath = appConfigNode.SelectSingleNode("dataPathes/Classes").InnerText;
                XmlNodeList authorsNodes = appConfigNode.SelectNodes("authors/author");
                appConfig.Authors = new string[authorsNodes.Count];
                for (int i = 0; i < authorsNodes.Count; i++)
                {
                    appConfig.Authors[i] = authorsNodes[i].InnerText;
                }
                AppSettings.BackupInterval = int.Parse(appConfigNode.SelectSingleNode("appSettings/backupInterval").InnerText);
                XmlNodeList appSettingsNodes = appConfigNode.SelectNodes("appSettings");
                XmlNodeList languagesNodes = appSettingsNodes[0].SelectNodes("language");
                AppSettings.Languages = new string[languagesNodes.Count];
                for (int i = 0; i < languagesNodes.Count; i++)
                {
                    AppSettings.Languages[i] = languagesNodes[i].InnerText;
                }
                XmlNodeList dateFormatsNodes = appSettingsNodes[0].SelectNodes("DateFormat");
                AppSettings.DateFormats = new string[dateFormatsNodes.Count];
                for (int i = 0; i < dateFormatsNodes.Count; i++)
                {
                    AppSettings.DateFormats[i] = dateFormatsNodes[i].InnerText;
                }
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

            XmlElement authors = doc.CreateElement("authors");
            appConfiguration.AppendChild(authors);

            foreach (string author in appConfig.Authors)
            {
                XmlElement authorElement = doc.CreateElement("author");
                authorElement.InnerText = author;
                authors.AppendChild(authorElement);
            }

            XmlElement createdDate = doc.CreateElement("createdDate");
            createdDate.InnerText = DateTime.Now.ToString("yyyy-MM-dd");
            appConfiguration.AppendChild(createdDate);

            XmlElement appSettings = doc.CreateElement("appSettings");
            appConfiguration.AppendChild(appSettings);

            XmlElement updateInterval = doc.CreateElement("updateInterval");
            updateInterval.InnerText = AppSettings.BackupInterval.ToString();
            appSettings.AppendChild(updateInterval);

            foreach (string language in AppSettings.Languages)
            {
                XmlElement languageElement = doc.CreateElement("language");
                languageElement.InnerText = language;
                appSettings.AppendChild(languageElement);
            }

            foreach (string dateFormat in AppSettings.DateFormats)
            {
                XmlElement dateFormatElement = doc.CreateElement("DateFormat");
                dateFormatElement.InnerText = dateFormat;
                appSettings.AppendChild(dateFormatElement);
            }
            root.AppendChild(appConfiguration);
            doc.AppendChild(root);
            doc.Save(filePath);
        }


    }
    /*
<? xml version="1.0" encoding="UTF-8"?>
<appConfigurations>
    <appConfiguration>
        <name>Attendance Management System</name>
        <version>1.0</version>
        <description>Attendance Management System Description</description>
        <dataPathes>
            <!-- <Users>../../../../users.xml</Users> -->
            <Users>G:\ITI\Xml-C-project\users.xml</Users>
            <!-- <Courses>../../../../courses.xml</Courses> -->
            <Courses>G:\ITI\Xml-C-project\courses.xml</Courses>
            <!-- <Classes>../../../../class.xml</Classes> -->
            <Classes>G:\ITI\Xml-C-project\class.xml</Classes>
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
            <language>Arabic</language> s
            <DateFormat>dd-MM-yyyy</DateFormat>
            <DateFormat>MM-dd-yyyy</DateFormat>
            <DateFormat>yyyy-MM-dd</DateFormat>
        </appSettings>
    </appConfiguration>
</appConfigurations>
    */
}
