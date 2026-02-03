using TetPee.Repository.Abtraction;

namespace TetPee.Repository.Entity;

public class ProductStorage: BaseEntity<Guid>, IAudictableEntity
{
    //Tạo liên kết với Storage
    public Guid StorageId { get; set; }
    public required Storage Storage { get; set; }
    
    //Tạo liên kết với Product
    public Guid ProductId { get; set; }
    public required Product Product { get; set; }
    
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
}