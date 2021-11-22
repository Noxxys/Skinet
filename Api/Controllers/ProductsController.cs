using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly IProductRepository productRepository;

    public ProductsController(IProductRepository productRepository)
    {
        this.productRepository = productRepository;
    }

    // GET api/products
    [HttpGet]
    public async Task<ActionResult<List<Product>>> GetProductsAsync()
    {
        var products = await productRepository
            .GetProductsAsync()
            .ConfigureAwait(false);
        
        return Ok(products);
    }

    // GET api/products/5
    [HttpGet("{id:int}")]
    public async Task<ActionResult<Product>> GetProductAsync(int id)
    {
        var product = await productRepository
            .FindProductAsync(id)
            .ConfigureAwait(false);

        return Ok(product);
    }
}