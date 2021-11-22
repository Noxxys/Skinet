using Core.Entities;

namespace Core.Interfaces;

public interface IProductRepository
{
    Task<Product?> FindProductAsync(int id);
    Task<IReadOnlyList<Product>> GetProductsAsync();
}