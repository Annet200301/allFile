using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicStudents.Mappers;
using UnicomTicStudents.Models.DTOs;
using UnicomTicStudents.Models.Mappers;
using UnicomTicStudents.Repositories.Irepository;
using UnicomTicStudents.Services.Iservices;

namespace UnicomTicStudents.Services
{

    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _repository;

        public StudentService(IStudentRepository repository)
        {
            _repository = repository;
        }

        public void AddStudent(StudentDTO dto)
        {
            var entity = StudentMappers.ToEntity(dto);
            _repository.Add(entity);
        }

        public void UpdateStudent(StudentDTO dto)
        {
            var entity = StudentMappers.ToEntity(dto);
            _repository.Update(entity);
        }

        public void DeleteStudent(int id)
        {
            _repository.Delete(id);
        }

        public List<StudentDTO> GetAllStudents()
        {
            var students = _repository.GetAll();
            return students.Select(StudentMappers.ToDTO).ToList();
        }
    }
}