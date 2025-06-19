using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicStudents.Services;
using static UnicomTicStudents.Course.CourseDTO;
using static UnicomTicStudents.Course.CourseEnum;

namespace UnicomTicStudents.Course
{
    internal class CourseController
    {
        private readonly ICourseService _service;
        
        public CourseController(ICourseService service)
        {
            _service = service;
        }

        public void Add(string name)
        {
            var dto = new CourseDTO { Name = name };
            _service.AddCourse(dto);
        }

        public void Update(int id, string name)
        {
            var dto = new CourseDTO { Id = id, Name = name };
            _service.UpdateCourse(dto);
        }

        public void Delete(int id)
        {
            _service.DeleteCourse(id);
        }

        public List<CourseDTO> GetAll()
        {
            return _service.GetAllCourses();
        }

        public CourseDTO GetById(int id)
        {
            return _service.GetCourseById(id);
        }
    }
}
