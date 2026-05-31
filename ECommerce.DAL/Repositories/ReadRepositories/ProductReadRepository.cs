using ECommerce.DAL.Data;

namespace ECommerce.DAL.Repositories.ReadRepositories;

public class ProductReadRepository(AppDbContext dbContext) : BaseReadRepositories<Product>(dbContext), IProductReadRepository
{
}
