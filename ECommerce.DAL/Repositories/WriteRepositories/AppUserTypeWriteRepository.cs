using ECommerce.DAL.Data;
using ECommerce.DAL.Repositories.WriteRepositories.Interfaces;

namespace ECommerce.DAL.Repositories.WriteRepositories;

public class AppUserTypeWriteRepository(AppDbContext context) : BaseWriteRepository<AppUserType>(context), IAppUserTypeWriteRepository
{
}
