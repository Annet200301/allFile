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
using UnicomTicStudents.Services.IServices;

namespace UnicomTicStudents.Controllers
{
    internal class SubjectController
    {
        private readonly IsubjectServices subjectServices;

        public SubjectController(IsubjectServices _subjectServices)
        {
            subjectServices = _subjectServices; 
        }

        public void AddSubject(string subjectName, int courseId)
        {
            AddSubject(subjectName, courseId);
        }

        public void AddSubject(string subjectName, int courseId, SubjectEntity subjectEntity)
        {
            var subjectDTO = new SubjectDTO
            {
                Name = subjectName,
                CourseId = courseId
            };

            subjectServices.AddSubject(subjectDTO);
        }

        public List<SubjectDTO> GetSubjectsByCourseId(int courseId)
        {
            return subjectServices.GetSubjectsByCourseId(courseId);
        }
    }
}
