using ADMIN.Enums;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicStudents.Datas;
using UnicomTicStudents.Models;
using UnicomTicStudents.Repositories.Irepository;

namespace UnicomTicStudents.Repositories
{
    public  class UserRepository : IUserRepository
    {

        public void AddUser(UsersEntity user)
        {
            using (var conn = DataConfig.GetConnection())
            {
                conn.Open();
                var query = "INSERT INTO Users (NIC, Name, IndexNumber, Username, Password, Role) VALUES (@nic, @name, @index, @username, @password, @role)";
                using (var cmd = new SQLiteCommand(query, conn)) 
                {
                    cmd.Parameters.AddWithValue("@nic", user.NIC);
                    cmd.Parameters.AddWithValue("@name", user.Name);
                    cmd.Parameters.AddWithValue("@index", user.IndexNumber);
                    cmd.Parameters.AddWithValue("@username", user.Username ?? "");
                    cmd.Parameters.AddWithValue("@password", user.Password ?? "");
                    cmd.Parameters.AddWithValue("@role", user.Role.ToString());
                    cmd.ExecuteNonQuery();
                }
                   
            }
                
        }

        public void UpdateUser(UsersEntity user)
        {
            using (var conn = DataConfig.GetConnection())
            {
                conn.Open();
                var query = "UPDATE Users SET NIC=@nic, Name=@name, IndexNumber=@index, Username=@username, Password=@password, Role=@role WHERE Id=@id";
                using (var cmd = new SQLiteCommand(query, conn))
                {

                    cmd.Parameters.AddWithValue("@nic", user.NIC);
                    cmd.Parameters.AddWithValue("@name", user.Name);
                    cmd.Parameters.AddWithValue("@index", user.IndexNumber);
                    cmd.Parameters.AddWithValue("@username", user.Username ?? "");
                    cmd.Parameters.AddWithValue("@password", user.Password ?? "");
                    cmd.Parameters.AddWithValue("@role", user.Role.ToString());
                    cmd.Parameters.AddWithValue("@id", user.Id);
                    cmd.ExecuteNonQuery();
                }
            }
               
        }
        public void DeleteUser(int id)
        {
            using (var conn = DataConfig.GetConnection())
            {
                conn.Open();
                var query = "DELETE FROM Users WHERE Id = @id";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
               
            }
               
        }

        public UsersEntity GetById(int id)
        {
            using (var conn = DataConfig.GetConnection())
            {               
                var query = "SELECT * FROM Users WHERE Id = @id";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) return ReadUser(reader);
                        return null;
                    }
                        
                }
                    
            }
        }

        public UsersEntity GetByNICAndName(string nic, string name)
        {
            using (var conn = DataConfig.GetConnection())
            {
                
                var query = "SELECT * FROM Users WHERE NIC = @nic AND Name = @name";
                using (var cmd = new SQLiteCommand(query, conn))
                {

                    cmd.Parameters.AddWithValue("@nic", nic);
                    cmd.Parameters.AddWithValue("@name", name);
                    using (var reader = cmd.ExecuteReader())
                    {

                        if (reader.Read()) return ReadUser(reader);
                        return null;
                    }
                }
            }
                
        }

        public UsersEntity GetByUsernameAndPassword(string username, string password)
        {
            using (var conn = DataConfig.GetConnection())
            {

               
                var query = "SELECT * FROM Users WHERE Username = @username AND Password = @password";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) return ReadUser(reader);
                        return null;
                    }
                     
                }
                  
            }
        }

        public List<UsersEntity> GetAllUsers()
        {
            var users = new List<UsersEntity>();
            using (var conn = DataConfig.GetConnection())
            {              
                var query = "SELECT * FROM Users";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read()) users.Add(ReadUser(reader));
                        return users;
                    }
                       
                }
                   
            }
               
        }

        private UsersEntity ReadUser(SQLiteDataReader reader)
        {
            return new UsersEntity
            {
                Id = Convert.ToInt32(reader["Id"]),
                NIC = reader["NIC"].ToString(),
                Name = reader["Name"].ToString(),
                IndexNumber = reader["IndexNumber"].ToString(),
                Username = reader["Username"].ToString(),
                Password = reader["Password"].ToString(),
                Role = (UserRoles)Enum.Parse(typeof(UserRoles), reader["Role"].ToString())
            };
        }

        public List<UsersEntity> GetAll()
        {
            var list = new List<UsersEntity>();
            using (var conn = DataConfig.GetConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Users";
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(Map(reader));
                        }
                    }
                }
            }
            return list;
        }

        private UsersEntity Map(SQLiteDataReader reader)
        {
            return new UsersEntity
            {
                Id = Convert.ToInt32(reader["Id"]),
                NIC = reader["NIC"].ToString(),
                Name = reader["Name"].ToString(),
                IndexNumber = reader["IndexNumber"].ToString(),
                Username = reader["Username"].ToString(),
                Password = reader["Password"].ToString(),
                Role = (UserRoles)Enum.Parse(typeof(UserRoles), reader["Role"].ToString())
            };
        }
    }
}
