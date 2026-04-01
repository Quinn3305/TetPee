using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TetPee.Repository;
using TetPee.Service.JwtService;

namespace TetPee.Service.Identity;

public class Service: IService
{
    
    
    // private readonly IJwtServices _jwtServices;
    // private readonly AppDbContext  _dbContext;
    // private readonly JwtOptions _jwtOptions = new();
    //
    // public Service(IJwtServices jwtServices, AppDbContext dbContext, IConfiguration configuration)
    // {
    //     _jwtServices = jwtServices;
    //     _dbContext = dbContext;
    //     configuration.GetSection(nameof(JwtOptions)).Bind(_jwtOptions);
    // }
    //
    // public async Task<Response.IdentityResponse> Login(string email, string password)
    // {
    //     var user = await _dbContext.Users.FirstOrDefaultAsync(u => u.Email == email);
    //     if (user == null)
    //     {
    //         throw new Exception("User not found");
    //     }
    //
    //     if (user.HashedPassword != password)
    //     {
    //         throw new Exception("Invalidate Passwords");
    //     }
    //     //User nay chac chan la toi
    //     var claims = new List<Claim>
    //     {
    //         new Claim("UserId", user.Id.ToString()),
    //         new Claim("Email", user.Email),
    //         new Claim("Role", user.Role),
    //         new Claim(ClaimTypes.Role, user.Role),
    //         new Claim(ClaimTypes.Expired,
    //             //Phải có clainm này để phân quyền cho API endpoint nếu thiếu claim này thì sẽ không phân quyền được
    //             DateTimeOffset.UtcNow.AddMinutes(_jwtOptions.ExpireMinutes).ToString())
    //         //
    //     };
    //     var token = _jwtServices.GeneratAccessToken(claims);
    //     var result = new Response.IdentityResponse()
    //     {
    //         AccessToken = token,
    //     };
    //     return  result;
    // }
    private readonly AppDbContext _dbcontext;
    private readonly IJwtServices _jwtServices;
    private readonly JwtOptions _jwtOptions = new() ;

    public Service(AppDbContext dbcontext, IJwtServices jwtServices, IConfiguration configuration)
    {
        _dbcontext = dbcontext;
        _jwtServices = jwtServices;
        configuration.GetSection(nameof(JwtOptions)).Bind(_jwtOptions);
    }

    public async Task<Response.IdentityResponse> Login(string Email, string Password)
    {
        var user = await _dbcontext.Users.Include(x=> x.Seller).FirstOrDefaultAsync(x => x.Email == Email);
        if (user == null) throw new Exception("User Exist");
        
        if(user.HashedPassword != Password)  throw new Exception("pass not match");

        var claims = new List<Claim>()
        {
            new Claim("UserId", user.Id.ToString()),
            new Claim("Email", user.Email),
            new Claim("Role", user.Role),
            new Claim(ClaimTypes.Role, user.Role),
            new Claim(ClaimTypes.Expired, 
                DateTimeOffset.UtcNow.AddMinutes(_jwtOptions.ExpireMinutes).ToString())
        };
        
        if (user.Role == "Seller")
        {
            var seller = await _dbcontext.Sellers.FirstOrDefaultAsync(x => x.UserId == user.Id);
            if (seller != null)
            {
                claims.Add(new Claim("SellerId", seller.Id.ToString()));
            }
        }
        var token = _jwtServices.GeneratAccessToken(claims);
        var result = new Response.IdentityResponse()
        {
            Accesstoken = token,
        };
        return result;
    }
}