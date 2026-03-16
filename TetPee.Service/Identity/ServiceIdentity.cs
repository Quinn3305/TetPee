namespace TetPee.Service.Identity;

public class ServiceIdentity:  IServiceIdentity
{
    
    public Task<ResponseIdentity.IdentityResponse> Login(string email, string password)
    {
        throw new NotImplementedException();
    }
}