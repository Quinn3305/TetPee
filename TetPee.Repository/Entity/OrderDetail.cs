using TetPee.Repository.Abtraction;

namespace TetPee.Repository.Entity;

public class OrderDetail : BaseEntity<Guid>, IAudictableEntity
{
    //Tạo khóa ngoại với Order
    public Guid OrderId {get;set;}
    public required Order Order {get;set;}
    
    //Tạo liên kết với Product
    public Guid ProductId {get;set;}
    public required Product Product {get;set;}
    public int Quantity  {get;set;} // số lượng nó mua là bao nhiêu
    public decimal UnitPrice  {get;set;} // giá thời điểm mua
    
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
}