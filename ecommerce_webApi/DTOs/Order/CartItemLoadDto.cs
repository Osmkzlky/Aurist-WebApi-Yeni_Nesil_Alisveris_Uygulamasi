using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce_app.DTOs.Order
{
    public class CartItemLoadDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public string? ProductImage { get; set; }
        public string ProductBrand { get; set; }
        public string ProductSize { get; set; }
        public string ProductColorName { get; set; }
        public int ProductQuantity { get; set; }
    }
}