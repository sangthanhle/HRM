using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Domain.DTO
{
    public class EmployeeDTO
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string CivilianId { get; set; }
        public int DepartmentID { get; set; }
        public int PositionID { get; set; }

        public DateTime? JoiningDate { get; set; }

        public bool IsActive { get; set; } = true;

        public int? RoleID { get; set; }

        public DepartmentDTO Department { get; set; }

        public PositionDTO Position { get; set; }

        public RoleDTO Role { get; set; }

        public ICollection<EmployeeContractDTO> Contracts { get; set; }

        public ICollection<EmployeeInsuranceDTO> Insurances { get; set; }

        public ICollection<EmployeeMovementDTO> Movements { get; set; }

        public ICollection<AttendanceRecordDTO> AttendanceRecords { get; set; }

        public ICollection<LeaveRequestDTO> LeaveRequests { get; set; }

        public ICollection<TrainingAttendanceDTO> TrainingAttendances { get; set; }
    }
}
