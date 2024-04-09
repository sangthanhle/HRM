using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Domain.Data
{
    public class EmployeeContract
    {
        [Key]
        public int ContractID { get; set; }

        [Required]
        public int EmployeeID { get; set; }

        [Required]
        [StringLength(50)]
        public string ContractType { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [Required]
        public decimal BaseSalary { get; set; }

        [Required]
        public DateTime SignedDate { get; set; }

        public bool IsActive { get; set; } = true;

        public virtual Employee Employee { get; set; }
    }
}
