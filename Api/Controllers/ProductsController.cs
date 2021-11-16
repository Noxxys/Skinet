using Api.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

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
        var product = new Product("test");
        return product;
    }
}