using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicStudents.Course;

namespace UnicomTicStudents.Services
{
    internal interface ICourseService
    {      
        void AddCourse(CourseDTO dto);
        void UpdateCourse(CourseDTO dto);
        void DeleteCourse(int id);
        List<CourseDTO> GetAllCourses();
        CourseDTO GetCourseById(int id);        
    }
}
