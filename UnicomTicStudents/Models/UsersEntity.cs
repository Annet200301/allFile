using ADMIN.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTicStudents.Models
{
    public  class UsersEntity
    {
        public int Id { get; set; }
        public string NIC { get; set; }
        public string Name { get; set; }
        public string IndexNumber { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public UserRoles Role { get; set; }
    }
}
