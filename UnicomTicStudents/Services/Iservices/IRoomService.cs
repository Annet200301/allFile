using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicStudents.Models.DTOs;

namespace UnicomTicStudents.Services.Interfaces
{
  public  interface IRoomService
    {
        void AddRoom(RoomDTO roomDTO);
        void UpdateRoom(RoomDTO roomDTO);
        void DeleteRoom(int roomId);
        RoomDTO GetRoomById(int roomId);
        List<RoomDTO> GetAllRooms();

    }
}
