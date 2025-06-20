using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicStudents.Datas;
using UnicomTicStudents.Mappers;
using UnicomTicStudents.Models.DTOs;
using UnicomTicStudents.Repositories.Irepository;
using UnicomTicStudents.Services.Iservices;

namespace UnicomTicStudents.Services
{
    internal class SubjectSevices: IsubjectServices
    {
        private readonly ISubjectRepository _repository;

        public SubjectServices(ISubjectRepository repository)
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

            DeleteSubject(dto.Id);
            AddSubject(dto);
        }

        public void DeleteSubject(int id)
        {
            using (var connection = DataConfig.GetConnection())
            {
                var query = "DELETE FROM Subjects WHERE Id = @Id";
                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<SubjectDTO> GetSubjectsByCourseId(int courseId)
        {
            return _repository.GetSubjectsByCourseId(courseId);
        }
    }
}
