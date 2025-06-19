using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicStudents.Models;
using UnicomTicStudents.Models.DTOs;

namespace UnicomTicStudents.Repositories.Irepository
{
    internal interface ISubjectRepository
    {
        void AddSubject(SubjectEntity subject);
        List<SubjectDTO> GetSubjectsByCourseId(int courseId);
    }
}
