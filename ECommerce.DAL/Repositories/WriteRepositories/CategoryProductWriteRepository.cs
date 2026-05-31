using ECommerce.DAL.Data;
using ECommerce.DAL.Repositories.WriteRepositories.Interfaces;

namespace ECommerce.DAL.Repositories.WriteRepositories;

public class CategoryProductWriteRepository(AppDbContext dbContext) : BaseWriteRepository<CategoryProduct>(dbContext), ICategoryProductWriteRepository
{
}
