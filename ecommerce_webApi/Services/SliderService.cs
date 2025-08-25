using AutoMapper;
using ecommerce_app.Entities;
using ecommerce_app.Interfaces;

namespace ecommerce_app.Services;

public class SliderService
{
    private readonly ISliderRepository _repository;

    public SliderService(ISliderRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<Slider>> GetAllSlidersAsync()
    {
        var sliders = await _repository.GetAllAsync();
        return sliders;
    }

}