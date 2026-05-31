using ECommerce.DAL.Data;
using ECommerce.DAL.Repositories.WriteRepositories.Interfaces;

namespace ECommerce.DAL.Repositories.WriteRepositories;

public class SellerWriteRepository(AppDbContext dbContext) : BaseWriteRepository<Seller>(dbContext), ISellerWriteRepository
{
}
