using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Attendance_Management_System.classes
{
    public static class CourseSerialize
    {

        // serialize course from list of courses to xml file
        public static void SerializeCourse(List<Course> courses)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Course>));
            TextWriter writer = new StreamWriter("course.xml");
            serializer.Serialize(writer, courses);
            writer.Close();
        }
        // deserialize course from xml file to list of courses
        public static List<Course> DeserializeCourse(List<Course> courses)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Course>));
            FileStream fs = new FileStream("course.xml", FileMode.Open);
            XmlReader reader = XmlReader.Create(fs);
            courses = (List<Course>)serializer.Deserialize(reader);
            reader.Close();
            fs.Close();
            return courses;
        }
    }
}
