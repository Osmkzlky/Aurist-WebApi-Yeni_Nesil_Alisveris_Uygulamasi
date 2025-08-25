using ecommerce_app.Entities;

namespace ecommerce_app.Interfaces;

public interface ISliderRepository
{
    Task<List<Slider>> GetAllAsync();
}