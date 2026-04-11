namespace TetPee.Service.Order;

public class Request
{
    public class CreateOrderRequest
    {   
        public string Address { get; set; }
        public string PhoneNumber {get; set;}
        public List<ProductOrderRequest> Products {get; set;}
    }
    
    public class ProductOrderRequest
    {
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
    }
    
    //Tạo đơn hàng (Giả sử hệ thống mình, muốn đặt hàng thì phải chuyển khoảng trước)
    //setup chuyển khoảng để thành công (bằng tiền thiệt), để xác nhận đơn hàng
    //đã được đặt
    //Nếu tạo ra đơn hàng mà không chuyển khoảng liền, thì đơn hàng sẽ bị hủy sau 15p
        
    
    //Huy don hang
    //cap nhat don hang

    public class SepayWebhookRequest
    {
        public string Gateway { get; set; }
        public string TransactionDate { get; set; }
        public string AccountNumber { get; set; }
        public string SubAccount { get; set; }
        public string Code { get; set; }
        public string Content { get; set; }
        public string TransferType { get; set; }
        public string Description { get; set; }
        public decimal TransferAmount { get; set; }
        public string ReferenceCode { get; set; }
        public decimal Accumulated { get; set; }
        public long Id {get; set;}
    }
    
}