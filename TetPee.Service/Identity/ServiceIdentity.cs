using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TetPee.Repository;
using TetPee.Service.JwtService;

namespace TetPee.Service.Identity;

public class ServiceIdentity:  IServiceIdentity
{
    private readonly JwtService.IJwtServices _jwtServices;
    private readonly AppDbContext  _dbContext;
    private readonly JwtOptions _jwtOptions = new();
    
    public ServiceIdentity(IJwtServices jwtServices, AppDbContext dbContext, IConfiguration configuration)
    {
        _jwtServices = jwtServices;
        _dbContext = dbContext;
        configuration.GetSection(nameof(JwtOptions)).Bind(_jwtOptions);
    }

    public async Task<ResponseIdentity.IdentityResponse> Login(string email, string password)
    {
        var user = await _dbContext.Users.FirstOrDefaultAsync(u => u.Email == email);
        if (user == null)
        {
            throw new Exception("User not found");
        }

        if (user.HashedPassword != password)
        {
            throw new Exception("Invalidate Passwords");
        }
        //User nay chac chan la toi
        var claims = new List<Claim>
        {
            new Claim("UserId", user.Id.ToString()),
            new Claim("Email", user.Email),
            new Claim("Role", user.Role),
            new Claim(ClaimTypes.Role, user.Role),
            new Claim(ClaimTypes.Expired,
                //Phải có clainm này để phân quyền cho API endpoint nếu thiếu claim này thì sẽ không phân quyền được
                DateTimeOffset.UtcNow.AddMinutes(_jwtOptions.ExpireMinutes).ToString())
            //
        };
        var token = _jwtServices.GeneratAccessToken(claims);
        var result = new ResponseIdentity.IdentityResponse()
        {
            AccessToken = token,
        };
        return  result;
        
        

    }
}