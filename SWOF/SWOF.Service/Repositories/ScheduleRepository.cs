using SWOF.Service.Models;
using SWOF.Service.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWOF.Service.Repositories
{
    public class ScheduleRepository : IScheduleRepository
    {
        public int Create(Schedule entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> CreateAsync(Schedule entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Schedule> Get()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Schedule>> GetAsync()
        {
            throw new NotImplementedException();
        }

        public void Remove(object key)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(object key)
        {
            throw new NotImplementedException();
        }

        public int Update(Schedule entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(Schedule entity)
        {
            throw new NotImplementedException();
        }
    }
}
