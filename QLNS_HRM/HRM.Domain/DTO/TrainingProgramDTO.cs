using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Domain.DTO
{
    public class TrainingProgramDTO
    {
        public int TrainingProgramID { get; set; }

        public string TrainingName { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public decimal Cost { get; set; }

        public int? InstructorID { get; set; }

        public bool IsActive { get; set; } = true;

        public EmployeeDTO Instructor { get; set; }
    }
}
