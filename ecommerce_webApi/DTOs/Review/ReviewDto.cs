using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce_app.DTOs.Review
{
    public class ReviewDto
    {
        public int ProductId { get; set; }
        public string CustomerId { get; set; }
        public string ReviewDetail { get; set; }
        public int ReviewRating { get; set; }
    }
}