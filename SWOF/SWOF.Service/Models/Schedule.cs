using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWOF.Service.Models
{
    public class Schedule
    {
        public DateTime Date { get; set; }
        public Tuple<Shift, Shift> Shifts { get; set; } //May need to change to a collection
    }
}
