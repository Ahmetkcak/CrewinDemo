using CrewinDemo.Business.Abstracts;
using CrewinDemo.Models.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrewinDemo.ApiService.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController(IProductService productService) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<BaseResponseModel>> GetProductsByCategory([FromQuery] string category)
    {
        var products = await productService.GetProductsByCategory(category);
        return Ok(new BaseResponseModel { Success = true, Message = "Products have been successfully listed.", Data = products });
    }
}
