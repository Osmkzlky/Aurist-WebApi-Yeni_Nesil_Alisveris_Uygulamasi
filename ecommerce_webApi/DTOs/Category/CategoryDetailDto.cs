

using ecommerce_app.Entities;
using ecommerce_app.Dtos.Product;
namespace ecommerce_app.Dtos.Category;



public class CategoryDetailDto
{
    public int Id { get; set; }
    public string category_name { get; set; } = null!;
    public string? category_campaign { get; set; }
    public string? category_campaignColor { get; set; }
    public List<ProductHomeDto> Products { get; set; } = new();
}