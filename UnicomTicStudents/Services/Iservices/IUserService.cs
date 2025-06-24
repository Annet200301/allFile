using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicStudents.Models.DTOs;

namespace UnicomTicStudents.Services.Iservices
{
    public  interface IUserService
    {
        void RegisterUser(UserDTO user);
        void UpdateUser(UserDTO user);
        void DeleteUser(int id);
        UserDTO GetByNICAndName(string nic, string name);
        UserDTO Login(string username, string password);
<<<<<<< HEAD
        List<UserDTO> GetAllUsers();
=======
       
>>>>>>> aaf16da70d44d4987a8c27562a13b683e3b478f6
    }
}
