using ECommerce.Domain.Entities.Orders;

namespace ECommerce.Domain.Entities;

public class PaymentTransaction : BaseEntity, IAuditEntity
{
    public Guid OrderId { get; set; }
    public Order? Order { get; set; }
    public string Description { get; set; } = string.Empty!;
    public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
    public DateTimeOffset? UpdatedAt { get; set; }
    public DateTimeOffset? DeletedAt { get; set; }
    public string CreatedBy { get; set; } = string.Empty!;
    public string? UpdatedBy { get; set; }
    public string? DeletedBy { get; set; }
}
