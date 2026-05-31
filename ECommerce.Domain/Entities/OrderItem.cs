using ECommerce.Domain.Entities.Orders;

namespace ECommerce.Domain.Entities;

public class OrderItem : BaseEntity, IAuditEntity
{
    public Guid OrderId { get; set; }
    public Order? Order { get; set; }
    public Guid ProductId { get; set; }
    public Product? Product { get; set; }
    public int ProductQuantity { get; set; }
    public decimal Amount { get; set; }
    public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
    public DateTimeOffset? UpdatedAt { get; set; }
    public DateTimeOffset? DeletedAt { get; set; }
    public string CreatedBy { get; set; } = string.Empty!;
    public string? UpdatedBy { get; set; }
    public string? DeletedBy { get; set; }
}
