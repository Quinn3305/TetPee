namespace TetPee.Service.Seller;

public class RequestSeller
{
    public class CreateSellerRequest
    {
        public string TaxCode { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
    }
}