using CrewinDemo.Business.Abstracts;
using CrewinDemo.Models.Entities;
using CrewinDemo.Models.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrewinDemo.ApiService.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoryController(ICategoryService categoryService) : ControllerBase
{

    [HttpPost]
    public async Task<ActionResult<BaseResponseModel>> AddCategory([FromBody] Category category)
    {
        var categories = await categoryService.AddCategory(category);
        return Ok(new BaseResponseModel { Success = true, Message = "Categories have been successfully added.", Data = category });
    }

    [HttpGet]
    public async Task<ActionResult<BaseResponseModel>> GetCategories()
    {
        var categories = await categoryService.GetCategories();
        return Ok(new BaseResponseModel { Success = true, Message = "Categories have been successfully listed.", Data = categories });
    }
}
