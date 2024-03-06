using Microsoft.AspNetCore.Mvc;

namespace Product.Microservice.Controllers
{
    [ApiController]
    [Route("Product")]
    public class ProductController : ControllerBase
    {
        public ProductController()
        {
        }

        [HttpGet]
        public IEnumerable<ProductModel> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new ProductModel
            {
                CreationDate = DateTime.Now,
                ID = new Random().Next()
            })
            .ToArray();
        }
    }
}