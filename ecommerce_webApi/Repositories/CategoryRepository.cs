using ecommerce_app.Entities;
using ecommerce_app.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using ecommerce_app.Data;

namespace ecommerce_app.Repositories;

public class CategoryRepository : ICategoryRepository
{
    private readonly DataContext _context;

    public CategoryRepository(DataContext context)
    {
        _context = context;
    }

    public async Task<List<Category>> GetAllAsync()
    {
        return await _context.Categories.ToListAsync();
    }

    public async Task<Category?> GetByIdAsync(int id)
    {
        return await _context.Categories
       .Include(c => c.Products)
           .ThenInclude(p => p.product_images)
       .Include(c => c.Products)
           .ThenInclude(p => p.product_colors)
       .Include(c => c.Products)
           .ThenInclude(p => p.Reviews)
       .FirstOrDefaultAsync(c => c.Id == id);

    }
}