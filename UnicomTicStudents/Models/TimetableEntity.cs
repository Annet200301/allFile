using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTicStudents.Models
{
    internal class TimetableEntity
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string DayOfWeek { get; set; } 
        public string StartTime { get; set; } 
        public string EndTime { get; set; } 
        public string Room { get; set; }
        public string Teacher { get; set; }
    }
}
