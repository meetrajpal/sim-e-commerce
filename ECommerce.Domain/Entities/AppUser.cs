namespace ECommerce.Domain.Entities;

public class AppUser : IdentityUser<Guid>, IAuditEntity
{
    public Guid UserTypeId { get; set; }
    public AppUserType? UserType { get; set; }

    public string? RefreshToken { get; set; }
    public DateTime? RefreshTokenExpiryTime { get; set; }

    public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
    public DateTimeOffset? UpdatedAt { get; set; }
    public DateTimeOffset? DeletedAt { get; set; }
    public string CreatedBy { get; set; } = string.Empty!;
    public string? UpdatedBy { get; set; }
    public string? DeletedBy { get; set; }
    public bool IsDeleted { get; set; } = false;
}
