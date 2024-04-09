using AutoMapper;
using HRM.BusinessLogic;
using HRM.Domain.Data;
using HRM.Domain.DTO;
using HRM_API.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HRM_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly DepartmentService _departmentService;
        private readonly IMapper _mapper;
        public DepartmentController(DepartmentService departmentService, IMapper mapper)
        {
            _departmentService = departmentService;
            _mapper = mapper;

        }
        // GET: api/Department/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<DepartmentVM>> GetDepartmentById(int id)
        {
            var departmentDTO = await _departmentService.GetDepartmentById(id);

            if (departmentDTO == null)
            {
                return NotFound();
            }

            var departmentVM = _mapper.Map<DepartmentDTO, DepartmentVM>(departmentDTO);

            return departmentVM;
        }
          // GET: api/Department/all
        [HttpGet()]
        public async Task<ActionResult<DepartmentVM>> GetAllDepartments()
        {
            var departmentDTO = await _departmentService.GetAllDepartment();

            var departmentVM = _mapper.Map<IEnumerable<DepartmentDTO>, IEnumerable<DepartmentVM>>(departmentDTO);

            return Ok(departmentVM);
        }
        [HttpPost]
        public async Task<IActionResult> Create( DepartmentVM departmentVM)
        {
            try
            {
                var departmentDTO = _mapper.Map<DepartmentDTO>(departmentVM);
                await _departmentService.Create(departmentDTO);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

    }
}
