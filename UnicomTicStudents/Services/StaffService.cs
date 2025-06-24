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


    public class StaffService : IStaffService
    {
        private readonly IStaffRepository _repository;

        public StaffService(IStaffRepository repository)
        {
            _repository = repository;
        }

        public void AddStaff(StaffDTO dto)
        {
            if (string.IsNullOrWhiteSpace(dto.Name) || string.IsNullOrWhiteSpace(dto.Username))
                throw new ArgumentException("Name and Username are required.");

            var entity = StaffMappers.ToEntity(dto);
            _repository.Add(entity);
        }

        public void UpdateStaff(StaffDTO dto)
        {
            if (dto.Id <= 0)
                throw new ArgumentException("Invalid Staff Id.");

            var entity = StaffMappers.ToEntity(dto);
            _repository.Update(entity);
        }

        public void DeleteStaff(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Invalid Staff Id.");

            _repository.Delete(id);
        }

        public List<StaffDTO> GetAllStaff()
        {
            return _repository.GetAll().Select(StaffMappers.ToDTO).ToList();
        }
    }
}
