namespace ecommerce_app.Interfaces;

using ecommerce_app.Entities;
public interface ICategoryRepository
{
    Task<List<Category>> GetAllAsync();
    Task<Category?> GetByIdAsync(int id);
}