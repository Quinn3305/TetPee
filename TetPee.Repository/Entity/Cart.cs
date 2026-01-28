using TetPee.Repository.Abtraction;

namespace TetPee.Repository.Entity;

public abstract class Cart : BaseEntity<Guid>, IAudictableEntity
{
    
    //Tạo dây nối vô user
    public Guid UserId  {get;set;}
    public required User User {get;set;}
    
    // public Decimal {get;}
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
}