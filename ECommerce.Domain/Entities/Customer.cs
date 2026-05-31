namespace ECommerce.Domain.Entities;

public class Customer : BaseEntity, IAuditEntity
{
    public string CustomerName { get; set; } = string.Empty!;
    public string Address { get; set; } = string.Empty!;
    public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
    public DateTimeOffset? UpdatedAt { get; set; }
    public DateTimeOffset? DeletedAt { get; set; }
    public string CreatedBy { get; set; } = string.Empty!;
    public string? UpdatedBy { get; set; }
    public string? DeletedBy { get; set; }
}
