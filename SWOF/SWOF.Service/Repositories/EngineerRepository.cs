using SWOF.Service.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SWOF.Service.Models;
using SWOF.Service.Infrastructure.Interface;
using System.Data;
using SWOF.Service.Enums;
using SWOF.Service.TempDatabase;

namespace SWOF.Service.Repositories
{
    public class EngineerRepository : IEngineerRepository
    {
        #region Private Variables
        IConnection _connection;
        #endregion

        #region Constructors
        public EngineerRepository(IConnection connection)
        {
            _connection = connection;
        }
        #endregion

        public int Create(Engineer entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> CreateAsync(Engineer entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Engineer> Get()
        {
            IEnumerable<Engineer> list;
            using (IDbConnection db = _connection.GetConnection(DatabaseTypes.ScheduleConnection))
            {
                list = UsersDatabase.UserTable.table;
            }

            return list;
        }

        public Task<IEnumerable<Engineer>> GetAsync()
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

        public int Update(Engineer entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(Engineer entity)
        {
            throw new NotImplementedException();
        }
    }
}
