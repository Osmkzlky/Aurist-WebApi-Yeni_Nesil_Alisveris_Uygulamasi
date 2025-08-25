using ecommerce_app.Entities;

namespace ecommerce_app.Interfaces;

public interface IProductRepository
{
    Task<List<Product>> GetAllAsync();
    Task<Product?> GetByIdAsync(int id);
    Task<List<Product>> GetSimilarProductsAsync(int categoryId, int excludeProductId, int count = 10);
}