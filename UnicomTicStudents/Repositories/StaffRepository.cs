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
    public  class StaffRepository : IStaffRepository
    {
        public void Add(StaffEntity staff)
        {
            using (var connection = DataConfig.GetConnection())
            {
                var query = "INSERT INTO Staff (Name, NIC, Username, Password, Work) VALUES (@Name, @NIC, @Username, @Password, @Work)";
                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Name", staff.Name);
                    cmd.Parameters.AddWithValue("@NIC", staff.NIC);
                    cmd.Parameters.AddWithValue("@WorkId", staff.Work);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Update(StaffEntity staff)
        {
            using (var connection = DataConfig.GetConnection())
            {
                var query = "UPDATE Staff SET Name = @Name, NIC = @NIC, Username = @Username, Password = @Password, Work = @Work WHERE Id = @Id";
                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Name", staff.Name);
                    cmd.Parameters.AddWithValue("@NIC", staff.NIC);
                    cmd.Parameters.AddWithValue("@Work", staff.Work);
                    cmd.Parameters.AddWithValue("@Id", staff.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int id)
        {
            using (var connection = DataConfig.GetConnection())
            {
                var query = "DELETE FROM Staff WHERE Id = @Id";
                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<StaffEntity> GetAll()
        {
            var list = new List<StaffEntity>();
            using (var connection = DataConfig.GetConnection())
            {
                var query = "SELECT * FROM Staff";
                using (var cmd = new SQLiteCommand(query, connection))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new StaffEntity
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString(),
                            NIC = reader["NIC"].ToString(),
                            Username = reader["Username"].ToString(),
                            Password = reader["Password"].ToString(),
                            Work = reader["Work"].ToString()
                        });
                    }
                }
            }
            return list;
        }
    }

}
