using AutoMapper;
using ecommerce_app.Dtos.Product;
using ecommerce_app.Entities;
using ecommerce_app.Interfaces;
using ecommerce_app.Data;
using Microsoft.EntityFrameworkCore;

namespace ecommerce_app.Services;

public class ProductService
{
    private readonly IProductRepository _repository;
    private readonly IMapper _mapper;
    private readonly DataContext _context;

    public ProductService(IProductRepository repository, IMapper mapper, DataContext context)
    {
        _repository = repository;
        _mapper = mapper;
        _context = context;
    }

    public async Task<List<ProductHomeDto>> GetAllProductsAsync()
    {
        var products = await _repository.GetAllAsync();
        var productList = new List<ProductHomeDto>();

        foreach (var product in products)
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

        return productList;
    }
    public async Task<ProductDetailDto> GetProductByIdAsync(int id)
    {
        var product = await _repository.GetByIdAsync(id);

        if (product == null)
            throw new Exception("Product not found");

        var productDto = _mapper.Map<ProductDetailDto>(product);
        var similarProducts = await _repository.GetSimilarProductsAsync(product.CategoryId, product.Id, 10);
        productDto.product_similarList = _mapper.Map<List<ProductHomeDto>>(similarProducts);
        return productDto;

    }
}