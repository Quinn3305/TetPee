using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TetPee.Service.Cart;
using TetPee.Service.Models;

namespace TetPee.Api.Controllers;
[Authorize]
[ApiController]
[Route("[controller]")]
public class CartController: ControllerBase
{
    private readonly IService _cartService;
    public CartController(IService cartService)
    {
        _cartService = cartService;
    }

    [HttpPost("")]
    public async Task<IActionResult> CreateCart()
    {
        await _cartService.CreateCart();
        return Ok(ApiResponse.ApiResponseFactory.SuccessResponse(null, "Cart created", HttpContext.TraceIdentifier));
    }
    [HttpPost("product")]
    public async Task<IActionResult> AddProductToCart([FromBody]Request.AddProductToCartRequest request)
    {
        await _cartService.AddProductToCart(request);
        return Ok(ApiResponse.ApiResponseFactory.SuccessResponse("Successfully", "Product Add To Cart", HttpContext.TraceIdentifier));
    }

    [HttpDelete("product")]
    public async Task<IActionResult> DeleteProductFromCart([FromBody] Request.RemoveProductFromCartRequest request)
    {
        await _cartService.RemoveProductFromCart(request);
        return Ok(ApiResponse.ApiResponseFactory.SuccessResponse("Successfully", "Product remove", HttpContext.TraceIdentifier)); 
    }
    [HttpGet("product")]
    public async Task<IActionResult> GetCart()
    {
        var result = await _cartService.GetCart();
        return Ok(ApiResponse.ApiResponseFactory.SuccessResponse(result, "Product retrive", HttpContext.TraceIdentifier)); 
    }
}