using ecommerce_app.Entities;


namespace ecommerce_app.Dtos.Product;

public class ProductDetailDto
{
    public int Id { get; set; }
    public string product_name { get; set; } = null!;
    public double product_price { get; set; }
    public string? product_detail { get; set; }
    public string? product_tag { get; set; }
    public string? product_tagColor { get; set; }
    public List<string> product_sizes { get; set; } = null!;
    public string product_brand { get; set; } = null!;
    public List<ProductImageDto> product_images { get; set; } = new();
    public List<ProductColorDto> product_colors { get; set; } = new();
    public int CategoryId { get; set; }
    public List<ProductHomeDto> product_similarList { get; set; } = [];

}