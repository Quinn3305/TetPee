namespace TetPee.Service.Category;

public class Response
{
    public class CateGoryResponse
    {
        public Guid Id { get; set; }
    
        public string Name { get; set; } = null;
        //anh muốn trả ra thêm 
        public Guid? ParentId { get; set; }
    }
}