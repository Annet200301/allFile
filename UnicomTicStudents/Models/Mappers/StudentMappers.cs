using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicStudents.Models.DTOs;

namespace UnicomTicStudents.Models.Mappers
{
     public  class StudentMappers
     {
        public static StudentDTO ToDTO(StudentEntity entity)
        {
            return new StudentDTO
            {
                Id = entity.Id,
                Name = entity.Name,
                NIC = entity.NIC,
                Username = entity.Username,
                Password = entity.Password,
                CourseId = entity.CourseId
            };
        }

        public static StudentEntity ToEntity(StudentDTO dto)
        {
            return new StudentEntity
            {
                Id = dto.Id,
                Name = dto.Name,
                NIC = dto.NIC,
                Username = dto.Username,
                Password = dto.Password,
                CourseId = dto.CourseId
            };
        }
    }
}
