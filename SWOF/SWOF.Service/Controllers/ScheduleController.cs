using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SWOF.Service.Services.Interfaces;
using SWOF.Service.Models;

namespace SWOF.Service.Controllers
{
    [Produces("application/json")]
    [Route("api/Schedule")]
    public class ScheduleController : Controller
    {
        #region Private Variables
        private IScheduleService _scheduleService;        
        #endregion

        public ScheduleController(IScheduleService scheduleService)
        {
            _scheduleService = scheduleService;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Schedule> Get()
        {
            return _scheduleService.Get();
            //return new string[] { "value1", "value2" };
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
            string a = "sdf";
        }

        //[HttpGet]
        //public IEnumerable<Schedule> Get(DateTime dateFrom, DateTime endDate)
        //{
        //    return _scheduleService.Get(dateFrom, endDate);
        //    //return new string[] { "value1", "value2" };
        //}

        //[HttpGet]
        //public IEnumerable<Schedule> Get(DateTime date)
        //{
        //    return _scheduleService.Get(date);
        //    //return new string[] { "value1", "value2" };
        //}
    }
}