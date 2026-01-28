using TetPee.Repository.Abtraction;

namespace TetPee.Repository.Entity;

public class Cart : BaseEntity<Guid>, IAudictableEntity
{
    
    //Tạo dây nối vô user
    public Guid UserId  {get;set;}
    public User User {get;set;}
    
    // public Decimal {get;}
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
}