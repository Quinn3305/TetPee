using Microsoft.AspNetCore.Mvc;
using TetPee.Repository;
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
    public async Task<IActionResult> GetSellers(int pageIndex = 1, int pageSize = 10, string? searchTerm = null)
    {
        var ressult = await _sellerService.GetSellers(searchTerm, pageIndex, pageSize);
        return Ok(ressult);
        // return Ok(_dbContext.Categories.Find(id)); // có xử lí trường hợp null không
    }

    //GetDetailSellerByID
    [HttpGet("id")]
    public async Task<IActionResult> GetSellerById(Guid id)
    {
        var result = await _sellerService.GetSellerId(id);
        return Ok(result);
        // return Ok(_dbContext.Categories.Find(id)); // có xử lí trường hợp null không
    }
}