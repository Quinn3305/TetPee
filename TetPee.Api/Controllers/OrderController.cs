using Microsoft.AspNetCore.Mvc;
using TetPee.Service.Models;
using TetPee.Service.Order;

namespace TetPee.Api.Controllers;
[ApiController]
[Route("[controller]")] 
public class OrderController: ControllerBase
{
    private readonly IService _orderService;
    public OrderController(IService orderService)
    {
        _orderService = orderService;
    }

    [HttpPost("")]
    public async Task<IActionResult> CreateOrder(Request.CreateOrderRequest createOrderRequest)
    {
        var result =  await  _orderService.CreateOrder(createOrderRequest);
        return Ok(ApiResponse.ApiResponseFactory.SuccessResponse(result, "Created Order Successfully", HttpContext.TraceIdentifier));
    }
    
    [HttpPost("sepay/webhook")]
    public async Task<IActionResult> SepayWebhook(Request.SepayWebhookRequest  sepayWebhookRequest)
    {
        await _orderService.SepayWebhookHandler(sepayWebhookRequest);
        return Ok(ApiResponse.ApiResponseFactory.SuccessResponse("", "Webhook response", HttpContext.TraceIdentifier));
    } 
}