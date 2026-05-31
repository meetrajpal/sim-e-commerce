namespace ECommerce.Domain.Entities;

public class Product : BaseEntity, IAuditEntity
{
    public string ProductName { get; set; } = string.Empty!;
    public decimal Price { get; set; }
    public string? Description { get; set; }
    public int Quantity { get; set; }
    public Guid SellerId { get; set; }
    public Seller? Seller { get; set; }
    public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
    public DateTimeOffset? UpdatedAt { get; set; }
    public DateTimeOffset? DeletedAt { get; set; }
    public string CreatedBy { get; set; } = string.Empty!;
    public string? UpdatedBy { get; set; }
    public string? DeletedBy { get; set; }
    public List<ProductImages>? ProductImages { get; set; }
    public List<CategoryProduct>? ProductCategories { get; set; }
}
