using ECommerce.DAL.Data;

namespace ECommerce.DAL.Repositories.ReadRepositories;

public class ProductImagesReadRepository(AppDbContext dbContext) : BaseReadRepositories<ProductImages>(dbContext), IProductImagesReadRepository
{
}
