using DHMOnline.DataEF.Context;
using DHMOnline.Domain.Interfaces.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMOnline.DataEF.Generics
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class, IEntity, new()
    {
        // variables
        protected readonly PersonelDBContext _context;
        internal DbSet<TEntity> _dbSet;
        
        // constructor
        public GenericRepository(PersonelDBContext context)
        {
            this._context = context;
            _dbSet = context.Set<TEntity>();
        }

        // AddAsync - Kayıt ekler
        public async Task<TEntity> AddAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
            return entity;
        }

        // GetAllAsync - lambda sorgu ile veri çeker
        public async Task<IQueryable<TEntity>> GetAllAsync(Func<TEntity, bool> filter = null)
        {
            if (filter != null)
            {
                return await Task.FromResult(_dbSet.AsQueryable().AsNoTracking().Where(filter).AsQueryable());
            }
            else
            {
                return await Task.FromResult(_dbSet.AsQueryable().AsNoTracking());
            }
        }


        //Table does not have an ID column we set it PersonelKey so ById methods wont work generically...

        //public async Task<TEntity> GetByIdAsync(int id)
        //{
        //    return await _dbSet.AsNoTracking().FirstOrDefaultAsync(a => a.Id == id) ?? new TEntity();
        //}

        //public async Task<TEntity> UpdateAsync(TEntity entity)
        //{
        //    var oldEntity = await GetByIdAsync(entity.Id);

        //    if (oldEntity is null)
        //        return await Task.FromResult(entity);

        //    _dbSet.Attach(entity);
        //    _context.Entry(entity).State = EntityState.Modified;

        //    return await Task.FromResult(entity);
        //}
        //public async Task<bool> DeleteByIdAsync(int id)
        //{
        //    var entity = await GetByIdAsync(id);

        //    if (entity.Id > 0)
        //    {
        //        _context.Entry(entity).State = EntityState.Deleted;
        //        _context.Remove(entity);
        //        return true;
        //    }

        //    return false;
        //}
    }

}
