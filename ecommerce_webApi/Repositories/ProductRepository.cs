using ecommerce_app.Entities;
using ecommerce_app.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using ecommerce_app.Data;

namespace ecommerce_app.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly DataContext _context;

    public ProductRepository(DataContext context)
    {
        _context = context;
    }

    public async Task<List<Product>> GetAllAsync()
    {
        return await _context.Products.Include(p => p.product_images).Include(i => i.product_colors).ToListAsync();
    }

    public async Task<Product?> GetByIdAsync(int id)
    {
        return await _context.Products.Include(p => p.product_images).Include(c => c.product_colors).FirstOrDefaultAsync(p => p.Id == id);
    }

    public async Task<List<Product>> GetSimilarProductsAsync(int categoryId, int excludeProductId, int count = 10)
    {
        return await _context.Products
            .Where(p => p.CategoryId == categoryId && p.Id != excludeProductId)
            .Include(p => p.product_images)
            .Take(count)
            .ToListAsync();
    }

}