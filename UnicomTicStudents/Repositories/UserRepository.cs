using ADMIN.Enums;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicStudents.Models;
using UnicomTicStudents.Repositories.Irepository;

namespace UnicomTicStudents.Repositories
{
    internal class UserRepository : IUserRepository
    {
        private readonly SQLiteConnection _connection;

        public UserRepository(string connectionString)
        {
            _connection = new SQLiteConnection(connectionString);
            _connection.Open();
        }

        public void Add(UsersEntity user)
        {
            using (var cmd = _connection.CreateCommand())
            {
                cmd.CommandText = "INSERT INTO Users (NIC, Name, IndexNumber, Username, Password, Role) VALUES (@nic, @name, @index, @username, @password, @role)";
                cmd.Parameters.AddWithValue("@nic", user.NIC);
                cmd.Parameters.AddWithValue("@name", user.Name);
                cmd.Parameters.AddWithValue("@index", user.IndexNumber);
                cmd.Parameters.AddWithValue("@username", user.Username ?? "");
                cmd.Parameters.AddWithValue("@password", user.Password ?? "");
                cmd.Parameters.AddWithValue("@role", user.Role.ToString());
                cmd.ExecuteNonQuery();
            }

        }

        public void Update(UsersEntity user)
        {
            using (var cmd = _connection.CreateCommand())
            {

                cmd.CommandText = "UPDATE Users SET Username = @username, Password = @password WHERE NIC = @nic AND Name = @name";
                cmd.Parameters.AddWithValue("@username", user.Username);
                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.Parameters.AddWithValue("@nic", user.NIC);
                cmd.Parameters.AddWithValue("@name", user.Name);
                cmd.ExecuteNonQuery();
            }
        }

        public UsersEntity GetByNICAndName(string nic, string name)
        {
            using (var cmd = _connection.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM Users WHERE NIC = @nic AND Name = @name";
                cmd.Parameters.AddWithValue("@nic", nic);
                cmd.Parameters.AddWithValue("@name", name);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read()) return Map(reader);
                    return null;
                }

            }

        }

        public UsersEntity GetByUsernameAndPassword(string username, string password)
        {
            using (var cmd = _connection.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM Users WHERE Username = @username AND Password = @password";
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                using (var reader = cmd.ExecuteReader())
                {

                    if (reader.Read()) return Map(reader);
                    return null;
                }
            }

        }

        public List<UsersEntity> GetAll()
        {
            var list = new List<UsersEntity>();
            using (var cmd = _connection.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM Users";
                using (var reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        list.Add(Map(reader));
                    }
                    return list;
                }
            }

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
