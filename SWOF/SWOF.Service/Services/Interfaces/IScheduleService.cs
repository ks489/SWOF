using SWOF.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWOF.Service.Services.Interfaces
{
    public interface IScheduleService
    {
        bool HasCompletedSchedule(Engineer engineer);

        IEnumerable<Schedule> Get();

        IEnumerable<Schedule> Get(DateTime fromDate, DateTime endDate);

        IEnumerable<Schedule> Get(DateTime date);

        IEnumerable<Shift> GetShifts(Schedule schedule);

        int Create(Schedule schedule);

        Schedule GenerateNewSchedule();

        bool IsScheduleGeneratedToday();
    }
}
