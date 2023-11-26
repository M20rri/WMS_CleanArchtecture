using System.Linq.Expressions;

namespace Application.Interfaces
{
    public interface IGenericRepositoryAsync<T> where T : class
    {
        Task<T> GetByIdAsync(Guid id);

        Task<IQueryable<T>> GetAllAsync();

        Task<IQueryable<T>> GetPagedReponseAsync(int pageNumber, int pageSize);

        Task<IQueryable<T>> GetPagedAdvancedReponseAsync(int pageNumber, int pageSize, string orderBy, string fields);

        Task<IQueryable<T>> FindAllByConditionAsync(Expression<Func<T, bool>> expression);
        
        Task<T> FindByConditionAsync(Expression<Func<T, bool>> expression);

        Task<T> AddAsync(T entity);

        Task UpdateAsync(T entity);

        Task DeleteAsync(T entity);
    }
}