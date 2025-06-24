using System;
using System.Collections.Generic;
using System.Data.SQLite;
using UnicomTicStudents.Datas;
using UnicomTicStudents.Models;
using UnicomTicStudents.Repositories.Interfaces;

namespace UnicomTicStudents.Repositories
{
   public class RoomRepository : IRoomRepository
    {
        public void AddRoom(RoomEntity room)
        {
            if (room == null)
                throw new ArgumentNullException(nameof(room));

            using (var conn = DataConfig.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO Rooms (RoomName) VALUES (@RoomName)";
                cmd.Parameters.AddWithValue("@RoomName", room.RoomName);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateRoom(RoomEntity room)
        {
            if (room == null)
                throw new ArgumentNullException(nameof(room));

            using (var conn = DataConfig.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE Rooms SET RoomName = @RoomName WHERE RoomID = @RoomID";
                cmd.Parameters.AddWithValue("@RoomID", room.RoomID);
                cmd.Parameters.AddWithValue("@RoomName", room.RoomName);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteRoom(int roomId)
        {
            using (var conn = DataConfig.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM Rooms WHERE RoomID = @RoomID";
                cmd.Parameters.AddWithValue("@RoomID", roomId);
                cmd.ExecuteNonQuery();
            }
        }

        public RoomEntity GetRoomById(int roomId)
        {
            using (var conn = DataConfig.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT RoomID, RoomName FROM Rooms WHERE RoomID = @RoomID";
                cmd.Parameters.AddWithValue("@RoomID", roomId);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new RoomEntity
                        {
                            RoomID = reader.GetInt32(0),
                            RoomName = reader.GetString(1)
                        };
                    }
                    return null;
                }
            }
        }

        public List<RoomEntity> GetAllRooms()
        {
            var rooms = new List<RoomEntity>();

            using (var conn = DataConfig.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT RoomID, RoomName FROM Rooms";

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        rooms.Add(new RoomEntity
                        {
                            RoomID = reader.GetInt32(0),
                            RoomName = reader.GetString(1)
                        });
                    }
                }
            }

            return rooms;
        }
    }
}
