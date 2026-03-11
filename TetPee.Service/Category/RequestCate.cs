namespace ClassLibrary1.Category;

public class RequestCate
{
    public class CreateCategoryRequest
    {
        public required string Name { get; set; }
        public Guid? ParentId { get; set; }
    }
    
}