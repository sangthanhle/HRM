using AutoMapper;
using HRM.DataAccess;
using HRM.DataAccess.Repositories;
using HRM.Domain.Data;
using HRM.Domain.DTO;

namespace HRM.BusinessLogic
{
    public class DepartmentService
    {
        public readonly DepartmentRepository _departmentRepository;
        public readonly IMapper _mapper;
        public DepartmentService(DepartmentRepository departmentRepository, IMapper mapper)
        {
            _departmentRepository = departmentRepository;
            _mapper = mapper;
        }
        public async Task<DepartmentDTO> GetDepartmentById(int id)
        {
            var department = await _departmentRepository.GetByIdAsync(id);
            return  _mapper.Map<DepartmentDTO>(department);
        }
        public async Task<IEnumerable<DepartmentDTO>> GetAllDepartment()
        {
            var department = await _departmentRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<DepartmentDTO>>(department);
        }
        public async Task Create(DepartmentDTO departmentDTO)
        {
            var department = _mapper.Map<Department>(departmentDTO);
            await _departmentRepository.AddAsync(department);
        }

    }
}
