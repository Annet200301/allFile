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
        public static UsersEntity ToEntity(UserDTO dto) => new UsersEntity
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

        public static UserDTO ToDTO(UsersEntity entity) => new UserDTO
        {
<<<<<<< HEAD
            return new UserDTO
            {
                Id = entity.Id,
                NIC = entity.NIC,
                Name = entity.Name,
                IndexNumber = entity.IndexNumber,              
                Role = entity.Role
            };
        }
=======
            Id = entity.Id,
            NIC = entity.NIC,
            Name = entity.Name,
            IndexNumber = entity.IndexNumber,
            Username = entity.Username,
            Password = entity.Password,
            Role = entity.Role
        };
    
>>>>>>> aaf16da70d44d4987a8c27562a13b683e3b478f6
    }
}
