using TetPee.Repository.Abtraction;

namespace TetPee.Repository.Entity;

public abstract class Seller : BaseEntity<Guid>, IAudictableEntity
{
    // public Guid Id {get;set;}
    // public  bool IsDeleted  {get;set;} = false;// Soft Delete
    // public DateTimeOffset CreatedAt {get;set;}// Dòng dữ liệu này tạo ra khi nào
    // public DateTimeOffset?  UpdatedAt {get;set;} // Dòng dữ liệu này được cập nhật lần cuối khi nào
    public required string TaxCode  {get;set;}
    public required string CompanyName {get;set;}
    public required string CompanyAddress {get;set;}
    
    //Giống như việc tạo khóa ngoại (sợi dây liên kết với User)
    //Nên chỉ cần tạo 1 bên thôi 
    public Guid UserId  {get;set;}
    public User User {get;set;} //m có mối quan hệ với user
    //Thay vì kế thừa user thì mình có thể tạo field User để có dữ liệu để hứng
    //làm vậy đê biết nó có mối quan hệ với nhau
    
    //Seller chứa 1 mảng Product nè
    public ICollection<Product> Products {get;set;} = new List<Product>();
    
    
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
}