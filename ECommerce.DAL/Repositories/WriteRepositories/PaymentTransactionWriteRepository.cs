using ECommerce.DAL.Data;
using ECommerce.DAL.Repositories.WriteRepositories.Interfaces;

namespace ECommerce.DAL.Repositories.WriteRepositories;

public class PaymentTransactionWriteRepository(AppDbContext dbContext) : BaseWriteRepository<PaymentTransaction>(dbContext), IPaymentTransactionWriteRepository
{
}
