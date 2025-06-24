using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTicStudents.Models.DTOs
{
    public  class LecturerDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NIC { get; set; }
        public string IndexNumber { get; set; }
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
    }
}
