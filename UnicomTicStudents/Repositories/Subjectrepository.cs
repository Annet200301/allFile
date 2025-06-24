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

        public void UpdateSubject(SubjectEntity subject)
        {
            using (var connection = DataConfig.GetConnection())
            {
                var query = "UPDATE Subjects SET Name = @Name, CourseId = @CourseId WHERE Id = @Id";
                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Name", subject.Name);
                    cmd.Parameters.AddWithValue("@CourseId", subject.CourseId);
                    cmd.Parameters.AddWithValue("@Id", subject.Id);
                    cmd.ExecuteNonQuery();
                }
            }
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
            var subjects = new List<SubjectDTO>();
            using (var connection = DataConfig.GetConnection())
            {
                var query = "SELECT s.Id, s.Name, c.Name AS CourseName FROM Subjects s INNER JOIN Courses c ON s.CourseId = c.Id WHERE s.CourseId = @CourseId";
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
                                Name = reader.GetString(1),
                                CourseName = reader.GetString(2), 
                                CourseId = courseId
                            });
                        }
                    }
                }
            }
            return subjects;
        }
        public List<SubjectDTO> GetAllSubjects()
        {
            var subjects = new List<SubjectDTO>();

            using (var connection = DataConfig.GetConnection())
            {
                var query = "SELECT s.Id, s.Name, c.Name AS CourseName FROM Subjects s INNER JOIN Courses c ON s.CourseId = c.Id";
                using (var cmd = new SQLiteCommand(query, connection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            subjects.Add(new SubjectDTO
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                CourseName = reader.GetString(2),
                                CourseId = 0  
                            });
                        }
                    }
                }
            }

            return subjects;
        }
    }
}
