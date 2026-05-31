namespace ECommerce.Domain.Entities;

public class AppUserType : BaseEntity, IAuditEntity
{
    public string UserType { get; set; } = string.Empty!;
    public List<AppUser>? AppUsers { get; set; }
    public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
    public DateTimeOffset? UpdatedAt { get; set; }
    public DateTimeOffset? DeletedAt { get; set; }
    public string CreatedBy { get; set; } = string.Empty!;
    public string? UpdatedBy { get; set; }
    public string? DeletedBy { get; set; }
}
