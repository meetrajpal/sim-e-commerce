namespace ECommerce.Domain.Entities.Orders;

public abstract class Order : BaseEntity, IAuditEntity
{
    public List<OrderItem> OrderItems { get; set; } = [];
    public virtual OrderStatus Status { get; } = OrderStatus.Created;
    public virtual PaymentType PaymentType { get; }
    public Guid CustomerId { get; set; }
    public Customer? Customer { get; set; }
    public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
    public DateTimeOffset? UpdatedAt { get; set; }
    public DateTimeOffset? DeletedAt { get; set; }
    public string CreatedBy { get; set; } = string.Empty!;
    public string? UpdatedBy { get; set; }
    public string? DeletedBy { get; set; }
}
