using ECommerce.DAL.Data;

namespace ECommerce.DAL.Repositories.ReadRepositories;

public class CategoryProductReadRepository(AppDbContext dbContext) : BaseReadRepositories<CategoryProduct>(dbContext), ICategoryProductReadRepository
{
}
