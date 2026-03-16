namespace TetPee.Service.Category;

public interface IService
{
    public Task<List<Response.CateGoryResponse>> GetCateGory();
    public Task<List<Response.CateGoryResponse>> GetChildrenByCateGory(Guid parentId);
}   