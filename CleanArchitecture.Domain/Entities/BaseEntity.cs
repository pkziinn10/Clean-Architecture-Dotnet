namespace Domain.Entities;

public abstract class BaseEntity
{
    public Guid Id { get; set; }
    public DateTimeOffset? CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
    public DateTimeOffset? IsDeleted { get; set; }
}