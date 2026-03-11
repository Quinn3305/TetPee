using ClassLibrary1.Category;
using ClassLibrary1.User;
using Microsoft.AspNetCore.Mvc;
using TetPee.Repository;
using TetPee.Repository.Entity;

namespace TetPee.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class CategoryController : ControllerBase
{
    private readonly AppDbContext _dbContext;

    //cái này nâng cao giải thich sau
    public CategoryController(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    //Chuẩn res full API
    //Get all Category GET http://localhost:5000/Category
    //create Category: POST http://localhost:5000/User
    //get Category by id:   Get //get all Categorys http://localhost:5000/User/{id}
    //update Category by id: PUT  http://localhost:5000/User/{id}
    //delete Category by id: DELETE //get all users http://localhost:5000/User/{id}
    
    //Get all Category GET http://localhost:5000/Categories
   

    [HttpGet("")]
    public IActionResult GetCategories()
    {
        var categories = _dbContext.Categories.ToList();
        return Ok(categories);
    }
    
    //get Category by id:   Get //get all Categorys http://localhost:5000/Category/{id}
    [HttpGet("{id}")]
    public IActionResult GetCategory(Guid id)
    {
        // var categories = _dbContext.Categories.ToList();
        // return Ok(categories);
        return Ok(_dbContext.Categories.Find(id)); // có xử lí trường hợp null không
    }

    //create Category: POST http://localhost:5000/Category
    [HttpPost("")]
    public IActionResult CreateCategories([FromBody] RequestCate.CreateCategoryRequest request)
    {
        var category = new Category()
        {
            Name = request.Name,
            ParentId = request.ParentId,
        };
    

        _dbContext.Categories.Add(category);
        _dbContext.SaveChanges();

        Console.WriteLine(Request);
        return Ok(category);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateCategories(Guid id)
    {
        // var users = _dbContext.Users.ToList();
        // return Ok(users);
        return Ok(_dbContext.Users);
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteCategories(Guid id)
    {
        // var users = _dbContext.Users.ToList();
        // return Ok(users);
        return Ok(_dbContext.Users);
    }
}
