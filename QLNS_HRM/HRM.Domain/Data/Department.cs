using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Domain.Data
{
    public class Department
    {
        [Key]
        public int DepartmentID { get; set; }
        [Required]
        [StringLength(100)]
        public string DepartmentName { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        public int? PositionID { get; set; }
        public bool IsActive { get; set; } = true;

        public virtual ICollection<Employee> Employees { get; set; }
        public virtual Position Position { get; set; }
    }
}
