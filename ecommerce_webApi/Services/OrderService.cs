using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ecommerce_app.Data;
using ecommerce_app.Entities;
using ecommerce_app.DTOs.Order;
using Microsoft.EntityFrameworkCore;

namespace ecommerce_app.Services
{
    public class OrderService
    {
        private readonly DataContext _context;

        public OrderService(DataContext context)
        {
            _context = context;
        }

        public async Task<Order> CreateOrderAsync(CreateOrderDto dto)
        {
            var order = new Order
            {
                CustomerId = dto.CustomerId,
                AddressName = dto.AddressName,
                AddressSurname = dto.AddressSurname,
                OrderDate = DateTime.UtcNow,
                OrderPhone = dto.OrderPhone,
                OrderEmail = dto.OrderEmail,
                OrderPromoRating = dto.OrderPromoRating,
                OrderPromoPrice = dto.OrderPromoPrice,
                OrderPaymentCardNumber = dto.OrderPaymentCardNumber,
                OrderPaymentCardCompany = dto.OrderPaymentCardCompany,
                OrderTotalPrice = 0,
                OrderShippingCompany = dto.OrderShippingCompany,
                OrderShippingPrice = dto.OrderShippingPrice
            };


            var address = new Address
            {
                CustomerId = dto.Address.CustomerId,
                AddressTitle = dto.Address.AddressTitle,
                AddressCity = dto.Address.AddressCity,
                AddressDistricts = dto.Address.AddressDistricts,
                AddressPostalCode = dto.Address.AddressPostalCode,
                AddressDetail = dto.Address.AddressDetail
            };
            order.OrderAddressInfo = address;

            double totalPrice = 0;

            foreach (var cartItem in dto.CartItems)
            {
                var product = await _context.Products.FindAsync(cartItem.ProductId);
                if (product == null)
                {
                    throw new Exception($"Ürün bulunamadı: {cartItem.ProductId}");
                }

                string? colorName = null;
                string? colorHex = null;
                double priceSnapshot = product.product_price;
                int quantity = cartItem.ProductQuantity;

                if (cartItem.ProductColorId != null)
                {
                    var color = await _context.ProductColors
                        .FirstOrDefaultAsync(c => c.Id == cartItem.ProductColorId && c.ProductId == product.Id);

                    if (color == null)
                    {
                        throw new Exception($"Geçersiz renk: {cartItem.ProductColorId}");
                    }

                    colorName = color.color_name;
                    colorHex = color.color_hex;

                }
                var image = _context.ProductImages.Where(i => i.ProductId == product.Id).FirstOrDefault();



                order.CartItems.Add(new CartItem
                {
                    ProductId = product.Id,
                    ProductQuantity = quantity,
                    ProductPriceSnapshot = priceSnapshot,
                    ProductColorId = cartItem.ProductColorId,
                    ProductColorNameSnapshot = colorName,
                    ProductColorHexSnapshot = colorHex,
                    ProductSizeId = cartItem.ProductSizeId,
                    ProductNameSnapshot = product.product_name,
                    ProductBrandSnapshot = product.product_brand,
                    ProductImageSnapshot = image.image_url,
                    ProductSizeSnapshot = product.product_sizes[cartItem.ProductSizeId]

                });

                totalPrice += priceSnapshot * quantity;
            }
            totalPrice -= dto.OrderPromoPrice ?? 0;
            totalPrice += dto.OrderShippingPrice;
            order.OrderTotalPrice = totalPrice;

            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
            return order;
        }

        public async Task<List<OrderLoadDto>> LoadOrderService(string CustomerId)
        {
            var orderList = await _context.Orders.Where(i => i.CustomerId == CustomerId).ToListAsync();
            var orders = new List<OrderLoadDto>();

            foreach (var order in orderList)
            {
                var addressEntity = await _context.Addresses.FirstOrDefaultAsync(i => i.OrderId == order.Id);
                var cartItems = _context.CartItems.Where(i => i.OrderId == order.Id).ToList();
                var cartItemList = new List<CartItemLoadDto>();
                foreach (var cartItem in cartItems)
                {
                    var cartLoadModel = new CartItemLoadDto
                    {
                        ProductId = cartItem.ProductId,
                        ProductName = cartItem.ProductNameSnapshot,
                        ProductPrice = cartItem.ProductPriceSnapshot,
                        ProductColorName = cartItem.ProductColorNameSnapshot,
                        ProductQuantity = cartItem.ProductQuantity,
                        ProductImage = cartItem.ProductImageSnapshot,
                        ProductBrand = cartItem.ProductBrandSnapshot,
                        ProductSize = cartItem.ProductSizeSnapshot
                    };
                    cartItemList.Add(cartLoadModel);
                }
                var newOrder = new OrderLoadDto
                {
                    OrderId = order.Id,
                    CustomerId = CustomerId,
                    AddressName = order.AddressName,
                    AddressSurname = order.AddressSurname,
                    OrderDate = order.OrderDate,
                    OrderPhone = order.OrderPhone,
                    OrderEmail = order.OrderEmail,
                    OrderPromoRating = order.OrderPromoRating,
                    OrderPromoPrice = order.OrderPromoPrice,
                    OrderPaymentCardNumber = order.OrderPaymentCardNumber,
                    OrderPaymentCardCompany = order.OrderPaymentCardCompany,
                    OrderTotalPrice = order.OrderTotalPrice,
                    OrderShippingPrice = order.OrderShippingPrice,
                    OrderShippingCompany = order.OrderShippingCompany,
                    OrderAddressInfo = new AddressDto
                    {
                        CustomerId = CustomerId,
                        AddressTitle = addressEntity.AddressTitle,
                        AddressCity = addressEntity.AddressCity,
                        AddressDistricts = addressEntity.AddressDistricts,
                        AddressPostalCode = addressEntity.AddressPostalCode,
                        AddressDetail = addressEntity.AddressDetail
                    },
                    CartItems = cartItemList

                };
                orders.Add(newOrder);

            }

            return orders;
        }
    }

}