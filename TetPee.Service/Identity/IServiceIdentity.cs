namespace TetPee.Service.Identity;

public interface IServiceIdentity
{
    public Task<ResponseIdentity.IdentityResponse> Login(string email, string password);
}