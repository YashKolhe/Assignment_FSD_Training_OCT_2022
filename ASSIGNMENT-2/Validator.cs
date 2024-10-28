using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DAY_3_ASSIGNMENT.ASSIGNMENT_2
{
    internal class Validator
    {
        
            public static bool IsValidPhoneNumber(string phoneNumber)
            {
                string pattern = @"^\d{10}$";
                return Regex.IsMatch(phoneNumber, pattern);
            }

            public static bool IsValidEmail(string email)
            {
                string emailPattern = @"^[^@\s]+@[^@\s]+\.(com|net|org|gov|in)$";
                return Regex.IsMatch(email, emailPattern);
            }

            public static bool IsValidDateOfBirth(DateTime dateOfBirth)
            {
                int age = DateTime.Today.Year - dateOfBirth.Year;
                return age > 0;
            }
        
    }
}
