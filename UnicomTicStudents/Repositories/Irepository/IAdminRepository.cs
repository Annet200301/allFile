using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicStudents.Models;

namespace UnicomTicStudents.Repositories.Irepository
{
    public  interface IAdminRepository
    {
        void Add(AdminEntity admin);
        void Update(AdminEntity admin);
        void Delete(int id);
        List<AdminEntity> GetAll();
        bool IsUserExist(string nic, string fullName); 
        void RegisterAdmin(AdminEntity admin); 

    }
}
