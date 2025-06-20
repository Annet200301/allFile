using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicStudents.Models.DTOs;
using UnicomTicStudents.Services.Iservices;

namespace UnicomTicStudents.Controllers
{
    internal class UserController
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

            _service.RegisterUser(dto);
            return "User registered successfully.";
        }

        public UserDTO GetByNICAndName(string nic, string name)
        {
            return _service.GetByNICAndName(nic, name);
        }

        public string SetUserCredentials(string nic, string name, string username, string password)
        {
            var user = _service.GetByNICAndName(nic, name);

            if (user == null)
                return "User not found.";

            if (!string.IsNullOrEmpty(user.Username))
                return "Account already created.";

            user.Username = username;
            user.Password = password;
            _service.UpdateUser(user);
            return "Account setup successful.";
        }

        public UserDTO Login(string username, string password)
        {
            return _service.Login(username, password);
        }
    }
}
