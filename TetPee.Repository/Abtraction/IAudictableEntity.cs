namespace TetPee.Repository.Abtraction;

public interface IAudictableEntity  
{
    public DateTimeOffset CreatedAt {get;set;}// Dòng dữ liệu này tạo ra khi nào
    public DateTimeOffset?  UpdatedAt {get;set;} // Dòng dữ liệu này được cập nhật lần cuối khi nào
}