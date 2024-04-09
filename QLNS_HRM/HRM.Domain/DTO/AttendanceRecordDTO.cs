using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Domain.DTO
{
    public class AttendanceRecordDTO
    {
        public int AttendanceRecordID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime AttendanceDate { get; set; }

        public TimeSpan? InTime { get; set; }

        public TimeSpan? OutTime { get; set; }

        public decimal? TotalHours { get; set; }

        public int? ShiftID { get; set; }

        public int? LeaveTypeID { get; set; }

        public bool IsActive { get; set; } = true;

        public EmployeeDTO Employee { get; set; }

        public ShiftDTO Shift { get; set; }

        public LeaveTypeDTO LeaveType { get; set; }
    }
}
