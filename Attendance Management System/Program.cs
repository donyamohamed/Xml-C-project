using Attendance_Management_System.classes;
using System.Xml;

namespace Attendance_Management_System.Forms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.


           ApplicationConfiguration.Initialize();
            Application.Run(new StudentForm());



       

            /*
             * 
             
            // --------------->  just try get data of student :)
             
           
            XmlDocument usersDoc = new XmlDocument();
            usersDoc.Load("../../../../users.xml"); // default->  bin/depug folder

           
            List<Student> students = GetStudents(usersDoc);

           
            foreach (var student in students)
            {
                MessageBox.Show(student.ToString());
            }
            */

        }

        /*
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
    
        */
    }
}