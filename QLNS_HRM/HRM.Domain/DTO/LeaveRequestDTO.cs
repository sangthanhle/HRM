using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Domain.DTO
{
    public class LeaveRequestDTO
    {
        public int LeaveRequestID { get; set; }

        public int EmployeeID { get; set; }

        public int LeaveTypeID { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Reason { get; set; }

        public string Status { get; set; }

        public int? ApprovedBy { get; set; }

        public bool IsActive { get; set; } = true;

        public EmployeeDTO Employee { get; set; }

        public LeaveTypeDTO LeaveType { get; set; }

        public EmployeeDTO Approver { get; set; }
    }
}
