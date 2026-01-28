using TetPee.Repository.Abtraction;

namespace TetPee.Repository.Entity;

public class OrderDetail : BaseEntity<Guid>, IAudictableEntity
{
    //Tạo khóa ngoại với Order
    public Guid OrderId {get;set;}
    public Order Order {get;set;}
    
    //Tạo liên kết với Product
    public Guid ProductId {get;set;}
    public Product Product {get;set;}
    
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
}