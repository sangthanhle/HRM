using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Domain.DTO
{
    public class EmployeeInsuranceDTO
    {
        public int InsuranceID { get; set; }

        public int EmployeeID { get; set; }

        public string InsuranceType { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string InsuranceNumber { get; set; }

        public bool IsActive { get; set; } = true;

        public EmployeeDTO Employee { get; set; }
    }
}
