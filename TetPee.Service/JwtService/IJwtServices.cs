using System.Security.Claims;

namespace TetPee.Service.JwtService;

public interface IJwtServices
{
    public string GeneratAccessToken(IEnumerable<Claim> claims);
    
    ClaimsIdentity ValidateToken(string token);
}