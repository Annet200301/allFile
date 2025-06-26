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
        public static UserDTO ToDTO(UsersEntity entity)
        {
            if (entity == null) return null;

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

        public static UsersEntity ToEntity(UserDTO dto)
        {
            if (dto == null) return null;

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

        public static List<UserDTO> ToDTOList(List<UsersEntity> entities)
        {
            return entities?.Select(e => ToDTO(e)).ToList();
        }

        public static List<UsersEntity> ToEntityList(List<UserDTO> dtos)
        {
            return dtos?.Select(d => ToEntity(d)).ToList();
        }
    }
}
