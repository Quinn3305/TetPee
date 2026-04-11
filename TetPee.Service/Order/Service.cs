using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using TetPee.Repository;
using TetPee.Repository.Entity;

namespace TetPee.Service.Order;

public class Service : IService
{
     private readonly AppDbContext _dbContext;
    private readonly IHttpContextAccessor _httpContext;

    public Service(AppDbContext dbContext, IHttpContextAccessor httpContext)
    {
        _dbContext = dbContext;
        _httpContext = httpContext;
    }
    
    //flow:
    // - Lấy user -> Kiểm tra sản phẩm -> Tính tiền -> Tạo Order + trả QR
    public async Task<Response.CreateOrderResponse> CreateOrder(Request.CreateOrderRequest request)
    {
        //lấy thông tin user đang đăng nhập từ token
        //vì mình cần phải biết được ai là người đặt hàng (User -> Order)
        var userId = _httpContext.HttpContext.User.Claims.FirstOrDefault(x => x.Type == "UserId")?.Value;
        var userIdGuid = Guid.Parse(userId!);//chuyển từ string -> Guid
        
        //List Object -> List Guid => Mapping List thì xài Select
        //Lấy ra danh sách ProductId của thằng User đó, loại bỏ trùng -> convert sang List
        var productIds = request.Products.Select(x => x.ProductId).Distinct().ToList();
        
        //Coi thử trong DB của mình, thằng nào có trong List ProductIds thì đếm
        //handler trường hợp người ta truyền vô linh tinh, tránh xung đột khóa ngoại
        var query = _dbContext.Products.Where(x => productIds.Contains(x.Id));
        //đếm sản phẩm
        var productCount = await query.CountAsync();
        //check thử có những sản phẩm không tồn tại không
        if (productCount != productIds.Count)
        {
            throw new Exception("Some products are not identical");
        }
        
        var result = await query.ToListAsync();

        decimal totalAmount = 0;
        
        foreach (var prod in result)
        {
            //Tìm trong list giỏ sàng sản phẩm để tìm số lượng mà khách hàng muốn mua
            var quantity = request.Products.First(x => x.ProductId == prod.Id).Quantity;

            if (quantity <= 0)
            {
                throw new Exception($"Quantity of product {prod.Id} must be greater than 0");
            }
            
            totalAmount += prod.Price * quantity;
        }

        if (totalAmount <= 0)
        {
            throw new Exception("Total amount must be greater than 0");
        }
        //flow ở trên: lấy thông tin yser
        //  check xem product (có nằm trong db không)
        //  tính tiền
        //xong ok rồi thì tiền hành tạo Order
        var order = new Repository.Entity.Order()
        {
            Id = Guid.NewGuid(),
            UserId = userIdGuid,
            TotalAmount = totalAmount,
            Address = request.Address,
            Status = "Pending",
            CreatedAt = DateTime.UtcNow,
        };
        _dbContext.Add(order);
        await _dbContext.SaveChangesAsync();
        
        //tạo OrderDetail
        List<OrderDetail> orderDetails = new List<OrderDetail>();
        foreach (var prod in result)
        {
            var quantity = request.Products.First(x => x.ProductId == prod.Id).Quantity;
            
            var orderDetail = new OrderDetail()
            {
                Id = Guid.NewGuid(),
                OrderId = order.Id,
                ProductId = prod.Id,
                Quantity = quantity,
                UnitPrice = prod.Price,
            };
            
            orderDetails.Add(orderDetail);
        }

        if (orderDetails.Any()) // coi có phần tử nào ko 
        {
            _dbContext.AddRange(orderDetails);
            await _dbContext.SaveChangesAsync();
        }
        
        //Tìm những sản phẩm chứa trong Cart với các id sau productIds của UserId(productIds cyar User nao)
        //Bank gửi về thì mình viết order nào
        string description = $"TETPEE-{order.Id}";

        //Trả về cho client những thứ này nhé
        var response = new Response.CreateOrderResponse()
        {
            OrderId = order.Id,
            TotalAmount = order.TotalAmount,
            BankName = "Sacombank", //Để giao dịch của mình trong đây
            BankAccount = "060335982994",
            Description =description ,
            QRCode = ""
        };
        //tạo qrcode này
        string qrCode = $"https://qr.sepay.vn/img?" +
                        $"acc={response.BankAccount}&" +
                        $"bank={response.BankName}&" +
                        $"amount={(int)totalAmount}&" +
                        $"des={description}&" +
                        $"template=qronly";
        response.QRCode = qrCode;
        return response;
    }

