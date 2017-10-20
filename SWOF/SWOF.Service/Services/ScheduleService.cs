using SWOF.Service.Models;
using SWOF.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWOF.Service.Services
{
    public class ScheduleService : IScheduleService
    {
        public bool IsCompletedFullSupport(Engineer engineer)
        {
            return false;
        }
        

    }
}
