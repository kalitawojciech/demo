using example.Core.Entities;
using example.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace example.Infrastructure
{
    class EFRepository<T> : IAsyncRepository<T> where T : BaseEntity
    {
        protected readonly StudentContext _dbContext;
        public EFRepository(StudentContext dbcontext)
        {
            _dbContext = dbcontext;
        }
        public Task<T> AddAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<T> GetByIdAsync(int id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public Task<IReadOnlyList<T>> ListAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
