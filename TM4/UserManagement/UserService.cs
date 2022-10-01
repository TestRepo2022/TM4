using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TM4.UserManagement
{
    class UserService : IUserAutho, IUserManage
    {
        public bool SignIn(string email, string password)
        {
            Console.WriteLine("Login Successfull");
            return true;
        }

        public bool SignUp(string name, string email, string password)
        {
            Console.WriteLine("Signup Successfull");
            return true;
        }

        public void DeleteUser(string email) {
            Console.WriteLine("User Dleted successfully...");
        }

        public void GetUser()
        {
            Console.WriteLine("List of all users fetched...");
        }
    }
}
