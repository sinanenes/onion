using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMOnline.Domain.Interfaces.Base
{
    public interface IGenericRepository<TEntity> where TEntity : class, new()
    {
        Task<IQueryable<TEntity>> GetAllAsync(Func<TEntity, bool> filter = null);
        
        Task<TEntity> AddAsync(TEntity entity);

        //Task<TEntity> GetByIdAsync(int id);
        //Task<bool> DeleteByIdAsync(int id);
        //Task<TEntity> UpdateAsync(TEntity entity);
    }
}
