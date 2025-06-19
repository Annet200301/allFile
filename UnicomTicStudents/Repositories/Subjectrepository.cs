using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicStudents.Datas;
using UnicomTicStudents.Models;
using UnicomTicStudents.Models.DTOs;
using UnicomTicStudents.Repositories.Irepository;

namespace UnicomTicStudents.Repositories
{
    internal class Subjectrepository : ISubjectRepository
    {
        public void AddSubject(SubjectEntity subject)
        {
            using (var connection = DataConfig.GetConnection())
            {
                var query = "INSERT INTO Subjects (Name, CourseId) VALUES (@Name, @CourseId)";
                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Name", subject.Name);
                    cmd.Parameters.AddWithValue("@CourseId", subject.CourseId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<SubjectDTO> GetSubjectsByCourseId(int courseId)
        {
            var subjects = new List<SubjectDTO>();
            using (var connection = DataConfig.GetConnection())
            {
                var query = "SELECT Id, Name FROM Subjects WHERE CourseId = @CourseId";
                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@CourseId", courseId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            subjects.Add(new SubjectDTO
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1)
                            });
                        }
                    }
                }
            }
            return subjects;
        }
    }
}
