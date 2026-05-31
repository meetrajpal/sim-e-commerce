using ECommerce.DAL.Data;

namespace ECommerce.DAL.Repositories.ReadRepositories;

public class AppUserTypeReadRepository(AppDbContext context) : BaseReadRepositories<AppUserType>(context), IAppUserTypeReadRepository
{
}
