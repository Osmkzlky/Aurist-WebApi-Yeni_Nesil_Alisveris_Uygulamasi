namespace ecommerce_app.Entities;

using System.Text.Json.Serialization;

public class Slider
{
    public int Id { get; set; }
    public string? slider_title { get; set; }
    public string? slider_detail { get; set; }
    public string slider_image { get; set; } = null!;
    public int slider_index { get; set; }
    public bool slider_isActive { get; set; }

}


