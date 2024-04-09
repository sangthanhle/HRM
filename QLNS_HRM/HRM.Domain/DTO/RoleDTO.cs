using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Domain.DTO
{
    public class RoleDTO
    {
        public int RoleID { get; set; }

        public string RoleName { get; set; }

        public ICollection<EmployeeDTO> Employees { get; set; }
    }
}
