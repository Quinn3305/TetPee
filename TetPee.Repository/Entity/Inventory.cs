using TetPee.Repository.Abtraction;

namespace TetPee.Repository.Entity;

public class Inventory: BaseEntity<Guid>, IAudictableEntity
{
    //Tạo dây liên kết với Product
    public Guid  ProductId { get; set; }
    public required Product Product  { get; set; }
    
    
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
}