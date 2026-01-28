using TetPee.Repository.Abtraction;

namespace TetPee.Repository.Entity;

public abstract class OrderDetail : BaseEntity<Guid>, IAudictableEntity
{
    //Tạo khóa ngoại với Order
    public Guid OrderId {get;set;}
    public required Order Order {get;set;}
    
    //Tạo liên kết với Product
    public Guid ProductId {get;set;}
    public required Product Product {get;set;}
    
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
}