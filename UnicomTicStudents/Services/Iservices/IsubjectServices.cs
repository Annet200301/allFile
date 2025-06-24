using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicStudents.Models.DTOs;

namespace UnicomTicStudents.Services.IServices
{
    public  interface IsubjectServices
    {
        void AddSubject(SubjectDTO dto);
        void UpdateSubject(SubjectDTO dto);
        void DeleteSubject(int id);
        List<SubjectDTO> GetSubjectsByCourseId(int courseId);
        List<SubjectDTO> GetAllSubjects();
    }
}