using ecommerce_app.Services;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce_app.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SliderController : ControllerBase
{
    private readonly SliderService _service;

    public SliderController(SliderService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var sliders = await _service.GetAllSlidersAsync();
        return Ok(sliders);
    }


}