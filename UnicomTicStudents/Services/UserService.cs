using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicStudents.Models.DTOs;
using UnicomTicStudents.Models.Mappers;
using UnicomTicStudents.Repositories.Irepository;
using UnicomTicStudents.Services.Iservices;

namespace UnicomTicStudents.Services
{
    internal class UserService: IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public void RegisterUser(UserDTO dto)
        {
            var entity = UserMapper.ToEntity(dto);
            _repository.Add(entity);
        }

        public UserDTO GetByNICAndName(string nic, string name)
        {
            var entity = _repository.GetByNICAndName(nic, name);
            return entity != null ? UserMapper.ToDTO(entity) : null;
        }

        public void UpdateUser(UserDTO dto)
        {
            var entity = UserMapper.ToEntity(dto);
            _repository.Update(entity);
        }

        public UserDTO Login(string username, string password)
        {
            var entity = _repository.GetByUsernameAndPassword(username, password);
            return entity != null ? UserMapper.ToDTO(entity) : null;
        }
    }
}
