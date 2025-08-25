using ecommerce_app.Entities;
using ecommerce_app.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using ecommerce_app.Data;

namespace ecommerce_app.Repositories;

public class SliderRepository : ISliderRepository
{
    private readonly DataContext _context;

    public SliderRepository(DataContext context)
    {
        _context = context;
    }

    public async Task<List<Slider>> GetAllAsync()
    {
        return await _context.Sliders.ToListAsync();
    }

}