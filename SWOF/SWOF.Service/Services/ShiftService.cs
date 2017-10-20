using SWOF.Service.Models;
using SWOF.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWOF.Service.Services
{
    public class ShiftService : IShiftService
    {
        public bool IsDoubledBooked()
        {
            return false;
        }

        public bool IsConsecutiveBooked()
        {
            return false;
        }

        public Tuple<Shift, Shift> Create()
        {
            Shift morningShift = new Shift();


            Shift afternoonShift = new Shift();
            return null;
        }

    }
}
