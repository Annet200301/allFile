using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADMIN.Enums
{
    public  class UserRoles
    {
        public enum Role
        {
            All = -1,
            Admin = 0,
            Lecturer = 1,
            Staff = 2,
            Student = 3
        }
    }
}
