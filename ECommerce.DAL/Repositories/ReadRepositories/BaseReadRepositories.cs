using ECommerce.DAL.Data;

namespace ECommerce.DAL.Repositories.ReadRepositories;

public class BaseReadRepositories<T>(AppDbContext dbContext) : IBaseReadRepository<T> where T : BaseEntity
{
    private readonly DbSet<T> _dbSet = dbContext.Set<T>();

    public async Task<List<T>> GetAllAsync(Guid? id = null, bool isDeleted = false, int page = 1, int limit = 10, CancellationToken cancellationToken = default)
    {
        IQueryable<T> query = _dbSet;

        if (id != null)
            query = query.Where(x => x.Id == id);

        return await query.Where(x => x.IsDeleted == isDeleted)
            .OrderBy(x => x.Id).Skip((page - 1) * limit)
            .Take(limit)
            .AsNoTracking()
            .ToListAsync(cancellationToken);
    }
}
