using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicStudents.Models;

namespace UnicomTicStudents.Repositories.Interfaces
{
    public  interface IRoomRepository
    {
        void AddRoom(RoomEntity room);
        void UpdateRoom(RoomEntity room);
        void DeleteRoom(int roomId);
        RoomEntity GetRoomById(int roomId);
        List<RoomEntity> GetAllRooms();
    }
}
