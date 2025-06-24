using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicStudents.Models;

namespace UnicomTicStudents.Repositories.Irepository
{
    public  interface IStudentRepository
    {
        void Add(StudentEntity student);
        void Update(StudentEntity student);
        void Delete(int id);
        List<StudentEntity> GetAll();
    }
}
