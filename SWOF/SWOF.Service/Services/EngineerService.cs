using SWOF.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SWOF.Service.Models;
using SWOF.Service.Repositories.Interface;

namespace SWOF.Service.Services
{
    public class EngineerService : IEngineerService
    {
        #region Private Variables
        IEngineerRepository _engineerRepository;
        IScheduleService _scheduleService;
        #endregion
        public EngineerService(IEngineerRepository engineerRepository, IScheduleService scheduleService)
        {
            _engineerRepository = engineerRepository;
            _scheduleService = scheduleService;
        }
        public IEnumerable<Engineer> Get()
        {
            return _engineerRepository.Get();
        }

        public Engineer Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Engineer> GetAvailableEngineers()
        {
            //var scheduleList = _scheduleService.Get().Where(x => x.Date == new DateTime(DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year));            
            
        }

        public bool HasCompletedSchedule(Engineer engineer)
        {
            return false;
        }

        public bool HasEngineerShiftToday()
        {
            _
        }

        public bool HasEngineerShiftTomorrow()
        {
            throw new NotImplementedException();
        }

        public bool IsConsecutiveBooked()
        {
            throw new NotImplementedException();
        }

        public bool IsDoubledBooked()
        {
            throw new NotImplementedException();
        }
    }
}
