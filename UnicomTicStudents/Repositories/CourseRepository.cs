using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicStudents.Datas;
using UnicomTicStudents.Repositories;
using static UnicomTicStudents.Course.CourseEnum;

namespace UnicomTicStudents.Course
{
    internal class CourseRepository: ICourseRepository
    {      
        public CourseRepository()
        {
            using (var connection = DataConfig.GetConnection())
            {              
                string query = "CREATE TABLE IF NOT EXISTS Courses (Id INTEGER PRIMARY KEY AUTOINCREMENT, Name TEXT NOT NULL)";
                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Add(CourseEntity course)
        {
            using (var connection = DataConfig.GetConnection())
            {                
                var query = "INSERT INTO Courses (Name) VALUES (@Name)";
                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Name", course.Name);
                    cmd.ExecuteNonQuery();
                }
                    };
        }

        public void Update(CourseEntity course)
        {
            using (var connection = DataConfig.GetConnection())
            {           
                var query = "UPDATE Courses SET Name = @Name WHERE Id = @Id";
                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Name", course.Name);
                    cmd.Parameters.AddWithValue("@Id", course.Id);
                    cmd.ExecuteNonQuery();
                }
                   
            }
           
        }

        public void Delete(int id)
        {
            using (var connection = DataConfig.GetConnection())
            {
                var query = "DELETE FROM Courses WHERE Id = @Id";
                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
                  
            }
               
        }

        public CourseEntity GetById(int id)
        {
            using (var connection = DataConfig.GetConnection())
            {            
                var query = "SELECT * FROM Courses WHERE Id = @Id";
                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    using (var reader = cmd.ExecuteReader())
                    {

                        if (reader.Read())
                        {
                            return new CourseEntity
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Name = reader["Name"].ToString()
                            };
                        }
                        return null;
                    }
                }
                 
            }
        }

        public List<CourseEntity> GetAll()
        {
            var courses = new List<CourseEntity>();
            using (var connection = DataConfig.GetConnection())
            {                
                var query = "SELECT * FROM Courses";
                using (var cmd = new SQLiteCommand(query, connection))
                {

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            courses.Add(new CourseEntity
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Name = reader["Name"].ToString()
                            });
                        }
                        return courses;
                    }
                       
                }
            }
        }
    }



}
