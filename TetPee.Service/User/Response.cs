namespace ClassLibrary1.User;

public class Response
{
    public class GetUsersResponse
    {
        public Guid Id {get;set;}
        public required string Email {get;set;}
        public required string FirstName {get;set;}
        public required string LastName {get;set;}
        public string? ImageUrl { get; set; } = null;
        public string? Address {get;set;}
        public string? PhoneNumber {get;set;}
        public string Role { get; set; } = "User"; //User, Seller, Admin
  
    }
    
}