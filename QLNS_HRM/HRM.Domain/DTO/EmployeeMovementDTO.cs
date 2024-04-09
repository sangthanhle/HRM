using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Domain.DTO
{
    public class EmployeeMovementDTO
    {
        public int MovementID { get; set; }

        public int EmployeeID { get; set; }

        public string MovementType { get; set; }

        public DateTime EffectiveDate { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; } = true;

        public EmployeeDTO Employee { get; set; }
    }
}
