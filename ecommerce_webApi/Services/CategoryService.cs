
using AutoMapper;
using ecommerce_app.Dtos.Category;
using ecommerce_app.Entities;
using ecommerce_app.Interfaces;
using Microsoft.EntityFrameworkCore;
using ecommerce_app.Data;
using ecommerce_app.Dtos.Product;

namespace ecommerce_app.Services;

public class CategoryService
{
    private readonly ICategoryRepository _repository;
    private readonly IMapper _mapper;
    private readonly DataContext _context;

    public CategoryService(ICategoryRepository repository, IMapper mapper, DataContext context)
    {
        _repository = repository;
        _mapper = mapper;
        _context = context;
    }

    public async Task<List<CategoryHomeDto>> GetAllCategoryAsync()
    {
        var categories = await _repository.GetAllAsync();
        return _mapper.Map<List<CategoryHomeDto>>(categories);
    }


    public async Task<CategoryDetailDto> GetCategoryByIdAsync(int id)
    {
        var category = await _repository.GetByIdAsync(id);
        var productList = new List<ProductHomeDto>();

        foreach (var product in category.Products)
        {
            var image = _context.ProductImages
                .FirstOrDefault(i => i.ProductId == product.Id);

            var reviews = await _context.Reviews
                .Where(i => i.ProductId == product.Id)
                .ToListAsync();

            double reviewRating = reviews.Any()
                ? reviews.Average(r => r.ReviewRating)
                : 0;

            var colorList = product.product_colors
                .Select(color => new ProductColorDto
                {
                    id = color.Id,
                    color_name = color.color_name,
                    color_hex = color.color_hex
                }).ToList();

            var productHomeDto = new ProductHomeDto
            {
                Id = product.Id,
                product_name = product.product_name,
                product_price = product.product_price,
                product_image = image?.image_url,
                product_tag = product.product_tag,
                product_tagColor = product.product_tagColor,
                product_brand = product.product_brand,
                product_star = reviewRating,
                product_totalReview = reviews.Count,
                product_sizes = product.product_sizes,
                product_colors = colorList,
                CategoryId = product.CategoryId
            };

            productList.Add(productHomeDto);
        }

        var dto = new CategoryDetailDto
        {
            Id = category.Id,
            category_name = category.category_name,
            category_campaign = category.category_campaign,
            category_campaignColor = category.category_campaignColor,
            Products = productList
        };



        return dto;
    }
}