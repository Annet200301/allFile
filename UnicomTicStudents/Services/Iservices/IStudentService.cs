using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicStudents.Models.DTOs;

namespace UnicomTicStudents.Services.Iservices
{
   public  interface IStudentService
    {
        void AddStudent(StudentDTO dto);
        void UpdateStudent(StudentDTO dto);
        void DeleteStudent(int id);
        List<StudentDTO> GetAllStudents();
    }
}
