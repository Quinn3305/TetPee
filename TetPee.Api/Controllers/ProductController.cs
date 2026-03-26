using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TetPee.Api.Extensions;
using TetPee.Service.Category;
using IService = TetPee.Service.Product.IService;
using Request = TetPee.Service.Product.Request;

namespace TetPee.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private readonly Service.Product.IService _productService;

    public ProductController(IService productService)
    {
        _productService = productService;
    }

    // [Authorize(Policy = JwtExtensions.SellerPolicy)]
    [HttpPost("")]
    public async Task<IActionResult> CreateProduct(Request.CreateProductRequest request)
    {
            var result = await _productService.CreateProduct(request);
            return Ok(result);
    }
}