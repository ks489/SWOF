using SWOF.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWOF.Service.Services.Interfaces
{
    public interface IEngineerService
    {
        IEnumerable<Engineer> Get();
        Engineer Get(int id);

        bool IsDoubledBooked();

        bool IsConsecutiveBooked();
        IEnumerable<Engineer> GetAvailableEngineers();
        bool HasCompletedSchedule(Engineer engineer);
        bool HasEngineerShiftToday();
        bool HasEngineerShiftTomorrow();
    }
}
