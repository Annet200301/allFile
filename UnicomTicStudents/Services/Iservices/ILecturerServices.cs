using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicStudents.Models.DTOs;

namespace UnicomTicStudents.Services.Iservices
{
    public  interface ILecturerServices
    {
        void AddLecturer(LecturerDTO dto);
        void UpdateLecturer(LecturerDTO dto);
        void DeleteLecturer(int id);
        List<LecturerDTO> GetAllLecturers();
    }
}
