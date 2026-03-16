namespace TetPee.Service.Seller;

public interface IService
{
    public Task<Tetpee.Service.Base.Response.PageResult<Response.GetSellersResponse>> GetSellers
    (
        string? searchTerm,
        int pageSize,
        int pageIndex);
        
    public Task<Response.GetSellerByIdResponse?> GetSellerId(Guid id);
}