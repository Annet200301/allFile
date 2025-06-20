using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicStudents.Models;
using UnicomTicStudents.Models.DTOs;

namespace UnicomTicStudents.Repositories.Irepository
{
    internal interface IUserRepository
    {


        void Add(UsersEntity user);
        void Update(UsersEntity user);
        UsersEntity GetByNICAndName(string nic, string name);
        UsersEntity GetByUsernameAndPassword(string username, string password);
        List<UsersEntity> GetAll();
    }
}
