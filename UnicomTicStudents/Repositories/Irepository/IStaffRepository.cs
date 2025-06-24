using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicStudents.Models;

namespace UnicomTicStudents.Repositories.Irepository
{
    public interface IStaffRepository
    {
        void Add(StaffEntity staff);
        void Update(StaffEntity staff);
        void Delete(int id);
        List<StaffEntity> GetAll();
    }
}

