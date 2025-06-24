using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicStudents.Models;
using UnicomTicStudents.Models.DTOs;
using UnicomTicStudents.Repositories.Irepository;
<<<<<<< HEAD
using UnicomTicStudents.Services;
using UnicomTicStudents.Services.Iservices;
=======
using UnicomTicStudents.Services.IServices;
>>>>>>> aaf16da70d44d4987a8c27562a13b683e3b478f6

namespace UnicomTicStudents.Controllers
{
    internal class SubjectController
    {
<<<<<<< HEAD
        private readonly IsubjectServices  _subjectSevices;

        public SubjectController(IsubjectServices subjectSevices)
        {
            _subjectSevices = subjectSevices;
=======
        private readonly ISubjectServices subjectServices;

        public SubjectController(ISubjectServices _subjectServices)
        {
            subjectServices = _subjectServices; 
>>>>>>> aaf16da70d44d4987a8c27562a13b683e3b478f6
        }

        public void AddSubject(string subjectName, int courseId)
        {
<<<<<<< HEAD
            var subjectDTO = new SubjectDTO
=======
            AddSubject(subjectName, courseId, subjectEntity);
        }

        public void AddSubject(string subjectName, int courseId, SubjectEntity subjectEntity)
        {
            var subjectEntity = new SubjectEntity
>>>>>>> aaf16da70d44d4987a8c27562a13b683e3b478f6
            {
                Name = subjectName,
                CourseId = courseId
            };

<<<<<<< HEAD
            _subjectSevices.AddSubject(subjectDTO);  
=======
            subjectServices.AddSubject(subjectEntity);
>>>>>>> aaf16da70d44d4987a8c27562a13b683e3b478f6
        }

        public List<SubjectDTO> GetSubjectsByCourseId(int courseId)
        {
<<<<<<< HEAD
            return _subjectSevices.GetSubjectsByCourseId(courseId);
=======
            return subjectServices.GetSubjectsByCourseId(courseId);
>>>>>>> aaf16da70d44d4987a8c27562a13b683e3b478f6
        }
    }
}
