using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopKeepingBL.Services;
using ShopKeepingModels.Models;

namespace ShopKeepingBlazorWithWebapi.ApiService.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController(IProductService productService) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<BaseResponseModel>> GetProducts()
        {
            var products=await productService.GetProducts();
            return Ok(new BaseResponseModel { Success = true, Data = products });
        }
    }
}
