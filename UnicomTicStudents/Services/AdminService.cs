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
    public class AdminService : IAdminService
    {
        private readonly IAdminRepository _repository;

        public AdminService(IAdminRepository repository)
        {
            _repository = repository;
        }

        public void AddAdmin(AdminDTO dto)
        {
            if (string.IsNullOrWhiteSpace(dto.Name) || string.IsNullOrWhiteSpace(dto.Username))
                throw new ArgumentException("Name and Username are required.");

            var entity = AdminMapper.ToEntity(dto);
            _repository.Add(entity);
        }

        public void UpdateAdmin(AdminDTO dto)
        {
            if (dto.Id <= 0)
                throw new ArgumentException("Invalid Admin Id.");

            var entity = AdminMapper.ToEntity(dto);
            _repository.Update(entity);
        }

        public void DeleteAdmin(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Invalid Admin Id.");

            _repository.Delete(id);
        }

        public List<AdminDTO> GetAllAdmins()
        {
            return _repository.GetAll().Select(AdminMapper.ToDTO).ToList();
        }
    }

}
