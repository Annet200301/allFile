using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicStudents.Course;
using UnicomTicStudents.Mappers;
using UnicomTicStudents.Models.DTOs;
using UnicomTicStudents.Repositories;
using UnicomTicStudents.Repositories.Irepository;
using UnicomTicStudents.Services.Iservices;
using UnicomTicStudents.Utilities;

namespace UnicomTicStudents.Services
{
    internal class SubjectSevices: IsubjectServices
    {
        private readonly ISubjectRepository _repository;

        public SubjectSevices(ISubjectRepository repository)
        {
            _repository = repository;
        }

        public void AddSubject(SubjectDTO dto)
        {
            if (string.IsNullOrWhiteSpace(dto.Name))
                throw new ArgumentException("Subject name is required.");
            if (dto.CourseId <= 0)
                throw new ArgumentException("Invalid Course Id.");

            var entity = SubjectMappers.ToEntity(dto);
            _repository.AddSubject(entity);
        }

        public void UpdateSubject(SubjectDTO dto)
        {
            if (dto.Id <= 0)
                throw new ArgumentException("Invalid Subject Id.");
            if (string.IsNullOrWhiteSpace(dto.Name))
                throw new ArgumentException("Subject name is required.");
            if (dto.CourseId <= 0)
                throw new ArgumentException("Invalid Course Id.");

            var entity = SubjectMappers.ToEntity(dto);
            _repository.UpdateSubject(entity);
        }

        public void DeleteSubject(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Invalid Subject Id.");

            _repository.DeleteSubject(id);
        }

        public List<SubjectDTO> GetSubjectsByCourseId(int courseId)
        {
            return _repository.GetSubjectsByCourseId(courseId);
        }
        public List<SubjectDTO> GetAllSubjects()
        {
            return _repository.GetAllSubjects(); 
        }
    }
}
