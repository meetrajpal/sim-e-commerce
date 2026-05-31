using ECommerce.DAL.Data;
using ECommerce.DAL.Repositories.WriteRepositories.Interfaces;

namespace ECommerce.DAL.Repositories.WriteRepositories;

public class ProductImagesWriteRepository(AppDbContext dbContext) : BaseWriteRepository<ProductImages>(dbContext), IProductImagesWriteRepository
{
}
