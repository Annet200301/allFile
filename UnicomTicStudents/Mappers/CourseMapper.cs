using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicStudents.Course;
using static UnicomTicStudents.Course.CourseDTO;
using static UnicomTicStudents.Course.CourseEnum;

namespace UnicomTicStudents.Utilities
{
    internal class CourseMapper
    {
        public static CourseDTO ToDTO(CourseEntity entity)
        {
            return new CourseDTO
            {
                Id = entity.Id,
                Name = entity.Name
            };
        }

        public static CourseEntity ToEntity(CourseDTO dto)
        {
            return new CourseEntity
            {
                Id = dto.Id,
                Name = dto.Name
            };
        }


    }
}
