using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Attendance_Management_System.classes
{
    public static class UserParser
    {
        public static List<User> ParseUsers(string xmlFilePath)
        {
            List<User> users = new List<User>();

         
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlFilePath);

            
            XmlNodeList userNodes = doc.SelectNodes("//user");
            foreach (XmlNode userNode in userNodes)
            {
                string id = userNode.SelectSingleNode("id").InnerText;
                string firstName = userNode.SelectSingleNode("fname").InnerText;
                string lastName = userNode.SelectSingleNode("lname").InnerText;
                int age = int.Parse(userNode.SelectSingleNode("age").InnerText);
                string email = userNode.SelectSingleNode("email").InnerText;
                string password = userNode.SelectSingleNode("password").InnerText;
                string phone = userNode.SelectSingleNode("phone").InnerText;
                string address = userNode.SelectSingleNode("address").InnerText;
                string role = userNode.Attributes["role"].Value;

               
                User user;
                switch (role)
                {
                    case "student":
                        user = new Student(id, firstName, lastName, age, email, password, phone, address);
                        break;
                    case "admin":
                        user = new Admin(id, firstName, lastName, age, email, password, phone, address);
                        break;
                    case "teacher":
                        user = new Teacher(id, firstName, lastName, age, email, password, phone, address);
                        break;
                    default:
                       
                        user = null;
                        break;
                }

            
                if (user != null)
                {
                    users.Add(user);
                }
            }

            return users;
        }
    }
}

