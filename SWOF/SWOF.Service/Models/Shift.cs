using SWOF.Service.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWOF.Service.Models
{
    public class Shift
    {
        public int ID { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public ShiftType TypeOfShift { get; set; }
        public Engineer AssignedEngineer { get; set; }
    }
}
