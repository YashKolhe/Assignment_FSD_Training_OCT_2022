using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_4_Assignment
{
    internal class UserFactory
    {
        public static IUserPermission CreateUser(string userType)
        {
            return userType switch
            {
                "Student" => new Student(),
                "Teacher" => new Teacher(),
                "Librarian" => new Librarian(),
                _ => throw new ArgumentException("Invalid user type.")
            };
        }
    }
}
