using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class ProductRepository : IProductRepository
{
    private readonly StoreContext context;
    
    public ProductRepository(StoreContext context)
    {
        this.context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public async Task<Product?> FindProductAsync(int id)
    {
        return await context
            .Products
            .FindAsync(id)
            .ConfigureAwait(false);
    }

    public async Task<IReadOnlyList<Product>> GetProductsAsync()
    {
        return await context
            .Products
            .ToListAsync()
            .ConfigureAwait(false);
    }
}