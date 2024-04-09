using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Domain.DTO
{
    public class EmployeeContractDTO
    {
        public int ContractID { get; set; }
        public int EmployeeID { get; set; }
        public string ContractType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal BaseSalary { get; set; }
        public DateTime SignedDate { get; set; }
        public bool IsActive { get; set; } = true;
        public EmployeeDTO Employee { get; set; }
    }
}
