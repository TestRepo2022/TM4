using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TM4.UserManagement
{
    interface IUserManage
    {
        void DeleteUser(string email);
        void GetUser();

    }
}
