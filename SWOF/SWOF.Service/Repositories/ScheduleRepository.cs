using SWOF.Service.Enums;
using SWOF.Service.Infrastructure.Interface;
using SWOF.Service.Models;
using SWOF.Service.Repositories.Interface;
using SWOF.Service.TempDatabase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace SWOF.Service.Repositories
{
    public class ScheduleRepository : IScheduleRepository
    {
        #region Private Variables
        IConnection _connection;
        #endregion

        #region Constructors
        public ScheduleRepository(IConnection connection)
        {
            _connection = connection;
        }
        #endregion
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
            IEnumerable<Schedule> list;
            using (IDbConnection db = _connection.GetConnection(DatabaseTypes.UsersConnection))
            {
                list = ScheduleDatabase.ScheduleTable.table;
            }

            return list;
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
