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

        public static void SaveUsersAsXml(List<User> users, string filePath)
        {
            XmlDocument doc = new XmlDocument();

            // Create the XML Declaration, and append it to XML document
            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(xmlDeclaration);

            XmlElement root = doc.CreateElement("Users");
            // set attributes
            root.SetAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            XmlAttribute att = doc.CreateAttribute("xsi", "noNamespaceSchemaLocation", "http://www.w3.org/2001/XMLSchema-instance");
            att.Value = filePath;
            root.Attributes.Append(att);

            // foreach user in the list
            foreach (User user in users)
            {
                XmlElement userElement = doc.CreateElement("user");
                userElement.SetAttribute("role", user.GetType().Name.ToLower());

                XmlElement id = doc.CreateElement("id");
                id.InnerText = user.Id;
                userElement.AppendChild(id);

                XmlElement fname = doc.CreateElement("fname");
                fname.InnerText = user.FirstName;
                userElement.AppendChild(fname);

                XmlElement lname = doc.CreateElement("lname");
                lname.InnerText = user.LastName;
                userElement.AppendChild(lname);

                XmlElement age = doc.CreateElement("age");
                age.InnerText = user.Age.ToString();
                userElement.AppendChild(age);

                XmlElement email = doc.CreateElement("email");
                email.InnerText = user.Email;
                userElement.AppendChild(email);

                XmlElement password = doc.CreateElement("password");
                password.InnerText = user.Password;
                userElement.AppendChild(password);

                XmlElement phone = doc.CreateElement("phone");
                phone.InnerText = user.Phone;
                userElement.AppendChild(phone);

                XmlElement address = doc.CreateElement("address");
                address.InnerText = user.Address;
                userElement.AppendChild(address);

                root.AppendChild(userElement);
            }

            doc.AppendChild(root);
            doc.Save(filePath);
        }
        // end get data from xml
        // start update data in xml
        public static void InsertUsers(List<User> users, string xmlFilePath)
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
<<<<<<< HEAD
        /////// Delete Student Or Teacher Done :)
=======
        ///////Remove
>>>>>>> 897f1a9b23cb769df97c1bda40aac7a503cd4748
        public static void RemoveUserById(List<User> users, string usersXmlFilePath, string classXmlFilePath, string userId)
        {
            try
            {
<<<<<<< HEAD
             
                XmlDocument usersDoc = new XmlDocument();
                usersDoc.Load(usersXmlFilePath);

               
                XmlDocument classDoc = new XmlDocument();
                classDoc.Load(classXmlFilePath);

                // Find the user 
=======
                // Load Users XML
                XmlDocument usersDoc = new XmlDocument();
                usersDoc.Load(usersXmlFilePath);

                // Load Classes XML
                XmlDocument classDoc = new XmlDocument();
                classDoc.Load(classXmlFilePath);

                // Check if the user is part of any class
                XmlNodeList studentIdNodes = classDoc.SelectNodes($"//studentId[@id='{userId}']");

                if (studentIdNodes.Count > 0)
                {
                    // Ask the user if they want to be removed from the class
                    DialogResult removeResult = MessageBox.Show("Do you want to leave this class?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (removeResult == DialogResult.Yes)
                    {
                        // Remove the studentId from all occurrences in the Classes XML
                        foreach (XmlNode studentIdNode in studentIdNodes)
                        {
                            studentIdNode.ParentNode.RemoveChild(studentIdNode);
                        }

                        // Save the updated Class XML file
                        classDoc.Save(classXmlFilePath);

                        MessageBox.Show($"User with ID '{userId}' removed from the class.");
                    }
                }

                // Find the user node with the specified ID in Users XML
>>>>>>> 897f1a9b23cb769df97c1bda40aac7a503cd4748
                XmlNode userNodeToRemove = usersDoc.SelectSingleNode($"//user[id='{userId}']");

                if (userNodeToRemove != null)
                {
<<<<<<< HEAD
                    
                    userNodeToRemove.ParentNode.RemoveChild(userNodeToRemove);

               
                    usersDoc.Save(usersXmlFilePath);

                 

               
                    if (userNodeToRemove.Attributes["role"].Value == "teacher")
                    {
                      
                        XmlNode classNodeToRemove = classDoc.SelectSingleNode($"//class[teacherId='{userId}']");

                        if (classNodeToRemove != null)
                        {
                           
                            DialogResult result = MessageBox.Show($"Do you want to remove the class associated with the teacher (ID: {userId})?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (result == DialogResult.Yes)
                            {
                               
                                classNodeToRemove.ParentNode.RemoveChild(classNodeToRemove);

                           
                                classDoc.Save(classXmlFilePath);

                                MessageBox.Show($"Class associated with the teacher (ID: {userId}) removed from the Classes XML.");
                            }
                            else
                            {
                                MessageBox.Show("Deletion canceled.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                 
                    else if (userNodeToRemove.Attributes["role"].Value == "student")
                    {
                    
                        XmlNodeList studentIdNodes = classDoc.SelectNodes($"//studentId[@id='{userId}']");

                       
                        DialogResult result = MessageBox.Show($"Do you want fire this student (ID: {userId}) ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                         
                            foreach (XmlNode studentIdNode in studentIdNodes)
                            {
                                studentIdNode.ParentNode.RemoveChild(studentIdNode);
                            }

                        
                            classDoc.Save(classXmlFilePath);

                            MessageBox.Show($"Student (ID: {userId}) removed from all classes");
                        }
                        else
                        {
                            MessageBox.Show("Deletion canceled.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show($"User with ID '{userId}' not found in the Users XML.");
=======
                    // Remove the user from the Users XML
                    userNodeToRemove.ParentNode.RemoveChild(userNodeToRemove);

                    // Save the updated Users XML file
                    usersDoc.Save(usersXmlFilePath);

                    MessageBox.Show($"User with ID '{userId}' removed from the Users.");
                }
                else
                {
                    MessageBox.Show($"User with ID '{userId}' not found.");
>>>>>>> 897f1a9b23cb769df97c1bda40aac7a503cd4748
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error removing user from XML file: " + ex.Message);
            }
        }

<<<<<<< HEAD


=======
>>>>>>> 897f1a9b23cb769df97c1bda40aac7a503cd4748


    }
}
