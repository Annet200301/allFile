using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicStudents.Models.DTOs;
using UnicomTicStudents.Services.Iservices;

namespace UnicomTicStudents.Controllers
{
    public class AdminController
    {
        private readonly IAdminService _adminService;

        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }

        public void Add(string name, string nic)
        {
            var dto = new AdminDTO
            {
                Name = name,
                NIC = nic,
             
            };
            _adminService.AddAdmin(dto);
        }

        public void Update(int id, string name, string nic )
        {
            var dto = new AdminDTO
            {
                Id = id,
                Name = name,
                NIC = nic,
                
                
            };
            _adminService.UpdateAdmin(dto);
        }

        public void Delete(int id)
        {
            _adminService.DeleteAdmin(id);
        }

        public List<AdminDTO> GetAll()
        {
            return _adminService.GetAllAdmins();
        }
    }
}