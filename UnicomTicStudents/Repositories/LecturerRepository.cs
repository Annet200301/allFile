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
    public  class LecturerRepository : ILecturerRepository
    {
        public void Add(LecturerEntity lecturer)
        {
            using (var conn = DataConfig.GetConnection())
            {

                var query = "INSERT INTO Lecturers (Name, NIC, IndexNumber, SubjectId) VALUES (@Name, @NIC, @IndexNumber, @SubjectId)";
                using (var cmd = new SQLiteCommand(query, conn)) 
                {
                    cmd.Parameters.AddWithValue("@Name", lecturer.Name);
                    cmd.Parameters.AddWithValue("@NIC", lecturer.NIC);
                    cmd.Parameters.AddWithValue("@IndexNumber", lecturer.IndexNumber);
                    cmd.Parameters.AddWithValue("@SubjectId", lecturer.SubjectId);
                    cmd.ExecuteNonQuery();
                }
                 
            }
        }

        public void Update(LecturerEntity lecturer)
        {
            using (var conn = DataConfig.GetConnection())
            {
                var query = "UPDATE Lecturers SET Name = @Name, NIC = @NIC, IndexNumber = @IndexNumber, SubjectId = @SubjectId WHERE Id = @Id";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", lecturer.Name);
                    cmd.Parameters.AddWithValue("@NIC", lecturer.NIC);
                    cmd.Parameters.AddWithValue("@IndexNumber", lecturer.IndexNumber);
                    cmd.Parameters.AddWithValue("@SubjectId", lecturer.SubjectId);
                    cmd.Parameters.AddWithValue("@Id", lecturer.Id);
                    cmd.ExecuteNonQuery();
                }
                  
            }
                
        }

        public void Delete(int id)
        {
            using (var conn = DataConfig.GetConnection())
            {

                var query = "DELETE FROM Lecturers WHERE Id = @Id";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
                  
            }
        }

        public List<LecturerDTO> GetAll()
        {
            var list = new List<LecturerDTO>();
            using (var conn = DataConfig.GetConnection())
            {

                var query = @"SELECT l.Id, l.Name, l.NIC, l.IndexNumber, l.SubjectId, s.Name AS SubjectName 
                      FROM Lecturers l INNER JOIN Subjects s ON l.SubjectId = s.Id";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader()) 
                    {

                        while (reader.Read())
                        {
                            list.Add(new LecturerDTO
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                NIC = reader.GetString(2),
                                IndexNumber = reader.GetString(3),
                                SubjectId = reader.GetInt32(4),
                                SubjectName = reader.GetString(5)
                            });
                        }
                        return list;
                    }
                }
                   
            }
        }
    }

}

