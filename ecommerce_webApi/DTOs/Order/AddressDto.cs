using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce_app.DTOs.Order
{
    public class AddressDto
    {
        public string CustomerId { get; set; }
        public string AddressTitle { get; set; }
        public string AddressCity { get; set; }
        public string AddressDistricts { get; set; }
        public string AddressPostalCode { get; set; }
        public string AddressDetail { get; set; }
    }
}