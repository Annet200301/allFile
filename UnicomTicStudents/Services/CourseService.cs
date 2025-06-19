using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicStudents.Repositories;
using UnicomTicStudents.Services;
using UnicomTicStudents.Utilities;
using static UnicomTicStudents.Course.CourseDTO;
using static UnicomTicStudents.Course.CourseEnum;

namespace UnicomTicStudents.Course
{
    internal class CourseService: ICourseService
    {
        private readonly ICourseRepository _repository;

        public CourseService(ICourseRepository repository)
        {
            _repository = repository;
        }

        public void AddCourse(CourseDTO dto)
        {
            if (string.IsNullOrWhiteSpace(dto.Name))
                throw new ArgumentException("Course name is required.");

            var entity = CourseMapper.ToEntity(dto);
            _repository.Add(entity);
        }

        public void UpdateCourse(CourseDTO dto)
        {
            if (dto.Id <= 0)
                throw new ArgumentException("Invalid Course Id.");
            if (string.IsNullOrWhiteSpace(dto.Name))
                throw new ArgumentException("Course name is required.");

            var entity = CourseMapper.ToEntity(dto);
            _repository.Update(entity);
        }

        public void DeleteCourse(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Invalid Course Id.");

            _repository.Delete(id);
        }

        public List<CourseDTO> GetAllCourses()
        {
            return _repository.GetAll()
                              .Select(CourseMapper.ToDTO)
                              .ToList();
        }

        public CourseDTO GetCourseById(int id)
        {
            var entity = _repository.GetById(id);
            return entity == null ? null : CourseMapper.ToDTO(entity);
        }
    }
}
