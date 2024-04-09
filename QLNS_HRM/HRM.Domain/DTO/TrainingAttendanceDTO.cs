using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Domain.DTO
{
    public class TrainingAttendanceDTO
    {
        public int AttendanceID { get; set; }

        public int TrainingProgramID { get; set; }

        public int EmployeeID { get; set; }

        public string Status { get; set; }

        public string Result { get; set; }

        public bool IsActive { get; set; } = true;

        public TrainingProgramDTO TrainingProgram { get; set; }

        public EmployeeDTO Employee { get; set; }
    }
}
