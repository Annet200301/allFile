using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicStudents.Models.DTOs;

namespace UnicomTicStudents.Services.IServices
{
<<<<<<< HEAD
    public  interface IsubjectServices
=======
    public interface ISubjectServices
>>>>>>> aaf16da70d44d4987a8c27562a13b683e3b478f6
    {
        void AddSubject(SubjectDTO dto);
        void UpdateSubject(SubjectDTO dto);
        void DeleteSubject(int id);
        List<SubjectDTO> GetSubjectsByCourseId(int courseId);
<<<<<<< HEAD
        List<SubjectDTO> GetAllSubjects();
=======
>>>>>>> aaf16da70d44d4987a8c27562a13b683e3b478f6
    }
}