using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicStudents.Models.DTOs;

namespace UnicomTicStudents.Models.Mappers
{
    public class UserMapper
    {
        public  UsersEntity ToEntity(UserDTO dto)
        {
            return new UsersEntity
            {
                Id = dto.Id,
                NIC = dto.NIC,
                Name = dto.Name,
                IndexNumber = dto.IndexNumber,
                Role = dto.Role
            };
        }

        public  UserDTO ToDTO(UsersEntity entity) 
        {
            return new UserDTO
            {
                Id = entity.Id,
                NIC = entity.NIC,
                Name = entity.Name,
                IndexNumber = entity.IndexNumber,
                Role = entity.Role
            };
        }
    }
}
