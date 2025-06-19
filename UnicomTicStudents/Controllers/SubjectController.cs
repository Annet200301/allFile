using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicStudents.Models;
using UnicomTicStudents.Models.DTOs;
using UnicomTicStudents.Repositories.Irepository;

namespace UnicomTicStudents.Controllers
{
    internal class SubjectController
    {
        private readonly ISubjectRepository _subjectRepository;

        public SubjectController(ISubjectRepository subjectRepository)
        {
            _subjectRepository = subjectRepository;
        }

        public void AddSubject(string subjectName, int courseId)
        {
            var subjectEntity = new SubjectEntity
            {
                Name = subjectName,
                CourseId = courseId
            };

            _subjectRepository.AddSubject(subjectEntity);
        }

        public List<SubjectDTO> GetSubjectsByCourseId(int courseId)
        {
            return _subjectRepository.GetSubjectsByCourseId(courseId);
        }
    }
}
