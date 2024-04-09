using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Domain.Data
{
    public class AttendanceRecord
    {
        [Key]
        public int AttendanceRecordID { get; set; }

        [Required]
        public int EmployeeID { get; set; }

        [Required]
        public DateTime AttendanceDate { get; set; }

        public TimeSpan? InTime { get; set; }

        public TimeSpan? OutTime { get; set; }

        public decimal? TotalHours { get; set; }

        public int? ShiftID { get; set; }

        public int? LeaveTypeID { get; set; }

        public bool IsActive { get; set; } = true;

        public virtual Employee Employee { get; set; }

        public virtual Shift Shift { get; set; }

        public virtual LeaveType LeaveType { get; set; }
    }
}
