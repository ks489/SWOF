using SWOF.Service.Enums;
using SWOF.Service.Models;
using SWOF.Service.Repositories.Interface;
using SWOF.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWOF.Service.Services
{
    public class ShiftService : IShiftService
    {
        #region Private Variables
        private IShiftRepository _shiftRepository;
        #endregion
        #region Constructors
        public ShiftService(IShiftRepository shiftRepository)
        {
            _shiftRepository = shiftRepository;
        }
        #endregion

        public Shift CreateShiftToday(ShiftType type)
        {
            DateTime time = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 8, 0, 0); //This shift time can be moved into a database or configuration class
            Shift shift = new Shift()
            {
                StartTime = time,
                EndTime = time.AddHours(5), //This shift time can be moved into a database or configuration class
                TypeOfShift = type,
                AssignedEngineer = null
            };

            if (IsShiftCreated(shift))
                return null;

            int rowsReturned = _shiftRepository.Create(shift);

            return shift;
        }

        public Shift CreateShiftTomorrow(ShiftType type)
        {
            DateTime time = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 8, 0, 0); //This shift time can be moved into a database or configuration class
            Shift shift = new Shift()
            {
                StartTime = time.AddDays(1),
                EndTime = time.AddHours(5), //This shift time can be moved into a database or configuration class
                TypeOfShift = type,
                AssignedEngineer = null
            };

            if (IsShiftCreated(shift))
                return null;

            int rowsReturned = _shiftRepository.Create(shift);

            return shift;
        }

        public bool IsShiftCreated(Shift shift)
        {
            var obj = _shiftRepository.Get().FirstOrDefault(x => x.StartTime == shift.StartTime && x.EndTime == shift.EndTime);
            return obj == null ? false : true;
        }
    }
}
