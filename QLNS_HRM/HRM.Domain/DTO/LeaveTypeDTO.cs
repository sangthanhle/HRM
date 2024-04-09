using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Domain.DTO
{
    public class LeaveTypeDTO
    {
        public int LeaveTypeID { get; set; }

        public string LeaveName { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; } = true;
    }
}
