using TetPee.Repository.Abtraction;

namespace TetPee.Repository.Entity;

public class Storage: BaseEntity<Guid>, IAudictableEntity
{
    public decimal Price  { get; set; }
    public required string Type{get;set;}// export, import
    
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
}