using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicStudents.Models.DTOs;

namespace UnicomTicStudents.Models.Mappers
{
    internal class StaffMappers
    {
        public static StaffDTO ToDTO(StaffEntity entity)
        {
            return new StaffDTO
            {
                Id = entity.Id,
                Name = entity.Name,
                NIC = entity.NIC,
                Username = entity.Username,
                Password = entity.Password,
                Work = entity.Work
            };
        }

        public static StaffEntity ToEntity(StaffDTO dto)
        {
            return new StaffEntity
            {
                Id = dto.Id,
                Name = dto.Name,
                NIC = dto.NIC,
                Username = dto.Username,
                Password = dto.Password,
                Work = dto.Work
            };
        }
    }
}
