using ECommerce.DAL.Data;
using ECommerce.DAL.Repositories.WriteRepositories.Interfaces;

namespace ECommerce.DAL.Repositories.WriteRepositories;

public class CategoryWriteRepository(AppDbContext dbContext) : BaseWriteRepository<Category>(dbContext), ICategoryWriteRepository
{
}
