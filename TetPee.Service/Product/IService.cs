namespace TetPee.Service.Product;

public interface IService
{
    Task<string> CreateProduct (Request.CreateProductRequest request);
    
}