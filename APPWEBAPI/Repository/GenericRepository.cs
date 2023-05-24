
using APPWEBAPI.Interface;
using APPWEBAPI.Models;
using APPWEBAPI.Partial;
using Microsoft.EntityFrameworkCore;

namespace APPWEBAPI.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected AppDbContext dbcontext;
        internal DbSet<T> dbSet;
        public GenericRepository(AppDbContext dbcontext)
        {
            this.dbcontext = dbcontext;
            this.dbSet = this.dbcontext.Set<T>();
        }

        public Task<Response<bool>> AddEntity(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<Response<bool>> DeleteEntity(int id)
        {
            throw new NotImplementedException();
        }

        public virtual Task<List<T>> GetAllAsync()
        {
            return this.dbSet.ToListAsync();
        }

        public Task<Response<T>> GetAsynce(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<bool>> UpdateEntity(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
