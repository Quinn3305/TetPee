using Microsoft.AspNetCore.Mvc;
using TetPee.Repository;
using TetPee.Service.Models;
using TetPee.Service.Seller;

namespace TetPee.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class SellerController : ControllerBase
{
    private readonly AppDbContext _dbContext;
    //cái này nâng cao giải thich sau
    private readonly IService _sellerService;

    public SellerController(AppDbContext dbContext, IService sellerService)
    {
        _dbContext = dbContext;
        _sellerService = sellerService;
    }


    //GetAllSeller - Có phân trang
    [HttpGet("")]
    public async Task<IActionResult> GetSellers(string? searchTerm, int pageIndex = 1, int pageSize = 10 )
    {
        var result = await _sellerService.GetSellers(searchTerm, pageSize, pageIndex);
        return Ok(ApiResponse.ApiResponseFactory.SuccessResponse(result, message:"Seller retrieved", HttpContext.TraceIdentifier));
        // return Ok(_dbContext.Categories.Find(id)); // có xử lí trường hợp null không
    }

    //GetDetailSellerByID
    [HttpGet("id")]
    public async Task<IActionResult> GetSellerById(Guid id)
    {
        var result = await _sellerService.GetSellerId(id);
        return Ok(ApiResponse.ApiResponseFactory.SuccessResponse(result, message:"Seller retrieved", HttpContext.TraceIdentifier));
        // return Ok(_dbContext.Categories.Find(id)); // có xử lí trường hợp null không
    }
    
    [HttpPost("")] // tạo và đưa dữ liệu lên db 
    public async Task<IActionResult> CreateSeller([FromBody] Request.CreateSellerRequest request)
    //body phải truyền một object key:value 
    {
        var seller = await _sellerService.CreateSeller(request);
        return Ok(ApiResponse.ApiResponseFactory.SuccessResponse(seller, message:"Seller retrieved", HttpContext.TraceIdentifier));
    }
    
}