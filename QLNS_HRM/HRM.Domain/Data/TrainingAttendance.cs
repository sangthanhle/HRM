using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Domain.Data
{
    public class TrainingAttendance
    {
        [Key]
        public int AttendanceID { get; set; }

        [Required]
        public int TrainingProgramID { get; set; }

        [Required]
        public int EmployeeID { get; set; }

        [Required]
        [StringLength(20)]
        public string Status { get; set; }

        [StringLength(500)]
        public string Result { get; set; }

        public bool IsActive { get; set; } = true;

        public virtual TrainingProgram TrainingProgram { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
