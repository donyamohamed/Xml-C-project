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
        // end get data from xml
        // start update data in xml
        public static void UpdateUsers(List<User> users, string xmlFilePath)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(xmlFilePath);

                XmlNode usersNode = doc.SelectSingleNode("Users");

                foreach (User user in users)
                {
                    // Check if the user ID already exists in the XML
                    bool idExists = false;
                    foreach (XmlNode userNode in usersNode.ChildNodes)
                    {
                        string userId = userNode.SelectSingleNode("id").InnerText;
                        if (userId == user.Id)
                        {
                            idExists = true;
                            break;
                        }
                    }

                    if (!idExists)
                    {
                        // Create XML elements for the new user
                        XmlElement newUserElement = doc.CreateElement("user");

                        XmlElement idElement = doc.CreateElement("id");
                        idElement.InnerText = user.Id;
                        newUserElement.AppendChild(idElement);

                        XmlElement fnameElement = doc.CreateElement("fname");
                        fnameElement.InnerText = user.FirstName;
                        newUserElement.AppendChild(fnameElement);

                        XmlElement lnameElement = doc.CreateElement("lname");
                        lnameElement.InnerText = user.LastName;
                        newUserElement.AppendChild(lnameElement);

                        XmlElement ageElement = doc.CreateElement("age");
                        ageElement.InnerText = user.Age.ToString();
                        newUserElement.AppendChild(ageElement);

                        XmlElement emailElement = doc.CreateElement("email");
                        emailElement.InnerText = user.Email;
                        newUserElement.AppendChild(emailElement);

                        XmlElement passwordElement = doc.CreateElement("password");
                        passwordElement.InnerText = user.Password;
                        newUserElement.AppendChild(passwordElement);

                        XmlElement phoneElement = doc.CreateElement("phone");
                        phoneElement.InnerText = user.Phone;
                        newUserElement.AppendChild(phoneElement);

                        XmlElement addressElement = doc.CreateElement("address");
                        addressElement.InnerText = user.Address;
                        newUserElement.AppendChild(addressElement);

                        XmlAttribute roleAttribute = doc.CreateAttribute("role");
                        roleAttribute.Value = user.Role;
                        newUserElement.Attributes.Append(roleAttribute);

                        // Add the new user element to the XML
                        usersNode.AppendChild(newUserElement);
                    }
                    else
                    {
                        // Handle duplicate ID
                        Console.WriteLine($"Error: User ID '{user.Id}' already exists.");
                    }
                }

                // Save the updated XML file
                doc.Save(xmlFilePath);
                MessageBox.Show("added");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating XML file: " + ex.Message);
            }
        }


    }
}

