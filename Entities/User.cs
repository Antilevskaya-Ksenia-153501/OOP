using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Calendar
{
    internal class User
    {
        public string Email { get; private set; }
        public string Password { get; private set; }
        public int UserId { get; private set; }

        public User(string email, string password)
        {
            Email = email;
            Password = password;
            UserId = email.GetHashCode();
        }
    }
}
