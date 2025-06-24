using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicStudents.Models.DTOs;
using UnicomTicStudents.Models.Mappers;
using UnicomTicStudents.Repositories;
using UnicomTicStudents.Repositories.Irepository;
using UnicomTicStudents.Services.Iservices;

namespace UnicomTicStudents.Services
{
    public  class LecturerService : ILecturerServices
    {
        private readonly ILecturerRepository _repository;

        public LecturerService(ILecturerRepository repository)
        {
            _repository = repository;
        }

        public void AddLecturer(LecturerDTO dto)
        {
            if (string.IsNullOrWhiteSpace(dto.Name) || string.IsNullOrWhiteSpace(dto.NIC))
                throw new ArgumentException("Name and NIC are required");
            var entity = LecturerMapper.ToEntity(dto);
            _repository.Add(entity);
        }

        public void UpdateLecturer(LecturerDTO dto)
        {
            if (dto.Id <= 0) throw new ArgumentException("Invalid ID");
            var entity = LecturerMapper.ToEntity(dto);
            _repository.Update(entity);
        }

        public void DeleteLecturer(int id)
        {
            _repository.Delete(id);
        }

        public List<LecturerDTO> GetAllLecturers()
        {
            return _repository.GetAll();
        }
    }
}
