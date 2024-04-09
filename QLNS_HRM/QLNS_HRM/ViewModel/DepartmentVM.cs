
using HRM.Domain.DTO;
using System.ComponentModel.DataAnnotations;

namespace HRM_API.ViewModel
{
    public class DepartmentVM
    {
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public string Description { get; set; }
        public int? PositionID { get; set; }
        public bool IsActive { get; set; } = true;
        public ICollection<EmployeeDTO> Employees { get; set; }
        public PositionDTO Position { get; set; }
    }
}
