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
        #endregion
        public EngineerService(IEngineerRepository engineerRepository)
        {
            _engineerRepository = engineerRepository;
        }
        public IEnumerable<Engineer> Get()
        {
            return _engineerRepository.Get();
        }

        public Engineer Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
