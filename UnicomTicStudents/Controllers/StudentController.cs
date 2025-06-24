using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicStudents.Models.DTOs;
using UnicomTicStudents.Services.Iservices;

namespace UnicomTicStudents.Controllers
{
    public class StudentController
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public void AddStudent(string name, string nic,  int courseId)
        {
            var dto = new StudentDTO
            {
                Name = name,
                NIC = nic,
                CourseId = courseId
            };
            _studentService.AddStudent(dto);
        }

        public void UpdateStudent(int id, string name, string nic, int courseId)
        {
            var dto = new StudentDTO
            {
                Id = id,
                Name = name,
                NIC = nic,
                CourseId = courseId
            };
            _studentService.UpdateStudent(dto);
        }

        public void DeleteStudent(int id)
        {
            _studentService.DeleteStudent(id);
        }

        public List<StudentDTO> GetAllStudents()
        {
            return _studentService.GetAllStudents();
        }
    }
}
