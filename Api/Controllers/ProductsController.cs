using Core.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly StoreContext context;

    public ProductsController(StoreContext context)
    {
        this.context = context;
    }

    // GET api/products
    [HttpGet]
    public async Task<ActionResult<List<Product>>> GetProductsAsync()
    {
        var products = await context
            .Products
            .ToListAsync()
            .ConfigureAwait(false);
        
        return Ok(products);
    }

    // GET api/products/5
    [HttpGet("{id:int}")]
    public async Task<ActionResult<Product>> GetProductAsync(int id)
    {
        var product = await context
            .Products
            .FirstOrDefaultAsync(p => p.Id == id)
            .ConfigureAwait(false);
        
        return Ok(product);
    }
}