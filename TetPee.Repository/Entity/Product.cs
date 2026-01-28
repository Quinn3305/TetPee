using TetPee.Repository.Abtraction;

namespace TetPee.Repository.Entity;

public abstract class Product : BaseEntity<Guid>, IAudictableEntity
{
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required string UrlImage { get; set; }
    public decimal Price { get; set; }
    
    public Guid SellerId { get; set; } // FK
    public required Seller Seller { get; set; }
    
    public ICollection<OrderDetail>  OrderDetails { get; set; } = new List<OrderDetail>();
    public ICollection<ProductCategory>  ProductCategories { get; set; } = new List<ProductCategory>();
    public ICollection<ProductStorage>  ProductStorages { get; set; } = new List<ProductStorage>();
    
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
}