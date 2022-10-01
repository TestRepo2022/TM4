using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TM4.UserManagement
{
    interface IUserAutho
    {
        bool SignIn(string email, string password);
        bool SignUp(string name,string email, string password);

    }
}
