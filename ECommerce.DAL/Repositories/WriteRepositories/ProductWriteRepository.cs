using ECommerce.DAL.Data;
using ECommerce.DAL.Repositories.WriteRepositories.Interfaces;

namespace ECommerce.DAL.Repositories.WriteRepositories;

public class ProductWriteRepository(AppDbContext dbContext) : BaseWriteRepository<Product>(dbContext), IProductWriteRepository
{
}
