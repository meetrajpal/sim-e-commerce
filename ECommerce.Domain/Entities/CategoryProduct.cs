namespace ECommerce.Domain.Entities;

public class CategoryProduct : BaseEntity, IAuditEntity
{
    public Guid CategoryId { get; set; }
    public Category? Category { get; set; }
    public Guid ProductId { get; set; }
    public Product? Product { get; set; }
    public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
    public DateTimeOffset? UpdatedAt { get; set; }
    public DateTimeOffset? DeletedAt { get; set; }
    public string CreatedBy { get; set; } = string.Empty!;
    public string? UpdatedBy { get; set; }
    public string? DeletedBy { get; set; }
}
