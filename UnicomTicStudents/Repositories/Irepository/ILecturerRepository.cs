using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicStudents.Models;
using UnicomTicStudents.Models.DTOs;

namespace UnicomTicStudents.Repositories.Irepository
{
    public  interface ILecturerRepository
    {

        void Add(LecturerEntity lecturer);
        void Update(LecturerEntity lecturer);
        void Delete(int id);
        List<LecturerDTO> GetAll();
    }
}
