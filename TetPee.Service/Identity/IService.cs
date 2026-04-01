namespace TetPee.Service.Identity;

public interface IService
{
        public Task<Response.IdentityResponse> Login(string Email, string Password);
        
        // public Task<Response.IdentityResponse> Login(string email, string password);
}