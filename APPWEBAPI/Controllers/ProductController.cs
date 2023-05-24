using APPWEBAPI.Interface;
using Microsoft.AspNetCore.Mvc;

namespace APPWEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IUnitofWork unit;
        public ProductController(IUnitofWork unit)
        {
            this.unit = unit;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()   
        {
            var result = await this.unit.product.GetAllAsync();
            return Ok(result);
        }
    }
}
