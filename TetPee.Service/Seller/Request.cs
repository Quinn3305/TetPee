namespace TetPee.Service.Seller;

public class Request
{
    public class CreateSellerRequest
    {
        public string TaxCode { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
    }
}