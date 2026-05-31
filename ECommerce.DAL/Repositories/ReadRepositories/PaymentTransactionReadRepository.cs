using ECommerce.DAL.Data;

namespace ECommerce.DAL.Repositories.ReadRepositories;

public class PaymentTransactionReadRepository(AppDbContext dbContext) : BaseReadRepositories<PaymentTransaction>(dbContext), IPaymentTransactionReadRepository
{
}
