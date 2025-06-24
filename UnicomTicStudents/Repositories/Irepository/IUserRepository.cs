using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicStudents.Models;
using UnicomTicStudents.Models.DTOs;

namespace UnicomTicStudents.Repositories.Irepository
{
    public  interface IUserRepository
    {
        void AddUser(UsersEntity user);
        void UpdateUser(UsersEntity user);
        void DeleteUser(int id);
        UsersEntity GetById(int id);
        UsersEntity GetByNICAndName(string nic, string name);
        UsersEntity GetByUsernameAndPassword(string username, string password);
        List<UsersEntity> GetAllUsers();
    }
}
