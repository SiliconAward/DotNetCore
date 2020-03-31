using Microsoft.EntityFrameworkCore;
using SiliconAward.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiliconAward.DataAccess.Repositories.BaseRepositories
{
    public class BaseRepository<TEntity>
    {
        private readonly ApplicationDbContext _context;

        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;

        }

        public async Task<TEntity> Create(TEntity model)
        {
            // await _dbset.AddAsync(model);
            _context.Entry(model).State = EntityState.Added;
            await _context.SaveChangesAsync();
            return model;
        }
        public async Task<TEntity> Update(TEntity model)
        {
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return model;
        }
        public async Task<TEntity> Delete(TEntity model)
        {
            _context.Entry(model).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
            return model;
        }


        public async Task<List<T>> GetListByCondition<T>(Expression<Func<T, bool>> predicate)
            where T : class
        {
            var item = await _context.Set<T>().Where(predicate).ToListAsync();
            return item;
        }

        public async Task<T> GetItemByCondition<T>(Expression<Func<T, bool>> predicate)
          where T : class
        {
            var item = await _context.Set<T>().SingleOrDefaultAsync(predicate);
            return item;
        }


        public async Task<T> GetById<T>(object id)
          where T : class
        {
            var item = await _context.Set<T>().FindAsync(id);
            return item;
        }



    }

}
