using ECommerce.DAL.Data;

namespace ECommerce.DAL.Repositories.ReadRepositories;

public class SellerReadRepository(AppDbContext dbContext) : BaseReadRepositories<Seller>(dbContext), ISellerReadRepository
{
}
