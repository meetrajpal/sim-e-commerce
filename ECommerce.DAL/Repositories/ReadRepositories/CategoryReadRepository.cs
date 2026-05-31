using ECommerce.DAL.Data;

namespace ECommerce.DAL.Repositories.ReadRepositories;

public class CategoryReadRepository(AppDbContext dbContext) : BaseReadRepositories<Category>(dbContext), ICategoryReadRepository
{
}
