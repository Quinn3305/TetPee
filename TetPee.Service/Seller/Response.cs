namespace TetPee.Service.Seller;

public class Response
{
    //Định hình đầu ra
    public class GetSellersResponse : User.Response.GetAllUsersResponse
    {
       
        public string? CompanyName { get; set; }
        public string? TaxCode { get; set; }
  
    }
    public class GetSellerByIdResponse : User.Response.GetUsersResponse
    {
        
        public string? TaxCode { get; set; } 
        public string? CompanyName { get; set; } 
        public string? CompanyAddress { get; set; } 
    }
}