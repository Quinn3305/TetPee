namespace TetPee.Service.User;

public class Response
{
    public class GetUsersResponse
    {
        public Guid Id {get;set;}
        public string Email { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? ImageUrl { get; set; } = null;
        public string? PhoneNumber { get; set; } = null;
        public string? Address { get; set; }
        public string Role { get; set; } = "User"; //User, Seller, Admin
  
    }

    public class GetAllUsersResponse
    {
        public Guid Id { get; set; }
        public string Email { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? ImageUrl { get; set; } = null;
        public string Role { get; set; } = "User";
  
    }
    
}