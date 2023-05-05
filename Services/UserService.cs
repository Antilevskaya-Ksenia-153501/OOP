using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Calendar.Services
{
    internal class UserService
    {
        private UserManager UserManager = null;
        private TaskManager TaskManager = null;
        public User CurrentUser { get; private set; }
        public UserService(UserManager userManager, TaskManager taskManager)
        {
            UserManager = userManager;
            TaskManager = taskManager;
        }
        public void SignUp(string email, string password)
        {
            User user = UserManager.GetUserByEmail(email);
            if (user != null)
            {
                Console.WriteLine("Such user already exists. You should sign in.");
            }
            if (user == null)
            {
                user = new User(email, password);
                UserManager.AddUser(user);
                CurrentUser = user;
            }
        }
        public void SignIn(string email, string password)
        {
            User user = UserManager.GetUserByEmail(email);
            if (user != null)
            {
                if (user.Password == password)
                {
                    CurrentUser = user;
                }
            }
        }
        public void SignOut()
        {
            CurrentUser = null;
        }
        public void DeleteAccount()
        {
            TaskManager.RemoveAllTasksOfUser(CurrentUser.UserId);
            UserManager.RemoveUser(CurrentUser);
            CurrentUser = null;
        }
    }
}
