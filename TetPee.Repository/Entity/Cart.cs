

using TetPee.Repository.Abtraction;

namespace TetPee.Repository.Entity;

public class Cart: BaseEntity<Guid>, IAudictableEntity
{
    //Lưu cart để phục vụ cho trair nghiệm người dùng UIUX
    
    public Guid UserId  {get;set;}
    public User User {get;set;}
    
    public DateTimeOffset CreatedAt { get; set; } 
    public DateTimeOffset? UpdatedAt { get; set; } 
}
