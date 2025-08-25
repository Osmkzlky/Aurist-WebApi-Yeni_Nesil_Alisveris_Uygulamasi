using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce_app.DTOs.Review
{
    public class ReviewLoadDto
    {
        public string ReviewFullName { get; set; }
        public string ReviewDetail { get; set; }
        public int ReviewRating { get; set; }
        public DateTime ReviewDate { get; set; }
    }
}