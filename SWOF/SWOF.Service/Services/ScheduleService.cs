using SWOF.Service.Models;
using SWOF.Service.Repositories.Interface;
using SWOF.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SWOF.Service.Services
{
    public class ScheduleService : IScheduleService
    {
        #region Private Variables
        private IScheduleRepository _scheduleRepository;
        private IShiftService _shiftService;
        #endregion

        #region Constructors
        public ScheduleService(IScheduleRepository scheduleRepository, IShiftService shiftService)
        {
            _scheduleRepository = scheduleRepository;
            _shiftService = shiftService;
        }
        #endregion              
        
        public IEnumerable<Schedule> Get()
        {
            return _scheduleRepository.Get();
        }

        public IEnumerable<Schedule> Get(DateTime fromDate, DateTime endDate)
        {
            return _scheduleRepository.Get().Where(x => x.Date >= fromDate && x.Date <= endDate);
        }

        public IEnumerable<Schedule> Get(DateTime date)
        {
            return _scheduleRepository.Get().Where(x => x.Date == date); ;
        }

        public int Create(Schedule schedule)
        {
            return 0;
        }

        public Schedule GenerateNewSchedule()
        {
            //Check to see if a new schedule hasn't been generated today
            if (IsScheduleGeneratedToday())
                return null;

            var morningShift =_shiftService.CreateShiftToday(Enums.ShiftType.Morning);
            var afternoonShift = _shiftService.CreateShiftToday(Enums.ShiftType.Afternoon);

            if (morningShift == null || afternoonShift == null)
                return null;

            //GetAvailableEngineer

            var schedule = new Schedule()
            {
                Date = new DateTime(DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year),
                Shifts = new Tuple<Shift, Shift>(morningShift, afternoonShift)
            };

            return schedule;
        }

        public bool IsScheduleGeneratedToday()
        {
            var item = _scheduleRepository.Get().Where(x => x.Date.Date == new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day));
            return item == null ? false : true;
        }

        public bool HasCompletedSchedule(Engineer engineer)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tuple<Shift, Shift>> GetShifts(IEnumerable<Schedule> schedule)
        {
            return schedule.Select(x => x.Shifts);
        }        
    }
}
