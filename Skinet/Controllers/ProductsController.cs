using Microsoft.AspNetCore.Mvc;
using Skinet.Entities;

namespace Skinet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        // GET api/products
        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            // TODO: return products
            return new List<Product>();
        }
        
        // GET api/products/5
        [HttpGet("{id:int}")]
        public Product GetProduct(int id)
        {
            // TODO: return product with id
            return new Product();
        }
    }
}