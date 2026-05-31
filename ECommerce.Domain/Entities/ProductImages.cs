namespace ECommerce.Domain.Entities;

public class ProductImages : BaseEntity, IAuditEntity
{
    public Guid ProductId { get; set; }
    public Product? Product { get; set; }
    public string ImageUrl { get; set; } = string.Empty!;
    public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
    public DateTimeOffset? UpdatedAt { get; set; }
    public DateTimeOffset? DeletedAt { get; set; }
    public string CreatedBy { get; set; } = string.Empty;
    public string? UpdatedBy { get; set; }
    public string? DeletedBy { get; set; }
}
