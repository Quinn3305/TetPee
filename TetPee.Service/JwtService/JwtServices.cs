using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace TetPee.Service.JwtService;

public class JwtServices : IJwtServices
{
    private readonly JwtOptions _jwtOptionses = new();

    public JwtServices(IConfiguration configuration)
    {
        configuration.GetSection(nameof(JwtOptions)).Bind(_jwtOptionses);
        //Anh xa duw tu tu AppSettings vao object JwtOptions
    }
    public string GeneratAccessToken(IEnumerable<Claim> claims)
    {
        var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtOptionses.SecretKey));
        //tạo 1 Key để mã hóa token, sử dụng secretKey từ JwtOptions
        var signingCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
        //Tạo 1 đối tượng SigningCredentials để xác định thuật toán mã hóa và key sử dụng để ký token
        
        var tokenOptions = new JwtSecurityToken(
            issuer: _jwtOptionses.Issuer, //Cái token này được kí - tạo bởi ai, tổ chức nào 
            audience: _jwtOptionses.Audience, // Cái token này dành cho ai, tổ chức nào
            claims: claims, // Những thông tin mà bạn muốn lưu trữ trong token,
            // thường là thông tin về người dùng như Id, email, role, ..
            // nằm trong payload
            expires: DateTime.Now.AddMinutes(_jwtOptionses.ExpireMinutes),//Token sẽ hết hạn sau bao lâu
            signingCredentials: signingCredentials
        );
        
        var tokenString = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
        //Sau đó JwtSercurityTokenHandler
        // để tạo ra token dưới dạng chuỗi(string) từ các thông tin đã cung cấp ở trên
        return tokenString;
    }

    public ClaimsIdentity ValidateToken(string token)
    {
        throw new NotImplementedException();
    }
}