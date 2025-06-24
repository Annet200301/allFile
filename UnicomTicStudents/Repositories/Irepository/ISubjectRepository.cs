using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicStudents.Models;
using UnicomTicStudents.Models.DTOs;

namespace UnicomTicStudents.Repositories.Irepository
{
    public interface ISubjectRepository
    {
        void AddSubject(SubjectEntity subject);
        void UpdateSubject(SubjectEntity subject);
        void DeleteSubject(int id);
        List<SubjectDTO> GetSubjectsByCourseId(int courseId);
        List<SubjectDTO> GetAllSubjects();
    }
}
