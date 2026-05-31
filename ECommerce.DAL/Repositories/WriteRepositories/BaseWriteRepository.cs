using ECommerce.DAL.Data;
using ECommerce.DAL.Repositories.WriteRepositories.Interfaces;

namespace ECommerce.DAL.Repositories.WriteRepositories;

public abstract class BaseWriteRepository<T>(AppDbContext dbContext) : IBaseWriteRepository<T> where T : BaseEntity
{
    private readonly DbSet<T> _dbSet = dbContext.Set<T>();

    public virtual async Task AddAsync(T entity, CancellationToken cancellationToken = default)
    {
        await _dbSet.AddAsync(entity, cancellationToken);
    }

    public virtual Task DeleteAsync(T entity, CancellationToken cancellationToken = default)
    {
        entity.IsDeleted = true;
        _dbSet.Update(entity);
        return Task.CompletedTask;
    }

    public virtual async Task<bool> ExistAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await _dbSet.AsNoTracking().IgnoreQueryFilters().AnyAsync(x => x.Id == id, cancellationToken);
    }

    public virtual async Task<T?> FindById(Guid id, CancellationToken cancellationToken = default)
    {
        return await _dbSet.IgnoreQueryFilters().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
    }

    public virtual Task UpdateAsync(T entity, CancellationToken cancellationToken = default)
    {
        _dbSet.Update(entity);
        return Task.CompletedTask;
    }
}
