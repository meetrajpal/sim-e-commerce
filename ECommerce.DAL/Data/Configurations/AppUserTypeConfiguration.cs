using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.DAL.Data.Configurations;

public class AppUserTypeConfiguration : IEntityTypeConfiguration<AppUserType>
{

    public void Configure(EntityTypeBuilder<AppUserType> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasDefaultValueSql("NEWSEQUENTIALID()");
        builder.Property(x => x.UserType).HasColumnType("NVARCHAR(100)").IsRequired();
        builder.HasIndex(x => x.UserType).HasDatabaseName("IX_Unique_AppUserType_UserType").IsUnique();

        builder.Property(c => c.IsDeleted).HasDefaultValue(false);

        builder.Property(c => c.CreatedAt).HasDefaultValueSql("GETUTCDATE()");
        builder.Property(c => c.UpdatedAt).IsRequired(false);
        builder.Property(c => c.DeletedAt).IsRequired(false);

        builder.Property(c => c.CreatedBy).HasColumnType("NVARCHAR(100)").IsRequired();
        builder.Property(c => c.UpdatedBy).HasColumnType("NVARCHAR(100)").IsRequired(false);
        builder.Property(c => c.DeletedBy).HasColumnType("NVARCHAR(100)").IsRequired(false);

    }
}
