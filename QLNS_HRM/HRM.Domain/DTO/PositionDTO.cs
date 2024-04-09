using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Domain.DTO
{
    public class PositionDTO
    {
        public int PositionID { get; set; }

        public string PositionName { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; } = true;

        public ICollection<EmployeeDTO> Employees { get; set; }
    }
}
