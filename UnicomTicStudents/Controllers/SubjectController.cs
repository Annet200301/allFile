using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicStudents.Models;
using UnicomTicStudents.Models.DTOs;
using UnicomTicStudents.Repositories.Irepository;
using UnicomTicStudents.Services.IServices;

namespace UnicomTicStudents.Controllers
{
    internal class SubjectController
    {
        private readonly ISubjectServices subjectServices;

        public SubjectController(ISubjectServices _subjectServices)
        {
            subjectServices = _subjectServices; 
        }

        public void AddSubject(string subjectName, int courseId)
        {
            AddSubject(subjectName, courseId, subjectEntity);
        }

        public void AddSubject(string subjectName, int courseId, SubjectEntity subjectEntity)
        {
            var subjectEntity = new SubjectEntity
            {
                Name = subjectName,
                CourseId = courseId
            };

            subjectServices.AddSubject(subjectEntity);
        }

        public List<SubjectDTO> GetSubjectsByCourseId(int courseId)
        {
            return subjectServices.GetSubjectsByCourseId(courseId);
        }
    }
}
