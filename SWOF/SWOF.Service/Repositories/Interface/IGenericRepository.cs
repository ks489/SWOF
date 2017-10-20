using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWOF.Service.Repositories.Interface
{
    public interface IGenericRepository<TEntity> : IDisposable where TEntity : class
    {
        IEnumerable<TEntity> Get();
        Task<IEnumerable<TEntity>> GetAsync();
        int Create(TEntity entity);
        Task<int> CreateAsync(TEntity entity);
        int Update(TEntity entity);
        Task<int> UpdateAsync(TEntity entity);
        void Remove(object key);
        Task RemoveAsync(object key);
    }
}
