using TetPee.Repository.Abtraction;

namespace TetPee.Repository.Entity;

public class Order : BaseEntity<Guid>, IAudictableEntity
{
    public required decimal TotalAmount  { get; set; }
    public required string Status { get; set; } = "Pending"; //Pending, Completed, Cancelled
    public required string Address { get; set; }
    
    //Tạo liên kết với User
    public required Guid UserId { get; set; }
    public User User { get; set; }
    
    //Cấn cấn khúc nàu nè
    //1 order có nhiều orderDetail á nên dị á 
    public ICollection<OrderDetail>  OrderDetails { get; set; } = new List<OrderDetail>();
    
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
}