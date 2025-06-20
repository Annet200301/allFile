using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicStudents.Models;
using UnicomTicStudents.Models.DTOs;

namespace UnicomTicStudents.Mappers
{
    internal class SubjectMappers
    {
        public static SubjectDTO ToDTO(SubjectEntity entity)
        {
            return new SubjectDTO
            {
                Id = entity.Id,
                Name = entity.Name,
                CourseId = entity.CourseId
            };
        }

        public static SubjectEntity ToEntity(SubjectDTO dto)
        {
            return new SubjectEntity
            {
                Id = dto.Id,
                Name = dto.Name,
                CourseId = dto.CourseId
            };
        }
    }
}
