using ECommerce.Domain.Entities.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Reflection;

namespace ECommerce.DAL.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : IdentityDbContext<AppUser, IdentityRole<Guid>, Guid>(options)
{
    public DbSet<AppUserType> AppUserTypes => Set<AppUserType>();
    public DbSet<AppUser> AppUsers => Set<AppUser>();
    public DbSet<Customer> Customers => Set<Customer>();
    public DbSet<Employee> Employees => Set<Employee>();
    public DbSet<Seller> Sellers => Set<Seller>();
    public DbSet<Category> Categories => Set<Category>();
    public DbSet<Product> Products => Set<Product>();
    public DbSet<ProductImages> ProductImages => Set<ProductImages>();
    public DbSet<CategoryProduct> CategoryProducts => Set<CategoryProduct>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        modelBuilder.Entity<IdentityRole<Guid>>().HasData(
            new IdentityRole<Guid>() { Id = Guid.Parse("11111111-1111-1111-1111-111111111111"), Name = "Admin", NormalizedName = "ADMIN" },
            new IdentityRole<Guid>() { Id = Guid.Parse("22222222-2222-2222-2222-222222222222"), Name = "Employee", NormalizedName = "EMPLOYEE" },
            new IdentityRole<Guid>() { Id = Guid.Parse("33333333-3333-3333-3333-333333333333"), Name = "Customer", NormalizedName = "CUSTOMER" },
            new IdentityRole<Guid>() { Id = Guid.Parse("44444444-4444-4444-4444-444444444444"), Name = "Seller", NormalizedName = "SELLER" }
        );

        modelBuilder.Entity<AppUserType>().HasData(
            new AppUserType()
            {
                Id = Guid.Parse("11111111-1111-1111-1111-111111111111"),
                UserType = "Employee",
                CreatedAt = new DateTime(2026, 5, 31, 0, 0, 0, DateTimeKind.Utc),
                CreatedBy = "system",
                IsDeleted = false
            },
            new AppUserType()
            {
                Id = Guid.Parse("22222222-2222-2222-2222-222222222222"),
                UserType = "Customer",
                CreatedAt = new DateTime(2026, 5, 31, 0, 0, 0, DateTimeKind.Utc),
                CreatedBy = "system",
                IsDeleted = false
            },
            new AppUserType()
            {
                Id = Guid.Parse("33333333-3333-3333-3333-333333333333"),
                UserType = "Seller",
                CreatedAt = new DateTime(2026, 5, 31, 0, 0, 0, DateTimeKind.Utc),
                CreatedBy = "system",
                IsDeleted = false
            }
        );
    }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        var userId = "system";

        foreach (var entry in ChangeTracker.Entries<IAuditEntity>())
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.Entity.CreatedAt = DateTimeOffset.UtcNow;
                    entry.Entity.CreatedBy = userId;
                    break;

                case EntityState.Modified:
                    entry.Entity.UpdatedAt = DateTimeOffset.UtcNow;
                    entry.Entity.UpdatedBy = userId;
                    break;

                case EntityState.Deleted:
                    entry.Entity.DeletedAt = DateTimeOffset.UtcNow;
                    entry.Entity.DeletedBy = userId;
                    break;
            }
        }

        return await base.SaveChangesAsync(cancellationToken);
    }
}
