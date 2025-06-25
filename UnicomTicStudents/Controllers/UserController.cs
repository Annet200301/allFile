using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicStudents.Models.DTOs;
using UnicomTicStudents.Services.Iservices;

namespace UnicomTicStudents.Controllers
{
    public  class UserController
    {
        private readonly IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }

        public string AddPreRegisteredUser(UserDTO dto)
        {
            if (_service.GetByNICAndName(dto.NIC, dto.Name) != null)
                return "User already exists.";

            _service.RegisterUser(dto, UserMapper);
            return "User registered successfully.";
        }

        public UserDTO GetByNICAndName(string nic, string name)
        {
            return _service.GetByNICAndName(nic, name);
        }

        public void UpdateUser(UserDTO dto)
        {
            _service.UpdateUser(dto, UserMapper);
        }

        public void DeleteUser(int id)
        {
            _service.DeleteUser(id);
        }

        public UserDTO Login(string username, string password)
        {
            return _service.Login(username, password);
        }

        public List<UserDTO> GetAllUsers()
        {
            return _service.GetAllUsers();
        }
    }
}
