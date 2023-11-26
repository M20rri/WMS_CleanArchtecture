using Microsoft.EntityFrameworkCore;
using Application.Interfaces;
using Infrastructure.Persistence.Contexts;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;

namespace Infrastructure.Persistence.Repositories
{
    public class GenericRepositoryAsync<T> : IGenericRepositoryAsync<T> where T : class
    {
        private readonly ApplicationDbContext _dbContext;

        public GenericRepositoryAsync(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual async Task<T> GetByIdAsync(Guid id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public async Task<IQueryable<T>> GetPagedReponseAsync(int pageNumber, int pageSize)
        {
            return _dbContext
                .Set<T>()
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .AsNoTracking()
                .AsQueryable();
        }

        public async Task<IQueryable<T>> GetPagedAdvancedReponseAsync(int pageNumber, int pageSize, string orderBy, string fields)
        {
            return _dbContext
                .Set<T>()
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .Select<T>("new(" + fields + ")")
                .OrderBy(orderBy)
                .AsNoTracking()
                .AsQueryable();
        }

        public async Task<T> AddAsync(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IQueryable<T>> GetAllAsync()
        {
            return _dbContext
                 .Set<T>()
                 .AsQueryable();
        }

        public async Task<IQueryable<T>> FindAllByConditionAsync(Expression<Func<T, bool>> expression)
        {
            return _dbContext.Set<T>().Where(expression).AsQueryable();
        }

        public async Task<T> FindByConditionAsync(Expression<Func<T, bool>> expression)
        {
            return await _dbContext.Set<T>().Where(expression).FirstOrDefaultAsync();
        }
    }
}