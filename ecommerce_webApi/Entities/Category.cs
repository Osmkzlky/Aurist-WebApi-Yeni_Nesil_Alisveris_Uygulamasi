namespace ecommerce_app.Entities;

public class Category
{
    public int Id { get; set; }
    public string category_name { get; set; } = null!;
    public string category_kind { get; set; } = null!;
    public string? category_campaign { get; set; }
    public string? category_campaignColor { get; set; }
    public string category_url { get; set; } = null!;
    public string? category_image { get; set; }
    public bool category_isHome { get; set; }
    public List<Product> Products { get; set; } = new();
}

