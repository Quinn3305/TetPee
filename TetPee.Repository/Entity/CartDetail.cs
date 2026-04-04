using TetPee.Repository.Abtraction;

namespace TetPee.Repository.Entity;

public class CartDetail : BaseEntity<Guid>, IAudictableEntity
{
    //Tạo khóa ngoại với Order
    public Guid CartId { get; set; }
    public Cart Cart { get; set; }

    //Tạo liên kết với Product
    public Guid ProductId { get; set; }
    public Product Product { get; set; }
    
    public int Quantity { get; set; } // số lượng nó mua là bao nhiêu

    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
}