using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce_app.DTOs.Order
{
    public class CartItemDto
    {
        public int ProductId { get; set; }
        public int? ProductColorId { get; set; }
        public int ProductQuantity { get; set; }
        public int ProductSizeId { get; set; }
    }
}