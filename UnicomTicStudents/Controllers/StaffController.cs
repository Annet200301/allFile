using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicStudents.Models.DTOs;
using UnicomTicStudents.Services.Iservices;

namespace UnicomTicStudents.Controllers
{
    internal class StaffController
    {
        private readonly IStaffService _staffService;

        public StaffController(IStaffService staffService)
        {
            _staffService = staffService;
        }

        public void Add(string name, string nic, string username, string password, string work)
        {
            var dto = new StaffDTO
            {
                Name = name,
                NIC = nic,
                Username = username,
                Password = password,
                Work=work
            };
            _staffService.AddStaff(dto);
        }

        public void Update(int id, string name, string nic, string username, string password, string work)
        {
            var dto = new StaffDTO
            {
                Id = id,
                Name = name,
                NIC = nic,
                Username = username,
                Password = password,
                Work = work
            };
            _staffService.UpdateStaff(dto);
        }

        public void Delete(int id)
        {
            _staffService.DeleteStaff(id);
        }

        public List<StaffDTO> GetAll()
        {
            return _staffService.GetAllStaff();
        }

    }
}
