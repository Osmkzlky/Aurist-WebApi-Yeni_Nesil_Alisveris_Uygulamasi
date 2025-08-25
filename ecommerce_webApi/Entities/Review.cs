using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce_app.Entities
{
    public class Review
    {
        public int Id { get; set; }
        public string CustomerId { get; set; }
        public int ProductId { get; set; }
        public string ReviewDetail { get; set; }
        public int ReviewRating { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public Product Product { get; set; } = null!;

    }
}