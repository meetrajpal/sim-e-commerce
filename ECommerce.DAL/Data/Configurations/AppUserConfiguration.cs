using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.DAL.Data.Configurations;

public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
{
    public void Configure(EntityTypeBuilder<AppUser> builder)
    {
        builder.HasOne(x => x.UserType).WithMany(x => x.AppUsers).HasForeignKey(x => x.UserTypeId).HasConstraintName("FK_AppUser_AppUserType");

        builder.Property(c => c.IsDeleted).HasDefaultValue(false);

        builder.Property(c => c.CreatedAt).HasDefaultValueSql("GETUTCDATE()");
        builder.Property(c => c.UpdatedAt).IsRequired(false);
        builder.Property(c => c.DeletedAt).IsRequired(false);

        builder.Property(c => c.CreatedBy).HasColumnType("NVARCHAR(100)").IsRequired();
        builder.Property(c => c.UpdatedBy).HasColumnType("NVARCHAR(100)").IsRequired(false);
        builder.Property(c => c.DeletedBy).HasColumnType("NVARCHAR(100)").IsRequired(false);

        builder.Property(u => u.RefreshToken)
           .HasMaxLength(500);
    }
}
