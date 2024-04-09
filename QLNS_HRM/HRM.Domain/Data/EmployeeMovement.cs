using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Domain.Data
{
    public class EmployeeMovement
    {
        [Key]
        public int MovementID { get; set; }

        [Required]
        public int EmployeeID { get; set; }

        [Required]
        [StringLength(50)]
        public string MovementType { get; set; }

        [Required]
        public DateTime EffectiveDate { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public bool IsActive { get; set; } = true;

        public virtual Employee Employee { get; set; }
    }
}
