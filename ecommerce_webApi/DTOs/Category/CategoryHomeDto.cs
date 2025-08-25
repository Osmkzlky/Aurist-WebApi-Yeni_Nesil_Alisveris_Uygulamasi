namespace ecommerce_app.Dtos.Category;

public class CategoryHomeDto
{
  public int Id { get; set; }
  public string category_name { get; set; } = null!;
  public string category_kind { get; set; } = null!;
  public string? category_image { get; set; }
}