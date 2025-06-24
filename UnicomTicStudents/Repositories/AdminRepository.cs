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
    public class AdminRepository : IAdminRepository
    {
        public void Add(AdminEntity admin)
        {
            using (var connection = DataConfig.GetConnection())
            {
                var query = "INSERT INTO Admins (Name, NIC, Username, Password) VALUES (@Name, @NIC, @Username, @Password)";
                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Name", admin.Name);
                    cmd.Parameters.AddWithValue("@NIC", admin.NIC);
                    cmd.Parameters.AddWithValue("@Username", admin.Username);
                    cmd.Parameters.AddWithValue("@Password", admin.Password);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Update(AdminEntity admin)
        {
            using (var connection = DataConfig.GetConnection())
            {
                var query = "UPDATE Admins SET Name = @Name, NIC = @NIC, Username = @Username, Password = @Password WHERE Id = @Id";
                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Name", admin.Name);
                    cmd.Parameters.AddWithValue("@NIC", admin.NIC);
                    cmd.Parameters.AddWithValue("@Username", admin.Username);
                    cmd.Parameters.AddWithValue("@Password", admin.Password);
                    cmd.Parameters.AddWithValue("@Id", admin.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int id)
        {
            using (var connection = DataConfig.GetConnection())
            {
                var query = "DELETE FROM Admins WHERE Id = @Id";
                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<AdminEntity> GetAll()
        {
            var list = new List<AdminEntity>();
            using (var connection = DataConfig.GetConnection())
            {
                var query = "SELECT * FROM Admins";
                using (var cmd = new SQLiteCommand(query, connection))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new AdminEntity
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString(),
                            NIC = reader["NIC"].ToString(),
                            Username = reader["Username"].ToString(),
                            Password = reader["Password"].ToString()
                        });
                    }
                }
            }
            return list;
        }
        public bool IsUserExist(string nic, string fullName)
        {
            using (var conn = DataConfig.GetConnection())
            {
                var query = "SELECT COUNT(*) FROM Admins WHERE NIC = @NIC AND FullName = @FullName";
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@NIC", nic);
                cmd.Parameters.AddWithValue("@FullName", fullName);
                var count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        public void RegisterAdmin(AdminEntity admin)
        {
            using (var conn = DataConfig.GetConnection())
            {
               
                var query = "INSERT INTO Admins (FullName, NIC, IndexNumber, UserName, Password) VALUES (@FullName, @NIC, @IndexNumber, @UserName, @Password)";
                using (var cmd = new SQLiteCommand(query, conn)) 
                {
                    cmd.Parameters.AddWithValue("@FullName", admin.Name);
                    cmd.Parameters.AddWithValue("@NIC", admin.NIC);
                    cmd.Parameters.AddWithValue("@UserName", admin.Username);
                    cmd.Parameters.AddWithValue("@Password", admin.Password);
                    cmd.ExecuteNonQuery();
                }
                  
            }
        }
    }


}

