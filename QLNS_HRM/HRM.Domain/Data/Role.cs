using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Domain.Data
{
    public class Role
    {
        [Key]
        public int RoleID { get; set; }
        [Required]
        [StringLength(50)]
        public string RoleName { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
