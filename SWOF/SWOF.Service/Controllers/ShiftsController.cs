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
    [Route("api/Shifts")]
    public class ShiftsController : Controller
    {
        #region Private Variables
        private IShiftService _shiftService;
        private IEngineerService _engineerService;
        #endregion

        public ShiftsController(IShiftService shiftService, IEngineerService engineerService)
        {
            _shiftService = shiftService;
            _engineerService = engineerService;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Engineer> Get()
        {
            return _engineerService.Get();
            //return new string[] { "value1", "value2" };
        }
    }
}