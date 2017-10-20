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
        #endregion

        #region Constructors
        public ScheduleService(IScheduleRepository scheduleRepository)
        {
            _scheduleRepository = scheduleRepository;
        }
        #endregion
        public bool IsCompletedFullSupport(Engineer engineer)
        {
            return false;
        }
        
        public IEnumerable<Schedule> Get()
        {
            return null;
        }

        public IEnumerable<Schedule> Get(DateTime fromDate, DateTime endDate)
        {
            return null;
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

            return null;
        }

        public bool IsScheduleGeneratedToday()
        {
            var item = _scheduleRepository.Get().Where(x => x.Date.Date == DateTime.Now.Date);
            return item == null ? false : true;
        }
    }
}
