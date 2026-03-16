using Microsoft.AspNetCore.Mvc;
using TetPee.Repository;
using TetPee.Service.Category;

namespace TetPee.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class CategoryController : ControllerBase
{
    private readonly AppDbContext _dbContext;
    //cái này nâng cao giải thich sau
    private readonly IService _categoryService;
    
    public CategoryController(AppDbContext dbContext, IService service)
    {
        _dbContext = dbContext;
        _categoryService = service;
    }

    //Chuẩn res full API
    //Get all Category GET http://localhost:5000/Category
    //create Category: POST http://localhost:5000/User
    //get Category by id:   Get //get all Categorys http://localhost:5000/User/{id}
    //update Category by id: PUT  http://localhost:5000/User/{id}
    //delete Category by id: DELETE //get all users http://localhost:5000/User/{id}
    //Get all Category GET http://localhost:5000/Categories
   //get Category by id:   Get //get all Categorys http://localhost:5000/Category/{id}
    
   //Get all categories
    [HttpGet("")]
    public async Task<IActionResult> GetAllCategories()
    {
        var categories = await _categoryService.GetCateGory();
        return Ok(categories);
    }
    
    //GetAllCategories
    //Bình thường khúc này mình hay để trong đây chỉ có Id thôi
    //nhưng mình cải tiến để biết là mình đang lấy childrens từ Id cha
    [HttpGet("{parentId}/childrens")]
    public async Task<IActionResult> GetCategoryById(Guid parentId)
    {
        var categories = await _categoryService.GetChildrenByCateGory(parentId);
        return Ok(categories);
        // return Ok(_dbContext.Categories.Find(id)); // có xử lí trường hợp null không
    }
  

}
