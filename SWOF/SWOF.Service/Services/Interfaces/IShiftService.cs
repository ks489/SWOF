using SWOF.Service.Enums;
using SWOF.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWOF.Service.Services.Interfaces
{
    public interface IShiftService
    {
        Shift CreateShiftToday(ShiftType type);

        Shift CreateShiftTomorrow(ShiftType type);

        bool IsShiftCreated(Shift shift);
    }
}
