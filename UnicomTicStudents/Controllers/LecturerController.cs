using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicStudents.Models.DTOs;
using UnicomTicStudents.Services.Iservices;

namespace UnicomTicStudents.Controllers
{
    public  class LecturerController
    {
        private readonly ILecturerServices _service;

        public LecturerController(ILecturerServices service)
        {
            _service = service;
        }

        public void Add(LecturerDTO dto) => _service.AddLecturer(dto);
        public void Update(LecturerDTO dto) => _service.UpdateLecturer(dto);
        public void Delete(int id) => _service.DeleteLecturer(id);
        public List<LecturerDTO> GetAll() => _service.GetAllLecturers();
    }
}
