namespace TetPee.Service.Product;

public interface IService
{
    // public Task<String> CreateProduct(Request.CreateProductRequest request);
    
    Task<string> CreateProduct (Request.CreateProductRequest request);
    
}