using RepositoryPattern.Entities;

namespace RepositoryPattern.Repositories;

public interface IGenericRepository<T> where T : notnull, BaseEntity
{
    Task<IReadOnlyList<T>> GetAllAsync();
    Task<T> GetByIdAsync(long id);
    Task AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(long id);
}
