using System.Collections.Generic;
using System.Linq;
using UnicomTicStudents.Models;
using UnicomTicStudents.Models.DTOs;

namespace UnicomTicStudents.Utilities
{
    public  static class RoomMapper
    {
        public static RoomDTO ToDTO(RoomEntity room)
        {
            if (room == null) return null;

            return new RoomDTO
            {
                RoomID = room.RoomID,
                RoomName = room.RoomName
            };
        }

        public static RoomEntity ToEntity(RoomDTO roomDTO)
        {
            if (roomDTO == null) return null;

            return new RoomEntity
            {
                RoomID = roomDTO.RoomID,
                RoomName = roomDTO.RoomName
            };
        }

        public static List<RoomDTO> ToDTOList(IEnumerable<RoomEntity> rooms)
        {
            return rooms?.Select(ToDTO).ToList() ?? new List<RoomDTO>();
        }

        public static List<RoomEntity> ToEntityList(IEnumerable<RoomDTO> roomDTOs)
        {
            return roomDTOs?.Select(ToEntity).ToList() ?? new List<RoomEntity>();
        }
    }
}
