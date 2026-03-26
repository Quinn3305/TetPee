using Microsoft.AspNetCore.Mvc;
using TetPee.Repository;
using TetPee.Repository.Entity;
using TetPee.Service.User;

namespace TetPee.Api.Controllers;
//Bộ 3 khai báo hệ thống
[ApiController]
[Route("[controller]")] 
public class UserController : ControllerBase 
{
    
    private readonly AppDbContext  _dbContext;
    //muốn sài đc service thì phải khai báo
    private readonly IService _userService;
    //cái này nâng cao giải thich sau
    
    public UserController(AppDbContext dbContext, IService userService)
    {
        _dbContext = dbContext;
        _userService = userService;
    }
    
    //Get all user GET http://localhost:5000/User
    [HttpGet("")]
    public async Task<IActionResult> GetUsers(string? searchTerm, int pageSize = 10, int pageIndex = 1)
    {
        var users = await _userService.GetUsers(searchTerm, pageSize, pageIndex);
        // throw new Exception("Get Users Error");
        return Ok(users);
        // var users = _dbContext.Users.ToList();
        // // throw new Exception("Get Users Error");
        // return Ok(users);
    }
    
    //Get UserById
    [HttpGet("{id}")]
    public async Task<IActionResult> GetUserById(Guid id)
    {
        var user = await _userService.GetUserById(id);
        return Ok(user);
    }
    
    //Post: Create a User
    [HttpPost("")] // tạo và đưa dữ liệu lên db 
    public async Task<IActionResult> CreateUsers([FromBody] Request.CreateUserRequest request)
    //body phải truyền một object key:value 
    {
        var user = await _userService.CreateUser(request);
        return Ok(user);
    }
    
    
    //update user by id: PUT  http://localhost:5000/User/{id}
    [HttpPut("{id}")]
    public IActionResult UpdateUserById(Guid id, [FromBody] Request.UpdateUserRequest request)
    {
        return Ok("Update User By Id");
    }
    //delete user by id: DELETE //get all users http://localhost:5000/User/{id}
    
    [HttpDelete("{id}")] //path para,
    public IActionResult DeleteUserById(Guid id)
    {
        return Ok("Delete User By Id");
    }
    //HTTP METHOD: Get Post Delete put patch
    //Param: query stringng, path param, body param
    //Query string: http://localhost:5000/User?=name=abc&age=20
    //name va age la query string
    //Query string nằm sau dấu ?
    
    //Path(Route) Param: http://localhost:5000/User/123
    //123 là path param hoặc route param
    //Path param nằm trong đường dẫn
    //Get là không có body
    //Post put patch có body
    //Tại 
    
    //123 là path pram hoact route praram
    //Path param nằm trong đường dẫn
    
    // GET la 2ko có body
    // POST, PUT, PATCH có body
    
    // Tại sao phải dùng body: Tránh để lộ những thông tin ko mong muốn
    
    //ví dụ: Username, Pass
    // không thể http://localhost:5000/login?username=abc&password=123
    
    //Chuẩn res full API
    //Get all user GET http://localhost:5000/User
    //create user: POST http://localhost:5000/User
    //get user by id:   Get //get all users http://localhost:5000/User/{id}
    //update user by id: PUT  http://localhost:5000/User/{id}
    //delete user by id: DELETE //get all users http://localhost:5000/User/{id}
}