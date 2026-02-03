using ClassLibrary1.User;
using Microsoft.AspNetCore.Mvc;
using TetPee.Repository;
using TetPee.Repository.Entity;

namespace TetPee.Api.Controllers;
//Bộ 3 khai báo hệ thống
[ApiController]
[Route("[controller]")] 
public class UserController : ControllerBase 
{
    private readonly AppDbContext  _dbcontext;
    //cái này nâng cao giải thich sau
    public UserController(AppDbContext dbContext)
    {
        _dbcontext = dbContext;
    }
    //HTTP METHOD: Get Post Delete put patch
    //Param: query stirng, path param, body param
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
    
    [HttpGet("")]
    public IActionResult GetUsers()
    {
        // var users = _dbContext.Users.ToList();
        // return Ok(users);
        return Ok("Get all  users");
    }
    
    [HttpPost("")]
    public IActionResult CreateUsers([FromBody] Request.CreateUserRequest request)
    //body phải truyền một object key:value 
    {
        // var users = _dbContext.Users.ToList();
        // return Ok(users);
        var user = new User()
        {
            Email = request.Email,
            FirstName = request.FirstName,
            LastName = request.LastName,
            HashedPassword = request.Password //chưa hash chỉ demo
        };
        //tương tác với db
        _dbcontext.Users.Add(user);
        //mang câu lệnh xuống db apply nhó
        _dbcontext.SaveChanges();
        return Ok("Create new User Successfully");
    }
    
    [HttpGet("{id}")]
    public IActionResult GetUserById(Guid id)
    {
        return Ok("Get user by Id");
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
    
}