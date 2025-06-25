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
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public void RegisterUser(UserDTO user, UserMapper UserMapper)
        {
            Validate(user);
            if (!string.IsNullOrWhiteSpace(user.Password))
                user.Password = Passwordhelper.HashPassword(user.Password);

            var entity = UserMapper.ToEntity(user);
            _repository.AddUser(entity);
        }

        public void UpdateUser(UserDTO user, UserMapper UserMapper)
        {
            Validate(user);
            if (!string.IsNullOrWhiteSpace(user.Password))
                user.Password = Passwordhelper.HashPassword(user.Password);

            var entity = UserMapper.ToEntity(user);
            _repository.UpdateUser(entity);
        }

        public void DeleteUser(int id)
        {
            _repository.DeleteUser(id);
        }

        public UserDTO GetByNICAndName(string nic, string name)
        {
            return GetByNICAndName(nic, name);
        }

        public UserDTO GetByNICAndName(string nic, string name, UserMapper UserMapper)
        {
            var entity = _repository.GetByNICAndName(nic, name);
            return entity == null ? null : UserMapper.ToDTO(entity);
        }

        public UserDTO Login(string username, string password)
        {
            var hashed = Passwordhelper.HashPassword(password);
            var entity = _repository.GetByUsernameAndPassword(username, hashed);
            return entity == null ? null : UserMapper.ToDTO(entity);
        }

        public List<UserDTO> GetAllUsers()
        {
            return _repository.GetAllUsers().Select(UserMapper.ToDTO).ToList();
        }

        private void Validate(UserDTO user)
        {
            if (string.IsNullOrWhiteSpace(user.NIC))
                throw new ArgumentException("NIC cannot be empty.");
            if (string.IsNullOrWhiteSpace(user.Name))
                throw new ArgumentException("Name cannot be empty.");
            if (string.IsNullOrWhiteSpace(user.IndexNumber))
                throw new ArgumentException("Index Number cannot be empty.");
        }
       
    }
}
