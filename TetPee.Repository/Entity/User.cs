using TetPee.Repository.Abtraction;

namespace TetPee.Repository.Entity;

public abstract class User : BaseEntity<Guid>, IAudictableEntity
{
    // public Guid Id {get;set;}
    
    public required string Email {get;set;}
    public required string FirstName {get;set;}
    public required string LastName {get;set;}
    public string? PhoneNumber {get;set;}
    public string? ImageUrl { get; set; } = null;
    public string? Address {get;set;}
    public required string HashedPassword {get;set;}
    public string Role { get; set; } = "User"; //User, Seller, Admin
    public bool IsVerify {get;set;} = false;//khi tạo mới 1 user register, thì mình phải verify email hợp lệ
    public int VerifyCode {get;set;} //Mã verify gửi về mail
    //(down)thuật ngữ con bot: trong 5p hay 10p thằng nào chưa verify thì con bot sẽ dọn dẹp
    // Đây là background job
    // Hangfire 
    // Quartz
    // Cron job
    //để tránh xung đột relationship
    // public  bool IsDeleted  {get;set;} = false;// Soft Delete
    // public DateTimeOffset CreatedAt {get;set;}// Dòng dữ liệu này tạo ra khi nào
    // public DateTimeOffset?  UpdatedAt {get;set;} // Dòng dữ liệu này được cập nhật lần cuối khi nào
    
    // tách ra những field trong interface để tái sử dụng, 
    // còn kế thừa thì bắt buộc phải có các field đó
    // BaseEntity:
    // Dùng cho Id + Soft Delete
    // Entity nào cũng cần
    // Interface:
    // Entity nào cần audit thì implement
    // Không bắt buộc tất cả
    // Soft Delete // Tránh xung đột khóa ngoại (FK Constraint)
    public ICollection<Order> Orders {get;set;} = new List<Order>(); 
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
}