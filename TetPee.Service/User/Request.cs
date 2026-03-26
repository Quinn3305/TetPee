using Microsoft.AspNetCore.Http;

namespace TetPee.Service.User;

public class Request
{
    //Nơi chứa dữ liệu mà người dùng gửi lên Server
    //Tức là lúc này bên Front-End bắt người dùng phải nhập
    //các dữ liệu này thì mới tiếp tục việc đăng ký được
    public class CreateUserRequest
    {
        public required string Email  {get;set;}
        
        public IFormFile? Avatar { get; set; }
        public required string FirstName {get;set;}
        public required string LastName {get;set;}
        public required string Password {get;set;}
            
    }
    public class UpdateUserRequest : CreateUserRequest
    {
        public Guid Id  { get; set; }
        
    }
    
}