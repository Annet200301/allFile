using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicStudents.Models.DTOs;

namespace UnicomTicStudents.Services.Iservices
{
    internal interface IUserService
    {

        void RegisterUser(UserDTO dto);
        UserDTO GetByNICAndName(string nic, string name);
        void UpdateUser(UserDTO dto);
        UserDTO Login(string username, string password);
       
    }
}
