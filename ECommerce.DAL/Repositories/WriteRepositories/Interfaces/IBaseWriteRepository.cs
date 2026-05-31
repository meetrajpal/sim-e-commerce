namespace ECommerce.DAL.Repositories.WriteRepositories.Interfaces;

public interface IBaseWriteRepository<T> where T : BaseEntity
{
    Task<T?> FindById(Guid id, CancellationToken cancellationToken);
    Task<bool> ExistAsync(Guid id, CancellationToken cancellationToken);
    Task AddAsync(T entity, CancellationToken cancellationToken);
    Task UpdateAsync(T entity, CancellationToken cancellationToken);
    Task DeleteAsync(T entity, CancellationToken cancellationToken);
}
