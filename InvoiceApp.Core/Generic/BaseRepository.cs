using InvoiceApp.Core.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceApp.Core
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext _context;
        public BaseRepository(DbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(TEntity entity)
        {
            try
            {
                await _context.Set<TEntity>().AddAsync(entity);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        
        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            try
            {
                return await _context.Set<TEntity>().ToListAsync();
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<TEntity> GetAsync(int id)
        {
            try
            {
                return await _context.Set<TEntity>().FindAsync(id);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Remove(TEntity entity)
        {
            try
            {
                _context.Set<TEntity>().Remove(entity);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(TEntity entity)
        {
            try
            {
                _context.Set<TEntity>().Update(entity);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        

    }
}