    public async Task SepayWebhookHandler(Request.SepayWebhookRequest request)
    {
        var description = request.Code;//TETPEEORDERID,
        //code và tổng số tiền là quan trọng trong callback API
        
        var raw = description.Replace("TETPEE", ""); // => ORDERID
        
        Guid? orderId = null;
        if (raw.Length == 32) // mặc định 1 Guid sẽ có 32 ký tự nếu không có gạch nối,
        //nếu không có dấu gạch nối thì sẽ có 36 ký tự
        {
            //Vì ORDERID theo format là không có dấu gạch ngang, nên format theo dấu gạch ngang
            //format của DB của mình
            //sample: 12b7b0ce-b395-4e7c-a3ec-7f27d485e10a
            var formatted = 
                            $"{raw.Substring(0, 8)}-" +
                            $"{raw.Substring(8, 4)}-" +
                            $"{raw.Substring(12, 4)}-" +
                            $"{raw.Substring(16, 4)}-" +
                            $"{raw.Substring(20, 12)}";
            //Id nhưng mà hiện tại nó đang theo string, chuẩn GUID rồi đó
            if (Guid.TryParse(formatted, out var guid))
            {
                orderId = guid;
            }
            //orderId  = Guid.Parse(formatted)
        }
        else
        {
            throw new Exception("Invalid exception format");
        }

        if (orderId == null)
        {
            throw new Exception("Order not found in description");
        }
        //kiểm tra order có tồn tại trong DB hay không
        var query = _dbContext.Orders
            .Where(x => x.Id == orderId)
            .Include(x => x.OrderDetails);
        var order = await query.FirstOrDefaultAsync();
        if (order == null)
        {
            throw new Exception("Order not found");
        }
        //nếu tồn tại mà status khác pending thì tức là đã xử lí rồi mà
        if (order.Status != "Pending")
        {
            throw new Exception("Order already progressed");
        }

        if (order.TotalAmount != request.TransferAmount)
        {
            throw new Exception("Invalid transfer amount");
        }
        order.Status = "Completed";
        _dbContext.Update(order);
        await _dbContext.SaveChangesAsync();
        
        var productIds = order.OrderDetails.Select(x => x.ProductId).ToList();
        
        var queryProductCart = _dbContext.CartDetails.Where(x => 
            x.Cart.UserId == order.UserId &&
            productIds.Contains(x.ProductId));
        
        var removeCartDetails = await queryProductCart.ToListAsync();
        // Tìm được rổi thì xóa nó đi
        _dbContext.RemoveRange(removeCartDetails);
        await _dbContext.SaveChangesAsync();       
    }
}
//Bản chất của SePay
// Sẽ là 1 thằng ngồi lắng nghe hết tất cả các giao dịch của mình trong tài khoản
//và mình có thể làm một thứ là nếu có giao dịch nào chuyển đến thì gọi 1 API callback
//api callback là s 
//vd a có 1 qr khi thành công nó sẽ sinh ra 1 cái giao dịch đối với giao dich nó sẽ gọi ra 1 api
// và không phải giao dịch nào cũng là giao dịch của hệ thống mình, 
    // giao dịch trả tiền nợ từ bạn A -> Call API
    // giao dịch mua hàng từ hệ thống TetPee -> Call API
    // Giao dịch trả tiền cổ tức -> Call API

    //Call APi của ai thì tùy mọi người setup với hệ thống của mình, nhưng ở đây anh muốn
    //là nó call API của mình để thông báo là đã ck thành công 
    
    //Không phải tất cả giao dịch nào cũng là giao dịch của hệ thống mình, vậy thì để
        //phân bịch giao dịch của mình, thì chúng ta sẽ tạo ra 1 dấu ấn riêng, làm dấu
