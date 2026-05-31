namespace ECommerce.DAL.Repositories.ReadRepositories.Interfaces;

public interface IBaseReadRepository<T> where T : BaseEntity
{
    Task<List<T>> GetAllAsync(Guid? id = null, bool isDeleted = false, int page = 1, int limit = 10, CancellationToken cancellationToken = default);
}
