using TetPee.Repository.Abtraction;

namespace TetPee.Repository.Entity;

public class Order : BaseEntity<Guid>, IAudictableEntity
{
    public decimal TotalAmount  { get; set; }
    public string Status { get; set; } = "Pending";//Pending , Processing, Compeleted,Cancled
    public string? Address {get;set;}
    
    public ICollection<OrderDetail>  OrderDetails {get;set;} = new List<OrderDetail>();
    
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
}