using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce_app.DTOs.Order
{

    public class OrderLoadDto
    {
        public int OrderId { get; set; }
        public string CustomerId { get; set; }
        public string AddressName { get; set; }
        public string AddressSurname { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.UtcNow;
        public string OrderPhone { get; set; }
        public string OrderEmail { get; set; }
        public string? OrderPromoRating { get; set; }
        public Double? OrderPromoPrice { get; set; }
        public string OrderPaymentCardNumber { get; set; }
        public string OrderPaymentCardCompany { get; set; }
        public Double OrderTotalPrice { get; set; }
        public Double OrderShippingPrice { get; set; }
        public string OrderShippingCompany { get; set; }
        public AddressDto OrderAddressInfo { get; set; }
        public List<CartItemLoadDto> CartItems { get; set; }
    }
}