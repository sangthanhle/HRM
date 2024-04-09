using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Domain.Data
{
    public class LeaveType
    {
        [Key]
        public int LeaveTypeID { get; set; }

        [Required]
        [StringLength(50)]
        public string LeaveName { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public bool IsActive { get; set; } = true;
    }
}
