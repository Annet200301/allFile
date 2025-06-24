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
    public class StudntRepository : IStudentRepository
    {
        public void Add(StudentEntity student)
        {
            using (var connection = DataConfig.GetConnection())
            {
                var query = "INSERT INTO Students (Name, NIC, Username, Password, CourseId) VALUES (@Name, @NIC, @Username, @Password, @CourseId)";
                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Name", student.Name);
                    cmd.Parameters.AddWithValue("@NIC", student.NIC);
                    cmd.Parameters.AddWithValue("@Username", student.Username);
                    cmd.Parameters.AddWithValue("@Password", student.Password);
                    cmd.Parameters.AddWithValue("@CourseId", student.CourseId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Update(StudentEntity student)
        {
            using (var connection = DataConfig.GetConnection())
            {
                var query = "UPDATE Students SET Name = @Name, NIC = @NIC, Username = @Username, Password = @Password, CourseId = @CourseId WHERE Id = @Id";
                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Name", student.Name);
                    cmd.Parameters.AddWithValue("@NIC", student.NIC);
                    cmd.Parameters.AddWithValue("@Username", student.Username);
                    cmd.Parameters.AddWithValue("@Password", student.Password);
                    cmd.Parameters.AddWithValue("@CourseId", student.CourseId);
                    cmd.Parameters.AddWithValue("@Id", student.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int id)
        {
            using (var connection = DataConfig.GetConnection())
            {
                var query = "DELETE FROM Students WHERE Id = @Id";
                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<StudentEntity> GetAll()
        {
            var list = new List<StudentEntity>();
            using (var connection = DataConfig.GetConnection())
            {
                var query = "SELECT * FROM Students";
                using (var cmd = new SQLiteCommand(query, connection))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new StudentEntity
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString(),
                            NIC = reader["NIC"].ToString(),
                            Username = reader["Username"].ToString(),
                            Password = reader["Password"].ToString(),
                            CourseId = Convert.ToInt32(reader["CourseId"])
                        });
                    }
                }
            }
            return list;
        }
    }
}