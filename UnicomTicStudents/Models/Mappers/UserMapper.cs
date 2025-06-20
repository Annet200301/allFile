using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicStudents.Models.DTOs;

namespace UnicomTicStudents.Models.Mappers
{
    internal class UserMapper
    {
        public static UsersEntity ToEntity(UserDTO dto)
        {
            return new UsersEntity
            {
                Id = dto.Id,
                NIC = dto.NIC,
                Name = dto.Name,
                IndexNumber = dto.IndexNumber,
                Username = dto.Username,
                Password = dto.Password,
                Role = dto.Role
            };
        }

        public static UserDTO ToDTO(UsersEntity entity)
        {
            return new UserDTO
            {
                Id = entity.Id,
                NIC = entity.NIC,
                Name = entity.Name,
                IndexNumber = entity.IndexNumber,
                Username = entity.Username,
                Password = entity.Password,
                Role = entity.Role
            };
        }
    }
}
