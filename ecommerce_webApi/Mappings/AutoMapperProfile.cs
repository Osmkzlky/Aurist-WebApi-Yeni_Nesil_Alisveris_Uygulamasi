using AutoMapper;
using ecommerce_app.Entities;
using ecommerce_app.Dtos.Product;
using ecommerce_app.Dtos.Category;
using System.Linq;

namespace ecommerce_app.Mappings;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<Product, ProductHomeDto>()
            .ForMember(dest => dest.product_image,
                opt => opt.MapFrom(src => src.product_images.FirstOrDefault() != null
                                           ? src.product_images.First().image_url
                                           : null));

        CreateMap<Product, ProductDetailDto>();
        CreateMap<ProductImage, ProductImageDto>();
        CreateMap<ProductColor, ProductColorDto>();

        CreateMap<Category, CategoryHomeDto>();
        CreateMap<Category, CategoryDetailDto>();


    }
}