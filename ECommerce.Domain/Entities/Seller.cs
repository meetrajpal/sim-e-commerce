namespace ECommerce.Domain.Entities;

public class Seller : BaseEntity, IAuditEntity
{
    public string SellerName { get; set; } = string.Empty!;
    public string StoreName { get; set; } = string.Empty!;
    public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
    public DateTimeOffset? UpdatedAt { get; set; }
    public DateTimeOffset? DeletedAt { get; set; }
    public string CreatedBy { get; set; } = string.Empty!;
    public string? UpdatedBy { get; set; }
    public string? DeletedBy { get; set; }
}
