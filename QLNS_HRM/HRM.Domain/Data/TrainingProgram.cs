using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Domain.Data
{
    public class TrainingProgram
    {
        [Key]
        public int TrainingProgramID { get; set; }

        [Required]
        [StringLength(100)]
        public string TrainingName { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public decimal Cost { get; set; }

        public int? InstructorID { get; set; }

        public bool IsActive { get; set; } = true;

        public virtual Employee Instructor { get; set; }
    }
}
