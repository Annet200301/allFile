using ADMIN.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTicStudents.Models.DTOs
{
<<<<<<< HEAD
    public  class UserDTO
=======
    internal  class UserDTO
>>>>>>> aaf16da70d44d4987a8c27562a13b683e3b478f6
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
