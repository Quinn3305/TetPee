using TetPee.Repository.Abtraction;

namespace TetPee.Repository.Entity;

public class Order : BaseEntity<Guid>, IAudictableEntity
{
    public decimal TotalAmount  { get; set; }
    public string Status { get; set; } = "Pending"; //Pending, Processing, Completed, Cancelled
    public required string Address { get; set; }
    
    //Tạo liên kết với User
    public Guid UserId { get; set; }
    public User User { get; set; }
    
    public ICollection<OrderDetail>  OrderDetails { get; set; } = new List<OrderDetail>();
    
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
}