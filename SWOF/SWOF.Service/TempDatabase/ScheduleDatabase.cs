using SWOF.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWOF.Service.TempDatabase
{
    public static class ScheduleDatabase
    {
        public static class ScheduleTable
        {
            public static List<Schedule> table = new List<Schedule>();
        }

        public static class ShiftTable
        {
            public static List<Shift> table = new List<Shift>();            
        }
    }
}
