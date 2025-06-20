using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicStudents.Models.DTOs;

namespace UnicomTicStudents.Services.Iservices
{
    internal class IsubjectServices
    {
        void AddSubject(SubjectDTO dto);
        void UpdateSubject(SubjectDTO dto);
        void DeleteSubject(int id);
        List<SubjectDTO> GetSubjectsByCourseId(int courseId);
    }
}
