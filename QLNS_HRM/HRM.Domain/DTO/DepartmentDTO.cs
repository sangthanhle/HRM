using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Domain.DTO
{
    public class DepartmentDTO
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
