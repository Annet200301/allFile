using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicStudents.Models;
using UnicomTicStudents.Models.DTOs;
using UnicomTicStudents.Repositories.Irepository;
using UnicomTicStudents.Services;
using UnicomTicStudents.Services.Iservices;

namespace UnicomTicStudents.Controllers
{
    internal class SubjectController
    {
        private readonly IsubjectServices  _subjectSevices;

        public SubjectController(IsubjectServices subjectSevices)
        {
            _subjectSevices = subjectSevices;
        }

        public void AddSubject(string subjectName, int courseId)
        {
            var subjectDTO = new SubjectDTO
            {
                Name = subjectName,
                CourseId = courseId
            };

            _subjectSevices.AddSubject(subjectDTO);  
        }

        public List<SubjectDTO> GetSubjectsByCourseId(int courseId)
        {
            return _subjectSevices.GetSubjectsByCourseId(courseId);
        }
    }
}
