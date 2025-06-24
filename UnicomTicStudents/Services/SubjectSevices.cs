using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
using UnicomTicStudents.Course;
using UnicomTicStudents.Mappers;
using UnicomTicStudents.Models.DTOs;
using UnicomTicStudents.Repositories;
using UnicomTicStudents.Repositories.Irepository;
using UnicomTicStudents.Services.Iservices;
using UnicomTicStudents.Utilities;

namespace UnicomTicStudents.Services
{
    internal class SubjectSevices: IsubjectServices
    {
        private readonly ISubjectRepository _repository;

        public SubjectSevices(ISubjectRepository repository)
=======
using UnicomTicStudents.Datas;
using UnicomTicStudents.Mappers;
using UnicomTicStudents.Models.DTOs;
using UnicomTicStudents.Repositories.Irepository;
using UnicomTicStudents.Services.Iservices;
using UnicomTicStudents.Services.IServices;

namespace UnicomTicStudents.Services
{
    internal class SubjectSevices: ISubjectServices
    {
        private readonly ISubjectRepository _repository;

        public SubjectServices(ISubjectRepository repository)
>>>>>>> aaf16da70d44d4987a8c27562a13b683e3b478f6
        {
            _repository = repository;
        }

        public void AddSubject(SubjectDTO dto)
        {
            if (string.IsNullOrWhiteSpace(dto.Name))
                throw new ArgumentException("Subject name is required.");
            if (dto.CourseId <= 0)
                throw new ArgumentException("Invalid Course Id.");

            var entity = SubjectMappers.ToEntity(dto);
            _repository.AddSubject(entity);
        }

        public void UpdateSubject(SubjectDTO dto)
        {
            if (dto.Id <= 0)
                throw new ArgumentException("Invalid Subject Id.");
            if (string.IsNullOrWhiteSpace(dto.Name))
                throw new ArgumentException("Subject name is required.");
            if (dto.CourseId <= 0)
                throw new ArgumentException("Invalid Course Id.");

<<<<<<< HEAD
            var entity = SubjectMappers.ToEntity(dto);
            _repository.UpdateSubject(entity);
=======
            DeleteSubject(dto.Id);
            AddSubject(dto);
>>>>>>> aaf16da70d44d4987a8c27562a13b683e3b478f6
        }

        public void DeleteSubject(int id)
        {
<<<<<<< HEAD
            if (id <= 0)
                throw new ArgumentException("Invalid Subject Id.");

            _repository.DeleteSubject(id);
=======
            using (var connection = DataConfig.GetConnection())
            {
                var query = "DELETE FROM Subjects WHERE Id = @Id";
                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
>>>>>>> aaf16da70d44d4987a8c27562a13b683e3b478f6
        }

        public List<SubjectDTO> GetSubjectsByCourseId(int courseId)
        {
            return _repository.GetSubjectsByCourseId(courseId);
        }
<<<<<<< HEAD
        public List<SubjectDTO> GetAllSubjects()
        {
            return _repository.GetAllSubjects(); 
        }
=======
>>>>>>> aaf16da70d44d4987a8c27562a13b683e3b478f6
    }
}
