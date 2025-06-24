using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicStudents.Models.DTOs;

namespace UnicomTicStudents.Services.Iservices
{
    public  interface IStaffService
    {
        void AddStaff(StaffDTO dto);
        void UpdateStaff(StaffDTO dto);
        void DeleteStaff(int id);
        List<StaffDTO> GetAllStaff();
    }
}
