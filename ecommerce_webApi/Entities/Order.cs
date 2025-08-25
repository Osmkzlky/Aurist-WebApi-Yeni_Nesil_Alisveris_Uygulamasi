using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ecommerce_app.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public string CustomerId { get; set; }
        public string AddressName { get; set; }
        public string AddressSurname { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.UtcNow;
        public string OrderPhone { get; set; }
        public string OrderEmail { get; set; }
        public Double OrderTotalPrice { get; set; }
        public string? OrderPromoRating { get; set; }
        public Double? OrderPromoPrice { get; set; }
        public string OrderPaymentCardNumber { get; set; }
        public string OrderPaymentCardCompany { get; set; }
        public Double OrderShippingPrice { get; set; }
        public string OrderShippingCompany { get; set; }
        public Address OrderAddressInfo { get; set; }
        public List<CartItem> CartItems { get; set; } = new();
    }

    public class Address
    {
        public int Id { get; set; }
        public string CustomerId { get; set; }
        public string AddressTitle { get; set; }
        public string AddressCity { get; set; }
        public string AddressDistricts { get; set; }
        public string AddressPostalCode { get; set; }
        public string AddressDetail { get; set; }
        public int? OrderId { get; set; }
        [JsonIgnore]
        public Order Order { get; set; }
    }

    public class CartItem
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        [JsonIgnore]
        public Product Product { get; set; }
        public int? ProductColorId { get; set; }
        public int ProductSizeId { get; set; }
        public ProductColor ProductColor { get; set; }
        public int OrderId { get; set; }
        [JsonIgnore]
        public Order Order { get; set; }
        public int ProductQuantity { get; set; }
        public double ProductPriceSnapshot { get; set; }
        public string? ProductColorNameSnapshot { get; set; }
        public string? ProductColorHexSnapshot { get; set; }
        public string ProductNameSnapshot { get; set; }
        public string ProductBrandSnapshot { get; set; }
        public string? ProductImageSnapshot { get; set; }
        public string ProductSizeSnapshot { get; set; }

    }
}