using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicStudents.Models.DTOs;

namespace UnicomTicStudents.Services.Iservices
{
    public  interface IAdminService
    {
        void AddAdmin(AdminDTO dto);
        void UpdateAdmin(AdminDTO dto);
        void DeleteAdmin(int id);
        List<AdminDTO> GetAllAdmins();
    }
}
