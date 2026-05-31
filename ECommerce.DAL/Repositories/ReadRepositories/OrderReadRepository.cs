using ECommerce.DAL.Data;
using ECommerce.Domain.Entities.Orders;

namespace ECommerce.DAL.Repositories.ReadRepositories;

public class OrderReadRepository(AppDbContext dbContext) : BaseReadRepositories<Order>(dbContext), IOrderReadRepository
{
}
