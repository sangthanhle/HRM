using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Domain.Data
{
    public class LeaveRequest
    {
        [Key]
        public int LeaveRequestID { get; set; }

        [Required]
        public int EmployeeID { get; set; }

        [Required]
        public int LeaveTypeID { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [StringLength(500)]
        public string Reason { get; set; }

        [Required]
        [StringLength(20)]
        public string Status { get; set; }

        public int? ApprovedBy { get; set; }

        public bool IsActive { get; set; } = true;

        public virtual Employee Employee { get; set; }

        public virtual LeaveType LeaveType { get; set; }

        [ForeignKey("ApprovedBy")]
        public virtual Employee Approver { get; set; }
    }
}
