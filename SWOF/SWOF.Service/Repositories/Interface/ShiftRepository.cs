using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SWOF.Service.Models;
using SWOF.Service.Infrastructure.Interface;
using System.Data;
using SWOF.Service.Enums;
using SWOF.Service.TempDatabase;

namespace SWOF.Service.Repositories.Interface
{
    public class ShiftRepository : IShiftRepository
    {
        #region Private Variables
        IConnection _connection;
        #endregion

        #region Constructors
        public ShiftRepository(IConnection connection)
        {
            _connection = connection;
        }
        #endregion
        public int Create(Shift entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> CreateAsync(Shift entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Shift> Get()
        {
            IEnumerable<Shift> list;
            using (IDbConnection db = _connection.GetConnection(DatabaseTypes.ScheduleConnection))
            {
                list = ScheduleDatabase.ShiftTable.table;
            }

            return list;
        }

        public Task<IEnumerable<Shift>> GetAsync()
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

        public int Update(Shift entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(Shift entity)
        {
            throw new NotImplementedException();
        }
    }
}
