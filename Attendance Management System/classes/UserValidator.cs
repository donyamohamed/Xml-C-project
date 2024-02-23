using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Attendance_Management_System.classes
{
    public enum RoleEnum
    {
        Admin,
        Student,
        Teacher
    }
    public static class UserValidator
    {
        public static bool ValidateId(string id)
        {
            if (string.IsNullOrEmpty(id))
                return false;

            Regex regex = new Regex(@"\d{1,2}(T|S|A){1}");
            return regex.IsMatch(id);
        }

        public static bool ValidateName(string name)
        {
            if (string.IsNullOrEmpty(name))
                return false;

            Regex regex = new Regex("[a-zA-Z]{3,}");
            return regex.IsMatch(name);
        }

        public static bool ValidateAge(int age)
        {
            return age >= 18;
        }

        public static bool ValidateEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;

            Regex regex = new Regex("[a-zA-Z]{3,}\\d{0,}@[a-zA-Z]{3,}\\.[a-zA-Z]{3}");
            return regex.IsMatch(email);
        }

        public static bool ValidatePassword(string password)
        {
            if (string.IsNullOrEmpty(password))
                return false;

            Regex regex = new Regex("[A-Za-z]{3,}($|@|#|%){1}\\d{2,}|($|@|#|%){1}[A-Za-z]{3,}\\d{2,}|[A-Za-z]{3,}\\d{2,}($|@|#|%)");
            return regex.IsMatch(password);
        }

        public static bool ValidatePhone(string phone)
        {
            if (string.IsNullOrEmpty(phone))
                return false;

            Regex regex = new Regex("(011|012|015|010)\\d{8}");
            return regex.IsMatch(phone);
        }

        public static bool ValidateRole(string role)
        {
            if (string.IsNullOrEmpty(role))
                return false;

            return Enum.TryParse<RoleEnum>(role, out _);
        }
    }
}
