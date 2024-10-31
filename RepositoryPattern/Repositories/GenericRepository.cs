using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Entities;

namespace RepositoryPattern.Repositories;

public class GenericRepository<T>(RepositoryPatternDbContext context) : IGenericRepository<T> where T : notnull, BaseEntity
{
    public async Task<IReadOnlyList<T>> GetAllAsync()
    {
        return await context.Set<T>().ToListAsync();
    }

    public async Task<T> GetByIdAsync(long id)
    {
        return await context.Set<T>().FirstAsync(e => e.Id == id);
    }

    public async Task AddAsync(T entity)
    {
        await context.Set<T>().AddAsync(entity);
        await context.SaveChangesAsync();
    }
    public async Task UpdateAsync(T entity)
    {
        context.Entry(entity).State = EntityState.Modified;
        await context.SaveChangesAsync();
    }

    public async Task DeleteAsync(long id)
    {
        var entity = await GetByIdAsync(id);
        context.Set<T>().Remove(entity);
        await context.SaveChangesAsync();
    }
}
