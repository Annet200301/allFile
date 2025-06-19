using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicStudents.Course;

namespace UnicomTicStudents.Repositories
{
    public interface ICourseRepository
    {
        void Add(CourseEntity course);
        void Update(CourseEntity course);
        void Delete(int id);
        CourseEntity GetById(int id);
        List<CourseEntity> GetAll();
    }
}
