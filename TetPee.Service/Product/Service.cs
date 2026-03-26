using Microsoft.EntityFrameworkCore;
using TetPee.Repository;
using TetPee.Repository.Entity;

namespace TetPee.Service.Product;

public class Service : IService
{
    private readonly AppDbContext _dbContext;
    public Service(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<string> CreateProduct(Request.CreateProductRequest request)
    {
        //Check coi là product có tồn tại chưa
        var existingProductQuery = _dbContext.Products.Where(
            x => x.Name.ToLower().Trim() == request.Name.ToLower().Trim());
        
        bool isExistProduct = await existingProductQuery.AnyAsync();
        
        if(isExistProduct)
            throw new Exception("Product with the same name already exists");
        
        //Check coi seller có tồn tại chưa
        var existingSellerQuery = _dbContext.Sellers.Where(
            x => x.Id == request.SellerId);
        
        bool isExistSeller = await existingSellerQuery.AnyAsync();
        
        if(!isExistSeller) 
            throw new Exception("Seller not exist");

        
        var product = new Repository.Entity.Product()
        {
            Description = request.Description,
            Name = request.Name,
            Price = request.Price,
            SellerId = request.SellerId
        };

        _dbContext.Add(product);
        
        var sellerResult = await _dbContext.SaveChangesAsync();
        
        if(request.CategoryIds != null && request.CategoryIds.Count > 0)
        {
            var productCateList = request.CategoryIds.Select(id => new ProductCategory()
            {
                CategoryId = id,
                ProductId = product.Id,
            });
            
            
            _dbContext.AddRange(productCateList);
            await _dbContext.SaveChangesAsync();
        }

        if (sellerResult > 0) return "Add Product successfully";
            
        return "Add Product failed";
    }
}