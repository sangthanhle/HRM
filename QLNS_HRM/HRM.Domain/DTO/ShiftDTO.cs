using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Domain.DTO
{
    public class ShiftDTO
    {
        public int ShiftID { get; set; }

        public string ShiftName { get; set; }

        public TimeSpan StartTime { get; set; }

        public TimeSpan EndTime { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; } = true;
    }
}
