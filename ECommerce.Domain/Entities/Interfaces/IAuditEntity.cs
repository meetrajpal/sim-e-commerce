namespace ECommerce.Domain.Entities.Interfaces;

public interface IAuditEntity
{
    DateTimeOffset CreatedAt { get; set; }
    DateTimeOffset? UpdatedAt { get; set; }
    DateTimeOffset? DeletedAt { get; set; }
    string CreatedBy { get; set; }
    string? UpdatedBy { get; set; }
    string? DeletedBy { get; set; }
}
