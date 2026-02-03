using TetPee.Repository.Abtraction;

namespace TetPee.Repository.Entity;

public class ProductCategory: BaseEntity<Guid>, IAudictableEntity
{
    public Guid CategoryId { get; set; } // FK
    public required Category Category { get; set; }
    
    public required Guid ProductId { get; set; } // FK
    public required Product Product { get; set; }
    
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
}