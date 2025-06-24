using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicStudents.Models.DTOs;

namespace UnicomTicStudents.Models.Mappers
{
    public static  class LecturerMapper
    {
        public static LecturerEntity ToEntity(LecturerDTO dto)
        {
            return new LecturerEntity
            {
                Id = dto.Id,
                Name = dto.Name,
                NIC = dto.NIC,
                IndexNumber = dto.IndexNumber,
                SubjectId = dto.SubjectId
            };
        }

        public static LecturerDTO ToDTO(LecturerEntity entity, string subjectName)
        {
            return new LecturerDTO
            {
                Id = entity.Id,
                Name = entity.Name,
                NIC = entity.NIC,
                IndexNumber = entity.IndexNumber,
                SubjectId = entity.SubjectId,
                SubjectName = subjectName
            };
        }
    }
}
