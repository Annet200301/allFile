using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicStudents.Models.DTOs;

namespace UnicomTicStudents.Models.Mappers
{
    internal class AdminMapper
    {
        public static AdminDTO ToDTO(AdminEntity entity)
        {
            return new AdminDTO
            {
                Id = entity.Id,
                Name = entity.Name,
                NIC = entity.NIC,
                Username = entity.Username,
                Password = entity.Password,
            };
        }

        public static AdminEntity ToEntity(AdminDTO dto)
        {
            return new AdminEntity
            {
                Id = dto.Id,
                Name = dto.Name,
                NIC = dto.NIC,
                Username = dto.Username,
                Password = dto.Password
            };
        }
    }
}
