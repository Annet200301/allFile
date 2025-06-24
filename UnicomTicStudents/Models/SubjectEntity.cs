using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTicStudents.Models
{
    public  class SubjectEntity
    {
        public int Id { get; set; }         
        public string Name { get; set; }   
        public int CourseId { get; set; }
    }
}
