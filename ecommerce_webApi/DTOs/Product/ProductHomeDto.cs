namespace ecommerce_app.Dtos.Product;


public class ProductHomeDto
{
    public int Id { get; set; }
    public string product_name { get; set; } = null!;
    public double product_price { get; set; }
    public string? product_image { get; set; }
    public string? product_tag { get; set; }
    public string? product_tagColor { get; set; }
    public string product_brand { get; set; } = null!;
    public double product_star { get; set; }
    public int product_totalReview { get; set; }
    public List<string> product_sizes { get; set; } = null!;
    public List<ProductColorDto> product_colors { get; set; } = new();
    public int CategoryId { get; set; }
}