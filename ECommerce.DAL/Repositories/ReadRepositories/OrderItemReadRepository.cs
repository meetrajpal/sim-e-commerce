using ECommerce.DAL.Data;

namespace ECommerce.DAL.Repositories.ReadRepositories;

public class OrderItemReadRepository(AppDbContext dbContext) : BaseReadRepositories<OrderItem>(dbContext), IOrderItemReadRepository
{
}
