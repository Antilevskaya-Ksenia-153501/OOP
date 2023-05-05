using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Calendar
{
    internal class UserManager
    {
        private List<User> users = new List<User>();
        public void AddUser(User user)
        {
            users.Add(user);
        }
        public void RemoveUser(User user)
        {
            users.Remove(user);
        }
        public User GetUserByEmail(string email)
        {
            foreach (User user in users)
            {
                if (user.Email == email)
                {
                    return user;
                }
            }
            return null;
        }
    }
}
