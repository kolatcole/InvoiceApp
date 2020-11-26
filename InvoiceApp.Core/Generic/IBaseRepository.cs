using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceApp.Core
{
    public interface IBaseRepository<TEntity> where TEntity:class
    {
        Task AddAsync(TEntity entity);

        void Remove(TEntity entity);

        Task<TEntity> GetAsync(int id);

        Task<IEnumerable<TEntity>> GetAllAsync();

        void Update(TEntity entity);




    }
}
