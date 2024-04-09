using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Domain.Data
{
    public class EmployeeInsurance
    {
        [Key]
        public int InsuranceID { get; set; }

        [Required]
        public int EmployeeID { get; set; }

        [Required]
        [StringLength(50)]
        public string InsuranceType { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [StringLength(20)]
        public string InsuranceNumber { get; set; }

        public bool IsActive { get; set; } = true;

        public virtual Employee Employee { get; set; }
    }
}
