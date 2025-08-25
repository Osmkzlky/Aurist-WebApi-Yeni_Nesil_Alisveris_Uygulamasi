namespace ecommerce_app.Entities;

using System.Text.Json.Serialization;

public class Product
{
    public int Id { get; set; }
    public string product_name { get; set; } = null!;
    public double product_price { get; set; }
    public string? product_detail { get; set; }
    public bool product_isActive { get; set; }
    public string? product_tag { get; set; }
    public string? product_tagColor { get; set; }
    public List<string> product_sizes { get; set; } = null!;
    public bool product_isHome { get; set; }
    public string product_brand { get; set; } = null!;
    public List<ProductImage> product_images { get; set; } = new();
    public List<ProductColor> product_colors { get; set; } = new();
    public int CategoryId { get; set; }
    public Category Category { get; set; } = null!;
    public List<Review> Reviews { get; set; } = new();

}
public class ProductImage
{
    public int Id { get; set; }
    public string image_url { get; set; } = null!;
    public int ProductId { get; set; }
}

public class ProductColor
{
    public int Id { get; set; }
    public string color_name { get; set; } = null!;
    public string color_hex { get; set; } = null!;
    public int ProductId { get; set; }

}

