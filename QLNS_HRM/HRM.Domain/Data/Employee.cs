using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HRM.Domain.Data
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public bool Gender { get; set; }
        [Required]
        [StringLength(100)]
        public string Address { get; set; }
        [Required]
        [StringLength(15)]
        public string Phone { get; set; }
        [StringLength(100)]
        public string Email { get; set; }
        [StringLength(32)]
        public string Password { get; set; }
        [StringLength(50)]
        public string CivilianId { get; set; }
        [Required]
        public int DepartmentID { get; set; }
        [Required]
        public int PositionID { get; set; }
        public DateTime? JoiningDate { get; set; }
        public bool IsActive { get; set; } = true;
        public int? RoleID { get; set; }

        public virtual Department Department { get; set; }
        public virtual Position Position { get; set; }
        public virtual Role Role { get; set; }
        public virtual ICollection<EmployeeContract> Contracts { get; set; }
        public virtual ICollection<EmployeeInsurance> Insurances { get; set; }
        public virtual ICollection<EmployeeMovement> Movements { get; set; }
        public virtual ICollection<AttendanceRecord> AttendanceRecords { get; set; }
        public virtual ICollection<LeaveRequest> LeaveRequests { get; set; }
        public virtual ICollection<TrainingAttendance> TrainingAttendances { get; set; }

    }
}
